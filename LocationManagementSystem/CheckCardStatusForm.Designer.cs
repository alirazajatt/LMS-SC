namespace LocationManagementSystem
{
    partial class CheckCardStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbxCompanyName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.checkInAndOutInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCheckInStatus = new System.Windows.Forms.DataGridView();
            this.checkInInfoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNICNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNmuberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfMaleGuestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfFemaleGuestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationOfStayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfChildrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaOfVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedInDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkInToPlantDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkInToColonyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cardHolderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardHolderInfosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyCardHolderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyCardHoldersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.checkInAndOutInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCompanyName
            // 
            this.cbxCompanyName.BackColor = System.Drawing.Color.White;
            this.cbxCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCompanyName.FormattingEnabled = true;
            this.cbxCompanyName.Location = new System.Drawing.Point(135, 12);
            this.cbxCompanyName.Name = "cbxCompanyName";
            this.cbxCompanyName.Size = new System.Drawing.Size(271, 29);
            this.cbxCompanyName.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 72;
            this.label3.Text = "Company Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(135, 47);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(271, 29);
            this.dtpFromDate.TabIndex = 75;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(135, 82);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(271, 29);
            this.dtpToDate.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "To Date";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(509, 64);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(106, 47);
            this.btnCheckIn.TabIndex = 78;
            this.btnCheckIn.Text = "Check Status";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // checkInAndOutInfoBindingSource1
            // 
            this.checkInAndOutInfoBindingSource1.DataSource = typeof(LocationManagementSystem.CheckInAndOutInfo);
            // 
            // dgvCheckInStatus
            // 
            this.dgvCheckInStatus.AllowUserToAddRows = false;
            this.dgvCheckInStatus.AllowUserToDeleteRows = false;
            this.dgvCheckInStatus.AutoGenerateColumns = false;
            this.dgvCheckInStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckInStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkInInfoIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.cNICNumberDataGridViewTextBoxColumn,
            this.cardNumberDataGridViewTextBoxColumn,
            this.vehicleNmuberDataGridViewTextBoxColumn,
            this.noOfMaleGuestDataGridViewTextBoxColumn,
            this.noOfFemaleGuestDataGridViewTextBoxColumn,
            this.durationOfStayDataGridViewTextBoxColumn,
            this.noOfChildrenDataGridViewTextBoxColumn,
            this.areaOfVisitDataGridViewTextBoxColumn,
            this.hostNameDataGridViewTextBoxColumn,
            this.dateTimeInDataGridViewTextBoxColumn,
            this.dateTimeOutDataGridViewTextBoxColumn,
            this.checkedInDataGridViewCheckBoxColumn,
            this.checkInToPlantDataGridViewCheckBoxColumn,
            this.checkInToColonyDataGridViewCheckBoxColumn,
            this.cardHolderIdDataGridViewTextBoxColumn,
            this.cardHolderInfosDataGridViewTextBoxColumn,
            this.visitorIdDataGridViewTextBoxColumn,
            this.visitorsDataGridViewTextBoxColumn,
            this.dailyCardHolderIdDataGridViewTextBoxColumn,
            this.dailyCardHoldersDataGridViewTextBoxColumn});
            this.dgvCheckInStatus.DataSource = this.checkInAndOutInfoBindingSource1;
            this.dgvCheckInStatus.Location = new System.Drawing.Point(12, 117);
            this.dgvCheckInStatus.Name = "dgvCheckInStatus";
            this.dgvCheckInStatus.ReadOnly = true;
            this.dgvCheckInStatus.Size = new System.Drawing.Size(603, 393);
            this.dgvCheckInStatus.TabIndex = 79;
            // 
            // checkInInfoIdDataGridViewTextBoxColumn
            // 
            this.checkInInfoIdDataGridViewTextBoxColumn.DataPropertyName = "CheckInInfoId";
            this.checkInInfoIdDataGridViewTextBoxColumn.HeaderText = "CheckInInfoId";
            this.checkInInfoIdDataGridViewTextBoxColumn.Name = "checkInInfoIdDataGridViewTextBoxColumn";
            this.checkInInfoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkInInfoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // cNICNumberDataGridViewTextBoxColumn
            // 
            this.cNICNumberDataGridViewTextBoxColumn.DataPropertyName = "CNICNumber";
            this.cNICNumberDataGridViewTextBoxColumn.HeaderText = "CNICNumber";
            this.cNICNumberDataGridViewTextBoxColumn.Name = "cNICNumberDataGridViewTextBoxColumn";
            this.cNICNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNICNumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            this.cardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleNmuberDataGridViewTextBoxColumn
            // 
            this.vehicleNmuberDataGridViewTextBoxColumn.DataPropertyName = "VehicleNmuber";
            this.vehicleNmuberDataGridViewTextBoxColumn.HeaderText = "VehicleNmuber";
            this.vehicleNmuberDataGridViewTextBoxColumn.Name = "vehicleNmuberDataGridViewTextBoxColumn";
            this.vehicleNmuberDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleNmuberDataGridViewTextBoxColumn.Visible = false;
            // 
            // noOfMaleGuestDataGridViewTextBoxColumn
            // 
            this.noOfMaleGuestDataGridViewTextBoxColumn.DataPropertyName = "NoOfMaleGuest";
            this.noOfMaleGuestDataGridViewTextBoxColumn.HeaderText = "NoOfMaleGuest";
            this.noOfMaleGuestDataGridViewTextBoxColumn.Name = "noOfMaleGuestDataGridViewTextBoxColumn";
            this.noOfMaleGuestDataGridViewTextBoxColumn.ReadOnly = true;
            this.noOfMaleGuestDataGridViewTextBoxColumn.Visible = false;
            // 
            // noOfFemaleGuestDataGridViewTextBoxColumn
            // 
            this.noOfFemaleGuestDataGridViewTextBoxColumn.DataPropertyName = "NoOfFemaleGuest";
            this.noOfFemaleGuestDataGridViewTextBoxColumn.HeaderText = "NoOfFemaleGuest";
            this.noOfFemaleGuestDataGridViewTextBoxColumn.Name = "noOfFemaleGuestDataGridViewTextBoxColumn";
            this.noOfFemaleGuestDataGridViewTextBoxColumn.ReadOnly = true;
            this.noOfFemaleGuestDataGridViewTextBoxColumn.Visible = false;
            // 
            // durationOfStayDataGridViewTextBoxColumn
            // 
            this.durationOfStayDataGridViewTextBoxColumn.DataPropertyName = "DurationOfStay";
            this.durationOfStayDataGridViewTextBoxColumn.HeaderText = "DurationOfStay";
            this.durationOfStayDataGridViewTextBoxColumn.Name = "durationOfStayDataGridViewTextBoxColumn";
            this.durationOfStayDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationOfStayDataGridViewTextBoxColumn.Visible = false;
            // 
            // noOfChildrenDataGridViewTextBoxColumn
            // 
            this.noOfChildrenDataGridViewTextBoxColumn.DataPropertyName = "NoOfChildren";
            this.noOfChildrenDataGridViewTextBoxColumn.HeaderText = "NoOfChildren";
            this.noOfChildrenDataGridViewTextBoxColumn.Name = "noOfChildrenDataGridViewTextBoxColumn";
            this.noOfChildrenDataGridViewTextBoxColumn.ReadOnly = true;
            this.noOfChildrenDataGridViewTextBoxColumn.Visible = false;
            // 
            // areaOfVisitDataGridViewTextBoxColumn
            // 
            this.areaOfVisitDataGridViewTextBoxColumn.DataPropertyName = "AreaOfVisit";
            this.areaOfVisitDataGridViewTextBoxColumn.HeaderText = "AreaOfVisit";
            this.areaOfVisitDataGridViewTextBoxColumn.Name = "areaOfVisitDataGridViewTextBoxColumn";
            this.areaOfVisitDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaOfVisitDataGridViewTextBoxColumn.Visible = false;
            // 
            // hostNameDataGridViewTextBoxColumn
            // 
            this.hostNameDataGridViewTextBoxColumn.DataPropertyName = "HostName";
            this.hostNameDataGridViewTextBoxColumn.HeaderText = "HostName";
            this.hostNameDataGridViewTextBoxColumn.Name = "hostNameDataGridViewTextBoxColumn";
            this.hostNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.hostNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateTimeInDataGridViewTextBoxColumn
            // 
            this.dateTimeInDataGridViewTextBoxColumn.DataPropertyName = "DateTimeIn";
            this.dateTimeInDataGridViewTextBoxColumn.HeaderText = "DateTimeIn";
            this.dateTimeInDataGridViewTextBoxColumn.Name = "dateTimeInDataGridViewTextBoxColumn";
            this.dateTimeInDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeInDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateTimeOutDataGridViewTextBoxColumn
            // 
            this.dateTimeOutDataGridViewTextBoxColumn.DataPropertyName = "DateTimeOut";
            this.dateTimeOutDataGridViewTextBoxColumn.HeaderText = "DateTimeOut";
            this.dateTimeOutDataGridViewTextBoxColumn.Name = "dateTimeOutDataGridViewTextBoxColumn";
            this.dateTimeOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeOutDataGridViewTextBoxColumn.Visible = false;
            // 
            // checkedInDataGridViewCheckBoxColumn
            // 
            this.checkedInDataGridViewCheckBoxColumn.DataPropertyName = "CheckedIn";
            this.checkedInDataGridViewCheckBoxColumn.HeaderText = "CheckedIn";
            this.checkedInDataGridViewCheckBoxColumn.Name = "checkedInDataGridViewCheckBoxColumn";
            this.checkedInDataGridViewCheckBoxColumn.ReadOnly = true;
            this.checkedInDataGridViewCheckBoxColumn.Visible = false;
            // 
            // checkInToPlantDataGridViewCheckBoxColumn
            // 
            this.checkInToPlantDataGridViewCheckBoxColumn.DataPropertyName = "CheckInToPlant";
            this.checkInToPlantDataGridViewCheckBoxColumn.HeaderText = "CheckInToPlant";
            this.checkInToPlantDataGridViewCheckBoxColumn.Name = "checkInToPlantDataGridViewCheckBoxColumn";
            this.checkInToPlantDataGridViewCheckBoxColumn.ReadOnly = true;
            this.checkInToPlantDataGridViewCheckBoxColumn.Visible = false;
            // 
            // checkInToColonyDataGridViewCheckBoxColumn
            // 
            this.checkInToColonyDataGridViewCheckBoxColumn.DataPropertyName = "CheckInToColony";
            this.checkInToColonyDataGridViewCheckBoxColumn.HeaderText = "CheckInToColony";
            this.checkInToColonyDataGridViewCheckBoxColumn.Name = "checkInToColonyDataGridViewCheckBoxColumn";
            this.checkInToColonyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.checkInToColonyDataGridViewCheckBoxColumn.Visible = false;
            // 
            // cardHolderIdDataGridViewTextBoxColumn
            // 
            this.cardHolderIdDataGridViewTextBoxColumn.DataPropertyName = "CardHolderId";
            this.cardHolderIdDataGridViewTextBoxColumn.HeaderText = "CardHolderId";
            this.cardHolderIdDataGridViewTextBoxColumn.Name = "cardHolderIdDataGridViewTextBoxColumn";
            this.cardHolderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardHolderIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cardHolderInfosDataGridViewTextBoxColumn
            // 
            this.cardHolderInfosDataGridViewTextBoxColumn.DataPropertyName = "CardHolderInfos";
            this.cardHolderInfosDataGridViewTextBoxColumn.HeaderText = "CardHolderInfos";
            this.cardHolderInfosDataGridViewTextBoxColumn.Name = "cardHolderInfosDataGridViewTextBoxColumn";
            this.cardHolderInfosDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardHolderInfosDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitorIdDataGridViewTextBoxColumn
            // 
            this.visitorIdDataGridViewTextBoxColumn.DataPropertyName = "VisitorId";
            this.visitorIdDataGridViewTextBoxColumn.HeaderText = "VisitorId";
            this.visitorIdDataGridViewTextBoxColumn.Name = "visitorIdDataGridViewTextBoxColumn";
            this.visitorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitorsDataGridViewTextBoxColumn
            // 
            this.visitorsDataGridViewTextBoxColumn.DataPropertyName = "Visitors";
            this.visitorsDataGridViewTextBoxColumn.HeaderText = "Visitors";
            this.visitorsDataGridViewTextBoxColumn.Name = "visitorsDataGridViewTextBoxColumn";
            this.visitorsDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // dailyCardHolderIdDataGridViewTextBoxColumn
            // 
            this.dailyCardHolderIdDataGridViewTextBoxColumn.DataPropertyName = "DailyCardHolderId";
            this.dailyCardHolderIdDataGridViewTextBoxColumn.HeaderText = "DailyCardHolderId";
            this.dailyCardHolderIdDataGridViewTextBoxColumn.Name = "dailyCardHolderIdDataGridViewTextBoxColumn";
            this.dailyCardHolderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.dailyCardHolderIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dailyCardHoldersDataGridViewTextBoxColumn
            // 
            this.dailyCardHoldersDataGridViewTextBoxColumn.DataPropertyName = "DailyCardHolders";
            this.dailyCardHoldersDataGridViewTextBoxColumn.HeaderText = "DailyCardHolders";
            this.dailyCardHoldersDataGridViewTextBoxColumn.Name = "dailyCardHoldersDataGridViewTextBoxColumn";
            this.dailyCardHoldersDataGridViewTextBoxColumn.ReadOnly = true;
            this.dailyCardHoldersDataGridViewTextBoxColumn.Visible = false;
            // 
            // CheckCardStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 522);
            this.Controls.Add(this.dgvCheckInStatus);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCompanyName);
            this.Controls.Add(this.label3);
            this.Name = "CheckCardStatusForm";
            this.Text = "CheckCardStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.checkInAndOutInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.BindingSource checkInAndOutInfoBindingSource1;
        private System.Windows.Forms.DataGridView dgvCheckInStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInInfoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNICNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNmuberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfMaleGuestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfFemaleGuestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationOfStayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfChildrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaOfVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedInDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkInToPlantDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkInToColonyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardHolderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardHolderInfosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyCardHolderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyCardHoldersDataGridViewTextBoxColumn;
    }
}