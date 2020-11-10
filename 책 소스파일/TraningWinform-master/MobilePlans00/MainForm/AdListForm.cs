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
    public partial class AdListForm : MetroFramework.Forms.MetroForm
    {
        string mode = "";
        public AdListForm()
        {
            InitializeComponent();

        }

        private void AdListForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
            {
                conn.Open();
                string strQuery = "SELECT  CallingPlan, Company, Price, Datas, Benefit " +
                                    " FROM productTbl ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet productlist = new DataSet();
                dataAdapter.Fill(productlist, "productTbl");

                GrdProductTbl.DataSource = productlist;
                GrdProductTbl.DataMember = "productTbl";
            }
        }

        private void GrdProductTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdProductTbl.Rows[e.RowIndex];
                txtPlans.Text = data.Cells[0].Value.ToString();
                txtCompany.Text = data.Cells[1].Value.ToString();
                txtPrice.Text = data.Cells[2].Value.ToString();
                txtData.Text = data.Cells[3].Value.ToString();
                txtBenefits.Text = data.Cells[4].Value.ToString();

                mode = "UPDATE";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
            mode = "INSERT";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlans.Text) || string.IsNullOrEmpty(txtCompany.Text)
                || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtData.Text)
                || string.IsNullOrEmpty(txtBenefits.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 저장할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveProcess();
            UpdateData();
        }

        private void ClearText()
        {
            txtPlans.Clear();
            txtPrice.Clear();
            txtData.Clear();
            txtCompany.Clear();
            txtBenefits.Clear();
            txtPlans.Focus();
        }

        private void SaveProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE  dbo.productTbl " +
                             " SET  CallingPlan = @CallingPlan, Company = @Company, Price = @Price, " +
                             " Datas = @Datas, Benefit = @Benefit " +
                             " WHERE CallingPlan = @CallingPlan";
                }
                else
                {
                    strQuery = "INSERT INTO  productTbl " +
                                " (CallingPlan, Company, Price, Datas, Benefit) " +
                                " VALUES (@CallingPlan, @Company, @Price, @Datas, @Benefit) ";
                }

                cmd.CommandText = strQuery;
                SqlParameter paramPlans = new SqlParameter("@CallingPlan", SqlDbType.NVarChar, 50);
                paramPlans.Value = txtPlans.Text;
                cmd.Parameters.Add(paramPlans);

                SqlParameter paramCompany = new SqlParameter("@Company", SqlDbType.NVarChar, 20);
                paramCompany.Value = txtCompany.Text;
                cmd.Parameters.Add(paramCompany);

                SqlParameter paramPrice = new SqlParameter("@Price", SqlDbType.NVarChar, 20);
                paramPrice.Value = txtPrice.Text;
                cmd.Parameters.Add(paramPrice);

                SqlParameter paramData = new SqlParameter("@Datas", SqlDbType.NVarChar, 10);
                paramData.Value = txtData.Text;
                cmd.Parameters.Add(paramData);

                SqlParameter paramBenefit = new SqlParameter("@Benefit", SqlDbType.NVarChar, 50);
                paramBenefit.Value = txtBenefits.Text;
                cmd.Parameters.Add(paramBenefit);

                cmd.ExecuteNonQuery();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlans.Text) || string.IsNullOrEmpty(txtCompany.Text)
                || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtData.Text)
                || string.IsNullOrEmpty(txtBenefits.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 삭제할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DeleteProcess();
            UpdateData();
            ClearText();
        }

        private void DeleteProcess()
        {
            using(SqlConnection conn=new SqlConnection(Commons.strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM productTbl " +
                                " WHERE CallingPlan = @CallingPlan ";

                SqlParameter paramPlans = new SqlParameter("@CallingPlan", SqlDbType.NVarChar, 50);
                paramPlans.Value = txtPlans.Text;
                cmd.Parameters.Add(paramPlans);

                SqlParameter paramCompany = new SqlParameter("@Company", SqlDbType.NVarChar, 20);
                paramCompany.Value = txtCompany.Text;
                cmd.Parameters.Add(paramCompany);

                SqlParameter paramPrice = new SqlParameter("@Price", SqlDbType.NVarChar, 20);
                paramPrice.Value = txtPrice.Text;
                cmd.Parameters.Add(paramPrice);

                SqlParameter paramData = new SqlParameter("@Datas", SqlDbType.NVarChar, 10);
                paramData.Value = txtData.Text;
                cmd.Parameters.Add(paramData);

                SqlParameter paramBenefit = new SqlParameter("@Benefit", SqlDbType.NVarChar, 50);
                paramBenefit.Value = txtBenefits.Text;
                cmd.Parameters.Add(paramBenefit);

                cmd.ExecuteNonQuery();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
