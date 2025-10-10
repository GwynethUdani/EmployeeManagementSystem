using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
	public partial class frmAddEmployee : Form
	{
		private static string Email;
        internal string TransactionNo;
        private object txtSection;

		public frmAddEmployee()
		{
			InitializeComponent();
		}

		public frmAddEmployee(string text)
		{
			Text = text;
		}

		public static string EmailAddress { get; private set; }
        public static string RequestorEmail { get; private set; }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text) ||
                string.IsNullOrWhiteSpace(txtRequestorName.Text) ||
                string.IsNullOrWhiteSpace(txtLocalNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAddress.Text))
            {
                MessageBox.Show("Incomplete fields, Enter valid values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;

            EMS_data = "SELECT * FROM [tbl_EmployeeData] WHERE [EmployeeNumber] = '" + txtEmpID.Text + "'";

            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (dtg_addrequestor == true)
            {
                DialogResult result = MessageBox.Show(
                    "This account '" + txtRequestorName.Text + "' already exists. Do you want to update?",
                    "Already Exists",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk
                );

                if (result == DialogResult.Yes)
                {
                    string updateQuery = "UPDATE [tbl_EmployeeData] SET " +
                                         "[EmployeeNumber] = '" + txtEmpID.Text + "', " +
                                         "[RequestorName] = '" + txtRequestorName.Text + "', " +
                                         "[RequestorEmail] = '" + txtEmailAddress.Text + "', " +
                                         "[Section] = '" + cmbSection.Text + "', " +
                                         "[LocalNumber] = '" + txtLocalNumber.Text + "' " +
                                         "WHERE [ID] = " + frmMasterData.selectedTransaction;

                    CRUD.CRUD.CUD(updateQuery);
                    MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtEmpID.Clear();
                    txtRequestorName.Clear();
                    txtEmailAddress.Clear();
                    txtLocalNumber.Clear();
                    cmbSection.SelectedIndex = -1;
                    this.Close();
                }
            }
            else
            {
                string add_requestor = "INSERT INTO [tbl_EmployeeData] " +
                                       "([EmployeeNumber],[RequestorName],[RequestorEmail],[Section],[LocalNumber]) " +
                                       "VALUES ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";

                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }




        private void frmAddEmployee_Load(object sender, EventArgs e)
		{
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmailAddress.Text = frmMasterData.Email;
            cmbSection.Text = frmMasterData.Section;
            txtLocalNumber.Text = frmMasterData.LocalNumber;
            txtEmpID.Text = frmMasterData.EmployeeID;
        }
	}
}
