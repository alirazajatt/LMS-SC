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
    public partial class VisitorForm : Form
    {
        public string mCNICNumber = string.Empty;
        public VisitorCardHolder mVisitor = null;
        public List<CheckInAndOutInfo> mCheckIns = new List<CheckInAndOutInfo>();
        public List<BlockedPersonInfo> mBlocks = new List<BlockedPersonInfo>();
        public bool mVisitorExist = true;
        public bool mSchoolingStaff = false;
        public string mVisitorInfo = string.Empty;

        public VisitorForm(VisitorCardHolder visitorCardHolder)
        {
            InitializeComponent();
            
            this.cbxAreaOfVisit.Items.AddRange(EFERTDbUtility.mVisitingLocations.FindAll(location => location.IsOnPlant == SearchForm.mIsPlant).Select(l => l.Location).ToArray());


            if (visitorCardHolder != null)
            {
                this.mVisitor = visitorCardHolder;
                this.mVisitorInfo = this.mVisitor.VisitorInfo;
                this.mCNICNumber = this.mVisitor.CNICNumber;

                this.tbxCnicNumber.Text = this.mVisitor.CNICNumber;
                this.cbxGender.SelectedItem = this.mVisitor.Gender;
                this.tbxFirstName.Text = this.mVisitor.FirstName;
                this.tbxLastName.Text = this.mVisitor.LastName;
                this.tbxAddress.Text = this.mVisitor.Address;
                this.tbxPostCode.Text = this.mVisitor.PostCode;
                this.tbxCity.Text = this.mVisitor.City;
                this.tbxState.Text = this.mVisitor.State;
                this.tbxCompanyName.Text = this.mVisitor.CompanyName;
                this.tbxPhoneNumber.Text = this.mVisitor.ContactNo;
                this.tbxEmergencyContact.Text = this.mVisitor.EmergencyContantPerson;
                this.tbxEmergencyContactNumber.Text = this.mVisitor.EmergencyContantPersonNumber;
                this.cbxVisitorType.SelectedItem = this.mVisitor.VisitorType;

                this.lblSchoolCollege.Visible = false;
                this.cbxSchoolCollege.Visible = false;

                if (this.mVisitor.VisitorInfo == "Education")
                {
                    this.cbxSchoolCollege.SelectedItem = this.mVisitor.SchoolName;
                    this.cbxSchoolCollege.Enabled = false;
                    this.lblSchoolCollege.Visible = true;
                    this.cbxSchoolCollege.Visible = true;

                    this.Text = "Education Staff Form";
                    this.groupBox1.Text = "Education Staff Details";
                    this.mSchoolingStaff = true;

                }
                else if (this.mVisitor.VisitorInfo == "House Servant")
                {
                    this.Text = "House Servant Form";
                    this.groupBox1.Text = "House Servant Details";
                }

                this.mCheckIns = this.mVisitor.CheckInInfos ?? new List<CheckInAndOutInfo>();
                this.mBlocks = this.mVisitor.BlockingInfos ?? new List<BlockedPersonInfo>();
                this.pbxSnapShot.Image = EFERTDbUtility.ByteArrayToImage(this.mVisitor.Picture);
                
                this.btnWebCam.Enabled = false;
                this.btnBrowse.Enabled = false;
                this.tbxCnicNumber.ReadOnly = true;
                this.cbxVisitorType.Enabled = false;
                this.cbxGender.Enabled = false;
                this.tbxFirstName.ReadOnly = true;
                this.tbxLastName.ReadOnly = true;
                this.tbxAddress.ReadOnly = true;
                this.tbxPostCode.ReadOnly = true;
                this.tbxCity.ReadOnly = true;
                this.tbxState.ReadOnly = true;
                this.tbxCompanyName.ReadOnly = true;
                this.tbxPhoneNumber.ReadOnly = true;
                this.tbxEmergencyContact.ReadOnly = true;
                this.tbxEmergencyContactNumber.ReadOnly = true;

                this.tbxCnicNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxLastName.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxPostCode.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxCity.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxState.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxCompanyName.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxPhoneNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxEmergencyContact.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxEmergencyContactNumber.BackColor = System.Drawing.SystemColors.ButtonFace;

                this.btnWebCam.Enabled = false;
                this.btnBrowse.Enabled = false;
            }
            
            this.UpdateStatus(this.mCNICNumber);

        }


        public VisitorForm(string cnicNumber,string vistorInfo, string title = null, string gpTitle = null, bool schoolStaff = false)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(title))
            {
                this.Text = title;
            }

            if (!string.IsNullOrEmpty(gpTitle))
            {
                this.groupBox1.Text = gpTitle;
            }

            this.mSchoolingStaff = schoolStaff;
            this.mVisitorInfo = vistorInfo;

            if (schoolStaff)
            {
                this.lblSchoolCollege.Visible = true;
                this.cbxSchoolCollege.Visible = true;
            }
            else
            {
                this.lblSchoolCollege.Visible = false;
                this.cbxSchoolCollege.Visible = false;
            }

            this.cbxAreaOfVisit.Items.AddRange(EFERTDbUtility.mVisitingLocations.FindAll(location => location.IsOnPlant == SearchForm.mIsPlant).Select(l=>l.Location).ToArray());

            this.tbxFirstName.BackColor = Color.Yellow;
            this.tbxCheckInCardNumber.BackColor = Color.Yellow;

            this.tbxCnicNumber.Text = cnicNumber;
            this.UpdateStatus(cnicNumber);
            
        }

        private void UpdateStatus(string cnicNumber)
        {
            bool blockedUser = false;
            BlockedPersonInfo blockedPerson = null;

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

            this.mCNICNumber = cnicNumber;                      

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
                this.nuNoOfMaleGuest.Value = checkedInInfo.NoOfMaleGuest;
                this.nuNoOfFemaleGuest.Value = checkedInInfo.NoOfFemaleGuest;
                this.numCheckInDurationOfStay.Value = checkedInInfo.DurationOfStay;
                this.nuCheckInNoOfChildren.Value = checkedInInfo.NoOfChildren;
                this.cbxAreaOfVisit.SelectedItem = checkedInInfo.AreaOfVisit;
                this.tbxCheckInHostName.Text = checkedInInfo.HostName;
                this.tbxCheckInDateTimeIn.Text = checkedInInfo.DateTimeIn.ToString();
                this.tbxCheckInDateTimeOut.Text = DateTime.Now.ToString();

                this.tbxCheckInCardNumber.ReadOnly = true;
                this.tbxCheckInVehicleNumber.ReadOnly = true;
                this.nuNoOfMaleGuest.ReadOnly = true;
                this.nuNoOfFemaleGuest.ReadOnly = true;
                this.numCheckInDurationOfStay.ReadOnly = true;
                this.nuCheckInNoOfChildren.ReadOnly = true;
                this.cbxAreaOfVisit.Enabled = false;
                this.tbxCheckInHostName.ReadOnly = true;

                this.tbxCheckInCardNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxCheckInVehicleNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.nuNoOfMaleGuest.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.nuNoOfFemaleGuest.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.numCheckInDurationOfStay.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.nuCheckInNoOfChildren.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxCheckInHostName.BackColor = System.Drawing.SystemColors.ButtonFace;
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
                this.tbxCheckInCardNumber.ReadOnly = true;
                this.tbxCheckInVehicleNumber.ReadOnly = true;
                this.tbxCheckInCardNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.tbxCheckInVehicleNumber.BackColor = System.Drawing.SystemColors.ButtonFace;

                BlockedPersonNotificationForm blockedForm = null;
                if (blockedPerson == null)
                {
                    blockedForm = new BlockedPersonNotificationForm(this.mVisitor.FirstName, this.mCNICNumber);
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
            bool validtated = EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxFirstName, this.tbxCnicNumber, this.tbxBlockedBy, this.tbxBlockedReason });
            if (!validtated)
            {
                MessageBox.Show(this, "Please fill mandatory fields first.");
                return;
            }

            DialogResult result = MessageBox.Show(this, "Are you sure you want to block this person?", "Confirmation Dialog", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            if (this.tbxBlockedBy.Text == EFERTDbUtility.CONST_SYSTEM_BLOCKED_BY)
            {
                MessageBox.Show(this, "Block by \"System\" can not be used.");
                return;
            }

            if (this.mVisitor == null)
            {
                VisitorCardHolder visitor = new VisitorCardHolder();

                visitor.CNICNumber = this.tbxCnicNumber.Text;
                visitor.Gender = this.cbxGender.SelectedItem == null ? string.Empty : this.cbxGender.SelectedItem as String;
                visitor.FirstName = this.tbxFirstName.Text;
                visitor.LastName = this.tbxLastName.Text;
                visitor.Address = this.tbxAddress.Text;
                visitor.PostCode = this.tbxPostCode.Text;
                visitor.City = this.tbxCity.Text;
                visitor.State = this.tbxState.Text;
                visitor.CompanyName = this.tbxCompanyName.Text;
                visitor.ContactNo = this.tbxPhoneNumber.Text;
                visitor.EmergencyContantPerson = this.tbxEmergencyContact.Text;
                visitor.EmergencyContantPersonNumber = this.tbxEmergencyContactNumber.Text;
                visitor.VisitorType = this.cbxVisitorType.SelectedItem == null ? string.Empty : this.cbxVisitorType.SelectedItem as String;
                visitor.IsOnPlant = SearchForm.mIsPlant;

                if (this.mSchoolingStaff)
                {
                    visitor.SchoolName = this.cbxSchoolCollege.SelectedItem == null ? string.Empty : this.cbxSchoolCollege.SelectedItem as String;
                }

                visitor.VisitorInfo = this.mVisitorInfo;

                if (this.pbxSnapShot.Image != null)
                {
                    visitor.Picture = EFERTDbUtility.ImageToByteArray(this.pbxSnapShot.Image);
                }

                EFERTDbUtility.mEFERTDb.Visitors.Add(visitor);

                //EFERTDbUtility.mEFERTDb.SaveChanges();

                this.mVisitor = visitor;
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

            if (this.mVisitor == null)
            {
                MessageBox.Show(this, "Unable to Block visitor. Some error occured in getting visitor information.");
                return null;
            }
            else
            {
                blockedPerson.Visitors = this.mVisitor;
            }

            try
            {
                EFERTDbUtility.mEFERTDb.BlockedPersons.Add(blockedPerson);
                EFERTDbUtility.mEFERTDb.SaveChanges();
            }
            catch (Exception ex)
            {
                EFERTDbUtility.RollBack();

                MessageBox.Show(this, "Some error occurred in blocking visitor.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                return null;
            }

            this.mBlocks = this.mVisitor.BlockingInfos;

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
            bool validtated = EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxFirstName, this.tbxCnicNumber, this.tbxUnBlockedBy, this.tbxUnblockReason });
            if (!validtated)
            {
                MessageBox.Show(this, "Please fill mandatory fields first.");
                return;
            }

            DialogResult result = MessageBox.Show(this, "Are you sure you want to block this person?", "Confirmation Dialog", MessageBoxButtons.YesNo);

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

                try
                {
                    EFERTDbUtility.mEFERTDb.Entry(blockedPerson).State = System.Data.Entity.EntityState.Modified;
                    EFERTDbUtility.mEFERTDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    EFERTDbUtility.RollBack();

                    MessageBox.Show(this, "Some error occurred in unblocking cardholder.\n\n" + EFERTDbUtility.GetInnerExceptionMessage(ex));
                    return;
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

                this.mBlocks = this.mVisitor.BlockingInfos;
                this.tbxBlockedBy.Text = string.Empty;
                this.tbxBlockedReason.Text = string.Empty;
                this.lblVisitorStatus.Text = "Allowed";
                this.lblVisitorStatus.BackColor = Color.Green;
                this.tbxUnBlockTime.Text = blockedPerson.UnBlockTime.ToString();
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
            else
            {
                MessageBox.Show(this, "This user is not blocked.");
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string cardNumber = this.tbxCheckInCardNumber.Text;

            bool validtated = EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxFirstName, this.tbxCnicNumber, this.tbxCheckInCardNumber });
            if (!validtated)
            {
                MessageBox.Show(this, "Please fill mandatory fields first.");
                return;
            }

            bool isCardNotReturned = this.mCheckIns.Any(checkInInfo => checkInInfo.CheckedIn && checkInInfo.CardNumber == cardNumber);

            CCFTCentralDb.CCFTCentral ccftCentralDb = new CCFTCentralDb.CCFTCentral();
            bool cardExist = ccftCentralDb.Cardholders.Any(card => card.LastName == cardNumber);

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
                if (this.mVisitor == null)
                {
                    VisitorCardHolder visitor = new VisitorCardHolder();

                    visitor.CNICNumber = this.tbxCnicNumber.Text;
                    visitor.Gender = this.cbxGender.SelectedItem == null ? string.Empty : this.cbxGender.SelectedItem as String;
                    visitor.FirstName = this.tbxFirstName.Text;
                    visitor.LastName = this.tbxLastName.Text;
                    visitor.Address = this.tbxAddress.Text;
                    visitor.PostCode = this.tbxPostCode.Text;
                    visitor.City = this.tbxCity.Text;
                    visitor.State = this.tbxState.Text;
                    visitor.CompanyName = this.tbxCompanyName.Text;
                    visitor.ContactNo = this.tbxPhoneNumber.Text;
                    visitor.EmergencyContantPerson = this.tbxEmergencyContact.Text;
                    visitor.EmergencyContantPersonNumber = this.tbxEmergencyContactNumber.Text;
                    visitor.VisitorType = this.cbxVisitorType.SelectedItem == null ? string.Empty : this.cbxVisitorType.SelectedItem as String;
                    visitor.IsOnPlant = SearchForm.mIsPlant;

                    if (this.pbxSnapShot.Image != null)
                    {
                        visitor.Picture = EFERTDbUtility.ImageToByteArray(this.pbxSnapShot.Image);
                    }

                    if (this.mSchoolingStaff)
                    {
                        visitor.SchoolName = this.cbxSchoolCollege.SelectedItem == null ? string.Empty : this.cbxSchoolCollege.SelectedItem as String;
                    }

                    visitor.VisitorInfo = this.mVisitorInfo;

                    EFERTDbUtility.mEFERTDb.Visitors.Add(visitor);

                    //EFERTDbUtility.mEFERTDb.SaveChanges();

                    this.mVisitor = visitor;
                }

                CheckInAndOutInfo checkedInInfo = new CheckInAndOutInfo();

                checkedInInfo.CheckInToPlant = SearchForm.mIsPlant;
                checkedInInfo.CheckInToPlant = !SearchForm.mIsPlant;
                checkedInInfo.FirstName = this.mVisitor.FirstName;
                checkedInInfo.Visitors = this.mVisitor;
                checkedInInfo.CNICNumber = this.mCNICNumber;
                checkedInInfo.CardNumber = this.tbxCheckInCardNumber.Text;
                checkedInInfo.VehicleNmuber = this.tbxCheckInVehicleNumber.Text;
                checkedInInfo.NoOfMaleGuest = this.nuNoOfMaleGuest.Value;
                checkedInInfo.NoOfFemaleGuest = this.nuNoOfFemaleGuest.Value;
                checkedInInfo.DurationOfStay = this.numCheckInDurationOfStay.Value;
                checkedInInfo.NoOfChildren = this.nuCheckInNoOfChildren.Value;
                checkedInInfo.AreaOfVisit = this.cbxAreaOfVisit.SelectedItem == null ? string.Empty : this.cbxAreaOfVisit.SelectedItem as String;
                checkedInInfo.HostName = this.tbxCheckInHostName.Text;
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

        public void SetCardNumber(string cardNumber)
        {
            this.tbxCheckInCardNumber.Text = cardNumber;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (this.mCheckIns.Exists(checkedOut => checkedOut.CheckedIn && checkedOut.CNICNumber == this.mCNICNumber))
            {
                CheckInAndOutInfo checkedOutInfo = this.mCheckIns.Find(checkedOut => checkedOut.CheckedIn && checkedOut.CNICNumber == this.mCNICNumber);
                checkedOutInfo.CheckedIn = false;
                checkedOutInfo.DateTimeOut = Convert.ToDateTime(this.tbxCheckInDateTimeOut.Text);

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

        private void button2_Click(object sender, EventArgs e)
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

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            EFERTDbUtility.ValidateInputs(new List<TextBox>() { this.tbxCheckInCardNumber, this.tbxFirstName });
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
