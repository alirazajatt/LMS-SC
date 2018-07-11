using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationManagementSystem
{
    public partial class CheckCardStatusForm : Form
    {
        public CheckCardStatusForm()
        {
            InitializeComponent();

            List<string> companies = (from company in EFERTDbUtility.mEFERTDb.Companies
                                      where company != null
                                      select company.CompanyName).ToList();

            this.cbxCompanyName.Items.AddRange(companies.ToArray());
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string companyName = this.cbxCompanyName.SelectedItem as string;

            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Please select any company first.");
                return;
            }

            companyName = companyName.ToLower();

            DateTime fromDate = this.dtpFromDate.Value.Date;
            DateTime toDate = this.dtpToDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            List<CheckInAndOutInfo> lstCheckIns =  (from checkIn in EFERTDbUtility.mEFERTDb.CheckedInInfos
                                                     where checkIn != null && 
                                                           checkIn.CheckedIn && 
                                                           (checkIn.DateTimeIn >= fromDate && checkIn.DateTimeIn <= toDate)
                                                     select checkIn).ToList();



            lstCheckIns = (from checkIn in lstCheckIns
                           where checkIn != null && 
                           (checkIn.DailyCardHolders == null || checkIn.DailyCardHolders.CompanyName == null ?
                                (checkIn.CardHolderInfos == null || checkIn.CardHolderInfos.Company == null || checkIn.CardHolderInfos.Company.CompanyName == null ? false : checkIn.CardHolderInfos.Company.CompanyName.ToLower() == companyName) :
                                 checkIn.DailyCardHolders.CompanyName.ToLower() == companyName)
                           select checkIn).ToList();

            this.checkInAndOutInfoBindingSource1.DataSource = lstCheckIns;
        }
    }
}
