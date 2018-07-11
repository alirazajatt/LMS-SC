using LocationManagementSystem.CCFTCentralDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationManagementSystem
{
    public partial class PermanentChForm : Form
    {
        public string mCNICNumber = string.Empty;
        public List<CheckInAndOutInfo> mCheckIns = new List<CheckInAndOutInfo>();
        public List<BlockedPersonInfo> mBlocks = new List<BlockedPersonInfo>();
        public CardHolderInfo mCardHolderInfo = null;

        public PermanentChForm(CardHolderInfo cardHolderInfo)
        {
            PermamentCardHolder permanentCh = null;

            if (cardHolderInfo != null)
            {
                this.mCardHolderInfo = cardHolderInfo;
                string strPNumber = string.IsNullOrEmpty(cardHolderInfo.PNumber) ? "P-Number not found." : cardHolderInfo.PNumber;

                string strDOB = string.IsNullOrEmpty(cardHolderInfo.DateOfBirth) ? "Date of birth not found." : cardHolderInfo.DateOfBirth;
                string bloodGroup = cardHolderInfo.BloodGroup;
                string CNICNumber = cardHolderInfo.CNICNumber;
                string crew = cardHolderInfo.Crew == null ? "" : cardHolderInfo.Crew.CrewName;
                string cadre = cardHolderInfo.Cadre == null ? "" : cardHolderInfo.Cadre.CadreName;
                string department = cardHolderInfo.Department == null ? "" : cardHolderInfo.Department.DepartmentName;
                string designation = cardHolderInfo.Designation == null ? "" : cardHolderInfo.Designation.Designation;
                string contactNumber = cardHolderInfo.EmergancyContactNumber;
                string section = cardHolderInfo.Section == null ? "" : cardHolderInfo.Section.SectionName;

                permanentCh = new PermamentCardHolder()
                {
                    FirstName = cardHolderInfo.FirstName,
                    LastName = cardHolderInfo.LastName,
                    BloodGroup = string.IsNullOrEmpty(bloodGroup) ? "Blood Group Not Found." : bloodGroup,
                    Cadre = cadre,
                    CardNumber = cardHolderInfo.LastName,
                    CNICNumber = string.IsNullOrEmpty(CNICNumber) ? "CINC Not Found." : CNICNumber,
                    Crew = string.IsNullOrEmpty(crew) ? "Crew Not Found." : crew,
                    Department = string.IsNullOrEmpty(department) ? "Department Not Found." : department,
                    Designation = string.IsNullOrEmpty(designation) ? "Designation Not Found." : designation,
                    EmergancyContactNumber = string.IsNullOrEmpty(contactNumber) ? "Contact Number Not Found." : contactNumber,
                    Section = string.IsNullOrEmpty(section) ? "Section Not Found." : section,
                    PNumber = strPNumber,
                    DateOfBirth = strDOB,
                    CheckInInfos = cardHolderInfo.CheckInInfos ?? new List<CheckInAndOutInfo>(),
                    BlockedInfos = cardHolderInfo.BlockingInfos ?? new List<BlockedPersonInfo>()
                };
            }

            InitializeComponent();

            if (permanentCh != null)
            {
                PersonalDataImageID pdii = (from pdi in EFERTDbUtility.mCCFTCentral.PersonalDataImageIDs
                                             where pdi != null && pdi.CardholderID == cardHolderInfo.FTItemId
                                             select pdi).FirstOrDefault();

                

                this.tbxCardNumber.Text = permanentCh.CardNumber;
                this.tbxFirstName.Text = permanentCh.FirstName;
                this.tbxBloodGroup.Text = permanentCh.BloodGroup;
                this.tbxCadre.Text = permanentCh.Cadre;
                this.tbxCrew.Text = permanentCh.Crew;
                this.tbxDob.Text = permanentCh.DateOfBirth;
                this.tbxDepartment.Text = permanentCh.Department;
                this.tbxDesignation.Text = permanentCh.Designation;
                this.tbxContactNumber.Text = permanentCh.EmergancyContactNumber;
                this.tbxCNICNumber.Text = permanentCh.CNICNumber;
                this.tbxPNumber.Text = permanentCh.PNumber;
                this.tbxSection.Text = permanentCh.Section;
                this.tbxLastName.Text = permanentCh.LastName;
                //this.tbxCardNumber.Text = permanentCh.CardNumber;
                this.mCheckIns = permanentCh.CheckInInfos;
                this.mBlocks = permanentCh.BlockedInfos;
                this.mCNICNumber = permanentCh.CNICNumber;
            }

            this.UpdateStatus(this.mCNICNumber);
        }

        //public PermanentChForm(string cnicNumber)
        //{
        //    InitializeComponent();

        //    this.tbxCardNumber.ReadOnly = false;
        //    this.tbxFirstName.ReadOnly = false;
        //    this.tbxBloodGroup.ReadOnly = false;
        //    this.tbxCadre.ReadOnly = false;
        //    this.tbxCrew.ReadOnly = false;
        //    this.tbxDob.ReadOnly = false;
        //    this.tbxDepartment.ReadOnly = false;
        //    this.tbxDesignation.ReadOnly = false;
        //    this.tbxContactNumber.ReadOnly = false;
        //    this.tbxCNICNumber.Text = cnicNumber;
        //    this.tbxPNumber.ReadOnly = false;
        //    this.tbxSection.ReadOnly = false;
        //    this.tbxLastName.ReadOnly = false;
        //    //this.tbxCardNumber.Text = permanentCh.CardNumber;


        //    this.UpdateStatus(cnicNumber);
        //}

        public void SetCardNumber(string cardNumber)
        {
            this.tbxCheckInCardNumber.Text = cardNumber;
        }

        private void UpdateStatus(string cnicNumber)
        {
            if (string.IsNullOrEmpty(cnicNumber))
            {
                this.btnCheckIn.Enabled = false;
                this.btnCheckOut.Enabled = false;
                this.tbxBlockedBy.ReadOnly = true;
                this.tbxBlockedReason.ReadOnly = true;
                this.tbxBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxBlockedReason.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.lblVisitorStatus.Text = "Invalid User";
                this.lblVisitorStatus.BackColor = Color.Red;
                this.btnBlock.Enabled = false;
                this.btnUnBlock.Enabled = false;
                return;
            }

            if (Form1.mLoggedInUser.IsAdmin)
            {
                this.btnBlock.Visible = true;
                this.btnUnBlock.Visible = true;
                this.tbxBlockedBy.ReadOnly = false;
                this.tbxBlockedReason.ReadOnly = false;
                this.tbxBlockedBy.BackColor = System.Drawing.Color.White;
                this.tbxBlockedReason.BackColor = System.Drawing.Color.White;
            }
            else
            {
                this.btnBlock.Visible = false;
                this.btnUnBlock.Visible = false;
                this.tbxBlockedBy.ReadOnly = true;
                this.tbxBlockedReason.ReadOnly = true;
                this.tbxBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxBlockedReason.BackColor = System.Drawing.SystemColors.ButtonFace;
            }

            this.mCNICNumber = cnicNumber;

            BlockedPersonInfo blockedPerson = null;
            bool blockedUser = false;

            if (this.mBlocks.Exists(blocked => blocked.Blocked && blocked.CNICNumber == this.mCNICNumber))
            {
                blockedUser = true;
                blockedPerson = this.mBlocks.Find(blocked => blocked.Blocked && blocked.CNICNumber == this.mCNICNumber);

                this.UpdateLayoutForBlockedPerson(blockedPerson);
            }
            else
            {
                this.btnUnBlock.Enabled = false;
                this.tbxBlockedBy.Text = string.Empty;
                this.tbxBlockedReason.Text = string.Empty;
                this.lblVisitorStatus.Text = "Allowed";
                this.lblVisitorStatus.BackColor = Color.Green;

                this.tbxBlockedBy.ReadOnly = false;
                this.tbxBlockedReason.ReadOnly = false;

                this.tbxBlockedBy.BackColor = System.Drawing.Color.White;
                this.tbxBlockedReason.BackColor = System.Drawing.Color.White;

                this.tbxUnBlockedBy.ReadOnly = true;
                this.tbxUnblockReason.ReadOnly = true;

                this.tbxUnBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxUnblockReason.BackColor = System.Drawing.SystemColors.ButtonFace;


                if (this.mBlocks.Count > 0)
                {
                    BlockedPersonInfo lastBlockedInfo = this.mBlocks.Last();

                    this.tbxUnBlockedBy.Text = lastBlockedInfo.UnBlockedBy;
                    this.tbxUnBlockTime.Text = lastBlockedInfo.UnBlockTime.ToString();
                    this.tbxUnblockReason.Text = lastBlockedInfo.UnBlockedReason;
                }
            }

            if (this.mCheckIns.Exists(checkedIn => checkedIn.CheckedIn && checkedIn.CNICNumber == this.mCNICNumber))
            {
                CheckInAndOutInfo checkedInInfo = this.mCheckIns.Find(checkedIn => checkedIn.CheckedIn && checkedIn.CNICNumber == this.mCNICNumber);
                this.btnCheckIn.Enabled = false;
                this.btnCheckOut.Enabled = true && !blockedUser;

                this.tbxCheckInCardNumber.Text = checkedInInfo.CardNumber;
                this.tbxCheckInVehicleNumber.Text = checkedInInfo.VehicleNmuber;
                this.tbxCheckInDateTimeIn.Text = checkedInInfo.DateTimeIn.ToString();
                this.tbxCheckInDateTimeOut.Text = DateTime.Now.ToString();

                this.tbxCheckInCardNumber.ReadOnly = true;
                this.tbxCheckInVehicleNumber.ReadOnly = true;
                this.tbxCheckInCardNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxCheckInVehicleNumber.BackColor = System.Drawing.SystemColors.ButtonFace;

                

                if (Form1.mLoggedInUser.IsAdmin)
                {
                    AlertInfo chAlertInfos = (from alert in EFERTDbUtility.mEFERTDb.AlertInfos
                                              where alert != null && alert.CNICNumber == this.mCNICNumber
                                              select alert).FirstOrDefault();

                    bool alertDisabled = chAlertInfos.DisableAlert;

                    if (alertDisabled)
                    {
                        this.btnDisableAlerts.Visible = true;
                        this.btnDisableAlerts.Text = "Enable Alert";
                        this.btnDisableAlerts.Tag = false;
                    }
                    else
                    {
                        this.btnDisableAlerts.Visible = true;
                        this.btnDisableAlerts.Tag = true;
                    }
                }
                

            }
            else
            {
                if (!blockedUser)
                {
                    LimitStatus limitStatus = EFERTDbUtility.CheckIfUserCheckedInLimitReached(this.mCheckIns, this.mBlocks);

                    if (limitStatus == LimitStatus.LimitReached)
                    {
                        blockedPerson = this.BlockPerson(EFERTDbUtility.CONST_SYSTEM_BLOCKED_BY, EFERTDbUtility.CONST_SYSTEM_LIMIT_REACHED_REASON);

                        if (blockedPerson != null)
                        {
                            this.UpdateLayoutForBlockedPerson(blockedPerson);

                            blockedUser = true;
                        }

                        //this.btnCheckIn.Enabled = false;
                        //this.btnCheckOut.Enabled = false;
                        //this.tbxBlockedBy.Text = "Admin";
                        //this.tbxBlockedReason.Text = "You have reached maximum limit of temporary check in.";
                        //this.lblVisitorStatus.Text = "Blocked";
                        //this.lblVisitorStatus.BackColor = Color.Red;
                        //this.btnBlock.Enabled = false;

                        //this.tbxBlockedBy.ReadOnly = true;
                        //this.tbxBlockedReason.ReadOnly = true;

                        //this.tbxBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                        //this.tbxBlockedReason.BackColor = System.Drawing.SystemColors.ButtonFace;
                    }
                    else
                    {
                        if (limitStatus == LimitStatus.EmailAlerted)
                        {
                            if (Form1.mLoggedInUser.IsAdmin)
                            {
                                this.btnDisableAlerts.Visible = true;
                                this.btnDisableAlerts.Tag = true;
                            }
                        }
                        else if (limitStatus == LimitStatus.EmailAlertDisabled)
                        {
                            if (Form1.mLoggedInUser.IsAdmin)
                            {
                                this.btnDisableAlerts.Visible = true;
                                this.btnDisableAlerts.Text = "Enable Alert";
                                this.btnDisableAlerts.Tag = false;
                            }
                        }

                        this.btnCheckIn.Enabled = true && !blockedUser;
                        this.btnCheckOut.Enabled = false;
                        this.tbxCheckInDateTimeIn.Text = DateTime.Now.ToString();
                    }
                }
                
            }

            if (blockedUser)
            {
                this.tbxCheckInCardNumber.ReadOnly = true;
                this.tbxCheckInVehicleNumber.ReadOnly = true;
                this.tbxCheckInCardNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxCheckInVehicleNumber.BackColor = System.Drawing.SystemColors.ButtonFace;

                BlockedPersonNotificationForm blockedForm = null;
                if (blockedPerson == null)
                {
                    blockedForm = new BlockedPersonNotificationForm(this.mCardHolderInfo.FirstName, this.mCNICNumber);
                }
                else
                {
                    blockedForm = new BlockedPersonNotificationForm(blockedPerson);
                }


                blockedForm.ShowDialog(this);
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            bool validtated = EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxFirstName, this.tbxCNICNumber, this.tbxBlockedBy, this.tbxBlockedReason });
            if (!validtated)
            {
                MessageBox.Show(this, "Please fill mandatory fields first.");
                return;
            }

            DialogResult result = MessageBox.Show(this, "Are you sure you want to block this person?", "Confirmation Dialog", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            if (this.tbxBlockedBy.Text == EFERTDbUtility.CONST_SYSTEM_BLOCKED_BY)
            {
                MessageBox.Show(this, "Block by \"System\" can not be used.");
                return;
            }

            BlockedPersonInfo blockedPerson = this.BlockPerson(this.tbxBlockedBy.Text, this.tbxBlockedReason.Text);

            if (blockedPerson != null)
            {
                this.UpdateLayoutForBlockedPerson(blockedPerson);
            }
        }

        private BlockedPersonInfo BlockPerson(string blockedBy, string blockedReason)
        {
            BlockedPersonInfo blockedPerson = new BlockedPersonInfo()
            {
                Blocked = true,
                BlockedBy = blockedBy,
                BlockedReason = blockedReason,
                CNICNumber = this.mCNICNumber,
                BlockedTime = DateTime.Now,
                UnBlockTime = DateTime.MaxValue
            };

            blockedPerson.BlockedInPlant = SearchForm.mIsPlant;
            blockedPerson.BlockedInColony = !SearchForm.mIsPlant;

            if (this.mCardHolderInfo == null)
            {
                MessageBox.Show(this, "Unable to Block Person. Some error occured in getting cardholder information.");
                return null;
            }
            else
            {
                blockedPerson.CardHolderInfos = this.mCardHolderInfo;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.BlockedPersons.Add(blockedPerson);
                EFERTDbUtility.mEFERTDb.SaveChanges();
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                MessageBox.Show(this, "Some error occurred in blocking cardholder.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                return null;
            }

            this.mBlocks = this.mCardHolderInfo.BlockingInfos;

            return blockedPerson;
        }

        private void UpdateLayoutForBlockedPerson(BlockedPersonInfo blockedPerson)
        {
            if (blockedPerson != null)
            {
                this.btnCheckIn.Enabled = false;
                this.btnCheckOut.Enabled = false;
                this.lblVisitorStatus.Text = "Blocked";
                this.lblVisitorStatus.BackColor = Color.Red;
                this.tbxBlockedBy.Text = blockedPerson.BlockedBy;
                this.tbxBlockedReason.Text = blockedPerson.BlockedReason;
                this.tbxBlockedTime.Text = blockedPerson.BlockedTime.ToString();
                this.btnBlock.Enabled = false;
                this.btnUnBlock.Enabled = true;

                this.tbxBlockedBy.ReadOnly = true;
                this.tbxBlockedReason.ReadOnly = true;

                this.tbxBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxBlockedReason.BackColor = System.Drawing.SystemColors.ButtonFace;

                this.tbxUnBlockedBy.ReadOnly = false;
                this.tbxUnblockReason.ReadOnly = false;

                this.tbxUnBlockedBy.Text = string.Empty;
                this.tbxUnblockReason.Text = string.Empty;

                this.tbxUnBlockedBy.BackColor = System.Drawing.Color.White;
                this.tbxUnblockReason.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnUnBlock_Click(object sender, EventArgs e)
        {
            bool validtated = EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxFirstName, this.tbxCNICNumber, this.tbxUnBlockedBy, this.tbxUnblockReason });
            if (!validtated)
            {
                MessageBox.Show(this, "Please fill mandatory fields first.");
                return;
            }


            DialogResult result = MessageBox.Show(this, "Are you sure you want to unblock this person?", "Confirmation Dialog", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            if (this.mBlocks.Exists(blocked => blocked.Blocked && blocked.CNICNumber == this.mCNICNumber))
            {                
                BlockedPersonInfo blockedPerson = this.mBlocks.Find(blocked => blocked.Blocked && blocked.CNICNumber == this.mCNICNumber);
                blockedPerson.Blocked = false;
                blockedPerson.UnBlockTime = DateTime.Now;
                blockedPerson.UnBlockedBy = this.tbxUnBlockedBy.Text;
                blockedPerson.UnBlockedReason = this.tbxUnblockReason.Text;

                try
                {
                    EFERTDbUtility.mEFERTDb.Entry(blockedPerson).State = System.Data.Entity.EntityState.Modified;
                    EFERTDbUtility.mEFERTDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    EFERTDbUtility.RollBack();

                    MessageBox.Show(this, "Some error occurred in unblocking cardholder.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                    return;
                }

                if (this.mCheckIns.Exists(checkedIn => checkedIn.CheckedIn && checkedIn.CNICNumber == this.mCNICNumber))
                {
                    this.btnCheckIn.Enabled = false;
                    this.btnCheckOut.Enabled = true;
                }
                else
                {
                    this.btnCheckIn.Enabled = true;
                    this.btnCheckOut.Enabled = false;
                }

                this.mBlocks = this.mCardHolderInfo.BlockingInfos;

                this.tbxBlockedBy.Text = string.Empty;
                this.tbxBlockedReason.Text = string.Empty;
                this.lblVisitorStatus.Text = "Allowed";
                this.lblVisitorStatus.BackColor = Color.Green;
                this.tbxUnBlockTime.Text = blockedPerson.UnBlockTime.ToString();
                this.btnBlock.Enabled = true;
                this.btnUnBlock.Enabled = false;

                this.tbxBlockedBy.ReadOnly = false;
                this.tbxBlockedReason.ReadOnly = false;

                this.tbxBlockedBy.BackColor = System.Drawing.Color.White;
                this.tbxBlockedReason.BackColor = System.Drawing.Color.White; 

                this.tbxUnBlockedBy.ReadOnly = true;
                this.tbxUnblockReason.ReadOnly = true;

                this.tbxUnBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxUnblockReason.BackColor = System.Drawing.SystemColors.ButtonFace;
            }
            else
            {
                MessageBox.Show(this, "This user is not blocked.");
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string cardNumber = this.tbxCheckInCardNumber.Text;

            if (string.IsNullOrEmpty(cardNumber))
            {
                MessageBox.Show(this, "Card number can not be empty.");
                return;
            }

            bool isCardNotReturned = this.mCheckIns.Any(checkInInfo => checkInInfo.CheckedIn && checkInInfo.CardNumber == cardNumber);

            bool cardExist = false;
            CCFTCentralDb.CCFTCentral ccftCentralDb = new CCFTCentralDb.CCFTCentral();
            cardExist = ccftCentralDb.Cardholders.Any(card => card.LastName == cardNumber);
            CardHolderInfo cardHolderInfo = this.mCardHolderInfo;

            if (cardExist && !isCardNotReturned)
            {
                var cardAlreadyIssued =(from checkin in EFERTDbUtility.mEFERTDb.CheckedInInfos
                 where checkin != null && checkin.CheckedIn && checkin.CardNumber == cardNumber
                 select new
                 {
                     checkin.CheckedIn,
                     checkin.CNICNumber
                 }).FirstOrDefault();

                if (cardAlreadyIssued != null && cardAlreadyIssued.CheckedIn)
                {
                    MessageBox.Show(this, "This card is already issue to the person with CNIC number: " + cardAlreadyIssued.CNICNumber);
                    return;
                }
                

                if (cardHolderInfo == null)
                {
                    MessageBox.Show(this, "Unable to Issue Card. Some error occured in getting cardholder information.");
                    return;
                }

                CheckInAndOutInfo checkedInInfo = new CheckInAndOutInfo();

                checkedInInfo.CheckInToPlant = SearchForm.mIsPlant;
                checkedInInfo.CheckInToPlant = !SearchForm.mIsPlant;
                checkedInInfo.FirstName = cardHolderInfo.FirstName;
                checkedInInfo.CardHolderInfos = cardHolderInfo;
                checkedInInfo.CNICNumber = this.mCNICNumber;
                checkedInInfo.CardNumber = cardNumber;
                checkedInInfo.VehicleNmuber = this.tbxCheckInVehicleNumber.Text;
                checkedInInfo.DateTimeIn = Convert.ToDateTime(this.tbxCheckInDateTimeIn.Text);
                checkedInInfo.DateTimeOut = DateTime.MaxValue;
                checkedInInfo.CheckedIn = true;                               

                try
                {
                    EFERTDbUtility.mEFERTDb.CheckedInInfos.Add(checkedInInfo);
                    EFERTDbUtility.mEFERTDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    EFERTDbUtility.RollBack();

                    MessageBox.Show(this, "Some error occurred in issuing card.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                    return;
                }

                this.btnCheckIn.Enabled = false;
                this.btnCheckOut.Enabled = true;

                if (NewColonyChForm.mNewColonyChForm != null)
                {
                    NewColonyChForm.mNewColonyChForm.Close();
                }

                if (NewPlantChForm.mNewPlantChForm != null)
                {
                    NewPlantChForm.mNewPlantChForm.Close();
                }

                this.Close();
            }
            else
            {
                if (!cardExist)
                {
                    MessageBox.Show(this, "Please enter valid card number.");
                }
                else if (isCardNotReturned)
                {
                    MessageBox.Show(this, "Card is already issued to some one else.");
                }

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (this.mCheckIns.Exists(checkedOut => checkedOut.CheckedIn && checkedOut.CNICNumber == this.mCNICNumber))
            {
                CheckInAndOutInfo checkedOutInfo = this.mCheckIns.Find(checkedOut => checkedOut.CheckedIn && checkedOut.CNICNumber == this.mCNICNumber);
                checkedOutInfo.CheckedIn = false;
                checkedOutInfo.DateTimeOut = Convert.ToDateTime(this.tbxCheckInDateTimeOut.Text);

                try
                {
                    EFERTDbUtility.mEFERTDb.Entry(checkedOutInfo).State = System.Data.Entity.EntityState.Modified;
                    EFERTDbUtility.mEFERTDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    EFERTDbUtility.RollBack();

                    MessageBox.Show(this, "Some error occurred in returning card.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                    return;
                }

                this.btnCheckIn.Enabled = true;
                this.btnCheckOut.Enabled = false;

                if (NewColonyChForm.mNewColonyChForm != null)
                {
                    NewColonyChForm.mNewColonyChForm.Close();
                }

                if (NewPlantChForm.mNewPlantChForm != null)
                {
                    NewPlantChForm.mNewPlantChForm.Close();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "This user is not checked in.");
            }
        }

        private void tbxCheckInCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            EFERTDbUtility.AllowNumericOnly(e);
        }

        private void tbxCheckInCardNumber_TextChanged(object sender, EventArgs e)
        {
            EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxCheckInCardNumber });
        }

        private void btnDisableAlerts_Click(object sender, EventArgs e)
        {
            bool disableAlert = Convert.ToBoolean(this.btnDisableAlerts.Tag);

            AlertInfo alertInfo = (from alert in EFERTDbUtility.mEFERTDb.AlertInfos
                                   where alert != null && alert.CNICNumber == this.mCNICNumber
                                   select alert).FirstOrDefault();

            if (alertInfo == null)
            {
                alertInfo = new AlertInfo();
                alertInfo.CNICNumber = this.mCNICNumber;

                if (disableAlert)
                {
                    alertInfo.DisableAlert = true;
                    alertInfo.DisableAlertDate = DateTime.Now;
                    alertInfo.EnableAlertDate = DateTime.MaxValue;
                }
                else
                {
                    alertInfo.DisableAlert = false;
                    alertInfo.EnableAlertDate = DateTime.Now;
                }

                EFERTDbUtility.mEFERTDb.AlertInfos.Add(alertInfo);
            }
            else
            {
                if (disableAlert)
                {
                    alertInfo.DisableAlert = true;
                    alertInfo.DisableAlertDate = DateTime.Now;
                }
                else
                {
                    alertInfo.DisableAlert = false;
                    alertInfo.EnableAlertDate = DateTime.Now;
                }

                EFERTDbUtility.mEFERTDb.Entry(alertInfo).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();

                if (disableAlert)
                {
                    this.btnDisableAlerts.Tag = false;
                    this.btnDisableAlerts.Text = "Enable Alert";
                }
                else
                {
                    this.btnDisableAlerts.Tag = false;
                    this.btnDisableAlerts.Text = "Disable Alert";
                }
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                MessageBox.Show(this, "Some error occurred.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                return;
            }
        }
    }
}
