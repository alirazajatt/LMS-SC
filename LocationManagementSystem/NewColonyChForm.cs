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
    public partial class NewColonyChForm : Form
    {
        public string mCNICNumber = string.Empty;
        public static NewColonyChForm mNewColonyChForm = null;

        public NewColonyChForm(string cnicNumber)
        {
            InitializeComponent();
            this.mCNICNumber = cnicNumber;
            mNewColonyChForm = this;
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            VisitorForm vf = new VisitorForm(this.mCNICNumber, "Visitor");

            vf.ShowDialog(this);
        }
                
        private void btnCasual3pStaff_Click(object sender, EventArgs e)
        {
            ContractorChForm cch = new ContractorChForm(this.mCNICNumber, "Casual 3P", true, title: "Casual 3P Staff Form", gpTitle: "Casual 3P Details");

            cch.ShowDialog(this);
        }
        
        private void btnMarketStaff_Click(object sender, EventArgs e)
        {
            ContractorChForm cch = new ContractorChForm(this.mCNICNumber, "Market Staff", true, title: "Market Staff Form", gpTitle: "Market Staff Details");

            cch.ShowDialog(this);
        }

        private void btnSchoolingStaff_Click(object sender, EventArgs e)
        {
            VisitorForm vf = new VisitorForm(this.mCNICNumber, "Education", title: "Education Staff Form", gpTitle: "Education Staff Details", schoolStaff: true);

            vf.ShowDialog(this);
        }

        private void btnMasjid_Click(object sender, EventArgs e)
        {
            ContractorChForm cch = new ContractorChForm(this.mCNICNumber, "Masjid Staff", true, title: "Masjid Staff Form", gpTitle: "Masjid Staff Details");

            cch.ShowDialog(this);
        }

        private void btnHouseServant_Click(object sender, EventArgs e)
        {
            VisitorForm vf = new VisitorForm(this.mCNICNumber, "House Servant", title: "House Servant Form", gpTitle: "House Servant Details");

            vf.ShowDialog(this);
        }

        private void btnClub_Click(object sender, EventArgs e)
        {
            ContractorChForm cch = new ContractorChForm(this.mCNICNumber, "Club Staff",true, title: "Club Staff Form", gpTitle: "Club Staff Details", clubStaff: true);

            cch.ShowDialog(this);
        }
    }
}
