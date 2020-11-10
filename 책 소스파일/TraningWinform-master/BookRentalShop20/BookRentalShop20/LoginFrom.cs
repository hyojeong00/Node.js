using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalShop20
{

    public partial class LoginFrom : MetroForm
    {
        public LoginFrom()
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
        }

        private void LoginProcess()
        {
           // throw new NotImplementedException();
            if(string.IsNullOrEmpty(txtUserID.Text)||string.IsNullOrEmpty(txtUserPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using(SqlConnection conn= new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userID"
                                        + " FROM userTbl"
                                        + " WHERE userID = @userID"
                                        + " AND password = @password";
                    SqlParameter parmUserId = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                    parmUserId.Value = txtUserID.Text;
                    cmd.Parameters.Add(parmUserId);

                    SqlParameter parmPassword = new SqlParameter("@password", SqlDbType.VarChar, 20);
                    parmPassword.Value = txtUserPassword.Text;
                    cmd.Parameters.Add(parmPassword);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    string strUserID = reader["userID"] != null ? reader["userID"].ToString() : ""; // userID행에서 읽어온 데이터가 있을시 string형으로 저장하며 없으면 ""을 저장

                    if (strUserID != "") // 로그인 성공할 경우
                    {
                        Commons.LOGINUSERID = strUserID;
                        MetroMessageBox.Show(this, "접속성공", "로그인성공"); // 로그인이 성공했다는 메시지박스를 화면에 띄어줌
                        this.Close(); // LoginForm을 종료하며 MainForm을 사용할 수 있게됨
                    }
                    else // 로그인 실패할 경우
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 접속실패 했다는 경고창을 화면에 띄어주며 OK를 누를시 로그인창으로 돌아감
                    }
                }
            }
            catch (Exception ex) // 에러가 날 경우
            {
                MetroMessageBox.Show(this, $"Error : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error); // 에러가 무엇인지 화면에 표시해주는 메시지박스 생성
                return;//OK버튼을 누르면 로그인창으로 돌아감
            }

        }

        private void txtUserID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtUserPassword.Focus();
            }
        }

        private void txtUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                btnOK.Focus();
            }
        }

        private void btnOK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                btnCancel.Focus();
            }
        }
    }
}
