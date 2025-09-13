namespace EmployeeManagementSystem
{
    partial class frmAddEmployee
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
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.tbLocalNumber = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbRequestorName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbEmployeeNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.pnlAddEmployee.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.BackColor = System.Drawing.Color.Firebrick;
            this.pnlAddEmployee.Controls.Add(this.lblAddEmployee);
            this.pnlAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(800, 60);
            this.pnlAddEmployee.TabIndex = 0;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.ForeColor = System.Drawing.Color.White;
            this.lblAddEmployee.Location = new System.Drawing.Point(12, 19);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(153, 23);
            this.lblAddEmployee.TabIndex = 0;
            this.lblAddEmployee.Text = "Add Employee";
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.Color.IndianRed;
            this.GroupBox.Controls.Add(this.button1);
            this.GroupBox.Controls.Add(this.ComboBox);
            this.GroupBox.Controls.Add(this.tbLocalNumber);
            this.GroupBox.Controls.Add(this.tbEmailAddress);
            this.GroupBox.Controls.Add(this.tbRequestorName);
            this.GroupBox.Controls.Add(this.btnSearch);
            this.GroupBox.Controls.Add(this.tbEmployeeNumber);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.lblEmployeeNumber);
            this.GroupBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(0, 66);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(800, 202);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Employee Details Manual Insert and Update";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(152, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "INSERT / UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ComboBox
            // 
            this.ComboBox.BackColor = System.Drawing.Color.RosyBrown;
            this.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(152, 131);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(262, 23);
            this.ComboBox.TabIndex = 10;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // tbLocalNumber
            // 
            this.tbLocalNumber.AcceptsReturn = true;
            this.tbLocalNumber.BackColor = System.Drawing.Color.RosyBrown;
            this.tbLocalNumber.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalNumber.Location = new System.Drawing.Point(152, 105);
            this.tbLocalNumber.Name = "tbLocalNumber";
            this.tbLocalNumber.Size = new System.Drawing.Size(262, 21);
            this.tbLocalNumber.TabIndex = 9;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.AcceptsReturn = true;
            this.tbEmailAddress.BackColor = System.Drawing.Color.RosyBrown;
            this.tbEmailAddress.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailAddress.Location = new System.Drawing.Point(152, 79);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(384, 21);
            this.tbEmailAddress.TabIndex = 8;
            // 
            // tbRequestorName
            // 
            this.tbRequestorName.AcceptsReturn = true;
            this.tbRequestorName.BackColor = System.Drawing.Color.RosyBrown;
            this.tbRequestorName.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequestorName.Location = new System.Drawing.Point(152, 53);
            this.tbRequestorName.Name = "tbRequestorName";
            this.tbRequestorName.Size = new System.Drawing.Size(384, 21);
            this.tbRequestorName.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightCoral;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(339, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbEmployeeNumber
            // 
            this.tbEmployeeNumber.BackColor = System.Drawing.Color.RosyBrown;
            this.tbEmployeeNumber.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeNumber.Location = new System.Drawing.Point(152, 27);
            this.tbEmployeeNumber.Name = "tbEmployeeNumber";
            this.tbEmployeeNumber.Size = new System.Drawing.Size(181, 21);
            this.tbEmployeeNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Section :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Local Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Requestor Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(12, 29);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(141, 16);
            this.lblEmployeeNumber.TabIndex = 0;
            this.lblEmployeeNumber.Text = "Employee Number :";
            this.lblEmployeeNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.pnlAddEmployee);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbEmployeeNumber;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.TextBox tbLocalNumber;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbRequestorName;
        private System.Windows.Forms.Button button1;
    }
}