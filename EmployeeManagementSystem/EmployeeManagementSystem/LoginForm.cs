using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace EmployeeManagementSystem
//{
//    public partial class LoginForm : Form
//    {
//        public LoginForm()
//        {
//            InitializeComponent();
//        }

//        private void InitializeComponent()
//        {
//            throw new NotImplementedException();
//        }

//        public static string fullname, Age, Section;
//        private object txtUsername;
//        private object txtPassword;

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string username = txtUsername.Text.Trim();
//            string password = txtPassword.Text.Trim();

//            if (username == "" && password == "")
//            {
//                MessageBox.Show("Please input username and password");
//                return;
//            }
//            else if (username == "")
//            {
//                MessageBox.Show("Please input username");
//                return;
//            }
//            else if (password == "")
//            {
//                MessageBox.Show("Please input password");
//                return;
//            }

//            string sql = $"SELECT [FullName], [Section], [Age] FROM Users WHERE Username='{username}' AND [Password]='{password}'";
//            bool isLogin = CRUD.RETRIEVESINGLE(sql);

//            if (isLogin)
//            {
//                fullname = CRUD.dt.Rows[0]["FullName"].ToString();
//                Section = CRUD.dt.Rows[0]["Section"].ToString();
//                Age = CRUD.dt.Rows[0]["Age"].ToString();
//                MessageBox.Show("Welcome " + fullname);

//                Form1 newForm1 = new Form1();
//                newForm1.ShowDialog();
//            }
//            else
//            {
//                MessageBox.Show("No Data");

//            }

//        }
//    }
//}
