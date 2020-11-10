using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class AdministrationForm : MetroFramework.Forms.MetroForm
    {
        public AdministrationForm()
        {
            InitializeComponent();
        }

        private void 목록관리LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdListForm form = new AdListForm();
            InitChildForm(form, "목록관리");
        }
        private void InitChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void 회원관리MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdMemberForm form = new AdMemberForm();
            InitChildForm(form, "회원관리");
        }

        private void 통계SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdStatisticsForm form = new AdStatisticsForm();
            InitChildForm(form, "통계");
        }
    }
}

