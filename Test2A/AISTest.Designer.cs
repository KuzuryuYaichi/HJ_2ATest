namespace Test2A
{
    partial class AISTest
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AIS测试控制 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ErrorBitPrecent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ErrorFramePrecent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ErrorBits = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ALLBits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ErrorFrameNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AISFrameNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AISChannal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AISRecvData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AISRewData = new System.Windows.Forms.TextBox();
            this.TimerRefresh = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.AIS测试控制);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ErrorBitPrecent);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ErrorFramePrecent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ErrorBits);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ALLBits);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ErrorFrameNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AISFrameNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AISChannal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AISRecvData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AISRewData);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AIS误码测试";
            // 
            // AIS测试控制
            // 
            this.AIS测试控制.Location = new System.Drawing.Point(661, 394);
            this.AIS测试控制.Name = "AIS测试控制";
            this.AIS测试控制.Size = new System.Drawing.Size(118, 23);
            this.AIS测试控制.TabIndex = 19;
            this.AIS测试控制.Text = "开始测试";
            this.AIS测试控制.UseVisualStyleBackColor = true;
            this.AIS测试控制.Click += new System.EventHandler(this.AIS测试控制_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "误码率";
            // 
            // ErrorBitPrecent
            // 
            this.ErrorBitPrecent.Location = new System.Drawing.Point(243, 394);
            this.ErrorBitPrecent.Name = "ErrorBitPrecent";
            this.ErrorBitPrecent.Size = new System.Drawing.Size(100, 22);
            this.ErrorBitPrecent.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "误帧率";
            // 
            // ErrorFramePrecent
            // 
            this.ErrorFramePrecent.Location = new System.Drawing.Point(104, 394);
            this.ErrorFramePrecent.Name = "ErrorFramePrecent";
            this.ErrorFramePrecent.Size = new System.Drawing.Size(100, 22);
            this.ErrorFramePrecent.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "误码数";
            // 
            // ErrorBits
            // 
            this.ErrorBits.Location = new System.Drawing.Point(637, 326);
            this.ErrorBits.Name = "ErrorBits";
            this.ErrorBits.Size = new System.Drawing.Size(100, 22);
            this.ErrorBits.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "总码数";
            // 
            // ALLBits
            // 
            this.ALLBits.Location = new System.Drawing.Point(508, 326);
            this.ALLBits.Name = "ALLBits";
            this.ALLBits.Size = new System.Drawing.Size(100, 22);
            this.ALLBits.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "误帧数";
            // 
            // ErrorFrameNum
            // 
            this.ErrorFrameNum.Location = new System.Drawing.Point(376, 326);
            this.ErrorFrameNum.Name = "ErrorFrameNum";
            this.ErrorFrameNum.Size = new System.Drawing.Size(100, 22);
            this.ErrorFrameNum.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "总帧数";
            // 
            // AISFrameNum
            // 
            this.AISFrameNum.Location = new System.Drawing.Point(243, 326);
            this.AISFrameNum.Name = "AISFrameNum";
            this.AISFrameNum.Size = new System.Drawing.Size(100, 22);
            this.AISFrameNum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "通道号";
            // 
            // AISChannal
            // 
            this.AISChannal.Location = new System.Drawing.Point(104, 326);
            this.AISChannal.Name = "AISChannal";
            this.AISChannal.Size = new System.Drawing.Size(100, 22);
            this.AISChannal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据信息统计：";
            // 
            // AISRecvData
            // 
            this.AISRecvData.Location = new System.Drawing.Point(99, 168);
            this.AISRecvData.Multiline = true;
            this.AISRecvData.Name = "AISRecvData";
            this.AISRecvData.Size = new System.Drawing.Size(671, 99);
            this.AISRecvData.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "AIS接收数据：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "AIS原始信息：";
            // 
            // AISRewData
            // 
            this.AISRewData.Location = new System.Drawing.Point(99, 42);
            this.AISRewData.Multiline = true;
            this.AISRewData.Name = "AISRewData";
            this.AISRewData.Size = new System.Drawing.Size(671, 99);
            this.AISRewData.TabIndex = 0;
            this.AISRewData.Text = "011111100010000000000000101100000000100100011100000000000000001001011000100110000" +
    "01001010001110101101000011010011100000100000011000000000000000000000000000000000" +
    "000000000000000100011101101100101111110";
            // 
            // TimerRefresh
            // 
            this.TimerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // AISTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AISTest";
            this.Size = new System.Drawing.Size(801, 422);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AIS测试控制;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ErrorBitPrecent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ErrorFramePrecent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ErrorBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ALLBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ErrorFrameNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AISFrameNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AISChannal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AISRecvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AISRewData;
        private System.Windows.Forms.Timer TimerRefresh;
    }
}
