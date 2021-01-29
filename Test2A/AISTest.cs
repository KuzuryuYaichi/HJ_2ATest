using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace Test2A
{
    public partial class AISTest : DevExpress.XtraEditors.XtraUserControl
    {
        public AISTest()
        {
            InitializeComponent();
            
        }

        private void AIS测试控制_Click(object sender, EventArgs e)
        {
            Form1.AISRevString = string.Empty;
            Form1.AISchannel = string.Empty;
            Form1.AISRecvNum = 0;
            Form1.AISErrorNum = 0;
            Form1.AISRecvBit = 0;
            Form1.AISErrorBit = 0;
            Form1.AISErrorRate = 0;
            Form1.AISErrorBitRate = 0;
            if(AIS测试控制.Text == "开始测试")
            {
                AIS测试控制.Text = "正在测试";
                TimerRefresh.Start();
                Form1.AISString = AISRewData.Text.Trim();
                Form1.isStart_AIS = true;
                Form1.savetxt1.Name = "AIS";
                Form1.savetxt1.Start();
            }
            else if (AIS测试控制.Text == "正在测试")
            {
                AIS测试控制.Text = "开始测试";
                TimerRefresh.Stop();
                Form1.isStart_AIS = false;
                Form1.savetxt1.Stop();
            }
        }

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            AISRecvData.Text = Form1.AISRevString;
            AISChannal.Text = Form1.AISchannel;
            AISFrameNum.Text = Form1.AISRecvNum.ToString();
            ErrorFrameNum.Text = Form1.AISErrorNum.ToString();
            ALLBits.Text = Form1.AISRecvBit.ToString();
            ErrorBits.Text = Form1.AISErrorBit.ToString();
            ErrorFramePrecent.Text = Form1.AISErrorRate.ToString("f7");
            ErrorBitPrecent.Text = Form1.AISErrorBitRate.ToString("f7");
        }
    }
}
