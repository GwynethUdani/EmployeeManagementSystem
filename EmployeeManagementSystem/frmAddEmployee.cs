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
			if (string.IsNullOrWhiteSpace(txtEmpID.Text)|| string.IsNullOrWhiteSpace(txtRequestorName.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text) || string.IsNullOrWhiteSpace(txtEmailAddress.Text))
			{
				MessageBox.Show("Incomplete fields, Enter valid values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			bool dtg_addrequestor = false;
			string EMS_data = string.Empty;
			EMS_data = "Select * from [tbl_EmployeeData] where [EmployeeNumber] = '" + txtEmpID.Text + "'";
			dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);
			if (dtg_addrequestor == true)
			{
				MessageBox.Show("This account '" + txtRequestorName.Text + "' is already exist.", "Information",
						MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtRequestorName.Text = "";
				txtEmailAddress.Text = "";
				txtLocalNumber.Text = "";
			}
			else
			{
				string add_requestor = "Insert into [tbl_EmployeeData] ([EmployeeNumber], [RequestorName], [RequestorEmail], [Section], [LocalNumber]) values ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";
				CRUD.CRUD.CUD(add_requestor);
				MessageBox.Show("Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void frmAddEmployee_Load(object sender, EventArgs e)
		{
			txtRequestorName.Text = frmMasterData.Name;
			txtEmailAddress.Text = frmMasterData.Email;
			cmbSection.Text = frmMasterData.Section;
			txtLocalNumber.Text = frmMasterData.LocalNumber;
			txtEmpID.Text = frmMasterData.EmployeeID;
		}
	}
}
