namespace EmployeeManagementSystem
{
    partial class frmMasterData
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
            this.pnlChildTitle = new System.Windows.Forms.Panel();
            this.lblMasterData = new System.Windows.Forms.Label();
            this.dtgMasterData = new System.Windows.Forms.DataGridView();
            this.pnlChildTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMasterData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChildTitle
            // 
            this.pnlChildTitle.BackColor = System.Drawing.Color.Firebrick;
            this.pnlChildTitle.Controls.Add(this.lblMasterData);
            this.pnlChildTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlChildTitle.Name = "pnlChildTitle";
            this.pnlChildTitle.Size = new System.Drawing.Size(748, 57);
            this.pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            this.lblMasterData.AutoSize = true;
            this.lblMasterData.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterData.ForeColor = System.Drawing.Color.White;
            this.lblMasterData.Location = new System.Drawing.Point(12, 19);
            this.lblMasterData.Name = "lblMasterData";
            this.lblMasterData.Size = new System.Drawing.Size(133, 23);
            this.lblMasterData.TabIndex = 0;
            this.lblMasterData.Text = "Master Data";
            this.lblMasterData.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgMasterData
            // 
            this.dtgMasterData.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dtgMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMasterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMasterData.Location = new System.Drawing.Point(0, 57);
            this.dtgMasterData.Name = "dtgMasterData";
            this.dtgMasterData.Size = new System.Drawing.Size(748, 316);
            this.dtgMasterData.TabIndex = 1;
            this.dtgMasterData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 373);
            this.Controls.Add(this.dtgMasterData);
            this.Controls.Add(this.pnlChildTitle);
            this.Name = "frmMasterData";
            this.Text = "frmMasterData";
            this.pnlChildTitle.ResumeLayout(false);
            this.pnlChildTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMasterData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildTitle;
        private System.Windows.Forms.Label lblMasterData;
        private System.Windows.Forms.DataGridView dtgMasterData;
    }
}