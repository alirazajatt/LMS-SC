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
    public partial class UpdateDepartmentForm : Form
    {
        public UpdateDepartmentForm()
        {
            InitializeComponent();

            this.departmentInfoBindingSource.DataSource = (from depart in EFERTDbUtility.mEFERTDb.Departments
                                                           where depart != null
                                                           select depart).ToList();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DepartmentInfo department = e.Row.Tag as DepartmentInfo;

                EFERTDbUtility.mEFERTDb.Entry(department).State = System.Data.Entity.EntityState.Deleted;

                EFERTDbUtility.mEFERTDb.SaveChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Some error occurred in deleting Department.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));

                e.Cancel = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDepartments.Rows[e.RowIndex];

            if (row == null || string.IsNullOrEmpty(row.Cells[1].Value as string))
            {
                this.dgvDepartments.CancelEdit();
            }

            DepartmentInfo department = null;

            if (row.Tag == null)
            {
                department = new DepartmentInfo()
                {
                    DepartmentName = row.Cells[1].Value as String
                };

                EFERTDbUtility.mEFERTDb.Departments.Add(department);

            }
            else
            {
                department = row.Tag as DepartmentInfo;
                department.DepartmentName = row.Cells[1].Value as String;

                EFERTDbUtility.mEFERTDb.Entry(department).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();

                if (row.Tag == null)
                {
                    //EFERTDbUtility.mVisitingLocations.Add(department);

                    row.Tag = department;
                }
                else
                {
                    //EFERTDbUtility.mVisitingLocations[EFERTDbUtility.mVisitingLocations.IndexOf(department)] = department;
                }
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                this.dgvDepartments.CancelEdit();

                MessageBox.Show(this, "Some error occurred in updating visiting locations.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }
        }

        private void dgvDepartments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<DepartmentInfo> lstDepartments = (from depart in EFERTDbUtility.mEFERTDb.Departments
                                                   where depart != null
                                                   select depart).ToList();

            for (int i = 0; i < lstDepartments.Count; i++)
            {
                DataGridViewRow row = this.dgvDepartments.Rows[i];

                row.Tag = lstDepartments[i];
            }
        }

        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
