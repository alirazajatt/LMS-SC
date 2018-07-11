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
    public partial class LocationSelectorForm : Form
    {
        public static LocationSelectorForm mLocationSelectorForm = null;

        public LocationSelectorForm()
        {
            InitializeComponent();

            mLocationSelectorForm = this;

            this.btnAdminPanel.Visible = Form1.mLoggedInUser.IsAdmin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(true);

            searchForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(false);

            searchForm.Show();

            this.Hide();
        }

        private void LocationSelectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Form1.mMainForm.Visible)
            {
                Form1.mMainForm.Close();
            }
            
        }
        

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();

            adminForm.ShowDialog(this);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form1.mLoggedInUser = null;
            Form1.mMainForm.Show();
            this.Close();
        }
    }
}
