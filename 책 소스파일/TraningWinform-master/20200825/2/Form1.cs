using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPcap;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(SharpPcap.Version.VersionString);
            CaptureDeviceList NicList = CaptureDeviceList.Instance;
            MessageBox.Show(NicList.Count.ToString());

            string NicListResult = "";
            foreach(var Temp in NicList)
            {
                NicListResult += (Temp + "\n");
            }
            
            
        }
    }
}
