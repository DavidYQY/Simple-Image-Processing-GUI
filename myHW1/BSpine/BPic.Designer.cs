namespace BSpine
{
    partial class BPic
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
            this.components = new System.ComponentModel.Container();
            this.myPic = new System.Windows.Forms.PictureBox();
            this.box1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.infoLabel = new System.Windows.Forms.Label();
            this.box2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.save = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.negative = new System.Windows.Forms.RadioButton();
            this.positive = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.TableLayoutPanel();
            this.m_Ny = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_Nx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myPic)).BeginInit();
            this.box1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.box2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.temp.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPic
            // 
            this.myPic.Location = new System.Drawing.Point(20, 20);
            this.myPic.Name = "myPic";
            this.myPic.Size = new System.Drawing.Size(600, 600);
            this.myPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPic.TabIndex = 0;
            this.myPic.TabStop = false;
            this.myPic.Click += new System.EventHandler(this.myPic_Click);
            // 
            // box1
            // 
            this.box1.Controls.Add(this.tableLayoutPanel1);
            this.box1.Location = new System.Drawing.Point(649, 20);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(235, 100);
            this.box1.TabIndex = 1;
            this.box1.TabStop = false;
            this.box1.Text = "起始点坐标";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelX, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelY, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX.Location = new System.Drawing.Point(3, 36);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(108, 37);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "100";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelY.Location = new System.Drawing.Point(117, 36);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(109, 37);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "100";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(117, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(646, 630);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(98, 18);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "提示信息：";
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // box2
            // 
            this.box2.Controls.Add(this.tableLayoutPanel2);
            this.box2.Location = new System.Drawing.Point(910, 20);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(235, 100);
            this.box2.TabIndex = 2;
            this.box2.TabStop = false;
            this.box2.Text = "目标点坐标";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelX2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelY2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(229, 73);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(3, 36);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 37);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "100";
            this.labelX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelY2.Location = new System.Drawing.Point(117, 36);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(109, 37);
            this.labelY2.TabIndex = 2;
            this.labelY2.Text = "100";
            this.labelY2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(117, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 120);
            this.button1.TabIndex = 4;
            this.button1.Text = "开始B样条变形";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.save, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.withdraw, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(697, 126);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(397, 79);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // save
            // 
            this.save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save.Location = new System.Drawing.Point(135, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(126, 73);
            this.save.TabIndex = 1;
            this.save.Text = "保存图片";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // withdraw
            // 
            this.withdraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.withdraw.Location = new System.Drawing.Point(3, 3);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(126, 73);
            this.withdraw.TabIndex = 0;
            this.withdraw.Text = "撤销";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(267, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 73);
            this.button2.TabIndex = 5;
            this.button2.Text = "还原图像";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(649, 595);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(471, 23);
            this.progressBar.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.negative, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.positive, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(650, 221);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(234, 60);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // negative
            // 
            this.negative.AutoSize = true;
            this.negative.Checked = true;
            this.negative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.negative.Location = new System.Drawing.Point(120, 3);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(111, 54);
            this.negative.TabIndex = 1;
            this.negative.TabStop = true;
            this.negative.Text = "反变换法";
            this.negative.UseVisualStyleBackColor = true;
            // 
            // positive
            // 
            this.positive.AutoSize = true;
            this.positive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positive.Location = new System.Drawing.Point(3, 3);
            this.positive.Name = "positive";
            this.positive.Size = new System.Drawing.Size(111, 54);
            this.positive.TabIndex = 0;
            this.positive.Text = "正变换法";
            this.positive.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.radioButton3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.radioButton2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(649, 287);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(490, 62);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton3.Location = new System.Drawing.Point(329, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(158, 56);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "双三次插值";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.Location = new System.Drawing.Point(166, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 56);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "双线性插值";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 56);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "最近邻插值";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "在B样条中，反变换支持三种插值。正变换将采取最近邻";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // temp
            // 
            this.temp.ColumnCount = 4;
            this.temp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.temp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.temp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.temp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.temp.Controls.Add(this.m_Ny, 3, 0);
            this.temp.Controls.Add(this.label8, 2, 0);
            this.temp.Controls.Add(this.label4, 0, 0);
            this.temp.Controls.Add(this.m_Nx, 1, 0);
            this.temp.Location = new System.Drawing.Point(666, 399);
            this.temp.Name = "temp";
            this.temp.RowCount = 1;
            this.temp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.temp.Size = new System.Drawing.Size(415, 38);
            this.temp.TabIndex = 10;
            // 
            // m_Ny
            // 
            this.m_Ny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Ny.Location = new System.Drawing.Point(312, 3);
            this.m_Ny.Name = "m_Ny";
            this.m_Ny.Size = new System.Drawing.Size(100, 28);
            this.m_Ny.TabIndex = 4;
            this.m_Ny.Text = "20";
            this.m_Ny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(209, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 38);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ny";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nx";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_Nx
            // 
            this.m_Nx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Nx.Location = new System.Drawing.Point(106, 3);
            this.m_Nx.Name = "m_Nx";
            this.m_Nx.Size = new System.Drawing.Size(97, 28);
            this.m_Nx.TabIndex = 3;
            this.m_Nx.Text = "20";
            this.m_Nx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 666);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.myPic);
            this.Name = "BPic";
            this.Text = "B样条变形 By.YQY";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPic)).EndInit();
            this.box1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.temp.ResumeLayout(false);
            this.temp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myPic;
        private System.Windows.Forms.GroupBox box1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox box2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton positive;
        private System.Windows.Forms.RadioButton negative;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel temp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_Nx;
        private System.Windows.Forms.TextBox m_Ny;
    }
}

