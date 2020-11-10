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
    public partial class BooksForm : MetroForm
    {

        public BooksForm()
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
                string strQuery = "SELECT  b.Idx , b.Author , b.Division , "+
                                " d.Names AS 'DivNames', b.Names , b.ReleaseDate , b.ISBN , "+
                                " REPLACE(CONVERT(varchar, CONVERT(money, b.price), 1), '.00', '') AS price "+
                                " FROM dbo.bookstbl AS b " +
                                " INNER JOIN dbo.divtbl AS d " +
                                " ON b.Division=d.Division ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "bookstbl");

                GrdBooksTbl.DataSource = ds;
                GrdBooksTbl.DataMember = "bookstbl";
            }
            DataGridViewColumn column = GrdBooksTbl.Columns[2]; // id 열
            column.Visible = false;

        }

        private void GrdBooksTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // INDEX가 0이상이면
            {
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];
                txtIdx.Text = data.Cells[0].Value.ToString();
                txtAuthor.Text = data.Cells[1].Value.ToString();
                txtIdx.ReadOnly = true;
                txtIdx.BackColor = Color.Salmon;
                //CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[3].Value.ToString());
                CboDivision.SelectedValue = data.Cells[2].Value;
                txtNames.Text = data.Cells[4].Value.ToString();
                dtpReleaseDate.CustomFormat = "yyyy-MM-dd";
                dtpReleaseDate.Format = DateTimePickerFormat.Custom;
                txtISBN.Text = data.Cells[6].Value.ToString();
                txtPrice.Text = data.Cells[7].Value.ToString();

                mode = "UPDATE"; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNames.Text) || string.IsNullOrEmpty(txtAuthor.Text)
                 || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtISBN.Text)
                 || string.IsNullOrEmpty(dtpReleaseDate.Text) || string.IsNullOrEmpty(CboDivision.Text))
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
            txtIdx.Text = txtAuthor.Text = txtNames.Text = txtPrice.Text = txtISBN.Text = "";
            txtPrice.Text = "";
            CboDivision.SelectedIndex = -1;
            txtIdx.ReadOnly = true;
            txtIdx.BackColor = Color.Salmon;
            dtpReleaseDate.CustomFormat = " ";
            dtpReleaseDate.Format = DateTimePickerFormat.Custom;

            txtAuthor.Focus();

        }


        //string strConnstring = "Data Source=127.0.0.1;Initial Catalog=BookRentalShopDB;User ID=sa;Password=p@ssw0rd!";

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
                    strQuery = "UPDATE  dbo.bookstbl " +
                                   " SET  Author = @Author " +
                                   " , Division = @Division " +
                                   " , Names = @Names " +
                                   " , ReleaseDate = @ReleaseDate " +
                                   " , ISBN = @ISBN " +
                                   " , Price = @Price "+
                                   " WHERE Idx = @Idx ";
                }
                else    if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO  dbo . bookstbl( Author , Division , Names , ReleaseDate , ISBN , Price ) "+
                                 "VALUES ( @Author, @Division, @Names, @ReleaseDate, @ISBN, @Price) ";
                }
                cmd.CommandText = strQuery;

                SqlParameter paramAuthor = new SqlParameter("@Author", SqlDbType.VarChar, 45);
                paramAuthor.Value = txtAuthor.Text;
                cmd.Parameters.Add(paramAuthor);

                SqlParameter paramDivision = new SqlParameter("@Division", SqlDbType.Char,4);
                paramDivision.Value = CboDivision.SelectedValue;
                cmd.Parameters.Add(paramDivision);

                SqlParameter paramNames = new SqlParameter("@Names", SqlDbType.VarChar, 100);
                paramNames.Value = txtNames.Text;
                cmd.Parameters.Add(paramNames);

                SqlParameter paramReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                paramReleaseDate.Value = dtpReleaseDate.Value;
                cmd.Parameters.Add(paramReleaseDate);

                SqlParameter paramISBN = new SqlParameter("@ISBN", SqlDbType.VarChar, 200);
                paramISBN.Value = txtISBN.Text;
                cmd.Parameters.Add(paramISBN);

                SqlParameter paramPrice = new SqlParameter("@Price", SqlDbType.Decimal, 10);
                paramPrice.Value = txtPrice.Text;
                cmd.Parameters.Add(paramPrice);

                if (mode == "UPDATE")
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
            if (string.IsNullOrEmpty(txtAuthor.Text) || string.IsNullOrEmpty(txtIdx.Text))
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
                parmDivision.Value = txtAuthor.Text;
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
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];
                txtIdx.Text = data.Cells[0].Value.ToString();
                txtAuthor.Text = data.Cells[1].Value.ToString();
                txtIdx.ReadOnly = true;
                txtIdx.BackColor = Color.Salmon;
                //CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[3].Value.ToString());
                CboDivision.SelectedValue = data.Cells[2].Value;
                txtNames.Text = data.Cells[4].Value.ToString();
                dtpReleaseDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());
                txtISBN.Text = data.Cells[6].Value.ToString();
                txtPrice.Text = data.Cells[7].Value.ToString();

                mode = "UPDATE";
            }

            
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            UpdateData(); //F12로 바로 같은걸로 찾아갈 수 있음
            UpdateCboDivision();
        }

        private void UpdateCboDivision()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Division, Names FROM divtbl ";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "Value";
                CboDivision.ValueMember = "Key";
                CboDivision.SelectedIndex = -1;

            }
        }

        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            dtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            dtpReleaseDate.Format = DateTimePickerFormat.Custom;
        }
    }
    
}
