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
    public partial class UpdateLocationsForm : Form
    {
        //private List<VisitingLocations> mLstPlantLocations = null;
        //private List<VisitingLocations> mLstColonyLocations = null;

        public UpdateLocationsForm()
        {
            InitializeComponent();

            this.visitingLocationsBindingSource.DataSource = EFERTDbUtility.mVisitingLocations.FindAll(location => location.IsOnPlant);
            //mLstPlantLocations = (this.visitingLocationsBindingSource.DataSource as List<VisitingLocations>);
            

            this.visitingLocationsBindingSource1.DataSource = EFERTDbUtility.mVisitingLocations.FindAll(location => !location.IsOnPlant);

            //mLstColonyLocations = (this.visitingLocationsBindingSource1.DataSource as List<VisitingLocations>);
            
        }

        //private void dgvPlantLocations_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    if (e.RowIndex < mLstPlantLocations.Count - 1)
        //    {
        //        this.dgvPlantLocations.Rows[e.RowIndex].Tag = mLstPlantLocations[e.RowIndex];
        //    }
        //}

        //private void dgvColonyLocations_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    if (e.RowIndex < mLstColonyLocations.Count - 1)
        //    {
        //        this.dgvColonyLocations.Rows[e.RowIndex].Tag = mLstColonyLocations[e.RowIndex];
        //    }
        //}
        
        //private void dgvPlantLocations_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{
        //    try
        //    {
        //        string newValue = e.Row.Cells[1].Value as string;

        //        VisitingLocations newLoacation = new VisitingLocations()
        //        {
        //            IsOnPlant = true,
        //            Location = newValue
        //        };

        //        EFERTDbUtility.mEFERTDb.VisitingLocations.Add(newLoacation);

        //        EFERTDbUtility.mEFERTDb.SaveChanges();

        //        EFERTDbUtility.mVisitingLocations.Add(newLoacation);

        //        e.Row.Tag = newLoacation;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, "Some error occurred in deleting location.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
        //    }
        //}

        private void dgvPlantLocations_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                VisitingLocations visitingLocations = e.Row.Tag as VisitingLocations;

                EFERTDbUtility.mEFERTDb.Entry(visitingLocations).State = System.Data.Entity.EntityState.Deleted;

                EFERTDbUtility.mEFERTDb.SaveChanges();

                EFERTDbUtility.mVisitingLocations.Remove(visitingLocations);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Some error occurred in deleting location.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));

                e.Cancel = true;
            }
        }

        //private void dgvColonyLocations_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{
        //    try
        //    {
        //        string newValue = e.Row.Cells[1].Value as string;

        //        VisitingLocations newLoacation = new VisitingLocations()
        //        {
        //            IsOnPlant = false,
        //            Location = newValue
        //        };

        //        EFERTDbUtility.mEFERTDb.VisitingLocations.Add(newLoacation);

        //        EFERTDbUtility.mEFERTDb.SaveChanges();

        //        EFERTDbUtility.mVisitingLocations.Add(newLoacation);

        //        e.Row.Tag = newLoacation;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, "Some error occurred in deleting location.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
        //    }
            
        //}

        private void dgvColonyLocations_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                VisitingLocations visitingLocations = e.Row.Tag as VisitingLocations;

                EFERTDbUtility.mEFERTDb.Entry(visitingLocations).State = System.Data.Entity.EntityState.Deleted;

                EFERTDbUtility.mEFERTDb.SaveChanges();

                EFERTDbUtility.mVisitingLocations.Remove(visitingLocations);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Some error occurred in deleting location.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));

                e.Cancel = true;
            }
        }

        private void dgvPlantLocations_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPlantLocations.Rows[e.RowIndex];

            if (row == null || string.IsNullOrEmpty(row.Cells[1].Value as string))
            {
                this.dgvPlantLocations.CancelEdit();
            }

            VisitingLocations visitingLocation = null;

            if (row.Tag == null)
            {
                visitingLocation = new VisitingLocations()
                {
                    Location = row.Cells[1].Value as String,
                    IsOnPlant = true
                };

                EFERTDbUtility.mEFERTDb.VisitingLocations.Add(visitingLocation);
           
            }
            else
            {
                visitingLocation = row.Tag as VisitingLocations;
                visitingLocation.Location = row.Cells[1].Value as String;

                EFERTDbUtility.mEFERTDb.Entry(visitingLocation).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();

                if (row.Tag == null)
                {
                    EFERTDbUtility.mVisitingLocations.Add(visitingLocation);

                    row.Tag = visitingLocation;
                }
                else
                {
                    EFERTDbUtility.mVisitingLocations[EFERTDbUtility.mVisitingLocations.IndexOf(visitingLocation)] = visitingLocation;
                }
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                this.dgvPlantLocations.CancelEdit();

                MessageBox.Show(this, "Some error occurred in updating visiting locations.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }
            
        }

        private void dgvColonyLocations_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvColonyLocations.Rows[e.RowIndex];

            if (row == null || string.IsNullOrEmpty(row.Cells[1].Value as string))
            {
                this.dgvColonyLocations.CancelEdit();
            }

            VisitingLocations visitingLocation = null;

            if (row.Tag == null)
            {
                visitingLocation = new VisitingLocations()
                {
                    Location = row.Cells[1].Value as String,
                    IsOnPlant = false
                };

                EFERTDbUtility.mEFERTDb.VisitingLocations.Add(visitingLocation);
            }
            else
            {
                visitingLocation = row.Tag as VisitingLocations;
                visitingLocation.Location = row.Cells[1].Value as String;

                EFERTDbUtility.mEFERTDb.Entry(visitingLocation).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();

                if (row.Tag == null)
                {
                    EFERTDbUtility.mVisitingLocations.Add(visitingLocation);

                    row.Tag = visitingLocation;
                }
                else
                {
                    EFERTDbUtility.mVisitingLocations[EFERTDbUtility.mVisitingLocations.IndexOf(visitingLocation)] = visitingLocation;
                }
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                this.dgvColonyLocations.CancelEdit();

                MessageBox.Show(this, "Some error occurred in updating visiting locations.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }

        }

        private void dgvColonyLocations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<VisitingLocations> lstColonyLocations = EFERTDbUtility.mVisitingLocations.FindAll(location => !location.IsOnPlant);

            for (int i = 0; i < lstColonyLocations.Count; i++)
            {
                DataGridViewRow row = this.dgvColonyLocations.Rows[i];

                row.Tag = lstColonyLocations[i];
            }
        }

        private void dgvPlantLocations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<VisitingLocations> lstPlantLocations = EFERTDbUtility.mVisitingLocations.FindAll(location => location.IsOnPlant);

            for (int i = 0; i < lstPlantLocations.Count; i++)
            {
                DataGridViewRow row = this.dgvPlantLocations.Rows[i];

                row.Tag = lstPlantLocations[i];
            }
        }
    }
}
