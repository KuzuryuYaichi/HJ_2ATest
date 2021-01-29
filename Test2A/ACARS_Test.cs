using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2A
{
    public partial class ACARS_Test : UserControl
    {
        public ACARS_Test()
        {
            InitializeComponent();
        }

        private void ACARS测试控制_Click(object sender, EventArgs e)
        {
            Form1.ACARSRevString = string.Empty;
            Form1.ACARSchannel = string.Empty;
            Form1.ACARSRecvNum = 0;
            Form1.ACARSErrorNum = 0;
            Form1.ACARSRecvBit = 0;
            Form1.ACARSErrorBit = 0;
            Form1.ACARSErrorRate = 0;
            Form1.ACARSErrorBitRate = 0;
            if (ACARS测试控制.Text == "开始测试")
            {
                Form1.isStart_ACARS = true;
                Form1.savetxt2.Name = "ACARS";
                Form1.savetxt2.Start();
                ACARS测试控制.Text = "正在测试";
                TimerRefresh.Start();
            }
            else if (ACARS测试控制.Text == "正在测试")
            {
                Form1.isStart_ACARS = false;
                Form1.savetxt2.Stop();
                ACARS测试控制.Text = "开始测试";
                TimerRefresh.Stop();
            }
        }

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            ACARSRecvData.Text = Form1.ACARSRevString;
            ACARSChannal.Text = Form1.ACARSchannel;
            ACARSFrameNum.Text = Form1.ACARSRecvNum.ToString();
            ErrorFrameNum.Text = Form1.ACARSErrorNum.ToString();
            ALLBits.Text = Form1.ACARSRecvBit.ToString();
            ErrorBits.Text = Form1.ACARSErrorBit.ToString();
            ErrorFramePrecent.Text = Form1.ACARSErrorRate.ToString("f7");
            ErrorBitPrecent.Text = Form1.ACARSErrorBitRate.ToString("f7");
        }
    }
}
