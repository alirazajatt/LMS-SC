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
    public partial class AddEmailAddressForm : Form
    {
        public AddEmailAddressForm()
        {
            InitializeComponent();

            this.emailAddressBindingSource.DataSource = (from email in EFERTDbUtility.mEFERTDb.EmailAddresses
                                                          where email != null
                                                          select email).ToList();
        }

        private void dgvEmails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<EmailAddress> lstEmails = (from email in EFERTDbUtility.mEFERTDb.EmailAddresses
                                         where email != null
                                         select email).ToList();

            for (int i = 0; i < lstEmails.Count; i++)
            {
                DataGridViewRow row = this.dgvEmails.Rows[i];

                row.Tag = lstEmails[i];
            }
        }

        private void dgvEmails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                EmailAddress email = e.Row.Tag as EmailAddress;

                EFERTDbUtility.mEFERTDb.Entry(email).State = System.Data.Entity.EntityState.Deleted;

                EFERTDbUtility.mEFERTDb.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Some error occurred in deleting Cadre.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));

                e.Cancel = true;
            }
        }

        private void dgvEmails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvEmails.Rows[e.RowIndex];

            if (row == null || (string.IsNullOrEmpty(row.Cells[1].Value as string) && string.IsNullOrEmpty(row.Cells[1].Value as string)))
            {
                this.dgvEmails.CancelEdit();
            }

            EmailAddress email = null;
            string name = row.Cells[1].Value as String ?? string.Empty;
            string emailAddress = row.Cells[2].Value as String ?? string.Empty;

            if (row.Tag == null)
            {
                email = new EmailAddress()
                {
                    Name = name,
                    Email = emailAddress
                };

                EFERTDbUtility.mEFERTDb.EmailAddresses.Add(email);

            }
            else
            {
                email = row.Tag as EmailAddress;
                email.Name = name;
                email.Email = emailAddress;

                EFERTDbUtility.mEFERTDb.Entry(email).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();

                if (row.Tag == null)
                {
                    //EFERTDbUtility.mVisitingLocations.Add(cadre);

                    row.Tag = email;
                }
                else
                {
                    //EFERTDbUtility.mVisitingLocations[EFERTDbUtility.mVisitingLocations.IndexOf(cadre)] = cadre;
                }
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                this.dgvEmails.CancelEdit();

                MessageBox.Show(this, "Some error occurred in updating visiting locations.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }
        }        
    }
}
