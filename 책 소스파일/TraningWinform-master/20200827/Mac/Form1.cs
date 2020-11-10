using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using SharpPcap;
using System.Text;
using System.Runtime.Remoting.Channels;
using System.Linq;

namespace Mac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(240,220,202);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> NicName = new List<string>();
            foreach (ICaptureDevice Temp in CaptureDeviceList.Instance)
            {
                string[] arrTemp = Temp.ToString().Split('\n');
                NicName.Add(arrTemp[1].Substring("FriendlyName: ".Length));
            }

            for (int iTemp = 0; iTemp < NicName.Count; ++iTemp)
            {
                Button aButton = new Button();
                aButton.Text = NicName[iTemp];
                aButton.Name = "Facto" + iTemp;
                aButton.Location = new Point(30, 30 + iTemp * 30);
                aButton.Click += new EventHandler(Facto_Click);
                Controls.Add(aButton);
            }

            (sender as Button).Enabled = false;
        }


        private void Print_MAC(byte[] EtherData)
        {
            Label aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Destination MAC";
            aLabel.Name = "LabelDMAC";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 30);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Source MAC";
            aLabel.Name = "LabelSMAC";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 60);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Next Protocol";
            aLabel.Name = "LabelProto";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 90);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            string data1 = string.Format("{0:X2}", EtherData[0]);
            for (int iTemp = 1; iTemp < 6; ++iTemp)
            {
                data1 += string.Format("-{0:X2}", EtherData[iTemp]);
            }
            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = data1;
            aLabel.Name = "LabelDMACData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 30);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------


            string data2 = string.Format("{0:X2}", EtherData[6]);
            for (int iTemp = 7; iTemp < 12; ++iTemp)
            {
                data2 += string.Format("-{0:X2}", EtherData[iTemp]);
            }
            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = data2;
            aLabel.Name = "LabelSMACData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 60);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            int iNum = BitConverter.ToInt16(EtherData.Skip<byte>(12).Take(2).Reverse<byte>().ToArray(), 0);

            switch (iNum)
            {
                case 0x0200:
                    data2 = "Xerox PUP";
                    break;
                case 0x0500:
                    data2 = "Sprite";
                    break;
                case 0x0800:
                    data2 = "IP";
                    break;
                case 0x0806:
                    data2 = "Address resolution";
                    break;
                case 0x8035:
                    data2 = "Reverse ARP";
                    break;
                case 0x809B:
                    data2 = "AppleTalk protocol";
                    break;
                case 0x80F3:
                    data2 = "AppleTalk ARPP";
                    break;
                case 0x8100:
                    data2 = "IEEE 802.1Q VLAN taggingP";
                    break;
                case 0x8137:
                    data2 = "IPX";
                    break;
                case 0x86dd:
                    data2 = "IP protocol version 6";
                    break;
                case 0x9000:
                    data2 = "used to test interfaces";
                    break;



                default:
                    break;
            }
            aLabel.Text = data2;          
            aLabel.Name = "LabelProtoData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 90);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);
        }

        //-------------------------


        private int Del_Button_Device(object sender)
        {
            int DeviceNum = Convert.ToInt32((sender as Button).Name.Substring("Facto".Length));
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);

            for (int iTemp = 0; iTemp < CaptureDeviceList.Instance.Count; ++iTemp)
            {
                foreach (Control Temp in Controls)
                {
                    if (Temp.Name == ("Facto" + iTemp))
                    {
                        Controls.Remove(Temp);
                    }
                }
            }
            return DeviceNum;
        }

        //-------------------------

        private void Print_IP(byte[] IPData)
        {
            Label aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Version";
            aLabel.Name = "LabelIPV";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 120);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Head Length";
            aLabel.Name = "LabelIPHL";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 150);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            byte byteTemp = IPData[14];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IPv"+(byteTemp>>4).ToString();
            aLabel.Name = "LabelIPVData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 120);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = ((byteTemp & 0x0F)*4).ToString()+" Bytes";
            aLabel.Name = "LabelIPHLData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 150);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP TOS";
            aLabel.Name = "LabelIPTOS";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 180);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            byteTemp = IPData[15];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = string.Format("0x{0:x2}",byteTemp);
            aLabel.Name = "LabelIPTOSData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 180);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Total Length";
            aLabel.Name = "LabelIPTL";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 210);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            int iNum= BitConverter.ToInt16(IPData.Skip<byte>(16).Take(2).Reverse().ToArray(),0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = iNum.ToString()+" Bytes";
            aLabel.Name = "LabelIPTLData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 210);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP IDentification";
            aLabel.Name = "LabelID";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 240);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            iNum = BitConverter.ToInt16(IPData.Skip<byte>(18).Take(2).Reverse().ToArray(), 0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = iNum.ToString();
            aLabel.Name = "LabelIPIDData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 240);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Fragment DF";
            aLabel.Name = "LabelFDF";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 280);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            iNum = BitConverter.ToInt16(IPData.Skip<byte>(20).Take(2).Reverse().ToArray(), 0);
          
            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = (0 !=(iNum & (1<<14))).ToString();
            aLabel.Name = "LabelFDFData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 280);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Fragment MF";
            aLabel.Name = "LabelFMF";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 305);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            iNum = BitConverter.ToInt16(IPData.Skip<byte>(20).Take(2).Reverse().ToArray(), 0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = (0 != (iNum & (1 << 13))).ToString();
            aLabel.Name = "LabelFMFData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 305);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Fragment offset";
            aLabel.Name = "LabelFoffset";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 330);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = (iNum&0x1FFF).ToString();
            aLabel.Name = "LabelFoffsetData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 330);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Time To Live";   
            //<TTL>
            //수명, 최대숫자는 255, 하나의 라우터를 통과할때마다 1씩 차감
            //트래픽이 영원히 가지 않도록 방지하는 것
            //핑을 때려도 ttl이 나옴
            //보통 100언저리로 설정
            //너무 큰 숫자로 설정하면 트래픽이 많아짐
            aLabel.Name = "LabelIPTTL";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 370);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            byteTemp = IPData[22];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = byteTemp.ToString();
            aLabel.Name = "LabelTTLData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 370);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            //-------------------------

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "L3 Protocol";
            aLabel.Name = "LabelProtocol";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 400);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "";
            aLabel.Name = "LabelFoffsetData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 400);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

        }
        private void Facto_Click(object sender, EventArgs e)
        {
            Del_Button_Device(sender);
            int DeviceNum = Convert.ToInt32((sender as Button).Name.Substring("Facto".Length));
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);
            RawCapture aRawCapture = CaptureDeviceList.Instance[DeviceNum].GetNextPacket();
            Print_MAC(aRawCapture.Data);
            Print_IP(aRawCapture.Data);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> NicName = new List<string>();
            foreach (ICaptureDevice Temp in CaptureDeviceList.Instance)
            {
                string[] arrTemp = Temp.ToString().Split('\n');
                NicName.Add(arrTemp[1].Substring("FriendlyName: ".Length));
            }

            for (int iTemp = 0; iTemp < NicName.Count; ++iTemp)
            {
                Button aButton = new Button();
                aButton.Text = NicName[iTemp];
                aButton.Name = "Facto" + iTemp;
                aButton.Location = new Point(30, 30 + iTemp * 30);
                aButton.Click += new EventHandler(Facto_Click);
                Controls.Add(aButton);
            }

            (sender as Button).Enabled = false;
        }
    }
}
