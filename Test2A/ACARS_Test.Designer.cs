namespace Test2A
{
    partial class ACARS_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACARS_Test));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ACARS测试控制 = new System.Windows.Forms.Button();
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
            this.ACARSFrameNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ACARSChannal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ACARSRecvData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ACARSRewData = new System.Windows.Forms.TextBox();
            this.TimerRefresh = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.ACARS测试控制);
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
            this.groupBox1.Controls.Add(this.ACARSFrameNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ACARSChannal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ACARSRecvData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ACARSRewData);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACARS误码测试";
            // 
            // ACARS测试控制
            // 
            this.ACARS测试控制.Location = new System.Drawing.Point(607, 364);
            this.ACARS测试控制.Name = "ACARS测试控制";
            this.ACARS测试控制.Size = new System.Drawing.Size(118, 23);
            this.ACARS测试控制.TabIndex = 35;
            this.ACARS测试控制.Text = "开始测试";
            this.ACARS测试控制.UseVisualStyleBackColor = true;
            this.ACARS测试控制.Click += new System.EventHandler(this.ACARS测试控制_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "误码率";
            // 
            // ErrorBitPrecent
            // 
            this.ErrorBitPrecent.Location = new System.Drawing.Point(231, 329);
            this.ErrorBitPrecent.Name = "ErrorBitPrecent";
            this.ErrorBitPrecent.Size = new System.Drawing.Size(100, 21);
            this.ErrorBitPrecent.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "误帧率";
            // 
            // ErrorFramePrecent
            // 
            this.ErrorFramePrecent.Location = new System.Drawing.Point(92, 329);
            this.ErrorFramePrecent.Name = "ErrorFramePrecent";
            this.ErrorFramePrecent.Size = new System.Drawing.Size(100, 21);
            this.ErrorFramePrecent.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(649, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "误码数";
            // 
            // ErrorBits
            // 
            this.ErrorBits.Location = new System.Drawing.Point(625, 261);
            this.ErrorBits.Name = "ErrorBits";
            this.ErrorBits.Size = new System.Drawing.Size(100, 21);
            this.ErrorBits.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "总码数";
            // 
            // ALLBits
            // 
            this.ALLBits.Location = new System.Drawing.Point(496, 261);
            this.ALLBits.Name = "ALLBits";
            this.ALLBits.Size = new System.Drawing.Size(100, 21);
            this.ALLBits.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "误帧数";
            // 
            // ErrorFrameNum
            // 
            this.ErrorFrameNum.Location = new System.Drawing.Point(364, 261);
            this.ErrorFrameNum.Name = "ErrorFrameNum";
            this.ErrorFrameNum.Size = new System.Drawing.Size(100, 21);
            this.ErrorFrameNum.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "总帧数";
            // 
            // ACARSFrameNum
            // 
            this.ACARSFrameNum.Location = new System.Drawing.Point(231, 261);
            this.ACARSFrameNum.Name = "ACARSFrameNum";
            this.ACARSFrameNum.Size = new System.Drawing.Size(100, 21);
            this.ACARSFrameNum.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "通道号";
            // 
            // ACARSChannal
            // 
            this.ACARSChannal.Location = new System.Drawing.Point(92, 261);
            this.ACARSChannal.Name = "ACARSChannal";
            this.ACARSChannal.Size = new System.Drawing.Size(100, 21);
            this.ACARSChannal.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "数据信息统计：";
            // 
            // ACARSRecvData
            // 
            this.ACARSRecvData.Location = new System.Drawing.Point(107, 130);
            this.ACARSRecvData.Multiline = true;
            this.ACARSRecvData.Name = "ACARSRecvData";
            this.ACARSRecvData.Size = new System.Drawing.Size(625, 68);
            this.ACARSRecvData.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ACARS接收信息：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACARS原始信息：";
            // 
            // ACARSRewData
            // 
            this.ACARSRewData.Location = new System.Drawing.Point(107, 41);
            this.ACARSRewData.Multiline = true;
            this.ACARSRewData.Name = "ACARSRewData";
            this.ACARSRewData.Size = new System.Drawing.Size(625, 68);
            this.ACARSRewData.TabIndex = 0;
            this.ACARSRewData.Text = resources.GetString("ACARSRewData.Text");
            // 
            // TimerRefresh
            // 
            this.TimerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // ACARS_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ACARS_Test";
            this.Size = new System.Drawing.Size(801, 442);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ACARSRecvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ACARSRewData;
        private System.Windows.Forms.Button ACARS测试控制;
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
        private System.Windows.Forms.TextBox ACARSFrameNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ACARSChannal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TimerRefresh;
    }
}
