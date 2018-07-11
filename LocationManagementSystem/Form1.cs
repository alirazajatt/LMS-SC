using LocationManagementSystem.CCFTCentralDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationManagementSystem
{
    public partial class Form1 : Form
    {
        public static Form1 mMainForm = null;
        public static AppUser mLoggedInUser = null;

        private List<AppUser> mUsers = new List<AppUser>()
        {            
            new AppUser()
            {
                UserName = "Admin",
                Password = "efert123#@!",
                IsAdmin = true
            },

            new AppUser()
            {
                UserName = "user",
                Password = "user",
                IsAdmin = false
            },

            new AppUser()
            {
                UserName = "user1",
                Password = "user1",
                IsAdmin = false
            },

            new AppUser()
            {
                UserName = "user2",
                Password = "user2",
                IsAdmin = false
            }
        };

        public Form1()
        {
            InitializeComponent();
            this.lblVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.tbxUserName.Select();
            mMainForm = this;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string userName = this.tbxUserName.Text;
            string password = this.tbxPassword.Text;

            AppUser loggedInUser = (from user in mUsers
                                    where user != null && user.UserName == userName && user.Password == password
                                    select user).FirstOrDefault();

            if (loggedInUser == null)
            {
                MessageBox.Show(this, "Either username or password is incorrect.");
            }
            else
            {
                mLoggedInUser = loggedInUser;

                LocationSelectorForm lsf = new LocationSelectorForm();

                lsf.Show();

                this.Hide();
            }

            
        }
    }
}
