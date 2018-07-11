namespace LocationManagementSystem
{
    partial class PictureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureForm));
            this.btnTakePicture = new System.Windows.Forms.Button();
            this.pbxSnapShot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSnapShot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.Location = new System.Drawing.Point(105, 183);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(75, 23);
            this.btnTakePicture.TabIndex = 68;
            this.btnTakePicture.Text = "TakePicture";
            this.btnTakePicture.UseVisualStyleBackColor = true;
            this.btnTakePicture.Click += new System.EventHandler(this.btnTakePicture_Click);
            // 
            // pbxSnapShot
            // 
            this.pbxSnapShot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSnapShot.Location = new System.Drawing.Point(82, 55);
            this.pbxSnapShot.Name = "pbxSnapShot";
            this.pbxSnapShot.Size = new System.Drawing.Size(120, 120);
            this.pbxSnapShot.TabIndex = 67;
            this.pbxSnapShot.TabStop = false;
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTakePicture);
            this.Controls.Add(this.pbxSnapShot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSnapShot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTakePicture;
        private System.Windows.Forms.PictureBox pbxSnapShot;
    }
}