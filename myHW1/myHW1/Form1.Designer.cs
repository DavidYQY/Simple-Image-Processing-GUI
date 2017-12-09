namespace myHW1
{
    partial class mainWindow
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rotateButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.newPic = new System.Windows.Forms.PictureBox();
            this.rotate = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Angle = new System.Windows.Forms.TextBox();
            this.Theta = new System.Windows.Forms.Label();
            this.anticlockwise = new System.Windows.Forms.RadioButton();
            this.clockwise = new System.Windows.Forms.RadioButton();
            this.R = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.waterButton = new System.Windows.Forms.Button();
            this.waterGroup = new System.Windows.Forms.GroupBox();
            this.dynamicButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.kLabel = new System.Windows.Forms.Label();
            this.kValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phiText = new System.Windows.Forms.TextBox();
            this.roText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiusText2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tripleButton = new System.Windows.Forms.RadioButton();
            this.bilearButton = new System.Windows.Forms.RadioButton();
            this.nearestButton = new System.Windows.Forms.RadioButton();
            this.savePic = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.test = new System.Windows.Forms.Button();
            this.original = new System.Windows.Forms.Button();
            this.changePic = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic)).BeginInit();
            this.rotate.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.waterGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(358, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rotateButton
            // 
            this.rotateButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rotateButton.Location = new System.Drawing.Point(73, 173);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(132, 59);
            this.rotateButton.TabIndex = 1;
            this.rotateButton.Text = "开始旋转";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(28, 645);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(80, 18);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "提示信息";
            this.infoLabel.Visible = false;
            // 
            // newPic
            // 
            this.newPic.Location = new System.Drawing.Point(804, 52);
            this.newPic.Name = "newPic";
            this.newPic.Size = new System.Drawing.Size(400, 400);
            this.newPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newPic.TabIndex = 3;
            this.newPic.TabStop = false;
            // 
            // rotate
            // 
            this.rotate.Controls.Add(this.tableLayoutPanel1);
            this.rotate.Controls.Add(this.rotateButton);
            this.rotate.Location = new System.Drawing.Point(25, 12);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(300, 240);
            this.rotate.TabIndex = 4;
            this.rotate.TabStop = false;
            this.rotate.Text = "图像旋转";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Angle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Theta, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.anticlockwise, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.clockwise, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.R, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Radius, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Angle
            // 
            this.Angle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Angle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Angle.Location = new System.Drawing.Point(144, 87);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(135, 35);
            this.Angle.TabIndex = 5;
            this.Angle.Text = "90";
            this.Angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Theta
            // 
            this.Theta.AutoSize = true;
            this.Theta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Theta.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Theta.Location = new System.Drawing.Point(3, 84);
            this.Theta.Name = "Theta";
            this.Theta.Size = new System.Drawing.Size(135, 44);
            this.Theta.TabIndex = 4;
            this.Theta.Text = "旋转角度：";
            this.Theta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // anticlockwise
            // 
            this.anticlockwise.AutoSize = true;
            this.anticlockwise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anticlockwise.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.anticlockwise.Location = new System.Drawing.Point(144, 3);
            this.anticlockwise.Name = "anticlockwise";
            this.anticlockwise.Size = new System.Drawing.Size(135, 36);
            this.anticlockwise.TabIndex = 1;
            this.anticlockwise.TabStop = true;
            this.anticlockwise.Text = "逆时针旋转";
            this.anticlockwise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.anticlockwise.UseVisualStyleBackColor = true;
            // 
            // clockwise
            // 
            this.clockwise.AutoSize = true;
            this.clockwise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockwise.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clockwise.Location = new System.Drawing.Point(3, 3);
            this.clockwise.Name = "clockwise";
            this.clockwise.Size = new System.Drawing.Size(135, 36);
            this.clockwise.TabIndex = 0;
            this.clockwise.TabStop = true;
            this.clockwise.Text = "顺时针旋转";
            this.clockwise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clockwise.UseVisualStyleBackColor = true;
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.R.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R.Location = new System.Drawing.Point(3, 42);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(135, 42);
            this.R.TabIndex = 2;
            this.R.Text = "旋转半径：";
            this.R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Radius
            // 
            this.Radius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Radius.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Radius.Location = new System.Drawing.Point(144, 45);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(135, 35);
            this.Radius.TabIndex = 3;
            this.Radius.Text = "200";
            this.Radius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(25, 601);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 27);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // waterButton
            // 
            this.waterButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.waterButton.Location = new System.Drawing.Point(13, 263);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(131, 47);
            this.waterButton.TabIndex = 6;
            this.waterButton.Text = "静态展示";
            this.waterButton.UseVisualStyleBackColor = true;
            this.waterButton.Click += new System.EventHandler(this.waterButton_Click);
            // 
            // waterGroup
            // 
            this.waterGroup.Controls.Add(this.dynamicButton);
            this.waterGroup.Controls.Add(this.tableLayoutPanel2);
            this.waterGroup.Controls.Add(this.waterButton);
            this.waterGroup.Controls.Add(this.label4);
            this.waterGroup.Location = new System.Drawing.Point(25, 259);
            this.waterGroup.Name = "waterGroup";
            this.waterGroup.Size = new System.Drawing.Size(300, 324);
            this.waterGroup.TabIndex = 7;
            this.waterGroup.TabStop = false;
            this.waterGroup.Text = "图像水纹变换";
            // 
            // dynamicButton
            // 
            this.dynamicButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dynamicButton.Location = new System.Drawing.Point(150, 263);
            this.dynamicButton.Name = "dynamicButton";
            this.dynamicButton.Size = new System.Drawing.Size(135, 47);
            this.dynamicButton.TabIndex = 13;
            this.dynamicButton.Text = "动态展示";
            this.dynamicButton.UseVisualStyleBackColor = true;
            this.dynamicButton.Click += new System.EventHandler(this.dynamicButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.kLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.kValue, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.phiText, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.roText, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radiusText2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 157);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kLabel.Location = new System.Drawing.Point(3, 117);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(135, 40);
            this.kLabel.TabIndex = 11;
            this.kLabel.Text = "比例系数k";
            this.kLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kValue
            // 
            this.kValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kValue.Location = new System.Drawing.Point(144, 120);
            this.kValue.Name = "kValue";
            this.kValue.Size = new System.Drawing.Size(135, 31);
            this.kValue.TabIndex = 10;
            this.kValue.Text = "0.1";
            this.kValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "变换参数phi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phiText
            // 
            this.phiText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phiText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phiText.Location = new System.Drawing.Point(144, 81);
            this.phiText.Name = "phiText";
            this.phiText.Size = new System.Drawing.Size(135, 31);
            this.phiText.TabIndex = 7;
            this.phiText.Text = "0.1";
            this.phiText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roText
            // 
            this.roText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roText.Location = new System.Drawing.Point(144, 42);
            this.roText.Name = "roText";
            this.roText.Size = new System.Drawing.Size(135, 31);
            this.roText.TabIndex = 5;
            this.roText.Text = "24";
            this.roText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "变换参数ro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "旋转半径：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiusText2
            // 
            this.radiusText2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiusText2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radiusText2.Location = new System.Drawing.Point(144, 3);
            this.radiusText2.Name = "radiusText2";
            this.radiusText2.Size = new System.Drawing.Size(135, 31);
            this.radiusText2.TabIndex = 3;
            this.radiusText2.Text = "200";
            this.radiusText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 62);
            this.label4.TabIndex = 12;
            this.label4.Text = "ro,phi定义与ppt相同，k为sin之前比例系数";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(358, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "插值方式";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.tripleButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.bilearButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.nearestButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(495, 73);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tripleButton
            // 
            this.tripleButton.AutoSize = true;
            this.tripleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tripleButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tripleButton.Location = new System.Drawing.Point(332, 3);
            this.tripleButton.Name = "tripleButton";
            this.tripleButton.Size = new System.Drawing.Size(160, 67);
            this.tripleButton.TabIndex = 11;
            this.tripleButton.TabStop = true;
            this.tripleButton.Text = "双三线性插值";
            this.tripleButton.UseVisualStyleBackColor = true;
            // 
            // bilearButton
            // 
            this.bilearButton.AutoSize = true;
            this.bilearButton.Checked = true;
            this.bilearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilearButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bilearButton.Location = new System.Drawing.Point(167, 3);
            this.bilearButton.Name = "bilearButton";
            this.bilearButton.Size = new System.Drawing.Size(159, 67);
            this.bilearButton.TabIndex = 10;
            this.bilearButton.TabStop = true;
            this.bilearButton.Text = "双线性插值";
            this.bilearButton.UseVisualStyleBackColor = true;
            // 
            // nearestButton
            // 
            this.nearestButton.AutoSize = true;
            this.nearestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nearestButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nearestButton.Location = new System.Drawing.Point(3, 3);
            this.nearestButton.Name = "nearestButton";
            this.nearestButton.Size = new System.Drawing.Size(158, 67);
            this.nearestButton.TabIndex = 9;
            this.nearestButton.TabStop = true;
            this.nearestButton.Text = "最近邻插值";
            this.nearestButton.UseVisualStyleBackColor = true;
            // 
            // savePic
            // 
            this.savePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savePic.Location = new System.Drawing.Point(3, 3);
            this.savePic.Name = "savePic";
            this.savePic.Size = new System.Drawing.Size(131, 59);
            this.savePic.TabIndex = 9;
            this.savePic.Text = "保存照片";
            this.savePic.UseVisualStyleBackColor = true;
            this.savePic.Click += new System.EventHandler(this.savePic_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel4.Controls.Add(this.test, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.original, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.changePic, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.savePic, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(345, 598);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(548, 65);
            this.tableLayoutPanel4.TabIndex = 10;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // test
            // 
            this.test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.test.Location = new System.Drawing.Point(140, 3);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(131, 59);
            this.test.TabIndex = 12;
            this.test.Text = "还原图像";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // original
            // 
            this.original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.original.Location = new System.Drawing.Point(414, 3);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(131, 59);
            this.original.TabIndex = 11;
            this.original.Text = "查看原图";
            this.original.UseVisualStyleBackColor = true;
            this.original.Click += new System.EventHandler(this.original_Click);
            // 
            // changePic
            // 
            this.changePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePic.Location = new System.Drawing.Point(277, 3);
            this.changePic.Name = "changePic";
            this.changePic.Size = new System.Drawing.Size(131, 59);
            this.changePic.TabIndex = 10;
            this.changePic.Text = "更改照片";
            this.changePic.UseVisualStyleBackColor = true;
            this.changePic.Click += new System.EventHandler(this.changePic_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(928, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 171);
            this.button1.TabIndex = 11;
            this.button1.Text = "打开B样条变形界面>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1230, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.waterGroup);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.rotate);
            this.Controls.Add(this.newPic);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainWindow";
            this.Text = "大作业1：图像变形扭曲 by.YQY";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic)).EndInit();
            this.rotate.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.waterGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox newPic;
        private System.Windows.Forms.GroupBox rotate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton clockwise;
        private System.Windows.Forms.RadioButton anticlockwise;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Label Theta;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.GroupBox waterGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox roText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox radiusText2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phiText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton nearestButton;
        private System.Windows.Forms.RadioButton tripleButton;
        private System.Windows.Forms.RadioButton bilearButton;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.TextBox kValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button savePic;
        private System.Windows.Forms.Button dynamicButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button changePic;
        private System.Windows.Forms.Button original;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button test;
    }
}

