using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            LoginProcess();
            if (!rdbtnAdmin.Checked && !rdbtnMember.Checked && !string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "관리자/사용자 모드를 선택해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            
           
        }

        private void LoginProcess()
        {

            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                txtID.Focus();
                // return;
            }

        if(rdbtnMember.Checked)
            { 
            try
            {
                using (SqlConnection conn = new SqlConnection(Commons.strConnString)) //commons.cs 로 만들었어요
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userID FROM userTbl " +
                                    " WHERE userID = @userID " +
                                    " AND userPassword = @userPassword ";
                    SqlParameter paramUserID = new SqlParameter("@userID", SqlDbType.VarChar, 50);
                    paramUserID.Value = txtID.Text;
                    cmd.Parameters.Add(paramUserID);

                    SqlParameter paramUserPassword = new SqlParameter("@userPassword", SqlDbType.VarChar, 50);
                    paramUserPassword.Value = txtPassword.Text;
                    cmd.Parameters.Add(paramUserPassword);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    string struserID = reader["userID"] != null ? reader["userID"].ToString() : "";


                    if (struserID != "")
                    {
                        MetroMessageBox.Show(this, "접속성공", "로그인성공");
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            catch (Exception)
            {
                    MetroMessageBox.Show(this, "로그인에 실패했습니다.\n아이디/비밀번호를 확인해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtPassword.Clear();
                    txtID.Focus();

                }
        }

        

            if(rdbtnAdmin.Checked)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Commons.strConnString)) //commons.cs 로 만들었어요
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT masterID FROM masterTbl " +
                                        " WHERE masterID = @masterID " +
                                        " AND masterPassword = @masterPassword ";
                        SqlParameter paramMasterID = new SqlParameter("@masterID", SqlDbType.VarChar, 50);
                        paramMasterID.Value = txtID.Text;
                        cmd.Parameters.Add(paramMasterID);

                        SqlParameter paramPassword = new SqlParameter("@masterPassword", SqlDbType.VarChar, 50);
                        paramPassword.Value = txtPassword.Text;
                        cmd.Parameters.Add(paramPassword);

                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        string strMasterID = reader["masterID"] !=null? reader["masterID"].ToString():"";

                        if(strMasterID !="")
                        {
                            MetroMessageBox.Show(this, "접속성공", "로그인성공");
                            this.Close();
                            AdministrationForm form = new AdministrationForm();
                            form.ShowDialog();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                        }

                    }
                }
                catch(Exception)
                {
                    MetroMessageBox.Show(this, "로그인에 실패했습니다.\n아이디 / 비밀번호를 확인해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtPassword.Clear();
                    txtID.Focus();
                }
                
            }

        }
       
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
               btnOK.Focus();
            }
        }

        private void rdbtnMember_MouseClick(object sender, MouseEventArgs e)
        {
            btnOK.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewMemberForm form = new NewMemberForm();
            form.ShowDialog();
        }
    }
}
