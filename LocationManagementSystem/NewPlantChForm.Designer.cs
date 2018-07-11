namespace LocationManagementSystem
{
    partial class NewPlantChForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlantChForm));
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnContractor = new System.Windows.Forms.Button();
            this.btnWoStaff = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.btnPallaydar = new System.Windows.Forms.Button();
            this.btnCasual3pStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(12, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(63, 27);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Plant";
            // 
            // btnContractor
            // 
            this.btnContractor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractor.Location = new System.Drawing.Point(86, 202);
            this.btnContractor.Name = "btnContractor";
            this.btnContractor.Size = new System.Drawing.Size(227, 39);
            this.btnContractor.TabIndex = 5;
            this.btnContractor.Text = "Contractor/Supervisor";
            this.btnContractor.UseVisualStyleBackColor = true;
            this.btnContractor.Click += new System.EventHandler(this.btnContractor_Click);
            // 
            // btnWoStaff
            // 
            this.btnWoStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWoStaff.Location = new System.Drawing.Point(86, 247);
            this.btnWoStaff.Name = "btnWoStaff";
            this.btnWoStaff.Size = new System.Drawing.Size(227, 39);
            this.btnWoStaff.TabIndex = 6;
            this.btnWoStaff.Text = "Work Order Staff";
            this.btnWoStaff.UseVisualStyleBackColor = true;
            this.btnWoStaff.Click += new System.EventHandler(this.btnWoStaff_Click);
            // 
            // btnVisitor
            // 
            this.btnVisitor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.Location = new System.Drawing.Point(86, 112);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(227, 39);
            this.btnVisitor.TabIndex = 7;
            this.btnVisitor.Text = "Visitor";
            this.btnVisitor.UseVisualStyleBackColor = true;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // btnPallaydar
            // 
            this.btnPallaydar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPallaydar.Location = new System.Drawing.Point(86, 157);
            this.btnPallaydar.Name = "btnPallaydar";
            this.btnPallaydar.Size = new System.Drawing.Size(227, 39);
            this.btnPallaydar.TabIndex = 8;
            this.btnPallaydar.Text = "Pallaydar";
            this.btnPallaydar.UseVisualStyleBackColor = true;
            this.btnPallaydar.Click += new System.EventHandler(this.btnPallaydar_Click);
            // 
            // btnCasual3pStaff
            // 
            this.btnCasual3pStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasual3pStaff.Location = new System.Drawing.Point(86, 67);
            this.btnCasual3pStaff.Name = "btnCasual3pStaff";
            this.btnCasual3pStaff.Size = new System.Drawing.Size(227, 39);
            this.btnCasual3pStaff.TabIndex = 9;
            this.btnCasual3pStaff.Text = "Casual-3P Staff";
            this.btnCasual3pStaff.UseVisualStyleBackColor = true;
            this.btnCasual3pStaff.Click += new System.EventHandler(this.btnCasual3pStaff_Click);
            // 
            // NewPlantChForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 325);
            this.Controls.Add(this.btnCasual3pStaff);
            this.Controls.Add(this.btnPallaydar);
            this.Controls.Add(this.btnVisitor);
            this.Controls.Add(this.btnWoStaff);
            this.Controls.Add(this.btnContractor);
            this.Controls.Add(this.lblLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPlantChForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Plant Cardholder Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnContractor;
        private System.Windows.Forms.Button btnWoStaff;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Button btnPallaydar;
        private System.Windows.Forms.Button btnCasual3pStaff;
    }
}