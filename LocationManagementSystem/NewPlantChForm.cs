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
    public partial class NewPlantChForm : Form
    {
        public string mCNICNumber = string.Empty;
        public static NewPlantChForm mNewPlantChForm = null;

        public NewPlantChForm(string cnicNumber)
        {
            InitializeComponent();
            this.mCNICNumber = cnicNumber;
            mNewPlantChForm = this;
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            VisitorForm vf = new VisitorForm(this.mCNICNumber, "Visitor");

            vf.ShowDialog(this);
        }

        private void btnContractor_Click(object sender, EventArgs e)
        {
            ContractorChForm cch = new ContractorChForm(this.mCNICNumber, "Contractor", true);

            cch.ShowDialog(this);
        }

        private void btnWoStaff_Click(object sender, EventArgs e)
        {
            ContractorChForm cch = new ContractorChForm(this.mCNICNumber, "WO Staff", true, title:"Work Order Staff Form", gpTitle:"WO Staff Details");

            cch.ShowDialog(this);
        }

        private void btnPallaydar_Click(object sender, EventArgs e)
        {
            ContractorChForm cch = new ContractorChForm(this.mCNICNumber, "Pallaydar", true, title: "Pallaydar Form", gpTitle: "Pallaydar Details");

            cch.ShowDialog(this);
        }

        private void btnCasual3pStaff_Click(object sender, EventArgs e)
        {
            ContractorChForm cch = new ContractorChForm(this.mCNICNumber, "Casual 3P", true, title: "Casual 3P Staff Form", gpTitle: "Casual 3P Details");

            cch.ShowDialog(this);
        }
    }
}
