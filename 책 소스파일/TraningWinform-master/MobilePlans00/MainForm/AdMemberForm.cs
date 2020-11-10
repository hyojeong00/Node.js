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
    public partial class AdMemberForm : MetroFramework.Forms.MetroForm
    {
        public AdMemberForm()
        {
            InitializeComponent();
        }

        private void AdMemberForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.strConnString))
            {
                conn.Open();
                string strQuery = "SELECT  userID , userName " +
                                     ", userAge , userGender , userMobile , userUSCallPlan " +
                                        " FROM  userTbl";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet memberlist = new DataSet();
                dataAdapter.Fill(memberlist, "userTbl");

                GrdUserTbl.DataSource = memberlist;
                GrdUserTbl.DataMember = "userTbl";
            }
        }

        private void GrdUserTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) 
            {
                DataGridViewRow data = GrdUserTbl.Rows[e.RowIndex];
                txtName.Text = data.Cells[0].Value.ToString();
                txtID.Text = data.Cells[1].Value.ToString();
                txtAge.Text = data.Cells[2].Value.ToString();
                txtGender.Text = data.Cells[3].Value.ToString();
                txtMobile.Text = data.Cells[4].Value.ToString();
                txtUsePlan.Text = data.Cells[5].Value.ToString();
                txtUsePlan.BackColor = Color.Aqua;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtGender.Clear();
            txtID.Clear();
            txtMobile.Clear();
            txtName.Clear();
            txtUsePlan.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
