using MetroFramework;
using MetroFramework.Forms;
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

namespace BookRentalShop20
{
    public partial class UserForm : MetroForm
    {

        public UserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            UpdateData();

        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                string strQuery = "SELECT id,userID,password,lastLoginDt,loginIpAddr "
                                 + " FROM userTbl"; // Qurey문 수정
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "userTbl"); // userTbl

                GrdUserTbl.DataSource = ds;
                GrdUserTbl.DataMember = "userTbl"; // userTbl
            }

            DataGridViewColumn column = GrdUserTbl.Columns[0]; // id 열
            column.Width = 40; // id열 길이 변경(테이블 열길이)
            column.HeaderText = "순번"; // 열이름 변경
            column = GrdUserTbl.Columns[1]; // userID 열
            column.Width = 80;
            column.HeaderText = "아이디";
            column = GrdUserTbl.Columns[2]; // Password 열
            column.Width = 100;
            column.HeaderText = "패스워드";
            column = GrdUserTbl.Columns[3]; // 최종 접속 시간
            column.Width = 120;
            column.HeaderText = "최종접속시간";
            column = GrdUserTbl.Columns[4]; // 접속 아이피 주소
            column.Width = 150;
            column.HeaderText = "접속아이피주소";

        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // INDEX가 0이상이면
            {
                DataGridViewRow data = GrdUserTbl.Rows[e.RowIndex];
                txtPassword.Text = data.Cells[0].Value.ToString();
                txtUserID.Text = data.Cells[1].Value.ToString();
                txtPassword.ReadOnly = true;
                txtPassword.BackColor = Color.Beige;

                mode = "UPDATE"; // 이름을 수정할 수 있으니 수정모드로 변환
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveProcess();
            UpdateData();
            ClearTextControls();


        }

        private void ClearTextControls()
        {


        }


        string strConnString = "Data Source=127.0.0.1;Initial Catalog=BookRentalShopDB;User ID=sa;Password=p@ssw0rd!";

        string mode = "";
        private void SaveProcess()
        {

            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE userTbl "
                               + " SET userID = @userID,password = @password "
                             + " WHERE id = @id "; // Query문 수정
                }
                else if (mode == "INSERT")
                {
                    strQuery = ""; // Query문 수정
                }

                cmd.CommandText = strQuery;

                SqlParameter parmUserID = new SqlParameter("@userID", SqlDbType.VarChar, 12); // 파라미터 수정
                parmUserID.Value = txtUserID.Text;
                cmd.Parameters.Add(parmUserID);

                SqlParameter parmPassword = new SqlParameter("@password", SqlDbType.VarChar, 20); // 파라미터 수정
                parmPassword.Value = txtPassword.Text;
                cmd.Parameters.Add(parmPassword);

                if (mode == "UPDATE") // UPDATE문의 경우 인자가 하나 더 필요하다(id/순번)
                {
                    SqlParameter parmid = new SqlParameter("@id", SqlDbType.Int); // 파라미터 수정
                    parmid.Value =txtId.Text;
                    cmd.Parameters.Add(parmid);
                }

                cmd.ExecuteNonQuery();

            }



        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserID.Text))
            {
                MetroMessageBox.Show(this, "빈칸은 삭제할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteProcess();
            UpdateData();
            ClearTextControls();
        }

        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM divtbl "
                                + " WHERE Division = @Division"; // 데이터 삭제를 위한 Query문 작성

                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = txtUserID.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();

            }
        }

        private void GrdUserTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdUserTbl.Rows[e.RowIndex];
                txtId.Text = data.Cells[0].Value.ToString();
                txtUserID.Text = data.Cells[1].Value.ToString();
                txtPassword.Text = data.Cells[2].Value.ToString();


                mode = "UPDATE";
            }
        }
    }
}
