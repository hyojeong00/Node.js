using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MnuNewFile_Click(object sender, EventArgs e)
        {
            textBox1.Text += MnuNewFile.Text + Environment.NewLine;
            toolStripStatusLabel1.Text = MnuNewFile.Text;
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += 열기OToolStripMenuItem.Text + Environment.NewLine;
        }

        private void 닫기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += 닫기CToolStripMenuItem.Text + Environment.NewLine;
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += 저장SToolStripMenuItem.Text + Environment.NewLine;
            MessageBox.Show("저장했습니다.");
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += 다른이름으로저장AToolStripMenuItem.Text + Environment.NewLine;
        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons)
            {
                contextMenuStrip1.Show(e.Location);
            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            LblMouseLocation.Text = $"(X : Y) = ({e.X}, {e.Y})";
        }


    
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MnuNewFile_Click(sender, e);
        }
    }
}
