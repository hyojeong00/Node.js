using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace make_game
{
    public partial class Form1 : Form
    {
        int[] intArray;
        int score;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(168, 245, 222);
        }

        private void Init()
        {
            Random aRandom = new Random();
            intArray = new int[3] { 100, 100, 100 };

            for (int Count = 0; Count < intArray.Length; ++Count)
            {
                int iTemp = aRandom.Next(0, 10);

                int Count2;
                for (Count2 = 0; Count2 < intArray.Length; ++Count2)
                {
                    if (iTemp == intArray[Count2])
                    {
                        break;
                    }
                }
                if (Count2 < intArray.Length)
                {
                    --Count;
                    continue;
                }
                intArray[Count] = iTemp;
            }

            lblRand1.Text = intArray[0].ToString();
            lblRand2.Text = intArray[1].ToString();
            lblRand3.Text = intArray[2].ToString();

            score = 0;
            lblCount.Text = score.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            int[] inputArray = new int[intArray.Length];
            int strikeCount = 0;
            int ballCount = 0;

            inputArray[0] = Convert.ToInt32(txtInput1.Text);
            inputArray[1] = Convert.ToInt32(txtInput2.Text);
            inputArray[2] = Convert.ToInt32(txtInput3.Text);

            for (int Count1 = 0; Count1 < intArray.Length; ++Count1)
            {
                for (int Count2 = 0; Count2 < intArray.Length; ++Count2)
                {
                    if (inputArray[Count1] == intArray[Count2]) // 숫자 비교
                    {
                        if (Count1 == Count2) // 위치 비교
                        {
                            //MessageBox.Show("스트라이크");
                            ++strikeCount;
                        }
                        else
                        {
                            //MessageBox.Show("볼");
                            ++ballCount;
                        }
                        break;
                    }
                }
            }
            lblStrike.Text = strikeCount.ToString();
            lblBall.Text = ballCount.ToString();
            ++score;
            lblCount.Text = score.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Init();
            lblStrike.Text = "0";
            lblBall.Text = "0";
            txtInput1.Clear();
            txtInput2.Clear();
            txtInput3.Clear();
        }
    }
}