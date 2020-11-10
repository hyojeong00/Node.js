using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;

        private void 구분코드관리DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DivForm form = new DivForm();
            form.Text = "구분코드관리";
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;                                              // Divform의 부모는 MainForm(this) 여기는 MainForm 코드이기 때문이다.
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }
    }
    
}
