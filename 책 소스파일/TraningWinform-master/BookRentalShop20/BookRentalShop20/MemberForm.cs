using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class MemberForm : MetroForm
    {

        public MemberForm()
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
     

        }

        private void UpdateData()
        {
            string strConnstring = "Data Source=127.0.0.1;Initial Catalog=BookRentalShopDB;User ID=sa;Password=p@ssw0rd!";
            //throw new NotImplementedException();
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                string strQuery = "SELECT  Idx , Names, Levels, Addr, Mobile, Email "+
                                    " From membertbl ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "membertbl");

                GrdMemberTbl.DataSource = ds;
                GrdMemberTbl.DataMember = "membertbl";
            }

        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // INDEX가 0이상이면
            {
                DataGridViewRow data = GrdMemberTbl.Rows[e.RowIndex];
                txtNames.Text = data.Cells[0].Value.ToString();
                txtIdx.Text = data.Cells[1].Value.ToString();
                txtNames.ReadOnly = true;
                txtNames.BackColor = Color.Beige;

                mode = "UPDATE"; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddr.Text) || string.IsNullOrEmpty(txtNames.Text)
                 || string.IsNullOrEmpty(txtMobile.Text) || string.IsNullOrEmpty(txtEmail.Text))
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
            txtIdx.Text = txtNames.Text = txtAddr.Text = txtMobile.Text = txtEmail.Text = "";
            txtNames.Text = "";
            txtIdx.Text = "";
            txtNames.ReadOnly = false;
            txtNames.BackColor = Color.White;
            txtNames.Focus();

        }


        string strConnstring = "Data Source=127.0.0.1;Initial Catalog=BookRentalShopDB;User ID=sa;Password=p@ssw0rd!";

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
                    strQuery = "UPDATE  dbo.membertbl " +
                               " SET       Names = @Names " +
                                 "  , Levels = @Levels " +
                                 "  , Addr = @Addr " +
                                 "  , Mobile = @Mobile " +
                                 "  , Email = @Email " +
                                 " WHERE Idx = @Idx ";
                }
                else    if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO  dbo . membertbl (Names, Levels, Addr, Mobile, Email) " +
                             " VALUES (@Names " +
                             " , @Levels " +
                             " , @Addr " +
                             " , @Mobile " +
                             " , @Email )";

                    cmd.CommandText = strQuery;
                }

                SqlParameter paramNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                paramNames.Value = txtNames.Text;
                cmd.Parameters.Add(paramNames);

                SqlParameter paramLevels = new SqlParameter("@Levels", SqlDbType.Char,1);
                paramLevels.Value = CboLevels.SelectedItem;
                cmd.Parameters.Add(paramLevels);

                SqlParameter paramAddr = new SqlParameter("@Addr", SqlDbType.VarChar, 100);
                paramAddr.Value = txtAddr.Text;
                cmd.Parameters.Add(paramAddr);

                SqlParameter paramMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                paramMobile.Value = txtMobile.Text;
                cmd.Parameters.Add(paramMobile);

                SqlParameter paramEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                paramEmail.Value = txtEmail.Text;
                cmd.Parameters.Add(paramEmail);

                if(mode == "UPDATE")
                {
                    SqlParameter paramIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    paramIdx.Value = txtIdx.Text;
                    cmd.Parameters.Add(paramIdx);
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
            if (string.IsNullOrEmpty(txtNames.Text) || string.IsNullOrEmpty(txtIdx.Text))
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
                                + " WHERE Division = @Division"; 

                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = txtNames.Text;
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
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdMemberTbl.Rows[e.RowIndex];
                txtIdx.Text = data.Cells[0].Value.ToString();
                txtNames.Text = data.Cells[1].Value.ToString();
                txtIdx.ReadOnly = true;
                txtIdx.BackColor = Color.Salmon;
                CboLevels.SelectedIndex = CboLevels.FindString(data.Cells[2].Value.ToString());
                txtAddr.Text = data.Cells[3].Value.ToString();
                txtMobile.Text = data.Cells[4].Value.ToString();
                txtEmail.Text = data.Cells[5].Value.ToString();

                mode = "UPDATE";
            }

            
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            UpdateData(); //F12로 바로 같은걸로 찾아갈 수 있음

           
        }

        
        
    }
}
