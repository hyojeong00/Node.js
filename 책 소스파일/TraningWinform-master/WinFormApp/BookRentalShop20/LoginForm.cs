using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop20
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        string strConnString = "Data Source=127.0.0.1;Initial Catalog=bookrentalshopDB;User ID=sa;Password=p@ssw0rd!";
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  캔슬 처리버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        /// <summary>
        /// 로그인 처리버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                label2.Focus();
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                LoginProcess();
            }
        }

        private void LoginProcess()
        {
            if(string.IsNullOrEmpty(txtUserID.Text)||
                    string.IsNullOrEmpty(label2.Text))
            {
                MetroMessageBox.Show(this, "아이디 / 패스워드를 입력하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string strUserId = string.Empty;

            using(SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT userID FROM userTbl " +
                                               " WHERE userID = @userID " +
                                                "  AND password = @password";
                SqlParameter parmUserId = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                parmUserId.Value = txtUserID.Text;
                cmd.Parameters.Add(parmUserId);

                SqlParameter parmPassword = new SqlParameter("@password", SqlDbType.VarChar, 20);
                parmPassword.Value = txtUserPassword.Text;
                cmd.Parameters.Add(parmPassword);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                strUserId = reader["userID"] != null ? reader["userID"].ToString(): "";

                if(strUserId !="")
                {
                    MetroMessageBox.Show(this, "접속실패", "로그인실패");
                }
               
                MetroMessageBox.Show(this, "접속성공", "로그인");
                Debug.WriteLine(" On the Debug");
            }

        }
    }
}
