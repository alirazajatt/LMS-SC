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
    public partial class UpdateSectionForm : Form
    {
        public UpdateSectionForm()
        {
            InitializeComponent();

            this.sectionInfoBindingSource.DataSource = (from section in EFERTDbUtility.mEFERTDb.Sections
                                                           where section != null
                                                           select section).ToList();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                SectionInfo section = e.Row.Tag as SectionInfo;

                EFERTDbUtility.mEFERTDb.Entry(section).State = System.Data.Entity.EntityState.Deleted;

                EFERTDbUtility.mEFERTDb.SaveChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Some error occurred in deleting Section.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));

                e.Cancel = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvSections.Rows[e.RowIndex];

            if (row == null || string.IsNullOrEmpty(row.Cells[1].Value as string))
            {
                this.dgvSections.CancelEdit();
            }

            SectionInfo section = null;

            if (row.Tag == null)
            {
                section = new SectionInfo()
                {
                    SectionName = row.Cells[1].Value as String
                };

                EFERTDbUtility.mEFERTDb.Sections.Add(section);

            }
            else
            {
                section = row.Tag as SectionInfo;
                section.SectionName = row.Cells[1].Value as String;

                EFERTDbUtility.mEFERTDb.Entry(section).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();

                if (row.Tag == null)
                {
                    //EFERTDbUtility.mVisitingLocations.Add(Section);

                    row.Tag = section;
                }
                else
                {
                    //EFERTDbUtility.mVisitingLocations[EFERTDbUtility.mVisitingLocations.IndexOf(Section)] = Section;
                }
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                this.dgvSections.CancelEdit();

                MessageBox.Show(this, "Some error occurred in updating visiting locations.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }
        }

        private void dgvDepartments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<SectionInfo> lstSections = (from depart in EFERTDbUtility.mEFERTDb.Sections
                                                   where depart != null
                                                   select depart).ToList();

            for (int i = 0; i < lstSections.Count; i++)
            {
                DataGridViewRow row = this.dgvSections.Rows[i];

                row.Tag = lstSections[i];
            }
        }
    }
}
