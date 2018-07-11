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
    public partial class ContractorChForm : Form
    {
        public string mCNICNumber = string.Empty;
        public ContractorCardHolder mContractorCardHolder = null;
        public CardHolderInfo mCardHolderInfo = null;
        public DailyCardHolder mDailyCardHolder = null;
        public List<CheckInAndOutInfo> mCheckIns = new List<CheckInAndOutInfo>();
        public List<BlockedPersonInfo> mBlocks = new List<BlockedPersonInfo>();
        public bool mIsDailyCardHolder = false;
        private bool mClubStaff = false;
        private string mContractorInfo = string.Empty;

        public ContractorChForm(CardHolderInfo cardHolderInfo, bool isTempCard = false)
        {
            ContractorCardHolder contractor = null;

            if (cardHolderInfo != null)
            {
                this.mCardHolderInfo = cardHolderInfo;

                if (isTempCard)
                {
                    contractor = new ContractorCardHolder()
                    {
                        FirstName = cardHolderInfo.FirstName,
                        CNICNumber = string.IsNullOrEmpty(cardHolderInfo.CNICNumber) ? "CINC Not Found." : cardHolderInfo.CNICNumber,
                        GallagherCardHolder = false,
                        CheckInInfos = cardHolderInfo.CheckInInfos ?? new List<CheckInAndOutInfo>(),
                        BlockedPersonsInfos = cardHolderInfo.BlockingInfos ?? new List<BlockedPersonInfo>()
                    };
                }
                else
                {
                    string cadre = cardHolderInfo.Cadre == null ? "" : cardHolderInfo.Cadre.CadreName;
                    string companyName = cardHolderInfo.Company == null ? "" : cardHolderInfo.Company.CompanyName;
                    string CNICNumber = cardHolderInfo.CNICNumber;
                    string department = cardHolderInfo.Department == null ? "" : cardHolderInfo.Department.DepartmentName;
                    string designation = cardHolderInfo.Designation == null ? "" : cardHolderInfo.Designation.Designation;
                    string emergancyContactNumber = cardHolderInfo.EmergancyContactNumber;
                    string section = cardHolderInfo.Section == null ? "" : cardHolderInfo.Section.SectionName;
                    string wONumber = cardHolderInfo.WONumber;

                    contractor = new ContractorCardHolder()
                    {
                        FirstName = cardHolderInfo.FirstName,
                        LastName = cardHolderInfo.LastName,
                        CompanyName = string.IsNullOrEmpty(companyName) ? "Company Name Not Found." : companyName,
                        Cadre = cadre,
                        CardNumber = cardHolderInfo.LastName,
                        CNICNumber = string.IsNullOrEmpty(CNICNumber) ? "CINC Not Found." : CNICNumber,
                        Department = string.IsNullOrEmpty(department) ? "Department Not Found." : department,
                        Designation = string.IsNullOrEmpty(designation) ? "Designation Not Found." : designation,
                        EmergancyContactNumber = string.IsNullOrEmpty(emergancyContactNumber) ? "Contact Number Not Found." : emergancyContactNumber,
                        Section = string.IsNullOrEmpty(section) ? "Section Not Found." : section,
                        WONumber = string.IsNullOrEmpty(wONumber) ? "WO No. Not Found." : wONumber,
                        CheckInInfos = cardHolderInfo.CheckInInfos ?? new List<CheckInAndOutInfo>(),
                        BlockedPersonsInfos = cardHolderInfo.BlockingInfos ?? new List<BlockedPersonInfo>()
                    };
                }
               

            }

            InitializeComponent();

            this.UpdateDropDownFields();

            if (contractor != null)
            {
                this.mContractorInfo = cardHolderInfo.ConstractorInfo;
                this.mIsDailyCardHolder = false;
                this.mContractorCardHolder = contractor;
                this.tbxCardNumber.Text = contractor.CardNumber;
                this.tbxFirstName.Text = contractor.FirstName;
                this.cbxCompanyName.SelectedItem = contractor.CompanyName;
                this.cbxCadre.SelectedItem = contractor.Cadre;
                this.cbxDepartment.SelectedItem = contractor.Department;
                this.cbxDesignation.SelectedItem = contractor.Designation;
                this.tbxContactNumber.Text = contractor.EmergancyContactNumber;
                this.tbxCNICNumber.Text = contractor.CNICNumber;
                this.tbxWONumber.Text = contractor.WONumber;
                this.cbxSection.SelectedItem = contractor.Section;
                this.tbxLastName.Text = contractor.LastName;
                //this.tbxCardNumber.Text = permanentCh.CardNumber;
                this.mCheckIns = contractor.CheckInInfos;
                this.mBlocks = contractor.BlockedPersonsInfos;
                this.mCNICNumber = contractor.CNICNumber;
                this.pbxSnapShot.Image = EFERTDbUtility.ByteArrayToImage(this.mCardHolderInfo.Picture);

                this.btnWebCam.Enabled = false;
                this.btnBrowse.Enabled = false;

                this.tbxFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.cbxCompanyName.Enabled = false;
                this.tbxCNICNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.cbxSection.Enabled = false;
                this.cbxCadre.Enabled = false;
                this.cbxDepartment.Enabled = false;
                this.cbxDesignation.Enabled = false;
                this.tbxContactNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxWONumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxLastName.BackColor = System.Drawing.SystemColors.ButtonFace;

                if (this.mContractorInfo == "Pallaydar")
                {
                    this.Text = "Pallaydar Form";
                    this.groupBox1.Text = "Pallaydar Details";

                    this.tbxFirstName.ReadOnly = false;
                    this.tbxFirstName.BackColor = System.Drawing.Color.White;

                    this.cbxCompanyName.Enabled = true;
                    this.tbxWONumber.ReadOnly = false;
                    this.tbxWONumber.BackColor = System.Drawing.Color.White;
                }
                else if (this.mContractorInfo == "WO Staff")
                {
                    this.Text = "Work Order Staff Form";
                    this.groupBox1.Text = "WO Staff Details";

                    this.tbxFirstName.ReadOnly = false;
                    this.tbxFirstName.BackColor = System.Drawing.Color.White;

                    this.cbxCompanyName.Enabled = true;
                    this.tbxWONumber.ReadOnly = false;
                    this.tbxWONumber.BackColor = System.Drawing.Color.White;
                }

            }

            if (isTempCard)
            {
                this.UpdateLayout(false);
            }

            this.UpdateStatus(this.mCNICNumber);
        }

        public ContractorChForm(DailyCardHolder dailyCardHolder)
        {
            InitializeComponent();

            this.UpdateDropDownFields();

            if (dailyCardHolder != null)
            {
                this.mIsDailyCardHolder = true;
                this.mDailyCardHolder = dailyCardHolder;
                this.mContractorInfo = dailyCardHolder.ConstractorInfo;
                this.tbxFirstName.Text = dailyCardHolder.FirstName;
                this.cbxCompanyName.SelectedItem = dailyCardHolder.CompanyName;
                this.cbxCadre.SelectedItem = dailyCardHolder.Cadre;
                this.cbxDepartment.SelectedItem = dailyCardHolder.Department;
                this.cbxDesignation.SelectedItem = dailyCardHolder.Designation;
                this.tbxContactNumber.Text = dailyCardHolder.EmergancyContactNumber;
                this.tbxCNICNumber.Text = dailyCardHolder.CNICNumber;
                this.tbxWONumber.Text = dailyCardHolder.WONumber;
                this.tbxLastName.Text = dailyCardHolder.LastName;
                this.cbxSection.SelectedItem = dailyCardHolder.Section;
                //this.tbxCardNumber.Text = permanentCh.CardNumber;
                this.mCheckIns = dailyCardHolder.CheckInInfos ?? new List<CheckInAndOutInfo>();
                this.mBlocks = dailyCardHolder.BlockingInfos ??  new List<BlockedPersonInfo>();
                this.mCNICNumber = dailyCardHolder.CNICNumber;
                this.pbxSnapShot.Image = EFERTDbUtility.ByteArrayToImage(dailyCardHolder.Picture);

                this.btnWebCam.Enabled = false;
                this.btnBrowse.Enabled = false;

                this.tbxFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.cbxCompanyName.Enabled = false;
                this.tbxCNICNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.cbxSection.Enabled = false;
                this.cbxCadre.Enabled = false;
                this.cbxDepartment.Enabled = false;
                this.cbxDesignation.Enabled = false;
                this.tbxContactNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxWONumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxLastName.BackColor = System.Drawing.SystemColors.ButtonFace;

                this.lblClubType.Visible = false;
                this.cbxClubType.Visible = false;

                if (this.mContractorInfo == "Contractor")
                {
                    this.Text = "Contractor Form";
                    this.groupBox1.Text = "Contractor Details";

                    this.tbxFirstName.ReadOnly = false;
                    this.tbxFirstName.BackColor = System.Drawing.Color.White;

                    this.cbxCompanyName.Enabled = true;
                    this.tbxWONumber.ReadOnly = false;
                    this.tbxWONumber.BackColor = System.Drawing.Color.White;
                }
                else
                if (this.mContractorInfo == "Casual 3P")
                {
                    this.Text = "Casual 3P Form";
                    this.groupBox1.Text = "Casual 3P Details";

                    this.lblAreaOfWork.Visible = true;
                    this.tbxAreaOfWork.Visible = true;

                    this.tbxAreaOfWork.Text = dailyCardHolder.AreaOfWork;
                    this.tbxAreaOfWork.ReadOnly = true;
                    this.tbxAreaOfWork.BackColor = System.Drawing.SystemColors.ButtonFace;

                    this.tbxFirstName.ReadOnly = false;
                    this.tbxFirstName.BackColor = System.Drawing.Color.White;

                    this.cbxCompanyName.Enabled = true;
                    this.tbxWONumber.ReadOnly = false;
                    this.tbxWONumber.BackColor = System.Drawing.Color.White;
                }
                else if (this.mContractorInfo == "Pallaydar")
                {
                    this.Text = "Pallaydar Form";
                    this.groupBox1.Text = "Pallaydar Details";
                    
                    this.tbxFirstName.ReadOnly = false;
                    this.tbxFirstName.BackColor = System.Drawing.Color.White;

                    this.cbxCompanyName.Enabled = true;
                    this.tbxWONumber.ReadOnly = false;
                    this.tbxWONumber.BackColor = System.Drawing.Color.White;

                }
                else if (this.mContractorInfo == "WO Staff")
                {
                    this.Text = "Work Order Staff Form";
                    this.groupBox1.Text = "WO Staff Details";

                    this.tbxFirstName.ReadOnly = false;
                    this.tbxFirstName.BackColor = System.Drawing.Color.White;

                    this.cbxCompanyName.Enabled = true;
                    this.tbxWONumber.ReadOnly = false;
                    this.tbxWONumber.BackColor = System.Drawing.Color.White;
                }
                else if (this.mContractorInfo == "Market Staff")
                {
                    this.Text = "Market Staff Form";
                    this.groupBox1.Text = "Market Staff Details";
                }
                else if (this.mContractorInfo == "Masjid Staff")
                {
                    this.Text = "Masjid Staff Form";
                    this.groupBox1.Text = "Masjid Staff Details";
                }
                else if (this.mContractorInfo == "Club Staff")
                {
                    this.Text = "Club Staff Form";
                    this.groupBox1.Text = "Club Staff Details";

                    this.mClubStaff = true;

                    this.lblClubType.Visible = true;
                    this.cbxClubType.Visible = true;
                    this.cbxClubType.SelectedItem = dailyCardHolder.ClubType;
                    this.cbxClubType.Enabled = false;
                }
            }
            this.UpdateLayout(this.mIsDailyCardHolder);

            this.UpdateStatus(this.mCNICNumber);
        }

        public ContractorChForm(string cnicNumber, string contractorInfo, bool dailyCardHolder = false, string title = null, string gpTitle = null, bool clubStaff = false)
        {
            InitializeComponent();

            this.UpdateDropDownFields();

            if (!string.IsNullOrEmpty(title))
            {
                this.Text = title;
            }

            if (!string.IsNullOrEmpty(gpTitle))
            {
                this.groupBox1.Text = gpTitle;
            }

            this.mContractorInfo = contractorInfo;
            this.mClubStaff = clubStaff;

            if (clubStaff)
            {
                this.lblClubType.Visible = true;
                this.cbxClubType.Visible = true;
            }
            else
            {
                this.lblClubType.Visible = false;
                this.cbxClubType.Visible = false;
            }

            if (this.mContractorInfo == "Casual 3P")
            {
                this.lblAreaOfWork.Visible = true;
                this.tbxAreaOfWork.Visible = true;


                this.tbxAreaOfWork.ReadOnly = false;
                this.tbxAreaOfWork.BackColor = System.Drawing.Color.White;
            }

            this.tbxFirstName.ReadOnly = false;
            this.cbxCompanyName.Enabled = true;
            this.cbxCadre.Enabled = true;
            this.cbxDepartment.Enabled = true;
            this.cbxDesignation.Enabled = true;
            this.tbxContactNumber.ReadOnly = false;
            this.tbxCNICNumber.Text = cnicNumber;
            this.tbxWONumber.ReadOnly = false;
            this.tbxLastName.ReadOnly = false;

            this.tbxFirstName.BackColor = System.Drawing.Color.Yellow;
            this.tbxCheckInCardNumber.BackColor = System.Drawing.Color.Yellow;
            //this.cbxCompanyName.BackColor = System.Drawing.Color.White;
            //this.cbxCadre.BackColor = System.Drawing.Color.White;
            //this.cbxDepartment.BackColor = System.Drawing.Color.White;
            //this.cbxDesignation.BackColor = System.Drawing.Color.White;
            this.tbxContactNumber.BackColor = System.Drawing.Color.White;
            this.tbxWONumber.BackColor = System.Drawing.Color.White;
            this.tbxLastName.BackColor = System.Drawing.Color.White;

            this.mIsDailyCardHolder = dailyCardHolder;
            this.mCNICNumber = cnicNumber;
            this.UpdateLayout(dailyCardHolder);

            this.UpdateStatus(cnicNumber);
        }

        public void SetCardNumber(string cardNumber)
        {
            this.tbxCheckInCardNumber.Text = cardNumber;
        }

        private void UpdateDropDownFields()
        {
            List<string> departments = (from depart in EFERTDbUtility.mEFERTDb.Departments
                                        where depart != null && !string.IsNullOrEmpty(depart.DepartmentName)
                                        select depart.DepartmentName).ToList();

            this.cbxDepartment.Items.AddRange(departments.ToArray());

            List<string> sections = (from section in EFERTDbUtility.mEFERTDb.Sections
                                     where section != null && !string.IsNullOrEmpty(section.SectionName)
                                     select section.SectionName).ToList();

            this.cbxSection.Items.AddRange(sections.ToArray());

            List<string> companies = (from company in EFERTDbUtility.mEFERTDb.Companies
                                     where company != null && !string.IsNullOrEmpty(company.CompanyName)
                                      select company.CompanyName).ToList();

            this.cbxCompanyName.Items.AddRange(companies.ToArray());

            List<string> cadres = (from cadre in EFERTDbUtility.mEFERTDb.Cadres
                                    where cadre != null && !string.IsNullOrEmpty(cadre.CadreName)
                                   select cadre.CadreName).ToList();

            this.cbxCadre.Items.AddRange(cadres.ToArray());

            List<string> designations = (from designation in EFERTDbUtility.mEFERTDb.Designations
                                           where designation != null && !string.IsNullOrEmpty(designation.Designation)
                                         select designation.Designation).ToList();

            this.cbxDesignation.Items.AddRange(designations.ToArray());

        }

        private void UpdateLayout(bool dailyCardHolder)
        {
            if (dailyCardHolder)
            {
                if (this.mClubStaff)
                {
                    this.lblClubType.Location = this.label11.Location;
                    this.cbxClubType.Location = this.tbxWONumber.Location;
                }
                this.label11.Location = this.label2.Location;
                this.tbxWONumber.Location = this.tbxFirstName.Location;
                this.tbxWONumber.Size = this.tbxFirstName.Size;
                this.label2.Location = this.label1.Location;
                this.tbxFirstName.Location = this.tbxCardNumber.Location;
                this.label1.Visible = false;
                this.tbxCardNumber.Visible = false;
                this.groupBox1.Size = new Size(this.groupBox1.Size.Width, 250);
                this.groupBox2.Location = new Point(this.groupBox2.Location.X, 264);
                this.groupBox3.Location = new Point(this.groupBox3.Location.X, 264);
                this.Size = new Size(this.Size.Width, 540);
            }
            else
            {
                this.tbxCardNumber.Visible = false;                
                this.tbxFirstName.Location = new Point(this.tbxFirstName.Location.X, this.tbxCardNumber.Location.Y);
                this.label2.Location = new Point(this.label2.Location.X, this.label1.Location.Y);
                this.cbxCompanyName.Visible = false;
                this.cbxCadre.Visible = false;
                this.cbxDepartment.Visible = false;
                this.cbxDesignation.Visible = false;
                this.tbxContactNumber.Visible = false;
                this.tbxCNICNumber.Text = this.mCNICNumber;
                this.label10.Location = new Point(this.label10.Location.X, this.label4.Location.Y);
                this.tbxCNICNumber.Location = new Point(this.tbxCNICNumber.Location.X, this.cbxCadre.Location.Y);
                this.label1.Visible = false;
                this.label4.Visible = false;
                this.cbxCadre.Visible = false;
                this.tbxCardNumber.Visible = false;
                this.tbxWONumber.Visible = false;
                this.cbxSection.Visible = false;
                this.tbxLastName.Visible = false;
                //this.tbxCardNumber.Text = permanentCh.CardNumber;

                this.groupBox1.Size = new Size(this.groupBox1.Size.Width, 60);
                this.groupBox2.Location = new Point(this.groupBox2.Location.X, 79);
                this.groupBox3.Location = new Point(this.groupBox3.Location.X, 79);
                this.Size = new Size(this.Size.Width, 350);
            }
        }

        private void UpdateStatus(string cnicNumber)
        {
            BlockedPersonInfo blockedPerson = null;
            bool blockedUser = false;
            if (string.IsNullOrEmpty(cnicNumber))
            {
                this.btnCheckIn.Enabled = false;
                this.btnCheckOut.Enabled = false;
                this.tbxBlockedBy.ReadOnly = true;
                this.tbxBlockedReason.ReadOnly = true;
                this.tbxBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxBlockedReason.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.lblVisitorStatus.Text = "Invalid User";
                this.lblVisitorStatus.BackColor = Color.Red;
                this.btnBlock.Enabled = false;
                this.btnUnBlock.Enabled = false;
                return;
            }

            if (Form1.mLoggedInUser.IsAdmin)
            {
                this.btnBlock.Visible = true;
                this.btnUnBlock.Visible = true;
                this.tbxBlockedBy.ReadOnly = false;
                this.tbxBlockedReason.ReadOnly = false;
                this.tbxBlockedBy.BackColor = System.Drawing.Color.White;
                this.tbxBlockedReason.BackColor = System.Drawing.Color.White;
            }
            else
            {
                this.btnBlock.Visible = false;
                this.btnUnBlock.Visible = false;
                this.tbxBlockedBy.ReadOnly = true;
                this.tbxBlockedReason.ReadOnly = true;
                this.tbxBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxBlockedReason.BackColor = System.Drawing.SystemColors.ButtonFace;
            }

            


            

            if (this.mBlocks.Exists(blocked => blocked.Blocked && blocked.CNICNumber == this.mCNICNumber))
            {
                blockedUser = true;
                blockedPerson = this.mBlocks.Find(blocked => blocked.Blocked && blocked.CNICNumber == this.mCNICNumber);

                this.UpdateLayoutForBlockedPerson(blockedPerson);
            }
            else
            {
                this.btnUnBlock.Enabled = false;
                this.tbxBlockedBy.Text = string.Empty;
                this.tbxBlockedReason.Text = string.Empty;
                this.lblVisitorStatus.Text = "Allowed";
                this.lblVisitorStatus.BackColor = Color.Green;

                this.tbxBlockedBy.ReadOnly = false;
                this.tbxBlockedReason.ReadOnly = false;

                this.tbxBlockedBy.BackColor = System.Drawing.Color.White;
                this.tbxBlockedReason.BackColor = System.Drawing.Color.White;

                this.tbxUnBlockedBy.ReadOnly = true;
                this.tbxUnblockReason.ReadOnly = true;

                this.tbxUnBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxUnblockReason.BackColor = System.Drawing.SystemColors.ButtonFace;

                if (this.mBlocks.Count > 0)
                {
                    BlockedPersonInfo lastBlockedInfo = this.mBlocks.Last();

                    this.tbxUnBlockedBy.Text = lastBlockedInfo.UnBlockedBy;
                    this.tbxUnBlockTime.Text = lastBlockedInfo.UnBlockTime.ToString();
                    this.tbxUnblockReason.Text = lastBlockedInfo.UnBlockedReason;
                }
            }

            if (this.mCheckIns.Exists(checkedIn => checkedIn.CheckedIn && checkedIn.CNICNumber == this.mCNICNumber))
            {
                CheckInAndOutInfo checkedInInfo = this.mCheckIns.Find(checkedIn => checkedIn.CheckedIn && checkedIn.CNICNumber == this.mCNICNumber);
                this.btnCheckIn.Enabled = false;
                this.btnCheckOut.Enabled = true && !blockedUser;

                this.tbxCheckInCardNumber.Text = checkedInInfo.CardNumber;
                this.tbxCheckInVehicleNumber.Text = checkedInInfo.VehicleNmuber;
                this.tbxCheckInDateTimeIn.Text = checkedInInfo.DateTimeIn.ToString();
                this.tbxCheckInDateTimeOut.Text = DateTime.Now.ToString();

                this.tbxCheckInCardNumber.ReadOnly = true;
                this.tbxCheckInVehicleNumber.ReadOnly = true;
                this.tbxCheckInCardNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxCheckInVehicleNumber.BackColor = System.Drawing.SystemColors.ButtonFace;

                //if (this.mContractorInfo == "Casual 3P")
                //{
                //    this.cbxCompanyName.Enabled = false;
                //    this.tbxWONumber.ReadOnly = true;
                //    this.tbxWONumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                //}
            }
            else
            {
                if (!blockedUser)
                {
                    LimitStatus limitStatus = EFERTDbUtility.CheckIfUserCheckedInLimitReached(this.mCheckIns, this.mBlocks);

                    if (limitStatus == LimitStatus.LimitReached)
                    {
                        blockedPerson = this.BlockPerson(EFERTDbUtility.CONST_SYSTEM_BLOCKED_BY, EFERTDbUtility.CONST_SYSTEM_LIMIT_REACHED_REASON);

                        if (blockedPerson != null)
                        {
                            this.UpdateLayoutForBlockedPerson(blockedPerson);

                            blockedUser = true;
                        }
                        
                        //this.btnCheckIn.Enabled = false;
                        //this.btnCheckOut.Enabled = false;
                        //this.tbxBlockedBy.Text = "Admin";
                        //this.tbxBlockedReason.Text = "You have reached maximum limit of temporary check in.";
                        //this.lblVisitorStatus.Text = "Blocked";
                        //this.lblVisitorStatus.BackColor = Color.Red;
                        //this.btnBlock.Enabled = false;

                        //this.tbxBlockedBy.ReadOnly = true;
                        //this.tbxBlockedReason.ReadOnly = true;

                        //this.tbxBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                        //this.tbxBlockedReason.BackColor = System.Drawing.SystemColors.ButtonFace;
                    }
                    else
                    {
                        if (limitStatus == LimitStatus.EmailAlerted)
                        {
                            if (Form1.mLoggedInUser.IsAdmin)
                            {
                                this.btnDisableAlerts.Visible = true;
                                this.btnDisableAlerts.Tag = true;
                            }
                        }
                        else if (limitStatus == LimitStatus.EmailAlertDisabled)
                        {
                            if (Form1.mLoggedInUser.IsAdmin)
                            {
                                this.btnDisableAlerts.Visible = true;
                                this.btnDisableAlerts.Text = "Enable Alert";
                                this.btnDisableAlerts.Tag = false;
                            }
                        }

                        this.btnCheckIn.Enabled = true && !blockedUser;
                        this.btnCheckOut.Enabled = false;
                        this.tbxCheckInDateTimeIn.Text = DateTime.Now.ToString();
                    }
                }
                
            }

            if (blockedUser)
            {
                //if (this.mContractorInfo == "Casual 3P")
                //{
                //    this.cbxCompanyName.Enabled = false;
                //    this.tbxWONumber.ReadOnly = true;
                //    this.tbxWONumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                //}
                this.tbxCheckInCardNumber.ReadOnly = true;
                this.tbxCheckInVehicleNumber.ReadOnly = true;
                this.tbxCheckInCardNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxCheckInVehicleNumber.BackColor = System.Drawing.SystemColors.ButtonFace;

                BlockedPersonNotificationForm blockedForm = null;
                if (blockedPerson == null)
                {
                    string firstName = this.mContractorCardHolder == null ? this.mDailyCardHolder.FirstName : this.mContractorCardHolder.FirstName;

                    blockedForm = new BlockedPersonNotificationForm(firstName, this.mCNICNumber);
                }
                else
                {
                    blockedForm = new BlockedPersonNotificationForm(blockedPerson);
                }


                blockedForm.ShowDialog(this);
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            CardHolderInfo cardHolderInfo = this.mCardHolderInfo;

            bool validtated = EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxFirstName, this.tbxCNICNumber, this.tbxBlockedBy, this.tbxBlockedReason });
            if (!validtated)
            {
                MessageBox.Show(this, "Please fill mandatory fields first.");
                return;
            }

            DialogResult result =  MessageBox.Show(this, "Are you sure you want to block this person?", "Confirmation Dialog", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            if (this.tbxBlockedBy.Text == EFERTDbUtility.CONST_SYSTEM_BLOCKED_BY)
            {
                MessageBox.Show(this, "Block by \"System\" can not be used.");
                return;
            }

            if (this.mContractorCardHolder == null && this.mDailyCardHolder == null)
            {
                
                if (this.mIsDailyCardHolder)
                {
                    DailyCardHolder dailyCardHolder = new DailyCardHolder()
                    {
                        FirstName = this.tbxFirstName.Text,
                        LastName = this.tbxLastName.Text,
                        Department = this.cbxDepartment.SelectedItem == null ? string.Empty : this.cbxDepartment.SelectedItem as string,
                        Cadre = this.cbxCadre.SelectedItem == null ? string.Empty : this.cbxCadre.SelectedItem as string,
                        CNICNumber = this.tbxCNICNumber.Text,
                        CompanyName = this.cbxCompanyName.SelectedItem == null ? string.Empty : this.cbxCompanyName.SelectedItem as string,
                        Designation = this.cbxDesignation.SelectedItem == null ? string.Empty : this.cbxDesignation.SelectedItem as string,
                        EmergancyContactNumber = this.tbxContactNumber.Text,
                        WONumber = this.tbxWONumber.Text,
                        ConstractorInfo = this.mContractorInfo,
                        Section = this.cbxSection.SelectedItem == null ? string.Empty : this.cbxSection.SelectedItem as string,
                    };

                    if (this.pbxSnapShot.Image != null)
                    {
                        dailyCardHolder.Picture = EFERTDbUtility.ImageToByteArray(this.pbxSnapShot.Image);
                    }

                    if (this.mClubStaff)
                    {
                        dailyCardHolder.ClubType = this.cbxClubType.SelectedItem == null ? string.Empty : this.cbxClubType.SelectedItem as String;
                    }

                    if (this.mContractorInfo == "Casual 3P")
                    {
                        dailyCardHolder.AreaOfWork = this.tbxAreaOfWork.Text;
                    }                                      

                    EFERTDbUtility.mEFERTDb.DailyCardHolders.Add(dailyCardHolder);
                    //EFERTDbUtility.mEFERTDb.SaveChanges();

                    this.mDailyCardHolder = dailyCardHolder;

                }
                else
                {
                    cardHolderInfo = new CardHolderInfo()
                    {
                        FirstName = this.tbxFirstName.Text,
                        CNICNumber = string.IsNullOrEmpty(this.mCNICNumber) ? null : this.mCNICNumber,
                        IsTemp = true,
                        ConstractorInfo = this.mContractorInfo
                    };

                    if (this.pbxSnapShot.Image != null)
                    {
                        cardHolderInfo.Picture = EFERTDbUtility.ImageToByteArray(this.pbxSnapShot.Image);
                    }

                    EFERTDbUtility.mEFERTDb.CardHolders.Add(cardHolderInfo);
                    //EFERTDbUtility.mEFERTDb.SaveChanges();

                    this.mCardHolderInfo = cardHolderInfo;

                }

            }
            else
            {
                if (this.mContractorInfo == "Casual 3P" || this.mContractorInfo == "Contractor" || this.mContractorInfo == "Pallaydar" || this.mContractorInfo == "WO Staff")
                {
                    if (this.mDailyCardHolder != null)
                    {
                        if (this.mDailyCardHolder.CompanyName != this.cbxCompanyName.SelectedItem || 
                            this.mDailyCardHolder.WONumber == this.tbxWONumber.Text ||
                            this.mDailyCardHolder.FirstName != this.tbxFirstName.Text)
                        {
                            this.mDailyCardHolder.CompanyName = this.cbxCompanyName.SelectedItem == null ? string.Empty : this.cbxCompanyName.SelectedItem as String;
                            this.mDailyCardHolder.WONumber = this.tbxWONumber.Text;
                            this.mDailyCardHolder.FirstName = this.tbxFirstName.Text;

                            EFERTDbUtility.mEFERTDb.Entry(this.mDailyCardHolder).State = System.Data.Entity.EntityState.Modified;
                        }
                    }                    
                }
            }

            BlockedPersonInfo blockedPerson = this.BlockPerson(this.tbxBlockedBy.Text, this.tbxBlockedReason.Text);

            if (blockedPerson != null)
            {
                this.UpdateLayoutForBlockedPerson(blockedPerson);
            }            
        }

        private BlockedPersonInfo BlockPerson(string blockedBy, string blockedReason)
        {
            BlockedPersonInfo blockedPerson = new BlockedPersonInfo()
            {
                Blocked = true,
                BlockedBy = blockedBy,
                BlockedReason = blockedReason,
                CNICNumber = this.mCNICNumber,
                BlockedTime = DateTime.Now,
                UnBlockTime = DateTime.MaxValue
            };

            blockedPerson.BlockedInPlant = SearchForm.mIsPlant;
            blockedPerson.BlockedInColony = !SearchForm.mIsPlant;

            if (this.mIsDailyCardHolder)
            {
                if (this.mDailyCardHolder == null)
                {
                    MessageBox.Show(this, "Unable to Block Person. Some error occured in getting cardholder information.");
                    return null;
                }
                else
                {
                    blockedPerson.DailyCardHolders = this.mDailyCardHolder;
                }
                
            }
            else
            {
                if (this.mCardHolderInfo == null)
                {
                    MessageBox.Show(this, "Unable to Block Person. Some error occured in getting cardholder information.");
                    return null;
                }
                else
                {
                    blockedPerson.CardHolderInfos = this.mCardHolderInfo;
                }
            }

            try
            {
                EFERTDbUtility.mEFERTDb.BlockedPersons.Add(blockedPerson);
                EFERTDbUtility.mEFERTDb.SaveChanges();
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                MessageBox.Show(this, "Some error occurred in blocking cardholder.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                return null;
            }

            if (this.mIsDailyCardHolder)
            {
                this.mBlocks = this.mDailyCardHolder.BlockingInfos;
            }
            else
            {
                this.mBlocks = this.mCardHolderInfo.BlockingInfos;
            }

            return blockedPerson;
        }

        private void UpdateLayoutForBlockedPerson(BlockedPersonInfo blockedPerson)
        {
            if (blockedPerson != null)
            {
                this.btnCheckIn.Enabled = false;
                this.btnCheckOut.Enabled = false;
                this.lblVisitorStatus.Text = "Blocked";
                this.lblVisitorStatus.BackColor = Color.Red;
                this.tbxBlockedBy.Text = blockedPerson.BlockedBy;
                this.tbxBlockedReason.Text = blockedPerson.BlockedReason;
                this.tbxBlockedTime.Text = blockedPerson.BlockedTime.ToString();
                this.btnBlock.Enabled = false;
                this.btnUnBlock.Enabled = true;

                this.tbxBlockedBy.ReadOnly = true;
                this.tbxBlockedReason.ReadOnly = true;

                this.tbxBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxBlockedReason.BackColor = System.Drawing.SystemColors.ButtonFace;

                this.tbxUnBlockedBy.ReadOnly = false;
                this.tbxUnblockReason.ReadOnly = false;

                this.tbxUnBlockedBy.Text = string.Empty;
                this.tbxUnblockReason.Text = string.Empty;

                this.tbxUnBlockedBy.BackColor = System.Drawing.Color.White;
                this.tbxUnblockReason.BackColor = System.Drawing.Color.White;
            }            
        }

        private void btnUnBlock_Click(object sender, EventArgs e)
        {
            bool validtated = EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxFirstName, this.tbxCNICNumber, this.tbxUnBlockedBy, this.tbxUnblockReason });
            if (!validtated)
            {
                MessageBox.Show(this, "Please fill mandatory fields first.");
                return;
            }

            DialogResult result = MessageBox.Show(this, "Are you sure you want to unblock this person?", "Confirmation Dialog", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            if (this.mBlocks.Exists(blocked => blocked.Blocked && blocked.CNICNumber == this.mCNICNumber))
            {
                BlockedPersonInfo blockedPerson = this.mBlocks.Find(blocked => blocked.Blocked && blocked.CNICNumber == this.mCNICNumber);
                blockedPerson.Blocked = false;
                blockedPerson.UnBlockTime = DateTime.Now;
                blockedPerson.UnBlockedBy = this.tbxUnBlockedBy.Text;
                blockedPerson.UnBlockedReason = this.tbxUnblockReason.Text;

                if (this.mContractorInfo == "Casual 3P" || this.mContractorInfo == "Contractor" || this.mContractorInfo == "Pallaydar" || this.mContractorInfo == "WO Staff")
                {
                    if (this.mDailyCardHolder != null)
                    {
                        if (this.mDailyCardHolder.CompanyName != this.cbxCompanyName.SelectedItem ||
                            this.mDailyCardHolder.WONumber == this.tbxWONumber.Text || 
                            this.mDailyCardHolder.FirstName != this.tbxFirstName.Text)
                        {
                            this.mDailyCardHolder.CompanyName = this.cbxCompanyName.SelectedItem == null ? string.Empty : this.cbxCompanyName.SelectedItem as String;
                            this.mDailyCardHolder.WONumber = this.tbxWONumber.Text;
                            this.mDailyCardHolder.FirstName = this.tbxFirstName.Text;

                            EFERTDbUtility.mEFERTDb.Entry(this.mDailyCardHolder).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                }
                EFERTDbUtility.mEFERTDb.Entry(blockedPerson).State = System.Data.Entity.EntityState.Modified;
                PerformActionAfterUnBlock(blockedPerson.UnBlockTime.ToString());

            }
            else
            {
                MessageBox.Show(this, "This user is not blocked.");
            }
        }

        private void PerformActionAfterUnBlock(string unBlockTime)
        {
            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                MessageBox.Show(this, "Some error occurred in unblocking cardholder.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                return;
            }

            if (this.mIsDailyCardHolder)
            {
                this.mBlocks = this.mDailyCardHolder.BlockingInfos;
            }
            else
            {
                this.mBlocks = this.mCardHolderInfo.BlockingInfos;
            }

            if (this.mCheckIns.Exists(checkedIn => checkedIn.CheckedIn && checkedIn.CNICNumber == this.mCNICNumber))
            {
                this.btnCheckIn.Enabled = false;
                this.btnCheckOut.Enabled = true;
            }
            else
            {
                this.btnCheckIn.Enabled = true;
                this.btnCheckOut.Enabled = false;
            }

            this.tbxBlockedBy.Text = string.Empty;
            this.tbxBlockedReason.Text = string.Empty;
            this.lblVisitorStatus.Text = "Allowed";
            this.lblVisitorStatus.BackColor = Color.Green;
            this.tbxUnBlockTime.Text = unBlockTime;
            this.btnBlock.Enabled = true;
            this.btnUnBlock.Enabled = false;

            this.tbxBlockedBy.ReadOnly = false;
            this.tbxBlockedReason.ReadOnly = false;

            this.tbxBlockedBy.BackColor = System.Drawing.Color.White;
            this.tbxBlockedReason.BackColor = System.Drawing.Color.White;

            this.tbxUnBlockedBy.ReadOnly = true;
            this.tbxUnblockReason.ReadOnly = true;

            this.tbxUnBlockedBy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxUnblockReason.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string cardNumber = this.tbxCheckInCardNumber.Text;

            bool validtated = EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxFirstName, this.tbxCNICNumber, this.tbxCheckInCardNumber });
            if (!validtated)
            {
                MessageBox.Show(this, "Please fill mandatory fields first.");
                return;
            }

            bool isCardNotReturned = this.mCheckIns.Any(checkInInfo => checkInInfo.CheckedIn && checkInInfo.CardNumber == cardNumber);
            CCFTCentralDb.CCFTCentral ccftCentralDb = new CCFTCentralDb.CCFTCentral();

            bool cardExist = ccftCentralDb.Cardholders.Any(card => card.LastName == cardNumber);

            CardHolderInfo cardHolderInfo = this.mCardHolderInfo;

            if (cardExist && !isCardNotReturned)
            {
                var cardAlreadyIssued = (from checkin in EFERTDbUtility.mEFERTDb.CheckedInInfos
                                         where checkin != null && checkin.CheckedIn && checkin.CardNumber == cardNumber
                                         select new
                                         {
                                             checkin.CheckedIn,
                                             checkin.CNICNumber
                                         }).FirstOrDefault();

                if (cardAlreadyIssued != null && cardAlreadyIssued.CheckedIn)
                {
                    MessageBox.Show(this, "This card is already issue to the person with CNIC number: " + cardAlreadyIssued.CNICNumber);
                    return;
                }
                if (this.mContractorCardHolder == null && this.mDailyCardHolder == null)
                {
                    

                    if (this.mIsDailyCardHolder)
                    {
                        DailyCardHolder dailyCardHolder = new DailyCardHolder()
                        {
                            FirstName = this.tbxFirstName.Text,
                            LastName = this.tbxLastName.Text,
                            Department = this.cbxDepartment.SelectedItem == null ? string.Empty : this.cbxDepartment.SelectedItem as string,
                            Cadre = this.cbxCadre.SelectedItem == null ? string.Empty : this.cbxCadre.SelectedItem as string,
                            CNICNumber = this.tbxCNICNumber.Text,
                            CompanyName = this.cbxCompanyName.SelectedItem == null ? string.Empty : this.cbxCompanyName.SelectedItem as string,
                            Designation = this.cbxDesignation.SelectedItem == null ? string.Empty : this.cbxDesignation.SelectedItem as string,
                            EmergancyContactNumber = this.tbxContactNumber.Text,
                            WONumber = this.tbxWONumber.Text,
                            ConstractorInfo = this.mContractorInfo,
                            Section = this.cbxSection.SelectedItem == null ? string.Empty : this.cbxSection.SelectedItem as string,
                        };

                        if (this.pbxSnapShot.Image != null)
                        {
                            dailyCardHolder.Picture = EFERTDbUtility.ImageToByteArray(this.pbxSnapShot.Image);
                        }

                        if (this.mClubStaff)
                        {
                            dailyCardHolder.ClubType = this.cbxClubType.SelectedItem == null ? string.Empty : this.cbxClubType.SelectedItem as String;
                        }

                        if (this.mContractorInfo == "Casual 3P")
                        {
                            dailyCardHolder.AreaOfWork = this.tbxAreaOfWork.Text;
                        }

                        EFERTDbUtility.mEFERTDb.DailyCardHolders.Add(dailyCardHolder);
                        //EFERTDbUtility.mEFERTDb.SaveChanges();

                        this.mDailyCardHolder = dailyCardHolder;

                    }
                    else
                    {
                        cardHolderInfo = new CardHolderInfo()
                        {
                            FirstName = this.tbxFirstName.Text,
                            CNICNumber = string.IsNullOrEmpty(this.mCNICNumber) ? null : this.mCNICNumber,
                            IsTemp = true,
                            ConstractorInfo = this.mContractorInfo
                        };

                        if (this.pbxSnapShot.Image != null)
                        {
                            cardHolderInfo.Picture = EFERTDbUtility.ImageToByteArray(this.pbxSnapShot.Image);
                        }

                        EFERTDbUtility.mEFERTDb.CardHolders.Add(cardHolderInfo);
                        //EFERTDbUtility.mEFERTDb.SaveChanges();

                        this.mCardHolderInfo = cardHolderInfo;
                        
                    }

                }
                else
                {
                    if (this.mContractorInfo == "Casual 3P" || this.mContractorInfo == "Contractor" || this.mContractorInfo == "Pallaydar" || this.mContractorInfo == "WO Staff")
                    {
                        if (this.mDailyCardHolder != null)
                        {
                            if (this.mDailyCardHolder.CompanyName != this.cbxCompanyName.SelectedItem ||
                                this.mDailyCardHolder.WONumber == this.tbxWONumber.Text ||
                                this.mDailyCardHolder.FirstName != this.tbxFirstName.Text)
                            {
                                this.mDailyCardHolder.CompanyName = this.cbxCompanyName.SelectedItem == null ? string.Empty : this.cbxCompanyName.SelectedItem as String;
                                this.mDailyCardHolder.WONumber = this.tbxWONumber.Text;
                                this.mDailyCardHolder.FirstName = this.tbxFirstName.Text;

                                EFERTDbUtility.mEFERTDb.Entry(this.mDailyCardHolder).State = System.Data.Entity.EntityState.Modified;
                            }
                        }
                    }
                }

                CheckInAndOutInfo checkedInInfo = new CheckInAndOutInfo();

                if (this.mIsDailyCardHolder)
                {
                    checkedInInfo.DailyCardHolders = this.mDailyCardHolder;
                    checkedInInfo.FirstName = this.mDailyCardHolder.FirstName;
                }
                else
                {
                    if (cardHolderInfo == null)
                    {
                        MessageBox.Show(this, "Unable to Issue Card. Some error occured in getting cardholder information.");
                        return;
                    }
                    else
                    {
                        checkedInInfo.CardHolderInfos = cardHolderInfo;
                        checkedInInfo.FirstName = cardHolderInfo.FirstName;
                    }
                }


                checkedInInfo.CheckInToPlant = SearchForm.mIsPlant;
                checkedInInfo.CheckInToPlant = !SearchForm.mIsPlant;

                checkedInInfo.CNICNumber = this.mCNICNumber;
                checkedInInfo.CardNumber = this.tbxCheckInCardNumber.Text;
                checkedInInfo.VehicleNmuber = this.tbxCheckInVehicleNumber.Text;
                checkedInInfo.DateTimeIn = Convert.ToDateTime(this.tbxCheckInDateTimeIn.Text);
                checkedInInfo.DateTimeOut = DateTime.MaxValue;
                checkedInInfo.CheckedIn = true;

                try
                {
                    EFERTDbUtility.mEFERTDb.CheckedInInfos.Add(checkedInInfo);
                    EFERTDbUtility.mEFERTDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    EFERTDbUtility.RollBack();

                    MessageBox.Show(this, "Some error occurred in issuing card.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                    return;
                }

                this.btnCheckIn.Enabled = false;
                this.btnCheckOut.Enabled = true;
                


                if (NewColonyChForm.mNewColonyChForm != null)
                {
                    NewColonyChForm.mNewColonyChForm.Close();
                }

                if (NewPlantChForm.mNewPlantChForm != null)
                {
                    NewPlantChForm.mNewPlantChForm.Close();
                }

                this.Close();
            }
            else
            {
                if (!cardExist)
                {
                    MessageBox.Show(this, "Please enter valid card number.");
                }
                else if (isCardNotReturned)
                {
                    MessageBox.Show(this, "Card is already issued to some one else.");
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (this.mCheckIns.Exists(checkedOut => checkedOut.CheckedIn && checkedOut.CNICNumber == this.mCNICNumber))
            {
                CheckInAndOutInfo checkedOutInfo = this.mCheckIns.Find(checkedOut => checkedOut.CheckedIn && checkedOut.CNICNumber == this.mCNICNumber);
                checkedOutInfo.CheckedIn = false;
                checkedOutInfo.DateTimeOut = Convert.ToDateTime(this.tbxCheckInDateTimeOut.Text);

                if (this.mContractorInfo == "Casual 3P" || this.mContractorInfo == "Contractor" || this.mContractorInfo == "Pallaydar" || this.mContractorInfo == "WO Staff")
                {
                    if (this.mDailyCardHolder != null)
                    {
                        if (this.mDailyCardHolder.CompanyName != this.cbxCompanyName.SelectedItem || 
                            this.mDailyCardHolder.WONumber == this.tbxWONumber.Text ||
                            this.mDailyCardHolder.FirstName != this.tbxFirstName.Text)
                        {
                            this.mDailyCardHolder.CompanyName = this.cbxCompanyName.SelectedItem == null ? string.Empty : this.cbxCompanyName.SelectedItem as String;
                            this.mDailyCardHolder.WONumber = this.tbxWONumber.Text;
                            this.mDailyCardHolder.FirstName = this.tbxFirstName.Text;

                            EFERTDbUtility.mEFERTDb.Entry(this.mDailyCardHolder).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                }

                try
                {
                    EFERTDbUtility.mEFERTDb.Entry(checkedOutInfo).State = System.Data.Entity.EntityState.Modified;
                    EFERTDbUtility.mEFERTDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    EFERTDbUtility.RollBack();

                    MessageBox.Show(this, "Some error occurred in returning card.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                    return;
                }


                this.btnCheckIn.Enabled = true;
                this.btnCheckOut.Enabled = false;

                if (NewColonyChForm.mNewColonyChForm != null)
                {
                    NewColonyChForm.mNewColonyChForm.Close();
                }

                if (NewPlantChForm.mNewPlantChForm != null)
                {
                    NewPlantChForm.mNewPlantChForm.Close();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "This user is not checked in.");
            }
        }

        private void btnWebCam_Click(object sender, EventArgs e)
        {
            PictureForm picForm = new PictureForm(ref pbxSnapShot);
            picForm.ShowDialog(this);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = this.openFileDialog1.FileName;

            Bitmap image = new Bitmap(filePath);

            this.pbxSnapShot.Image = image;
        }

        private void tbxCheckInCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            EFERTDbUtility.AllowNumericOnly(e); 
        }

        private void tbxCheckInCardNumber_TextChanged(object sender, EventArgs e)
        {
            EFERTDbUtility.ValidateInputs(new List<TextBox> { this.tbxCheckInCardNumber });
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            EFERTDbUtility.ValidateInputs(new List<TextBox> { this.tbxFirstName });
        }

        private void btnDisableAlerts_Click(object sender, EventArgs e)
        {
            bool disableAlert = Convert.ToBoolean(this.btnDisableAlerts.Tag);

            AlertInfo alertInfo = (from alert in EFERTDbUtility.mEFERTDb.AlertInfos
                                   where alert != null && alert.CNICNumber == this.mCNICNumber
                                   select alert).FirstOrDefault();

            if (alertInfo == null)
            {
                alertInfo = new AlertInfo();
                alertInfo.CNICNumber = this.mCNICNumber;

                if (disableAlert)
                {
                    alertInfo.DisableAlert = true;                    
                    alertInfo.DisableAlertDate = DateTime.Now;
                }
                else
                {
                    alertInfo.DisableAlert = false;
                    alertInfo.EnableAlertDate = DateTime.Now;
                }

                EFERTDbUtility.mEFERTDb.AlertInfos.Add(alertInfo);
            }
            else
            {
                if (disableAlert)
                {
                    alertInfo.DisableAlert = true;
                    alertInfo.DisableAlertDate = DateTime.Now;
                }
                else
                {
                    alertInfo.DisableAlert = false;
                    alertInfo.EnableAlertDate = DateTime.Now;
                }

                EFERTDbUtility.mEFERTDb.Entry(alertInfo).State = System.Data.Entity.EntityState.Modified;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.SaveChanges();
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                MessageBox.Show(this, "Some error occurred.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                return;
            }


        }
    }
}
