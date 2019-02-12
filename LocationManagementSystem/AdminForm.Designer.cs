namespace LocationManagementSystem
{
    partial class AdminForm
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
            this.btnUpdateLocations = new System.Windows.Forms.Button();
            this.btnUpdateDepartments = new System.Windows.Forms.Button();
            this.btnUpdateSections = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.btnUpdateDesgination = new System.Windows.Forms.Button();
            this.btnUpdateCadre = new System.Windows.Forms.Button();
            this.btnEmails = new System.Windows.Forms.Button();
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnAddorUpdateCategories = new System.Windows.Forms.Button();
            this.btnDeleteCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateLocations
            // 
            this.btnUpdateLocations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLocations.Location = new System.Drawing.Point(16, 22);
            this.btnUpdateLocations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateLocations.Name = "btnUpdateLocations";
            this.btnUpdateLocations.Size = new System.Drawing.Size(175, 65);
            this.btnUpdateLocations.TabIndex = 15;
            this.btnUpdateLocations.Text = "Update Visiting Locations";
            this.btnUpdateLocations.UseVisualStyleBackColor = true;
            this.btnUpdateLocations.Click += new System.EventHandler(this.btnUpdateLocations_Click);
            // 
            // btnUpdateDepartments
            // 
            this.btnUpdateDepartments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDepartments.Location = new System.Drawing.Point(199, 22);
            this.btnUpdateDepartments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateDepartments.Name = "btnUpdateDepartments";
            this.btnUpdateDepartments.Size = new System.Drawing.Size(175, 65);
            this.btnUpdateDepartments.TabIndex = 16;
            this.btnUpdateDepartments.Text = "Update Departments";
            this.btnUpdateDepartments.UseVisualStyleBackColor = true;
            this.btnUpdateDepartments.Click += new System.EventHandler(this.btnUpdateDepartments_Click);
            // 
            // btnUpdateSections
            // 
            this.btnUpdateSections.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSections.Location = new System.Drawing.Point(381, 22);
            this.btnUpdateSections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateSections.Name = "btnUpdateSections";
            this.btnUpdateSections.Size = new System.Drawing.Size(175, 65);
            this.btnUpdateSections.TabIndex = 17;
            this.btnUpdateSections.Text = "Update Sections";
            this.btnUpdateSections.UseVisualStyleBackColor = true;
            this.btnUpdateSections.Click += new System.EventHandler(this.btnUpdateSections_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCompany.Location = new System.Drawing.Point(16, 134);
            this.btnUpdateCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(175, 65);
            this.btnUpdateCompany.TabIndex = 18;
            this.btnUpdateCompany.Text = "Update Companies";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // btnUpdateDesgination
            // 
            this.btnUpdateDesgination.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDesgination.Location = new System.Drawing.Point(199, 134);
            this.btnUpdateDesgination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateDesgination.Name = "btnUpdateDesgination";
            this.btnUpdateDesgination.Size = new System.Drawing.Size(175, 65);
            this.btnUpdateDesgination.TabIndex = 19;
            this.btnUpdateDesgination.Text = "Update Designations";
            this.btnUpdateDesgination.UseVisualStyleBackColor = true;
            this.btnUpdateDesgination.Click += new System.EventHandler(this.btnUpdateDesgination_Click);
            // 
            // btnUpdateCadre
            // 
            this.btnUpdateCadre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCadre.Location = new System.Drawing.Point(381, 134);
            this.btnUpdateCadre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateCadre.Name = "btnUpdateCadre";
            this.btnUpdateCadre.Size = new System.Drawing.Size(175, 65);
            this.btnUpdateCadre.TabIndex = 20;
            this.btnUpdateCadre.Text = "Update Cadres";
            this.btnUpdateCadre.UseVisualStyleBackColor = true;
            this.btnUpdateCadre.Click += new System.EventHandler(this.btnUpdateCadre_Click);
            // 
            // btnEmails
            // 
            this.btnEmails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmails.Location = new System.Drawing.Point(564, 22);
            this.btnEmails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmails.Name = "btnEmails";
            this.btnEmails.Size = new System.Drawing.Size(175, 65);
            this.btnEmails.TabIndex = 21;
            this.btnEmails.Text = "Update Emails";
            this.btnEmails.UseVisualStyleBackColor = true;
            this.btnEmails.Click += new System.EventHandler(this.btnEmails_Click);
            // 
            // btnSystemSettings
            // 
            this.btnSystemSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemSettings.Location = new System.Drawing.Point(564, 134);
            this.btnSystemSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSystemSettings.Name = "btnSystemSettings";
            this.btnSystemSettings.Size = new System.Drawing.Size(175, 65);
            this.btnSystemSettings.TabIndex = 22;
            this.btnSystemSettings.Text = "Update System Settings";
            this.btnSystemSettings.UseVisualStyleBackColor = true;
            this.btnSystemSettings.Click += new System.EventHandler(this.btnSystemSettings_Click);
            // 
            // btnAddorUpdateCategories
            // 
            this.btnAddorUpdateCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddorUpdateCategories.Location = new System.Drawing.Point(16, 222);
            this.btnAddorUpdateCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddorUpdateCategories.Name = "btnAddorUpdateCategories";
            this.btnAddorUpdateCategories.Size = new System.Drawing.Size(175, 65);
            this.btnAddorUpdateCategories.TabIndex = 22;
            this.btnAddorUpdateCategories.Text = "Add/Update Category";
            this.btnAddorUpdateCategories.UseVisualStyleBackColor = true;
            this.btnAddorUpdateCategories.Click += new System.EventHandler(this.btnAddorUpdateCategories_Click);
            // 
            // btnDeleteCategories
            // 
            this.btnDeleteCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategories.Location = new System.Drawing.Point(200, 222);
            this.btnDeleteCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteCategories.Name = "btnDeleteCategories";
            this.btnDeleteCategories.Size = new System.Drawing.Size(175, 65);
            this.btnDeleteCategories.TabIndex = 22;
            this.btnDeleteCategories.Text = "Delete Category";
            this.btnDeleteCategories.UseVisualStyleBackColor = true;
            this.btnDeleteCategories.Click += new System.EventHandler(this.btnDeleteCategories_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 308);
            this.Controls.Add(this.btnSystemSettings);
            this.Controls.Add(this.btnEmails);
            this.Controls.Add(this.btnUpdateCadre);
            this.Controls.Add(this.btnUpdateDesgination);
            this.Controls.Add(this.btnUpdateCompany);
            this.Controls.Add(this.btnUpdateSections);
            this.Controls.Add(this.btnUpdateDepartments);
            this.Controls.Add(this.btnUpdateLocations);
            this.Controls.Add(this.btnAddorUpdateCategories);
            this.Controls.Add(this.btnDeleteCategories);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateLocations;
        private System.Windows.Forms.Button btnUpdateDepartments;
        private System.Windows.Forms.Button btnUpdateSections;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Button btnUpdateDesgination;
        private System.Windows.Forms.Button btnUpdateCadre;
        private System.Windows.Forms.Button btnEmails;
        private System.Windows.Forms.Button btnSystemSettings;
        private System.Windows.Forms.Button btnAddorUpdateCategories;
        private System.Windows.Forms.Button btnDeleteCategories;
    }
}