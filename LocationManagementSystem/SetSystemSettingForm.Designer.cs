namespace LocationManagementSystem
{
    partial class SetSystemSettingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSmtpPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSmtpServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nuNoOfBlockUserDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nuNoEmailNotificationDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chbIsSSL = new System.Windows.Forms.CheckBox();
            this.chbAuthReq = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuNoOfBlockUserDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuNoEmailNotificationDays)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbAuthReq);
            this.groupBox1.Controls.Add(this.chbIsSSL);
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxSmtpPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxSmtpServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.nuNoOfBlockUserDays);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nuNoEmailNotificationDays);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Settings";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.White;
            this.tbxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(183, 232);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(191, 29);
            this.tbxPassword.TabIndex = 75;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 74;
            this.label6.Text = "Password";
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.Color.White;
            this.tbxUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.Location = new System.Drawing.Point(183, 197);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(191, 29);
            this.tbxUserName.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 72;
            this.label5.Text = "User Name";
            // 
            // tbxSmtpPort
            // 
            this.tbxSmtpPort.BackColor = System.Drawing.Color.White;
            this.tbxSmtpPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSmtpPort.Location = new System.Drawing.Point(183, 128);
            this.tbxSmtpPort.Name = "tbxSmtpPort";
            this.tbxSmtpPort.Size = new System.Drawing.Size(191, 29);
            this.tbxSmtpPort.TabIndex = 71;
            this.tbxSmtpPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSmtpPort_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Smtp Port";
            // 
            // tbxSmtpServer
            // 
            this.tbxSmtpServer.BackColor = System.Drawing.Color.White;
            this.tbxSmtpServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSmtpServer.Location = new System.Drawing.Point(183, 93);
            this.tbxSmtpServer.Name = "tbxSmtpServer";
            this.tbxSmtpServer.Size = new System.Drawing.Size(191, 29);
            this.tbxSmtpServer.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Smtp Server";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(266, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 47);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nuNoOfBlockUserDays
            // 
            this.nuNoOfBlockUserDays.BackColor = System.Drawing.Color.White;
            this.nuNoOfBlockUserDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuNoOfBlockUserDays.Location = new System.Drawing.Point(183, 58);
            this.nuNoOfBlockUserDays.Name = "nuNoOfBlockUserDays";
            this.nuNoOfBlockUserDays.Size = new System.Drawing.Size(191, 29);
            this.nuNoOfBlockUserDays.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "Block User Days";
            // 
            // nuNoEmailNotificationDays
            // 
            this.nuNoEmailNotificationDays.BackColor = System.Drawing.Color.White;
            this.nuNoEmailNotificationDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuNoEmailNotificationDays.Location = new System.Drawing.Point(183, 23);
            this.nuNoEmailNotificationDays.Name = "nuNoEmailNotificationDays";
            this.nuNoEmailNotificationDays.Size = new System.Drawing.Size(191, 29);
            this.nuNoEmailNotificationDays.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email Notification Days";
            // 
            // chbIsSSL
            // 
            this.chbIsSSL.AutoSize = true;
            this.chbIsSSL.Location = new System.Drawing.Point(10, 162);
            this.chbIsSSL.Name = "chbIsSSL";
            this.chbIsSSL.Size = new System.Drawing.Size(105, 25);
            this.chbIsSSL.TabIndex = 76;
            this.chbIsSSL.Text = "Enable SSL";
            this.chbIsSSL.UseVisualStyleBackColor = false;
            // 
            // chbAuthReq
            // 
            this.chbAuthReq.AutoSize = true;
            this.chbAuthReq.Checked = true;
            this.chbAuthReq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAuthReq.Location = new System.Drawing.Point(10, 270);
            this.chbAuthReq.Name = "chbAuthReq";
            this.chbAuthReq.Size = new System.Drawing.Size(197, 25);
            this.chbAuthReq.TabIndex = 77;
            this.chbAuthReq.Text = "Authentication Required";
            this.chbAuthReq.UseVisualStyleBackColor = true;
            // 
            // SetSystemSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 357);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SetSystemSettingForm";
            this.Text = "System Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuNoOfBlockUserDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuNoEmailNotificationDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nuNoOfBlockUserDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuNoEmailNotificationDays;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSmtpPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSmtpServer;
        private System.Windows.Forms.CheckBox chbAuthReq;
        private System.Windows.Forms.CheckBox chbIsSSL;
    }
}