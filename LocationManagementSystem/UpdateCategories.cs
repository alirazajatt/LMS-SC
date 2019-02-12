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
    public partial class UpdateCategories : Form
    {
        public UpdateCategories(bool AddUpdate = true)
        {
            InitializeComponent();


            this.cbxLoction.DataSource = Enum.GetValues(typeof(CategoryLocation));

            this.cbxBlockCriteria.DataSource = Enum.GetValues(typeof(CategoryBlockCriteria));

           
            this.dgvCategoryInfo.DataSource = (from category in EFERTDbUtility.mEFERTDb.CategoryInfo
                                               where category != null
                                               select category).ToList();

            if (AddUpdate)
            {
                this.btnDelete.Visible = false;
            }
            else
            {
                this.btnAdd.Visible = false;
                this.btnUpdate.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            List<CategoryInfo> inf = (from category in EFERTDbUtility.mEFERTDb.CategoryInfo
                                      where category != null
                                      select category).ToList();

            string categoryName = this.txtName.Text.Trim();
            string blockInfo = this.cbxBlockCriteria.SelectedItem.ToString();
            string location = this.cbxLoction.SelectedItem.ToString();
            bool alreadyAdded = inf.Exists(cat => cat.CategoryName != null && cat.CategoryName.ToLower() == categoryName.ToLower());

            if (!string.IsNullOrEmpty(categoryName) && !alreadyAdded)
            {
                try
                {
                    CategoryInfo catInof = new CategoryInfo()
                    {
                        CategoryName = categoryName,
                        CategoryBlockCriteria = blockInfo,
                        CategoryLocation = location
                    };
                    EFERTDbUtility.mEFERTDb.CategoryInfo.Add(catInof);
                    EFERTDbUtility.mEFERTDb.SaveChanges();

                    this.dgvCategoryInfo.DataSource = (from category in EFERTDbUtility.mEFERTDb.CategoryInfo
                                                       where category != null
                                                       select category).ToList();
                }
                catch (Exception ex)
                {
                    EFERTDbUtility.RollBack();
                    MessageBox.Show(this, "Some error occurred in Adding category.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<CategoryInfo> inf = (from category in EFERTDbUtility.mEFERTDb.CategoryInfo
                                      where category != null
                                      select category).ToList();
            //category not already exist
            string categoryName = this.txtName.Text.Trim();
            string blockInfo = this.cbxBlockCriteria.SelectedItem.ToString();
            string location = this.cbxLoction.SelectedItem.ToString();

            if (string.IsNullOrEmpty(this.txtId.Text))
            {
                return;
            }

            int id = Convert.ToInt32(this.txtId.Text);

            CategoryInfo catInfo = inf.Find(cat => cat.CategoryId == id);

            if (catInfo != null)
            {
                if (!string.IsNullOrEmpty(categoryName) && (catInfo.CategoryLocation != location || catInfo.CategoryBlockCriteria != blockInfo || catInfo.CategoryName != categoryName))
                {
                    try
                    {
                        catInfo.CategoryName = categoryName;
                        catInfo.CategoryBlockCriteria = blockInfo;
                        catInfo.CategoryLocation = location;
                        EFERTDbUtility.mEFERTDb.Entry(catInfo).State = System.Data.Entity.EntityState.Modified;
                        EFERTDbUtility.mEFERTDb.SaveChanges();

                        this.dgvCategoryInfo.DataSource = (from category in EFERTDbUtility.mEFERTDb.CategoryInfo
                                                           where category != null
                                                           select category).ToList();
                    }
                    catch (Exception ex)
                    {
                        EFERTDbUtility.RollBack();
                        MessageBox.Show(this, "Some error occurred in updating category.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<CategoryInfo> inf = (from category in EFERTDbUtility.mEFERTDb.CategoryInfo
                                          where category != null
                                          select category).ToList();

                if (string.IsNullOrEmpty(this.txtId.Text))
                {
                    return;
                }

                int id = Convert.ToInt32(this.txtId.Text);

                CategoryInfo catInfo = inf.Find(cat => cat.CategoryId == id);

                if (catInfo != null)
                {
                    EFERTDbUtility.mEFERTDb.Entry(catInfo).State = System.Data.Entity.EntityState.Deleted;

                    EFERTDbUtility.mEFERTDb.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Some error occurred in deleting Cadre.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
            }
        }

       

        private void dgvCategoryInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvCategoryInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvCategoryInfo.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                string loction = row.Cells[2].Value.ToString();
                string blockinfo = row.Cells[3].Value.ToString();

                this.txtId.Text = id;
                this.txtName.Text = name;
                this.cbxLoction.SelectedItem = (CategoryLocation)Enum.Parse(typeof(CategoryLocation), loction); 
                this.cbxBlockCriteria.SelectedItem = (CategoryBlockCriteria)Enum.Parse(typeof(CategoryBlockCriteria), blockinfo); ;

            }
        }
    }
}
