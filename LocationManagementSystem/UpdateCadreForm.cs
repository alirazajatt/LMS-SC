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
    public partial class UpdateCadreForm : Form
    {
        public UpdateCadreForm()
        {
            InitializeComponent();

            this.cadreInfoBindingSource.DataSource = (from cadre in EFERTDbUtility.mEFERTDb.Cadres
                                                           where cadre != null
                                                           select cadre).ToList();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                CadreInfo cadre = e.Row.Tag as CadreInfo;

                EFERTDbUtility.mEFERTDb.Entry(cadre).State = System.Data.Entity.EntityState.Deleted;

                EFERTDbUtility.mEFERTDb.SaveChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Some error occurred in deleting Cadre.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));

                e.Cancel = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvCadres.Rows[e.RowIndex];

            if (row == null || string.IsNullOrEmpty(row.Cells[1].Value as string))
            {
                this.dgvCadres.CancelEdit();
            }


            CadreInfo cadre = null;

            if (row.Tag == null)
            {
                cadre = new CadreInfo()
                {
                    CadreName = row.Cells[1].Value as String
                };

                EFERTDbUtility.mEFERTDb.Cadres.Add(cadre);

            }
            else
            {
                cadre = row.Tag as CadreInfo;
                cadre.CadreName = row.Cells[1].Value as String;

                EFERTDbUtility.mEFERTDb.Entry(cadre).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();

                if (row.Tag == null)
                {
                    //EFERTDbUtility.mVisitingLocations.Add(cadre);

                    row.Tag = cadre;
                }
                else
                {
                    //EFERTDbUtility.mVisitingLocations[EFERTDbUtility.mVisitingLocations.IndexOf(cadre)] = cadre;
                }
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                this.dgvCadres.CancelEdit();

                MessageBox.Show(this, "Some error occurred in updating visiting locations.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }
        }

        private void dgvDepartments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<CadreInfo> lstCadres = (from depart in EFERTDbUtility.mEFERTDb.Cadres
                                                   where depart != null
                                                   select depart).ToList();

            for (int i = 0; i < lstCadres.Count; i++)
            {
                DataGridViewRow row = this.dgvCadres.Rows[i];

                row.Tag = lstCadres[i];
            }
        }
    }
}
