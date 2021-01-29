using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraTab;
using System.Collections.Concurrent;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Configuration;
using System.Xml;
using System.IO;
namespace Test2A
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private AISTest mAISTest;
        private ACARS_Test mACARS_Test;
        IntPtr indata = Marshal.AllocHGlobal(300);
        IntPtr outdata = Marshal.AllocHGlobal(300);
        public static ConcurrentQueue<byte[]> cardQueue = new ConcurrentQueue<byte[]>();
        public static ConcurrentQueue<byte[]> CureQueue = new ConcurrentQueue<byte[]>();
        Thread AISACARSDataProc;
        /*************************
         * AIS 显示参数
         * **********************/
        public static bool isStart_AIS = false;
        public static string AISchannel;               //通道号   
        public static int AISRecvNum = 0;              //总帧数
        public static int AISErrorNum = 0;             //误帧数
        public static UInt64 AISRecvBit = 0;           //总码数
        public static UInt64 AISErrorBit = 0;             //误码数
        public static double AISErrorBitRate = 0;      //误码率
        public static double AISErrorRate = 0;         //误帧率
        public static string AISString = "01111110001000000000000010110000000010010001110000000000000000100101100010011000001001010001110101101000011010011100000100000011000000000000000000000000000000000000000000000000100011101101100101111110";
        public static string AISRevString;
        /*************************
         * ACARS 显示参数
         * **********************/
        public static bool isStart_ACARS = false;
        public static string ACARSchannel;               //通道号   
        public static int ACARSRecvNum = 0;              //总帧数
        public static int ACARSErrorNum = 0;             //误帧数
        public static UInt64 ACARSRecvBit = 0;           //总码数
        public static UInt64 ACARSErrorBit = 0;             //误码数
        public static double ACARSErrorBitRate = 0;      //误码率
        public static double ACARSErrorRate = 0;         //误帧率

        public static string ACARSString = "10000000101010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101101101011011010110110101111000001001000001111000011111110";
        public static string ACARSRevString;

        public static SaveTXT savetxt1 = new SaveTXT();
        public static SaveTXT savetxt2 = new SaveTXT();

        //文件存储类
        public TcpServer tcpServer = null;

        public Form1()
        {
            InitializeComponent();
            AISSelect.Items.Add("AIS1");
            AISSelect.Items.Add("AIS2");
            ACARSSelect.Items.Add("ACARS1");
            ACARSSelect.Items.Add("ACARS2");
            ACARSSelect.Items.Add("ACARS3");
            ACARSSelect.Items.Add("ACARS4");
            
            //启动处理线程
            AISACARSDataProc = new Thread(AISACARSDataProcFun);
            AISACARSDataProc.IsBackground = true;
            AISACARSDataProc.Name = "AISACARSDataProc";
            AISACARSDataProc.Start();
            InfoInit();
            GetHostAddress();
            this.FormClosing += Form1_FormClosing;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(tcpServer != null)
                tcpServer.StopRunning();
        }
        public int ByteRevser(int data)
        {
            return (int)(((data & 0xff) << 24) + ((data & 0xff00) << 8) + ((data & 0xff0000) >> 8) + ((data & 0xff000000) >> 24));
        }
        public void AISACARSDataProcFun()
        {
            byte[] data = new byte[1024];
           
            while (true)
            {
                try
                {
                    if (cardQueue.IsEmpty != true)
                    {
                        byte[] SaveBuffer;
                        cardQueue.TryDequeue(out SaveBuffer);
                        if (SaveBuffer[127] == 0x01 || SaveBuffer[127] == 0x02)
                        {
                            if (SaveBuffer[128] == 'A')//AIS数据信息
                            {
                                savetxt1.PushData(SaveBuffer);
                                if (SaveBuffer[129] == '1')
                                {
                                    AISchannel = "AIS1";
                                }
                                else if (SaveBuffer[129] == '2')
                                {
                                    AISchannel = "AIS2";
                                }
                                else
                                {
                                    continue;
                                }
                                int Datalen = (int)((SaveBuffer[111 + 63] << 8) + SaveBuffer[111 + 64]);
                                byte[] CompareBuffer = new byte[Datalen];
                                Array.Copy(SaveBuffer, 111 + 65, CompareBuffer, 0, Datalen);
                                AISRevString = ByteArrayToString_2(CompareBuffer).Trim();
                                int errorbit = CompareCode(AISString, AISRevString);
                                AISErrorBit = AISErrorBit + (UInt64)errorbit;
                                AISRecvBit = AISRecvBit + 200;
                                AISErrorBitRate = (double)((double)AISErrorBit / (double)AISRecvBit);
                                AISRecvNum++;
                                if (errorbit != 0)
                                {
                                    AISErrorNum++;
                                    Console.WriteLine("Error Datalen : " + Datalen + " @@ Error Data : " + AISRevString);
                                }
                                AISErrorRate = (double)((double)AISErrorNum / (double)AISRecvNum);
                            }
                            else if (SaveBuffer[128] == 'C')
                            {
                                savetxt2.PushData(SaveBuffer);
                                switch (SaveBuffer[129])
                                {
                                    case (byte)'3':
                                        ACARSchannel = "ACARS1";
                                        break;
                                    case (byte)'4':
                                        ACARSchannel = "ACARS2";
                                        break;
                                    case (byte)'5':
                                        ACARSchannel = "ACARS3";
                                        break;
                                    case (byte)'6':
                                        ACARSchannel = "ACARS4";
                                        break;
                                    default: break;
                                }
                                int Datalen = (int)((SaveBuffer[111 + 63] << 8) + SaveBuffer[111 + 64]);
                                byte[] CompareBuffer = new byte[Datalen];
                                Array.Copy(SaveBuffer, 111 + 65, CompareBuffer, 0, Datalen);
                                ACARSRevString = ByteArrayToString_2(CompareBuffer).Trim();
                                int errorbit = CompareCode(ACARSString, ACARSRevString);
                                ACARSErrorBit = ACARSErrorBit + (UInt64)errorbit;
                                ACARSRecvBit = ACARSRecvBit + 1640;
                                ACARSErrorBitRate = (double)((double)ACARSErrorBit / (double)ACARSRecvBit);
                                ACARSRecvNum++;
                                if (errorbit != 0)
                                {
                                    ACARSErrorNum++;
                                }
                                ACARSErrorRate = (double)((double)ACARSErrorNum / (double)ACARSRecvNum);
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(50);
                    }
                }
                catch (System.Exception ex)
                {
                    ErrorRecord.ProcessError(ex.ToString());
                }
            }
        }
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                IXtraTabPage CheckPage = this.xtraTabControl1.SelectedTabPage;
                if (CheckPage.Text == "AIS/ACARS参数设置")
                {
                    this.xtraTabControl1.SelectedTabPage.PageVisible = false;
                }
                else if (CheckPage.Text == "AIS误码性能测试")
                {
                    this.xtraTabControl1.SelectedTabPage.PageVisible = false;
                }
                else
                {
                    this.xtraTabControl1.SelectedTabPage.PageVisible = false;
                }

            }
            catch (System.Exception ex)
            {

            }
        }
        //是否存在标签页XtraTabPage
        private bool IsTabControlExistPage(string name, out XtraTabPage page)
        {
            page = null;
            foreach (XtraTabPage tmp in xtraTabControl1.TabPages)
            {
                if (tmp.Text == name)
                {
                    page = tmp;
                    return true;
                }
            }
            return false;
        }
        //TabControl增加页签
        private void AddPage(XtraTabControl FTabControl, string PageName, Control NewPageControl)
        {
            try
            {
                bool IsPageExist = false;
                XtraTabPage tempPage = null;  //保存已经存在的Page
                foreach (XtraTabPage item in FTabControl.TabPages)
                {
                    if (item.Text == PageName)
                    {
                        IsPageExist = true;
                        tempPage = item;
                        break;
                    }
                }

                if (!IsPageExist)
                {
                    XtraTabPage NewPage = FTabControl.TabPages.Add(PageName);
                    NewPage.Name = PageName;
                    NewPage.Controls.Add(NewPageControl);
                    FTabControl.SelectedTabPage = NewPage;
                }
                else
                {
                    FTabControl.SelectedTabPage = tempPage;
                }
            }
            catch (System.Exception ex)
            {
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string pageName = barButtonItem3.Caption;
                XtraTabPage page = null;
                bool flag = IsTabControlExistPage(pageName, out page);
                if (flag)
                {
                    page.PageVisible = true;
                    page.Show();
                }
                else
                {
                    page = new XtraTabPage(); //新建一个标签页
                    page.Text = pageName;
                    page.Show();
                    mAISTest = new AISTest();
                    mAISTest.Dock = DockStyle.Fill;
                    AddPage(xtraTabControl1, pageName, mAISTest);

                }
            }
            catch (System.Exception ex)
            {

            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string pageName = barButtonItem4.Caption;
                XtraTabPage page = null;
                bool flag = IsTabControlExistPage(pageName, out page);
                if (flag)
                {
                    page.PageVisible = true;
                    page.Show();
                }
                else
                {
                    page = new XtraTabPage(); //新建一个标签页
                    page.Text = pageName;
                    page.Show();
                    mACARS_Test = new ACARS_Test();
                    mACARS_Test.Dock = DockStyle.Fill;
                    AddPage(xtraTabControl1, pageName, mACARS_Test);
                }
            }
            catch (System.Exception ex)
            {

            }
        }
        //string转换为byte[]
        public static byte[] StringToByteArray(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length / 2; i++)
            {
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }
            return returnBytes;
        }

        //byte[]转换为string
        public static string ByteArrayToString(byte[] buffer)
        {
            string hexString = string.Empty;

            if (buffer != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < buffer.Length; i++)
                {
                    strB.Append(buffer[i].ToString("X2"));
                    strB.Append(" ");
                }
                hexString = strB.ToString();
            }
            return hexString;
        }

        //byte[]转换为二进制string
        public static string ByteArrayToString_2(byte[] buffer)
        {
            string hexString = string.Empty;

            if (buffer != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < buffer.Length; i++)
                {
                    strB.Append(Convert.ToString(buffer[i], 2).PadLeft(8, '0'));
                }
                hexString = strB.ToString();
            }
            return hexString;
        }

        //二进制string转换为string
        public static string String_2ToString(string hexString)
        {
            string returnStr = "";
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 8) == 0)
            {
                for (int i = 0; i < hexString.Length / 4; i++)
                {
                    string str1 = hexString.Substring(i * 4, 4);
                    int num = Convert.ToInt32(str1, 2);
                    string str2 = Convert.ToString(num, 16);
                    returnStr += str2 + " ";
                }
            }
            return returnStr;
        }

        //Int数值转4位byte[]
        public byte[] IntTo2Byte(int value)
        {
            byte[] src = new byte[4];
            src[0] = (byte)((value >> 24) & 0xFF);
            src[1] = (byte)((value >> 16) & 0xFF);
            src[2] = (byte)((value >> 8) & 0xFF);
            src[3] = (byte)(value & 0xFF);
            return src;
        }
        //函数——计算误码数，位
        private int CompareCode(string Olddata, string Newdata)
        {
            int n = 0;
            for (int k = 0; k < Olddata.Length; k++)
            {
                string str1 = Olddata.Substring(k, 1);
                string str2 = Newdata.Substring(k, 1);
                if (str1 != str2)
                    n += 1;
            }
            return n;

        }
        //函数——计算误帧数，字节
        private int CompareFrame(string Olddata, string Newdata)
        {
            int n = 0;
            for (int k = 0; k < Olddata.Length / 8; k++)
            {
                string str1 = Olddata.Substring(k * 8, 8);
                string str2 = Newdata.Substring(k * 8, 8);
                if (str1 != str2)
                    n += 1;
            }
            return n;

        }

        private void AISParamSet_Click(object sender, EventArgs e)
        {
            byte[] cmd = new byte[8];
            byte[] tmp32 = new byte[4];
            double freq = 0;
            int calcfreq = 0;
            cmd[0] = 0xC1;
            cmd[1] = 0x00;
            if (AISSelect.Text == "AIS1")
            {
                cmd[2] = 0xA1;
                cmd[3] = 0x3A;
                cmd[4] = 0xA3;
                cmd[5] = 0x05;
                cmd[6] = 0x53;
            }
            else
            {
                cmd[2] = 0xA2;
                cmd[3] = 0x3B;
                cmd[4] = 0xE4;
                cmd[5] = 0x25;
                cmd[6] = 0xAE;
            }
            cmd[7] = byte.Parse(AISGain.Text);
        }

        private void ACARSParamSet_Click(object sender, EventArgs e)
        {
            byte[] cmd = new byte[8];
            byte[] tmp32 = new byte[4];
            double freq = 0;
            int calcfreq = 0;
            cmd[0] = 0xC1;
            cmd[1] = 0x00;
            switch (ACARSSelect.Text)
            { 
                case "ACARS1":
                    cmd[2] = 0xC4;
                    break;
                case "ACARS2":
                    cmd[2] = 0xC3;
                    break;
                case "ACARS3":
                    cmd[2] = 0xC6;
                    break;
                case "ACARS4":
                    cmd[2] = 0xC5;
                    break;
            }

            freq = double.Parse(ACARSFreq.Text);
            calcfreq = (int)((freq * 1000) - 118000) / 25;
            tmp32 = BitConverter.GetBytes(ByteRevser(calcfreq));
            Array.Copy(tmp32, 0, cmd, 3, 4);
            cmd[7] = byte.Parse(ACARSGain.Text);
        }
        private void GetHostAddress()
        {
            string name = Dns.GetHostName();
            IPAddress[] ipadrlist = Dns.GetHostAddresses(name);
            foreach (IPAddress item in ipadrlist)
            {
                if (item.AddressFamily == AddressFamily.InterNetwork)//ipv4
                    comboBox1.Items.Add(item.ToString());
            }
            comboBox1.Items.Add("127.0.0.1");
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "启动Server")
            {
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["LocalPort"].Value = textBox1.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSetting");
                int port = 6888;
                if(!int.TryParse(textBox1.Text, out port))
                {
                    textBox1.Text = "6888";
                }
                tcpServer = new TcpServer(IPAddress.Parse((string)(comboBox1.SelectedItem)), port);
                button1.Text = "停止Server";
            }
            else if (button1.Text == "停止Server")
            {
                if (tcpServer != null)
                    tcpServer.StopRunning();
                button1.Text = "启动Server";
            }
        }
        public void InfoInit()
        {
            textBox1.Text = ConfigurationManager.AppSettings["LocalPort"];
        }
    }
}
