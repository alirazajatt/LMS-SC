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
    public partial class UpdateDesignationForm : Form
    {
        public UpdateDesignationForm()
        {
            InitializeComponent();

            this.designationInfoBindingSource.DataSource = (from designation in EFERTDbUtility.mEFERTDb.Designations
                                                           where designation != null
                                                           select designation).ToList();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DesignationInfo designation = e.Row.Tag as DesignationInfo;

                EFERTDbUtility.mEFERTDb.Entry(designation).State = System.Data.Entity.EntityState.Deleted;

                EFERTDbUtility.mEFERTDb.SaveChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Some error occurred in deleting Designation.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));

                e.Cancel = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDesignation.Rows[e.RowIndex];

            if (row == null || string.IsNullOrEmpty(row.Cells[1].Value as string))
            {
                this.dgvDesignation.CancelEdit();
            }

            DesignationInfo designation = null;

            if (row.Tag == null)
            {
                designation = new DesignationInfo()
                {
                    Designation = row.Cells[1].Value as String
                };

                EFERTDbUtility.mEFERTDb.Designations.Add(designation);

            }
            else
            {
                designation = row.Tag as DesignationInfo;
                designation.Designation = row.Cells[1].Value as String;

                EFERTDbUtility.mEFERTDb.Entry(designation).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();

                if (row.Tag == null)
                {
                    //EFERTDbUtility.mVisitingLocations.Add(designation);

                    row.Tag = designation;
                }
                else
                {
                    //EFERTDbUtility.mVisitingLocations[EFERTDbUtility.mVisitingLocations.IndexOf(designation)] = designation;
                }
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                this.dgvDesignation.CancelEdit();

                MessageBox.Show(this, "Some error occurred in updating visiting locations.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }
        }

        private void dgvDepartments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<DesignationInfo> lstDesignations = (from depart in EFERTDbUtility.mEFERTDb.Designations
                                                   where depart != null
                                                   select depart).ToList();

            for (int i = 0; i < lstDesignations.Count; i++)
            {
                DataGridViewRow row = this.dgvDesignation.Rows[i];

                row.Tag = lstDesignations[i];
            }
        }
    }
}
