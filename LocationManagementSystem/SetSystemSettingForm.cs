using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationManagementSystem
{
    public partial class SetSystemSettingForm : Form
    {
        private SystemSetting mSettings = null;

        public SetSystemSettingForm(SystemSetting setting)
        {
            this.mSettings = setting;
            InitializeComponent();

            if (setting == null)
            {
                this.nuNoEmailNotificationDays.Value = 70;
                this.nuNoOfBlockUserDays.Value = 90;
            }
            else
            {
                this.nuNoEmailNotificationDays.Value = setting.DaysToEmailNotification;
                this.nuNoOfBlockUserDays.Value = setting.DaysToBlockUser;
                this.tbxSmtpServer.Text = setting.SmtpServer;
                this.tbxSmtpPort.Text = setting.SmtpPort;
                this.tbxUserName.Text = setting.FromEmailAddress;
                this.tbxPassword.Text = setting.FromEmailPassword;
                this.chbIsSSL.Checked = setting.IsSmptSSL;
                this.chbAuthReq.Checked = setting.IsSmptAuthRequired;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int dayToEmailNotification = Convert.ToInt32(this.nuNoEmailNotificationDays.Value);
            int daysToBlock = Convert.ToInt32(this.nuNoOfBlockUserDays.Value);

            if (daysToBlock < dayToEmailNotification)
            {
                MessageBox.Show("Days to block can not be less than day to email notification.");
                return;
            }

            try
            {
                if (this.mSettings == null)
                {
                    this.mSettings = new SystemSetting();

                    this.mSettings.DaysToEmailNotification = Convert.ToInt32(this.nuNoEmailNotificationDays.Value);
                    this.mSettings.DaysToBlockUser = Convert.ToInt32(this.nuNoOfBlockUserDays.Value);
                    this.mSettings.SmtpServer = this.tbxSmtpServer.Text;
                    this.mSettings.SmtpPort = this.tbxSmtpPort.Text;
                    this.mSettings.FromEmailAddress = this.tbxUserName.Text;
                    this.mSettings.FromEmailPassword = this.tbxPassword.Text;
                    this.mSettings.IsSmptSSL = this.chbIsSSL.Checked;
                    this.mSettings.IsSmptAuthRequired = this.chbAuthReq.Checked;

                    EFERTDbUtility.mEFERTDb.SystemSetting.Add(this.mSettings);
                }
                else
                {
                    this.mSettings.DaysToEmailNotification = Convert.ToInt32(this.nuNoEmailNotificationDays.Value);
                    this.mSettings.DaysToBlockUser = Convert.ToInt32(this.nuNoOfBlockUserDays.Value);
                    this.mSettings.SmtpServer = this.tbxSmtpServer.Text;
                    this.mSettings.SmtpPort = this.tbxSmtpPort.Text;
                    this.mSettings.FromEmailAddress = this.tbxUserName.Text;
                    this.mSettings.FromEmailPassword = this.tbxPassword.Text;
                    this.mSettings.IsSmptSSL = this.chbIsSSL.Checked;
                    this.mSettings.IsSmptAuthRequired = this.chbAuthReq.Checked;

                    EFERTDbUtility.mEFERTDb.Entry(this.mSettings).State = System.Data.Entity.EntityState.Modified;
                }

                EFERTDbUtility.mEFERTDb.SaveChanges();
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                MessageBox.Show(this, "Some save system settings.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }
            

        }

        private void tbxSmtpPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            EFERTDbUtility.AllowNumericOnly(e);
        }
    }
}
