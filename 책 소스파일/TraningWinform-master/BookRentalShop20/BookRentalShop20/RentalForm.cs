using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class RentalForm : MetroForm
    {

        public RentalForm()
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
            //string strConnstring = "Data Source=127.0.0.1;Initial Catalog=BookRentalShopDB;User ID=sa;Password=p@ssw0rd!";
            //throw new NotImplementedException();
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                string strQuery = "SELECT r.idx AS '대여번호', m.Names AS '대여회원', "
                                  + " t.Names AS '장르', "
                                    + " b.Names AS '대여책제목'  ,b.ISBN, "
                                      + " r.rentalDate AS '대여일' , r.returnDate AS '반납일'"
                                 + " FROM rentaltbl AS r "
                                + " INNER JOIN membertbl AS m "
                                   + " ON r.memberIdx = m.Idx "
                                + " INNER JOIN bookstbl AS b "
                                   + " ON r.bookIdx = b.Idx "
                                + " INNER JOIN divtbl AS t "
                                  + " ON b.division = t.division";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "rentaltbl");

                GrdRentalTbl.DataSource = ds;
                GrdRentalTbl.DataMember = "rentaltbl";
            }
            DataGridViewColumn column = GrdRentalTbl.Columns[2]; // id 열
            column.Visible = false;

        }

        private void GrdRentalTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // INDEX가 0이상이면
            {
                DataGridViewRow data = GrdRentalTbl.Rows[e.RowIndex];
                txtIdx.Text = data.Cells[0].Value.ToString();
                if ((data.Cells == null) || (data.Cells.Count == 0))
                {
                    return;
                }

                CboMemberIdx.Text = CboMemberIdx.FindString(data.Cells[1].Value.ToString());
                txtIdx.ReadOnly = true;
                txtIdx.BackColor = Color.Salmon;
                CboBookIdx.SelectedIndex = CboBookIdx.FindString(data.Cells[2].Value.ToString());
                dtpRentalDate.CustomFormat = "yyyy-MM-dd";
                dtpRentalDate.Format = DateTimePickerFormat.Custom;
                dtpReturnDate.CustomFormat = "yyyy-MM-dd";
                dtpReturnDate.Format = DateTimePickerFormat.Custom;


                mode = "UPDATE";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CboMemberIdx.Text) || string.IsNullOrEmpty(CboBookIdx.Text)
                 || string.IsNullOrEmpty(dtpRentalDate.Text) || string.IsNullOrEmpty(dtpReturnDate.Text))
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
            txtIdx.Text = CboMemberIdx.Text = CboBookIdx.Text = string.Empty;
            CboMemberIdx.SelectedIndex = 1;
            CboBookIdx.SelectedIndex = 1;
            txtIdx.ReadOnly = true;
            txtIdx.BackColor = Color.Salmon;
            dtpRentalDate.CustomFormat = " ";
            dtpRentalDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.CustomFormat = " ";
            dtpReturnDate.Format = DateTimePickerFormat.Custom;

            CboMemberIdx.Focus();

        }


        //string strConnstring = "Data Source=127.0.0.1;Initial Catalog=BookRentalShopDB;User ID=sa;Password=p@ssw0rd!";

        string mode = "INSERT";
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

                string strQuery = string.Empty;

                if (mode == "UPDATE")
                {
                    strQuery = "SET  memberIdx  = @memberIdx, bookIdx  = @bookIdx, " +
                                " rentalDate = @rentalDate, returnDate = @returnDate" +
                                    "WHERE Idx = @Idx ";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO  dbo . rentaltbl( memberIdx , bookIdx , rentalDate , returnDate ) " +
                                 " VALUES(@memberIdx, @bookIdx, @rentalDate, @returnDate) ";
                }
                cmd.CommandText = strQuery;

                SqlParameter paramBookIdx = new SqlParameter("@BookIdx", SqlDbType.Int);
                paramBookIdx.Value = CboBookIdx.Text;
                cmd.Parameters.Add(paramBookIdx);

                SqlParameter paramMemberIdx = new SqlParameter("@MemberIdx", SqlDbType.Int);
                paramMemberIdx.Value = CboMemberIdx.Text;
                cmd.Parameters.Add(paramMemberIdx);

                SqlParameter paramRentalDate = new SqlParameter("@RentalDate", SqlDbType.Date);
                paramRentalDate.Value = dtpRentalDate.Text;
                cmd.Parameters.Add(paramRentalDate);

                SqlParameter paramReturnDate = new SqlParameter("@ReturnDate", SqlDbType.Date);
                paramBookIdx.Value = dtpReturnDate.Text;
                cmd.Parameters.Add(paramReturnDate);

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
            if (string.IsNullOrEmpty(CboMemberIdx.Text) || string.IsNullOrEmpty(CboBookIdx.Text))
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
                parmDivision.Value = CboMemberIdx.Text;
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

        private void GrdBooksTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtIdx.Text = CboMemberIdx.Text = CboBookIdx.Text = string.Empty;
                CboMemberIdx.SelectedIndex = 1;
                CboBookIdx.SelectedIndex = 1;
                txtIdx.ReadOnly = true;
                txtIdx.BackColor = Color.Salmon;
                dtpRentalDate.CustomFormat = " ";
                dtpRentalDate.Format = DateTimePickerFormat.Custom;
                dtpReturnDate.CustomFormat = " ";
                dtpReturnDate.Format = DateTimePickerFormat.Custom;

                CboMemberIdx.Focus();

                mode = string.Empty;
            }


        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            UpdateData(); //F12로 바로 같은걸로 찾아갈 수 있음
            UpdateCboBookIdx();
        }

        private void UpdateCboBookIdx()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT BookIdx, Names FROM divtbl ";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboBookIdx.DataSource = new BindingSource(temps, null);
                CboBookIdx.DisplayMember = "Value";
                CboBookIdx.ValueMember = "Key";
                CboBookIdx.SelectedIndex = 1;

            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextControls();
        }

        private void dtpReturnDate_ValueChanged_1(object sender, EventArgs e)
        {
            dtpReturnDate.CustomFormat = "yyyy-MM-dd";
            dtpReturnDate.Format = DateTimePickerFormat.Custom;
        }

        private void dtpRentalDate_ValueChanged(object sender, EventArgs e)
        {
            dtpRentalDate.CustomFormat = "yyyy-MM-dd";
            dtpRentalDate.Format = DateTimePickerFormat.Custom;
        }
    }

}
