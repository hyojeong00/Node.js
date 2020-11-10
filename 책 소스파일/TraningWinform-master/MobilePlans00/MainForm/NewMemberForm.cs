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
    public partial class NewMemberForm : MetroFramework.Forms.MetroForm
    { bool overlapcheck = false;
        public NewMemberForm()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewMemberForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            UpdateCbo();
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
            {
                conn.Open();
                string strQuery = "SELECT  userID , userName , userPassword , userAge , userGender " +
                                    " , userMobile, userUSCallPlan " +
                                     " FROM userTbl ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet userlist = new DataSet();
                dataAdapter.Fill(userlist, "userTbl");
                grdNew.DataSource = userlist;
                grdNew.DataMember = "userTbl";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtAge.Text)
                || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text)
                || (!rdbtnFemale.Checked && !rdbtnMale.Checked) || (cboUSCallPlan.SelectedIndex == -1))
            {
                MetroMessageBox.Show(this, "빈 값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (overlapcheck == false)
            {
                MetroMessageBox.Show(this, "중복확인을 해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //string a = "";

            //if (!txtAge.Text.Equals(a))
            //{
            //    MetroMessageBox.show(this, "숫자를 입력하세요", "오류", message);
            //    txtAge.Text = "";

            //}

            SaveProcess();
            this.Close();

          

        }

        private void SaveProcess()
        {
            ///<summary>
            /// 다시해봅시당 화이팅팅팅
            /// 할수이따할수이따나는할수있따
            /// // = 동욱이 DB기준 = 
            // [선택된 cboBox의 텍스트를 이용하여 먼저 요금제의 std1, std2, std3을 구한다.]
            // Query문 : SELECT STD1,STD2,STD3 FROM productTbl WHERE CallingPlan = @CallingPlan
            // cboBox에 선택된 텍스트를 파리미터에 넣는다
            // 찾은 STD1, STD2, STD3을 알맞은 변수에 저장해 둔 뒤 아래의 소스에서 INSERT할 때 값을 추가해준다.
            // userTbl의 userSearch 열에는 처음 아이디를 만든 것이므로 1을 넣어준다. 
            /// </summary>
            //using (SqlConnection connNew = new SqlConnection(Commons.strConnString))
            //{
            //    connNew.Open();
            //    SqlCommand command = new SqlCommand();
            //    command.Connection = connNew;
            //    string strQuery = " SELECT STD1, STD2, STD3 FROM productTbl WHERE CallingPlan = @CallingPlan ";
            //    command.CommandText = strQuery;
            //    SqlDataReader reader = command.ExecuteReader();

            //    SqlParameter paramCbo = new SqlParameter();

            //    // SqlParameter paramSTD1 = new SqlParameter("@STD1", SqlDbType.Int);
            //    //paramSTD1.Value=...??

            //}
            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
            {
                conn.Open();
                string strQuery = "SELECT  userID , userName , userPassword , userAge , userGender " +
                                    " , userMobile, userUSCallPlan " +
                                     " FROM userTbl ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet userlist = new DataSet();
                dataAdapter.Fill(userlist, "userTbl");
                grdNew.DataSource = userlist;
                grdNew.DataMember = "userTbl";
            }
            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;


                string strQuery = " INSERT INTO userTbl " +
                                 " (userID, userName, userPassword, userAge" +
                                 " , userGender, userMobile, userUSCallPlan)" +
                                 " VALUES (@userID, @userName, @userPassword, @userAge" +
                                 " , @userGender, @userMobile, @userUSCallPlan)";

                cmd.CommandText = strQuery;
                SqlParameter paramUserID = new SqlParameter("@userID", SqlDbType.VarChar, 50);
                paramUserID.Value = txtID.Text;
                cmd.Parameters.Add(paramUserID);

                SqlParameter paramName = new SqlParameter("@userName", SqlDbType.NVarChar, 20);
                paramName.Value = txtName.Text;
                cmd.Parameters.Add(paramName);

                SqlParameter paramPassword = new SqlParameter("@userPassword", SqlDbType.VarChar, 50);
                paramPassword.Value = txtPassword.Text;
                cmd.Parameters.Add(paramPassword);

                SqlParameter paramAge = new SqlParameter("@userAge", SqlDbType.Int);
                paramAge.Value = txtAge.Text;
                cmd.Parameters.Add(paramAge);

                SqlParameter paramGender = new SqlParameter("@userGender", SqlDbType.NChar, 10);
                if (rdbtnMale.Checked)
                {
                    paramGender.Value = rdbtnMale.Text;
                }
                if (rdbtnFemale.Checked)
                {
                    paramGender.Value = rdbtnFemale.Text;
                }
                cmd.Parameters.Add(paramGender);

                SqlParameter paramMobile = new SqlParameter("@userMobile", SqlDbType.VarChar, 13);
                paramMobile.Value = txtMobile.Text;
                cmd.Parameters.Add(paramMobile);

                SqlParameter paramUSCallPlan = new SqlParameter("@userUSCallPlan", SqlDbType.NVarChar, 50);
                paramUSCallPlan.Value = cboUSCallPlan.Text;
                cmd.Parameters.Add(paramUSCallPlan);

                cmd.ExecuteNonQuery();

                MetroMessageBox.Show(this, "회원가입이 완료되었습니다.", "환영합니다.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void UpdateCbo()
        {
            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = " SELECT CallingPlan, Company FROM dbo.productTbl";
                SqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }

                cboUSCallPlan.DataSource = new BindingSource(temps, null);
                cboUSCallPlan.DisplayMember = "Key";
                cboUSCallPlan.ValueMember = "Value";
                cboUSCallPlan.SelectedIndex = -1;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            Checking();
        }



        private void Checking()
        {
            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
            {
                conn.Open();
                string strQuery = "SELECT userID FROM userTbl WHERE userID=@userID ";
                SqlCommand command = new SqlCommand(strQuery, conn);
                string temp = "";

                SqlParameter paramUserID = new SqlParameter("@userID", SqlDbType.VarChar, 50);
                paramUserID.Value = txtID.Text;
                command.Parameters.Add(paramUserID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        MetroMessageBox.Show(this, "이미 사용중인 아이디입니다.\n아이디를 확인해 주세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Clear();
                        txtID.Focus();

                    }
                    else
                    {
                        overlapcheck = true;
                        MetroMessageBox.Show(this, "사용 가능한 아이디입니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                }

            }
        }


        //using (SqlConnection conn = new SqlConnection(Commons.strConnString))
        //{
        //    conn.Open();
        //    string strQuery = "SELECT userID FROM userTbl WHERE userID=@userID ";
        //    SqlCommand command = new SqlCommand(strQuery, conn);
        //    string temp = "";

        //    SqlParameter paramUserID = new SqlParameter("@userID", SqlDbType.VarChar, 50);
        //    paramUserID.Value = txtID.Text;
        //    command.Parameters.Add(paramUserID);

        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        if (reader.HasRows)
        //        {
        //            MetroMessageBox.Show(this, "이미 사용중인 아이디입니다.\n아이디를 확인해 주세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtID.Clear();
        //            txtID.Focus();

        //        }
        //        else
        //        {
        //            MetroMessageBox.Show(this, "사용 가능한 아이디입니다.","완료",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //            return;
        //        }


        //    }


        //}


        //private void metroButton1_Click(object sender, EventArgs e)
        //{
        //    using(SqlConnection conn = new SqlConnection(Commons.strConnString))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandText= " SELECT userID FROM userTbl " +
        //                            "WHERE userID = @userID";
        //        string strQuery = " SELECT userID FROM userTbl "+
        //                            "WHERE userID = @userID";
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
        //        SqlParameter newmember = new SqlParameter("@userID", SqlDbType.VarChar, 50);
        //        newmember.Value = txtID.Text;
        //        cmd.Parameters.Add(newmember);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        reader.Read();
        //        string strUserId = reader["userID"] != null ? reader["userID"].ToString() : "";

        //        if (strUserId != "")
        //        {
        //            MetroMessageBox.Show(this, "사용 가능한 아이디입니다.");
        //            this.Close();
        //        }
        //        else
        //        {
        //            MetroMessageBox.Show(this, "사용중인 아이디입니다.","오류",MessageBoxButtons.OK,MessageBoxIcon.Error);

        //        }
        //    }

        //}

        //private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string a="";
        //    //if ("System.Int32" != Type.GetType(txtAge.ToString()))
        //    if(!txtAge.Text.Equals(a))
        //    {
        //        MetroMessageBox.Show(this, "숫자를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtAge.Text = "";

        //    }
        //}

        //private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string a = "";
        //    if(!txtMobile.Text.Equals(a))
        //    {
        //        MetroMessageBox.Show(this, "숫자를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtMobile.Text = "";

        //    }
        //}
    }
}

        

//private void UpdadeData()
//{
//    using (SqlConnection conn = new SqlConnection(Commons.strConnString))
//    {
//        conn.Open();
//        string strQuery = "SELECT  userID, " +
//                          "        userName , " +
//                          "        userPassword , "+
//                          "        userAge, " +
//                          "        userGender , " +
//                          "        userMobile , "+
//                          "        userUSCallPlan " +
//                          "        FROM userTbl ";
//        SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
//        DataSet productlist = new DataSet();
//        dataAdapter.Fill(productlist, "productTbl");

//        cboUSCallPlan.DataSource = productlist;
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace MainForm
//{
//    public partial class NewMemberForm : MetroFramework.Forms.MetroForm
//    {
//        string mode = "";
//        string gender = "";

//        public NewMemberForm()
//        {
//            InitializeComponent();
//        }

//        private void btnCancel_Click(object sender, EventArgs e)
//        {           
//            LoginForm.ActiveForm.Close();
//        }

//        private void btnOK_Click(object sender, EventArgs e)
//        {
//            mode = "INSERT";
//            SaveProcess();
//            UpdadeData();

//        }



//        private void SaveProcess()
//        {
//            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
//            {
//                conn.Open();
//                SqlCommand cmd = new SqlCommand();
//                cmd.Connection = conn;

//                string strQuery = "";

//                if (mode=="INSERT")
//                {
//                    strQuery = " INSERT INTO userTbl(userID , userName, userPassword " +
//                                 " , userAge , userGender , userMobile, userUSCallPlan) " +
//                                  " VALUES (@userID, @userName, @userPassword, @userAge, @userGender, @userMobile, @userUSCallPlan)";
//                }

//                cmd.CommandText = strQuery;
//                SqlParameter paramUserID = new SqlParameter("@userID", SqlDbType.VarChar, 50);
//                paramUserID.Value = txtID.Text;
//                cmd.Parameters.Add(paramUserID);

//                SqlParameter paramName = new SqlParameter("@userName", SqlDbType.NVarChar, 20);
//                paramName.Value = txtName.Text;
//                cmd.Parameters.Add(paramName);

//                SqlParameter paramPassword = new SqlParameter("@userPassword", SqlDbType.VarChar, 50);
//                paramPassword.Value = txtPassword.Text;
//                cmd.Parameters.Add(paramPassword);

//                SqlParameter paramAge = new SqlParameter("@userAge", SqlDbType.Int);
//                paramAge.Value = txtAge.Text;
//                cmd.Parameters.Add(paramAge);

//                SqlParameter paramGender = new SqlParameter("@userGender", SqlDbType.NChar, 10);
//                paramGender.Value = gender;
//                cmd.Parameters.Add(paramGender);

//                SqlParameter paramMobile = new SqlParameter("@userMobile", SqlDbType.VarChar, 13);
//                paramMobile.Value = txtMobile.Text;
//                cmd.Parameters.Add(paramMobile);

//                SqlParameter paramUSCallPlan = new SqlParameter("@userUSCallPlan", SqlDbType.NVarChar, 50);
//                paramUSCallPlan.Value = cboUSCallPlan.Text;
//                cmd.Parameters.Add(paramUSCallPlan);

//                cmd.ExecuteNonQuery();
//            }
//        }


//        private void UpdateCbo()
//        {
//            using(SqlConnection conn=new SqlConnection(Commons.strConnString))
//            {
//                conn.Open();
//                SqlCommand cmd = new SqlCommand();
//                cmd.Connection = conn;
//                cmd.CommandText = " SELECT CallingPlan, Company FROM dbo.productTbl" ;
//                SqlDataReader reader = cmd.ExecuteReader();

//                Dictionary<string, string> temps = new Dictionary<string, string>();
//                while(reader.Read())
//                {
//                    temps.Add(reader[0].ToString(), reader[1].ToString());
//                }

//                cboUSCallPlan.DataSource = new BindingSource(temps, null);
//                cboUSCallPlan.DisplayMember = "Value";
//                cboUSCallPlan.ValueMember = "Key";
//                cboUSCallPlan.SelectedIndex = -1;
//            }
//        }
//        private void NewMemberForm_Load(object sender, EventArgs e)
//        {
//            UpdadeData();
//        }

//        private void UpdadeData()
//        {
//            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
//            {
//                conn.Open();
//                string strQuery = "SELECT  userID, userName , userPassword , userAge " +
//                                    " , userGender , userMobile , userUSCallPlan " +
//                                    " FROM   userTbl ";
//                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
//                DataSet productlist = new DataSet();
//            }
//        }

//        private void metroTextBox3_Click(object sender, EventArgs e)
//        {

//        }

//        private void metroTextBox4_Click(object sender, EventArgs e)
//        {

//        }

//        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
//        {
//            gender = "남자";
//        }

//        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
//        {
//            gender = "여자";
//        }

//        private void cboUSCallPlan_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            UpdateCbo();
//        }
//    }
//}
