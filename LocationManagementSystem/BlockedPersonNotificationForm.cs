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
    public partial class BlockedPersonNotificationForm : Form
    {
        public BlockedPersonNotificationForm(BlockedPersonInfo blockedPersonInfo)
        {
            InitializeComponent();

            if (blockedPersonInfo != null)
            {
                if (blockedPersonInfo.CardHolderInfos != null)
                {
                    this.lblCardHolderName.Text = blockedPersonInfo.CardHolderInfos.FirstName;
                    this.lblCNIC.Text = blockedPersonInfo.CardHolderInfos.CNICNumber;
                }
                else if(blockedPersonInfo.DailyCardHolders != null)
                {
                    this.lblCardHolderName.Text = blockedPersonInfo.DailyCardHolders.FirstName;
                    this.lblCNIC.Text = blockedPersonInfo.DailyCardHolders.CNICNumber;
                }
                else if(blockedPersonInfo.Visitors != null)
                {
                    this.lblCardHolderName.Text = blockedPersonInfo.Visitors.FirstName;
                    this.lblCNIC.Text = blockedPersonInfo.Visitors.CNICNumber;
                }
                else
                {
                    this.lblCardHolderName.Text = "Not Found";
                    this.lblCNIC.Text = "Not Found";
                }
            }
        }

        public BlockedPersonNotificationForm(string firstName, string cnicNumber)
        {
            InitializeComponent();

            this.lblCardHolderName.Text = firstName;
            this.lblCNIC.Text = cnicNumber;
        }
    }
}
