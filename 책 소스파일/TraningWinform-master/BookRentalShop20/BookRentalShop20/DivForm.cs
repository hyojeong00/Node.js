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
    public partial class DivForm : MetroForm
    {

        public DivForm()
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
            string strConnstring = "Data Source=127.0.0.1;Initial Catalog=BookRentalShopDB;User ID=sa;Password=p@ssw0rd!";
            //throw new NotImplementedException();
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                string strQuery = "SELECT Division, Names FROM divtbl";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "divtbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "divtbl";
            }

        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // INDEX가 0이상이면
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                txtDivision.Text = data.Cells[0].Value.ToString();
                txtNames.Text = data.Cells[1].Value.ToString();
                txtDivision.ReadOnly = true;
                txtDivision.BackColor = Color.Beige;

                mode = "UPDATE"; // 이름을 수정할 수 있으니 수정모드로 변환
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDivision.Text) || string.IsNullOrEmpty(txtNames.Text))
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
            txtDivision.Text = "";
            txtNames.Text = "";
            txtDivision.ReadOnly = false;
            txtDivision.BackColor = Color.White;
            txtDivision.Focus();

        }


        string strConnString = "Data Source=127.0.0.1;Initial Catalog=BookRentalShopDB;User ID=sa;Password=p@ssw0rd!";

        string mode = "";
        private void SaveProcess()
        {

            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//경고창에서 OK버튼을 누르면 DivForm으로 복귀한다.
            }

            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE divtbl "
                               + " SET Names = @Names "
                             + " WHERE Division = @Division";
                }
                else // 신규 데이터를 추가하는 경우
                {
                    strQuery = "INSERT INTO divtbl(Division, Names) "
                           + " VALUES(@Division, @Names)"; // 신규데이터 추가를 위한 Query문 작성
                }

                cmd.CommandText = strQuery;

                SqlParameter paramDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                paramDivision.Value = txtDivision.Text;
                cmd.Parameters.Add(paramDivision);

                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                parmNames.Value = txtNames.Text;
                cmd.Parameters.Add(parmNames);

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
            if (string.IsNullOrEmpty(txtDivision.Text) || string.IsNullOrEmpty(txtNames.Text))
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
                parmDivision.Value = txtDivision.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();

            }
        }

        private void txtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, new EventArgs());
            }
        }

        private void GrdDivTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
            
            txtNames.Text = data.Cells[1].Value.ToString();
            txtNames.ReadOnly = true;
            txtNames.BackColor = Color.Salmon;           
        }
    }
}
