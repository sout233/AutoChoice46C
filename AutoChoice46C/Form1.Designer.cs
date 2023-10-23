namespace AutoChoice46C
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noRepeatCB = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.mLabel = new System.Windows.Forms.Label();
            this.congModeCB = new System.Windows.Forms.CheckBox();
            this.mOneshotCB = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "幸运大抽奖";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.Location = new System.Drawing.Point(281, 374);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(128, 42);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("宋体", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(160, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 96);
            this.label2.TabIndex = 2;
            this.label2.Text = "不知道";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(491, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "show options";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // noRepeatCB
            // 
            this.noRepeatCB.AutoSize = true;
            this.noRepeatCB.Checked = true;
            this.noRepeatCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noRepeatCB.Location = new System.Drawing.Point(18, 400);
            this.noRepeatCB.Margin = new System.Windows.Forms.Padding(2);
            this.noRepeatCB.Name = "noRepeatCB";
            this.noRepeatCB.Size = new System.Drawing.Size(84, 16);
            this.noRepeatCB.TabIndex = 6;
            this.noRepeatCB.Text = "不重复抽样";
            this.noRepeatCB.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.Location = new System.Drawing.Point(476, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(204, 23);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "帮助";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Made From 二年六班";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 24);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(29, 12);
            this.versionLabel.TabIndex = 9;
            this.versionLabel.Text = "v0.4";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(2, 39);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(184, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(10, 14);
            this.mLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(53, 12);
            this.mLabel.TabIndex = 1;
            this.mLabel.Text = "概率：0%";
            // 
            // congModeCB
            // 
            this.congModeCB.AutoSize = true;
            this.congModeCB.Location = new System.Drawing.Point(2, 87);
            this.congModeCB.Margin = new System.Windows.Forms.Padding(2);
            this.congModeCB.Name = "congModeCB";
            this.congModeCB.Size = new System.Drawing.Size(72, 16);
            this.congModeCB.TabIndex = 2;
            this.congModeCB.Text = "喜报模式";
            this.congModeCB.UseVisualStyleBackColor = true;
            // 
            // mOneshotCB
            // 
            this.mOneshotCB.AutoSize = true;
            this.mOneshotCB.Location = new System.Drawing.Point(2, 116);
            this.mOneshotCB.Name = "mOneshotCB";
            this.mOneshotCB.Size = new System.Drawing.Size(108, 16);
            this.mOneshotCB.TabIndex = 4;
            this.mOneshotCB.Text = "马哥单发大保底";
            this.mOneshotCB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mOneshotCB);
            this.panel1.Controls.Add(this.congModeCB);
            this.panel1.Controls.Add(this.mLabel);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(478, 250);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 133);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 438);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.noRepeatCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 469);
            this.MinimumSize = new System.Drawing.Size(700, 469);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox noRepeatCB;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.CheckBox congModeCB;
        private System.Windows.Forms.CheckBox mOneshotCB;
        public System.Windows.Forms.Panel panel1;
    }
}

