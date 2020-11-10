using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BookRentalShop2020
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            string strConnString = "Data Source=127.0.0.1;Initial Catalog=bookrentalshopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        {
            if(string.IsNullOrEmpty(txtID.Text)||string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
