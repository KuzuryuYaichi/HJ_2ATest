namespace Test2A
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.网络配置 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ACARSSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ACARSParamSet = new System.Windows.Forms.Button();
            this.ACARSOutside = new System.Windows.Forms.CheckBox();
            this.ACARSGain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ACARSFreq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AIS参数设置 = new System.Windows.Forms.GroupBox();
            this.AISSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AISParamSet = new System.Windows.Forms.Button();
            this.AISOutSide = new System.Windows.Forms.CheckBox();
            this.AISGain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AISFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.网络配置.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AIS参数设置.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1048, 147);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "AIS误码性能测试";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "ACARS误码性能测试";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "控制界面";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "误码测试";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(855, 479);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 147);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.网络配置);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1048, 479);
            this.splitContainerControl1.SplitterPosition = 188;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // 网络配置
            // 
            this.网络配置.Controls.Add(this.button1);
            this.网络配置.Controls.Add(this.textBox1);
            this.网络配置.Controls.Add(this.label8);
            this.网络配置.Controls.Add(this.comboBox1);
            this.网络配置.Controls.Add(this.label7);
            this.网络配置.Location = new System.Drawing.Point(3, 346);
            this.网络配置.Name = "网络配置";
            this.网络配置.Size = new System.Drawing.Size(179, 127);
            this.网络配置.TabIndex = 9;
            this.网络配置.TabStop = false;
            this.网络配置.Text = "网络配置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "启动Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "本地Port";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "本地IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ACARSSelect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ACARSParamSet);
            this.groupBox1.Controls.Add(this.ACARSOutside);
            this.groupBox1.Controls.Add(this.ACARSGain);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ACARSFreq);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 164);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACARS参数设置";
            // 
            // ACARSSelect
            // 
            this.ACARSSelect.FormattingEnabled = true;
            this.ACARSSelect.Location = new System.Drawing.Point(59, 25);
            this.ACARSSelect.Name = "ACARSSelect";
            this.ACARSSelect.Size = new System.Drawing.Size(99, 22);
            this.ACARSSelect.TabIndex = 7;
            this.ACARSSelect.Text = "ACARS1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "通道：";
            // 
            // ACARSParamSet
            // 
            this.ACARSParamSet.Location = new System.Drawing.Point(84, 133);
            this.ACARSParamSet.Name = "ACARSParamSet";
            this.ACARSParamSet.Size = new System.Drawing.Size(75, 23);
            this.ACARSParamSet.TabIndex = 5;
            this.ACARSParamSet.Text = "设置";
            this.ACARSParamSet.UseVisualStyleBackColor = true;
            this.ACARSParamSet.Click += new System.EventHandler(this.ACARSParamSet_Click);
            // 
            // ACARSOutside
            // 
            this.ACARSOutside.AutoSize = true;
            this.ACARSOutside.Location = new System.Drawing.Point(13, 109);
            this.ACARSOutside.Name = "ACARSOutside";
            this.ACARSOutside.Size = new System.Drawing.Size(110, 18);
            this.ACARSOutside.TabIndex = 4;
            this.ACARSOutside.Text = "启用外部衰减器";
            this.ACARSOutside.UseVisualStyleBackColor = true;
            // 
            // ACARSGain
            // 
            this.ACARSGain.Location = new System.Drawing.Point(59, 81);
            this.ACARSGain.Name = "ACARSGain";
            this.ACARSGain.Size = new System.Drawing.Size(100, 22);
            this.ACARSGain.TabIndex = 3;
            this.ACARSGain.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "衰减：";
            // 
            // ACARSFreq
            // 
            this.ACARSFreq.Location = new System.Drawing.Point(59, 53);
            this.ACARSFreq.Name = "ACARSFreq";
            this.ACARSFreq.Size = new System.Drawing.Size(100, 22);
            this.ACARSFreq.TabIndex = 1;
            this.ACARSFreq.Text = "131.45";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "频率：";
            // 
            // AIS参数设置
            // 
            this.AIS参数设置.Controls.Add(this.AISSelect);
            this.AIS参数设置.Controls.Add(this.label3);
            this.AIS参数设置.Controls.Add(this.AISParamSet);
            this.AIS参数设置.Controls.Add(this.AISOutSide);
            this.AIS参数设置.Controls.Add(this.AISGain);
            this.AIS参数设置.Controls.Add(this.label2);
            this.AIS参数设置.Controls.Add(this.AISFreq);
            this.AIS参数设置.Controls.Add(this.label1);
            this.AIS参数设置.Enabled = false;
            this.AIS参数设置.Location = new System.Drawing.Point(3, 147);
            this.AIS参数设置.Name = "AIS参数设置";
            this.AIS参数设置.Size = new System.Drawing.Size(179, 170);
            this.AIS参数设置.TabIndex = 0;
            this.AIS参数设置.TabStop = false;
            this.AIS参数设置.Text = "AIS参数设置";
            // 
            // AISSelect
            // 
            this.AISSelect.FormattingEnabled = true;
            this.AISSelect.Location = new System.Drawing.Point(59, 25);
            this.AISSelect.Name = "AISSelect";
            this.AISSelect.Size = new System.Drawing.Size(99, 22);
            this.AISSelect.TabIndex = 7;
            this.AISSelect.Text = "AIS1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "通道：";
            // 
            // AISParamSet
            // 
            this.AISParamSet.Location = new System.Drawing.Point(84, 136);
            this.AISParamSet.Name = "AISParamSet";
            this.AISParamSet.Size = new System.Drawing.Size(75, 23);
            this.AISParamSet.TabIndex = 5;
            this.AISParamSet.Text = "设置";
            this.AISParamSet.UseVisualStyleBackColor = true;
            this.AISParamSet.Click += new System.EventHandler(this.AISParamSet_Click);
            // 
            // AISOutSide
            // 
            this.AISOutSide.AutoSize = true;
            this.AISOutSide.Location = new System.Drawing.Point(13, 112);
            this.AISOutSide.Name = "AISOutSide";
            this.AISOutSide.Size = new System.Drawing.Size(110, 18);
            this.AISOutSide.TabIndex = 4;
            this.AISOutSide.Text = "启用外部衰减器";
            this.AISOutSide.UseVisualStyleBackColor = true;
            // 
            // AISGain
            // 
            this.AISGain.Location = new System.Drawing.Point(59, 81);
            this.AISGain.Name = "AISGain";
            this.AISGain.Size = new System.Drawing.Size(100, 22);
            this.AISGain.TabIndex = 3;
            this.AISGain.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "衰减：";
            // 
            // AISFreq
            // 
            this.AISFreq.Location = new System.Drawing.Point(59, 53);
            this.AISFreq.Name = "AISFreq";
            this.AISFreq.Size = new System.Drawing.Size(100, 22);
            this.AISFreq.TabIndex = 1;
            this.AISFreq.Text = "161.975";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "频率：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 626);
            this.Controls.Add(this.AIS参数设置);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "2A模块测试软件";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.网络配置.ResumeLayout(false);
            this.网络配置.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AIS参数设置.ResumeLayout(false);
            this.AIS参数设置.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ACARSSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ACARSParamSet;
        private System.Windows.Forms.CheckBox ACARSOutside;
        private System.Windows.Forms.TextBox ACARSGain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ACARSFreq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox AIS参数设置;
        private System.Windows.Forms.ComboBox AISSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AISParamSet;
        private System.Windows.Forms.CheckBox AISOutSide;
        private System.Windows.Forms.TextBox AISGain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AISFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox 网络配置;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}

