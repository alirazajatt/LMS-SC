namespace LocationManagementSystem
{
    partial class UpdateCadreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCadres = new System.Windows.Forms.DataGridView();
            this.cadreInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman MT Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadres";
            // 
            // dgvCadres
            // 
            this.dgvCadres.AutoGenerateColumns = false;
            this.dgvCadres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cadreIdDataGridViewTextBoxColumn,
            this.cadreNameDataGridViewTextBoxColumn});
            this.dgvCadres.DataSource = this.cadreInfoBindingSource;
            this.dgvCadres.Location = new System.Drawing.Point(16, 57);
            this.dgvCadres.Name = "dgvCadres";
            this.dgvCadres.Size = new System.Drawing.Size(334, 319);
            this.dgvCadres.TabIndex = 4;
            this.dgvCadres.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dgvCadres.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDepartments_DataBindingComplete);
            this.dgvCadres.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // cadreInfoBindingSource
            // 
            this.cadreInfoBindingSource.DataSource = typeof(LocationManagementSystem.CadreInfo);
            // 
            // cadreIdDataGridViewTextBoxColumn
            // 
            this.cadreIdDataGridViewTextBoxColumn.DataPropertyName = "CadreId";
            this.cadreIdDataGridViewTextBoxColumn.HeaderText = "CadreId";
            this.cadreIdDataGridViewTextBoxColumn.Name = "cadreIdDataGridViewTextBoxColumn";
            this.cadreIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cadreNameDataGridViewTextBoxColumn
            // 
            this.cadreNameDataGridViewTextBoxColumn.DataPropertyName = "CadreName";
            this.cadreNameDataGridViewTextBoxColumn.HeaderText = "CadreName";
            this.cadreNameDataGridViewTextBoxColumn.Name = "cadreNameDataGridViewTextBoxColumn";
            this.cadreNameDataGridViewTextBoxColumn.Width = 290;
            // 
            // UpdateCadreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 388);
            this.Controls.Add(this.dgvCadres);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCadreForm";
            this.Text = "UpdateDepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCadres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cadreInfoBindingSource;
    }
}