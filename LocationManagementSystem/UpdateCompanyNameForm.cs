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
    public partial class UpdateCompanyNameForm : Form
    {
        public UpdateCompanyNameForm()
        {
            InitializeComponent();

            this.companyInfoBindingSource.DataSource = (from company in EFERTDbUtility.mEFERTDb.Companies
                                                           where company != null
                                                           select company).ToList();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                CompanyInfo company = e.Row.Tag as CompanyInfo;

                EFERTDbUtility.mEFERTDb.Entry(company).State = System.Data.Entity.EntityState.Deleted;

                EFERTDbUtility.mEFERTDb.SaveChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Some error occurred in deleting Company.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));

                e.Cancel = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvCompanys.Rows[e.RowIndex];

            if (row == null || string.IsNullOrEmpty(row.Cells[1].Value as string))
            {
                this.dgvCompanys.CancelEdit();
            }

            CompanyInfo company = null;

            if (row.Tag == null)
            {
                company = new CompanyInfo()
                {
                    CompanyName = row.Cells[1].Value as String
                };

                EFERTDbUtility.mEFERTDb.Companies.Add(company);

            }
            else
            {
                company = row.Tag as CompanyInfo;
                company.CompanyName = row.Cells[1].Value as String;

                EFERTDbUtility.mEFERTDb.Entry(company).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();

                if (row.Tag == null)
                {
                    //EFERTDbUtility.mVisitingLocations.Add(company);

                    row.Tag = company;
                }
                else
                {
                    //EFERTDbUtility.mVisitingLocations[EFERTDbUtility.mVisitingLocations.IndexOf(company)] = company;
                }
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                this.dgvCompanys.CancelEdit();

                MessageBox.Show(this, "Some error occurred in updating visiting locations.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }
        }

        private void dgvDepartments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<CompanyInfo> lstCompanys = (from depart in EFERTDbUtility.mEFERTDb.Companies
                                                   where depart != null
                                                   select depart).ToList();

            for (int i = 0; i < lstCompanys.Count; i++)
            {
                DataGridViewRow row = this.dgvCompanys.Rows[i];

                row.Tag = lstCompanys[i];
            }
        }
    }
}
