using LocationManagementSystem.CCFTCentralDb;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationManagementSystem
{
    public static class EFERTDbUtility
    {
        public static CCFTCentral mCCFTCentral = null;
        public static EFERTDbContext mEFERTDb = null;
        public static List<VisitingLocations> mVisitingLocations = null;

        public static string CONST_SYSTEM_BLOCKED_BY = "System";
        public static string CONST_SYSTEM_LIMIT_REACHED_REASON = "System has block this person because maximum limit of temporary check in has reached.";

        public static void InitializeDatabases()
        {
            mEFERTDb = new EFERTDbContext();
            mCCFTCentral = new CCFTCentral();
            try
            {
                Cardholder cardHolderByNic = (from pds in mCCFTCentral.PersonalDataStrings
                                              where pds != null && pds.PersonalDataFieldID == 5051 && pds.Value != null && pds.Value == "12345-1234567-1"
                                              select pds.Cardholder).FirstOrDefault();
            }
            catch (Exception e)
            {
                
            }

            try
            {
                mVisitingLocations = (from visitLocation in mEFERTDb.VisitingLocations
                                      where visitLocation != null
                                      select visitLocation).ToList();
            }
            catch (Exception e)
            {
                
            }
            
        }

        public static void RollBack()
        {
            var context = mEFERTDb;
            var changedEntries = context.ChangeTracker.Entries()
                .Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }

        public static string GetInnerExceptionMessage(Exception ex)
        {
            string message = ex.Message;
            Exception innerException = ex.InnerException;

            while (innerException != null)
            {
                message += "\n" + innerException.Message;
                innerException = innerException.InnerException;
            }

            return message;
        }

        public static LimitStatus CheckIfUserCheckedInLimitReached(List<CheckInAndOutInfo> checkIns, List<BlockedPersonInfo> blocks, bool sendEmail = true)
        {
            LimitStatus limitStatus = LimitStatus.Allowed;
            SystemSetting setting = EFERTDbUtility.mEFERTDb.SystemSetting.FirstOrDefault();

            int daysToEmailNotification = setting == null ? 70 : setting.DaysToEmailNotification;
            int daysToBlock = setting == null ? 90 : setting.DaysToBlockUser;

            if (checkIns.Count > 0)
            {
                CheckInAndOutInfo last = checkIns.Last();

                if (last.CheckedIn)
                {
                    limitStatus = LimitStatus.CurrentlyCheckIn;
                }
                else
                {

                    DateTime fromDate = new DateTime(DateTime.Now.Year, 10, 1);
                    DateTime toDate = new DateTime(DateTime.Now.Year + 1, 10, 1);

                    BlockedPersonInfo lastBlockedPerson = (from block in blocks
                                                           where block != null &&
                                                                 block.BlockedTime >= fromDate &&
                                                                 block.BlockedTime < toDate && 
                                                                 !block.Blocked && 
                                                                 block.BlockedBy == CONST_SYSTEM_BLOCKED_BY
                                                           select block).LastOrDefault();

                    if (lastBlockedPerson != null)
                    {
                        fromDate = lastBlockedPerson.UnBlockTime;
                    }

                    checkIns = (from checkin in checkIns
                                where checkin != null && checkin.DateTimeIn >= fromDate && checkin.DateTimeIn < toDate
                                select checkin).ToList();

                    if (checkIns.Count == 0)
                    {
                        return limitStatus;
                    }

                    string name, cnic = string.Empty;

                    if (last.CardHolderInfos != null)
                    {
                        name = last.CardHolderInfos.FirstName;
                        cnic = last.CardHolderInfos.CNICNumber;
                    }
                    else if (last.Visitors != null)
                    {
                        name = last.Visitors.FirstName;
                        cnic = last.Visitors.CNICNumber;
                    }
                    else
                    {
                        name = last.DailyCardHolders.FirstName;
                        cnic = last.DailyCardHolders.CNICNumber;
                    }

                    List<AlertInfo> chAlertInfos = (from alert in EFERTDbUtility.mEFERTDb.AlertInfos
                                                    where alert != null && alert.CNICNumber == cnic
                                                    select alert).ToList();

                    DateTime alertEnableDate = DateTime.MaxValue;
                    bool alertEnabled = true;
                    AlertInfo lastAlertInfo = null;

                    if (chAlertInfos != null && chAlertInfos.Count > 0)
                    {
                        lastAlertInfo = chAlertInfos.Last();

                        if (lastAlertInfo.DisableAlert)
                        {
                            alertEnabled = false;
                        }
                        else
                        {
                            alertEnableDate = lastAlertInfo.EnableAlertDate;
                        }
                    }


                    CheckInAndOutInfo previousCheckIn = checkIns[0];
                    bool isSameDay = last.DateTimeIn.Date == DateTime.Now.Date;

                    if (previousCheckIn != null)
                    {
                        int count = 1;
                        DateTime previousDateTimeIn = previousCheckIn.DateTimeIn;

                        for (int i = 1; i < checkIns.Count; i++)
                        {
                            CheckInAndOutInfo CurrentCheckIn = checkIns[i];

                            DateTime currDateTimeIn = CurrentCheckIn.DateTimeIn;

                            TimeSpan timeDiff = currDateTimeIn.Date - previousDateTimeIn.Date;



                            //bool isContinous = timeDiff.Days == 1 || timeDiff.Days == 2 && currDateTimeIn.DayOfWeek == DayOfWeek.Monday;

                            if (timeDiff.Days >= 1 )
                            {
                                count++;
                            }
                            //else
                            //{
                            //    if (currDateTimeIn.Date != previousDateTimeIn.Date)
                            //    {
                            //        count = 1;
                            //    }

                            //}

                            previousDateTimeIn = currDateTimeIn;
                        }

                        if (count >= daysToEmailNotification)
                        {
                            if (count == daysToBlock && !isSameDay)
                            {
                                limitStatus = LimitStatus.LimitReached;
                            }
                            else
                            {
                                if (alertEnabled)
                                {
                                    if (sendEmail)
                                    {
                                        List<EmailAddress> toAddresses = new List<EmailAddress>();

                                        if (EFERTDbUtility.mEFERTDb.EmailAddresses != null)
                                        {
                                            toAddresses = (from email in EFERTDbUtility.mEFERTDb.EmailAddresses
                                                           where email != null
                                                           select email).ToList();

                                            foreach (EmailAddress toAddress in toAddresses)
                                            {
                                                SendMail(setting, toAddress.Email, toAddress.Name, name, cnic);
                                            }
                                        }
                                    }


                                    limitStatus = LimitStatus.EmailAlerted;
                                }
                                else
                                {
                                    limitStatus = LimitStatus.EmailAlertDisabled;
                                }
                            }

                        }
                        else
                        {
                            limitStatus = LimitStatus.Allowed;
                        }
                    }
                }
            }

            return limitStatus;
        }

        public static bool ValidateInputs(List<TextBox> lstTextBoxes)
        {
            bool validated = false;

            if (lstTextBoxes != null)
            {
                List<string> lstInvalidTextboxes = (from text in lstTextBoxes
                 where text != null && string.IsNullOrEmpty(text.Text)
                 select text.Name).ToList();

                validated = lstInvalidTextboxes.Count == 0;

                foreach (TextBox textbox in lstTextBoxes)
                {
                    if (textbox.ReadOnly)
                    {
                        continue;
                    }
                    if (lstInvalidTextboxes.Contains(textbox.Name))
                    {
                        textbox.BackColor = System.Drawing.Color.Yellow;
                    }
                    else
                    {
                        textbox.BackColor = System.Drawing.Color.White;
                    }

                }
            }

            return validated;
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            byte[] array = null;

            if (imageIn != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    array = ms.ToArray();
                }
            }

            return array;
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;

            if (byteArrayIn != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    returnImage = Image.FromStream(ms);
                }
            }
            
            return returnImage;
        }

        public static void AllowNumericOnly(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        public static void SendMail(SystemSetting settings, string toAddress, string toName, string chName, string chCnic)
        {
            try
            {
                string fromaddr = settings.FromEmailAddress;
                //string toAddress = "hassanwebdeveloper30@gmail.com";//TO ADDRESS HERE
                string password = settings.FromEmailPassword;

                int emailNotificationDays = settings.DaysToEmailNotification;

                using (MailMessage msg = new MailMessage())
                {

                    msg.Subject = "Security Alert for continously entry of casual worker.";

                    msg.From = new MailAddress(fromaddr);
                    msg.Body = "Dear Sir,\n\nIt's for your information following worker entry limit reached at " + emailNotificationDays + " day(s) need your necessary action on it.\n\n Name: "+chName+"\n\n CNIC Number: "+chCnic+"\n\nThis is system generated email.";
                    msg.To.Add(new MailAddress(toAddress));

                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = settings.SmtpServer;
                        smtp.Port = Convert.ToInt32(settings.SmtpPort);
                        smtp.UseDefaultCredentials = true;
                        smtp.EnableSsl = settings.IsSmptSSL;

                        if (settings.IsSmptAuthRequired)
                        {
                            NetworkCredential nc = new NetworkCredential(fromaddr, password);
                            smtp.Credentials = nc;
                        }

                        smtp.Send(msg);
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured in sending email.\n\n" + GetInnerExceptionMessage(ex));
            }
        }
    }

    public enum LimitStatus
    {
        Allowed,
        LimitReached,
        CurrentlyCheckIn,
        EmailAlerted,
        EmailAlertDisabled
    }
}
