namespace LocationManagementSystem
{
    partial class UpdateLocationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateLocationsForm));
            this.dgvPlantLocations = new System.Windows.Forms.DataGridView();
            this.visitingLocationsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOnPlantDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visitingLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvColonyLocations = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visitingLocationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingLocationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColonyLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingLocationsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlantLocations
            // 
            this.dgvPlantLocations.AllowUserToResizeColumns = false;
            this.dgvPlantLocations.AllowUserToResizeRows = false;
            this.dgvPlantLocations.AutoGenerateColumns = false;
            this.dgvPlantLocations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPlantLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitingLocationsIdDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.isOnPlantDataGridViewCheckBoxColumn});
            this.dgvPlantLocations.DataSource = this.visitingLocationsBindingSource;
            this.dgvPlantLocations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvPlantLocations.Location = new System.Drawing.Point(12, 59);
            this.dgvPlantLocations.Name = "dgvPlantLocations";
            this.dgvPlantLocations.RowHeadersWidth = 30;
            this.dgvPlantLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlantLocations.Size = new System.Drawing.Size(343, 150);
            this.dgvPlantLocations.TabIndex = 0;
            this.dgvPlantLocations.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlantLocations_CellEndEdit);
            this.dgvPlantLocations.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPlantLocations_DataBindingComplete);
            this.dgvPlantLocations.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvPlantLocations_UserDeletingRow);
            // 
            // visitingLocationsIdDataGridViewTextBoxColumn
            // 
            this.visitingLocationsIdDataGridViewTextBoxColumn.DataPropertyName = "VisitingLocationsId";
            this.visitingLocationsIdDataGridViewTextBoxColumn.HeaderText = "VisitingLocationsId";
            this.visitingLocationsIdDataGridViewTextBoxColumn.Name = "visitingLocationsIdDataGridViewTextBoxColumn";
            this.visitingLocationsIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 300;
            // 
            // isOnPlantDataGridViewCheckBoxColumn
            // 
            this.isOnPlantDataGridViewCheckBoxColumn.DataPropertyName = "IsOnPlant";
            this.isOnPlantDataGridViewCheckBoxColumn.HeaderText = "IsOnPlant";
            this.isOnPlantDataGridViewCheckBoxColumn.Name = "isOnPlantDataGridViewCheckBoxColumn";
            this.isOnPlantDataGridViewCheckBoxColumn.Visible = false;
            // 
            // visitingLocationsBindingSource
            // 
            this.visitingLocationsBindingSource.DataSource = typeof(LocationManagementSystem.VisitingLocations);
            // 
            // dgvColonyLocations
            // 
            this.dgvColonyLocations.AllowUserToResizeColumns = false;
            this.dgvColonyLocations.AllowUserToResizeRows = false;
            this.dgvColonyLocations.AutoGenerateColumns = false;
            this.dgvColonyLocations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvColonyLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColonyLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.dgvColonyLocations.DataSource = this.visitingLocationsBindingSource1;
            this.dgvColonyLocations.Location = new System.Drawing.Point(12, 262);
            this.dgvColonyLocations.Name = "dgvColonyLocations";
            this.dgvColonyLocations.RowHeadersWidth = 30;
            this.dgvColonyLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColonyLocations.Size = new System.Drawing.Size(343, 150);
            this.dgvColonyLocations.TabIndex = 1;
            this.dgvColonyLocations.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColonyLocations_CellEndEdit);
            this.dgvColonyLocations.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvColonyLocations_DataBindingComplete);
            this.dgvColonyLocations.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvColonyLocations_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VisitingLocationsId";
            this.dataGridViewTextBoxColumn1.HeaderText = "VisitingLocationsId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn2.HeaderText = "Location";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsOnPlant";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsOnPlant";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // visitingLocationsBindingSource1
            // 
            this.visitingLocationsBindingSource1.DataSource = typeof(LocationManagementSystem.VisitingLocations);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman MT Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plant Visiting Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman MT Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Colony Visiting Location";
            // 
            // UpdateLocationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvColonyLocations);
            this.Controls.Add(this.dgvPlantLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateLocationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateLocationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingLocationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColonyLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingLocationsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlantLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitingLocationsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOnPlantDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource visitingLocationsBindingSource;
        private System.Windows.Forms.DataGridView dgvColonyLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource visitingLocationsBindingSource1;
    }
}