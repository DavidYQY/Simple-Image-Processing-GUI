using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myHW1
{
    public partial class mainWindow :Form
    {
        int picWidth, picHeight;
        Bitmap myImage;
        public mainWindow()
        {
            InitializeComponent();
            this.pictureBox1.Image = new Bitmap(myHW1.Properties.Resources.LENA,400,400);
            myImage = new Bitmap(this.pictureBox1.Image,400,400);
            picHeight = this.pictureBox1.Image.Height;
            picWidth = this.pictureBox1.Image.Width;
            newPic.Image = myImage;
        }

        private Color Bilear(double indexX,double indexY)
        {
            int x = (int)Math.Floor(indexX);
            int y = (int)Math.Floor(indexY);
            double w1 = indexX - x;
            double w2 = indexY - y;

            if (x >= picWidth - 1 || y >= picHeight - 1)
                return myImage.GetPixel(picWidth-1, picHeight-1);
            if (x <= 0 && y <= 0)
                return myImage.GetPixel(0, 0);
            if (x <= 0)
                return myImage.GetPixel(0, y);
            if (y <= 0)
                return myImage.GetPixel(x, 0);
            double R, G, B;
            R = myImage.GetPixel(x, y).R * (1 - w1) * (1 - w2) +
                myImage.GetPixel(x + 1, y).R * (w1) * (1 - w2) +
                myImage.GetPixel(x, y + 1).R * (1 - w1) * (w2) +
                 myImage.GetPixel(x+1, y + 1).R * (w1) * (w2);
            G = myImage.GetPixel(x, y).G * (1 - w1) * (1 - w2) +
                myImage.GetPixel(x + 1, y).G * (w1) * (1 - w2) +
                myImage.GetPixel(x+1, y + 1).G * (1 - w1) * (w2) +
                 myImage.GetPixel(x, y + 1).G * (w1) * (w2);
            B = myImage.GetPixel(x, y).B * (1 - w1) * (1 - w2) +
                myImage.GetPixel(x + 1, y).B * (w1) * (1 - w2) +
                myImage.GetPixel(x, y + 1).B * (1 - w1) * (w2) +
                 myImage.GetPixel(x+1, y + 1).B * (w1) * (w2);
            return Color.FromArgb((int)R, (int)G, (int)B);            
        }

        private Color Nearest(double indexX,double indexY)
        {
            int x = (int)Math.Floor(indexX);
            int y = (int)Math.Floor(indexY);
            double w1 = indexX - x;
            double w2 = indexY - y;

            if (x >= picWidth-2 || y>= picHeight-2)
                return myImage.GetPixel(picWidth-1, picHeight-1);
            if (x <= 0 && y <= 0)
                return myImage.GetPixel(0, 0);
            if (x <= 0)
                return myImage.GetPixel(0, y);
            if (y <= 0)
                return myImage.GetPixel(x, 0);

            if (w1 > 0.5) x = x + 1;
            if (w2 > 0.5) y = y + 1;
            if (x >= picWidth) x = picWidth - 1;if (x < 0) x = 0;
            if (y >= picHeight) y = picHeight - 1;if (y < 0) y = 0;

            return myImage.GetPixel(x, y);
        }

        private Color Bicubic(double indexX,double indexY)
        {
            int i = (int)Math.Floor(indexX);
            int j = (int)Math.Floor(indexY);
            double u = indexX - i;
            double v = indexY - j;

            if (i >= picWidth - 2 || j >= picHeight - 2)
                return myImage.GetPixel(picWidth-1, picHeight-1);
            if (i <= 0 && j <= 0)
                return myImage.GetPixel(0, 0);
            if (i <= 0)
                return myImage.GetPixel(0, j);
            if (j <= 0)
                return myImage.GetPixel(i, 0);

            double R, G, B;

            Matrix A = new Matrix(1,4);
            for (int k = 0; k < 4; k++)
                A[0, k] = aux_bicubic(u + 1 - k);
            Matrix C = new Matrix(4, 1);
            for (int k = 0; k < 4; k++)
                C[k, 0] = aux_bicubic(v + 1 - k);

            Matrix m_B = new Matrix(4, 4);//跟B重名了
            for (int k1 = 0; k1 < 4; k1++)
                for (int k2 = 0; k2 < 4; k2++)
                    m_B[k1, k2] = myImage.GetPixel(i + k1 - 1, j + k2 - 1).R;
            R = (A * m_B * C)[0,0];
            for (int k1 = 0; k1 < 4; k1++)
                for (int k2 = 0; k2 < 4; k2++)
                    m_B[k1, k2] = myImage.GetPixel(i + k1 - 1, j + k2 - 1).G;
            G = (A * m_B * C)[0, 0];
            for (int k1 = 0; k1 < 4; k1++)
                for (int k2 = 0; k2 < 4; k2++)
                    m_B[k1, k2] = myImage.GetPixel(i + k1 - 1, j + k2 - 1).B;
            B = (A * m_B * C)[0, 0];

            if (R < 0) R = 0;if (R > 255) R = 255;
            if (G < 0) G = 0;if (G > 255) G = 255;
            if (B < 0) B = 0;if (B > 255) B = 255; 

            return Color.FromArgb((int)R, (int)G, (int)B);
        }

        private double aux_bicubic(double x)
        {
            double s;//ans
            double x_ = Math.Abs(x);
            if (x_ <= 1)
                s = 1 - 2 * Math.Pow(x_, 2) + Math.Pow(x_, 3);
            else if (x_ < 2)
                s = 4 - 8 * x_ + 5 * Math.Pow(x_, 2) - Math.Pow(x_, 3);
            else
                s = 0;
            return s;
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
           
            if(!nearestButton.Checked && !bilearButton.Checked && !tripleButton.Checked)
            {
                MessageBox.Show("请选择一个插值方式");
                return;
            }
            this.infoLabel.Text = "正在旋转";
            Bitmap currentImage = myImage;
            Bitmap temp = new Bitmap(currentImage.Width,currentImage.Height);
            double R, angle;
            try
            {
                R = Convert.ToDouble(Radius.Text);
                angle = Convert.ToDouble(Angle.Text) * Math.PI / 180.0;//旋转半径和旋转角度
            }
            catch(Exception)
            {
                MessageBox.Show("你输入了非法的字符！请重新输入");
                return;
            }


            if (clockwise.Checked)
                angle = -angle;

            double Rmax = Math.Min(currentImage.Height / 2, currentImage.Width/2);
            if (R > Rmax)
            {
                MessageBox.Show("您输入的半径超出了图片的最大尺寸！，将使用最大半径"+Rmax.ToString());
                Radius.Text = Rmax.ToString();
                R = Rmax;
            }
            rotateButton.Enabled = false;
            DateTime beforeDT = System.DateTime.Now;
            double centerX = currentImage.Width / 2.0;
            double centerY = currentImage.Height / 2.0;
            double x, y;//反变换所得原图中的x,y
            double _x, _y;//所需坐标
            double r;//极坐标变换
            progressBar.Maximum = temp.Width;
            progressBar.Visible = true;
            infoLabel.Visible = true;
            for (int i = 0; i < temp.Width; i++)
            {
                progressBar.Value = i;
                progressBar.PerformStep();
                Application.DoEvents();
                for (int j = 0; j < temp.Height; j++)
                {
                    _x = i - centerX;
                    _y = j - centerY;
                    r = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
                    if (r > R)
                    {
                        temp.SetPixel(i, j, currentImage.GetPixel(i, j));
                        continue;
                    }
                    y = (_y) * Math.Cos(angle * (R - r) / R) + (_x) * Math.Sin(angle * (R - r) / R)+ centerY;
                    x = (_x) * Math.Cos(angle * (R - r) / R) - (_y) * Math.Sin(angle * (R - r) / R) + centerX;

                    Color col;
                    if (nearestButton.Checked)
                        col = Nearest(x, y);
                    else if (bilearButton.Checked)
                    {
                        col = Bilear(x, y);
                    }

                    else {
                        col = Bicubic(x, y);
                    }
                        
                        
                    temp.SetPixel(i, j, col);
                }
            }
            newPic.Image = temp;
            myImage = temp;
            rotateButton.Enabled = true;
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforeDT);
            infoLabel.Text = "旋转完成！耗时："+ts.TotalMilliseconds.ToString()+"ms";

        }

        private void waterButton_Click(object sender, EventArgs e)
        {
            DateTime beforeDT = System.DateTime.Now;
            if (!nearestButton.Checked && !bilearButton.Checked && !tripleButton.Checked)
            {
                MessageBox.Show("请选择一个插值方式");
                return;
            }
            infoLabel.Text = "正在水纹变换";

            Bitmap currentImage = myImage;
            Bitmap temp = new Bitmap(currentImage.Width, currentImage.Height);

            double R, ro, phi, k;
            try
            {
                R = Convert.ToDouble(radiusText2.Text);
                ro = Convert.ToDouble(roText.Text); phi = Convert.ToDouble(phiText.Text);
                k = Convert.ToDouble(kValue.Text);
            }
            catch(Exception )
            {
                MessageBox.Show("你输入了非法字符！请重新输入！");
                return;
            }

            waterButton.Enabled = false;
            double Rmax = Math.Min(currentImage.Height / 2, currentImage.Width);
            if (R > Rmax)
            {
                MessageBox.Show("您输入的半径超出了图片的最大尺寸！，将使用最大半径"+Rmax.ToString());
                Radius.Text = Rmax.ToString();
                R = Rmax;
            }

            double centerX = currentImage.Width / 2.0;
            double centerY = currentImage.Height / 2.0;
            double x, y;//反变换所得原图中的x,y
            double _x, _y;//所需坐标
            double r;//极坐标变换
            double theta;//极坐标变换
           
            progressBar.Maximum = temp.Width;
            progressBar.Visible = true;
            infoLabel.Visible = true;
            for (int i = 0; i < temp.Width; i++)
            {
                progressBar.Value = i;
                progressBar.PerformStep();
                Application.DoEvents();
                for (int j = 0; j < temp.Height; j++)
                {
                    _x = i - centerX;
                    _y = j - centerY;
                    r = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
                    theta = Math.Atan2(_y, _x);
                    if (r > R)
                    {
                        temp.SetPixel(i, j, currentImage.GetPixel(i, j));
                        continue;
                    }
                    double alpha = theta - k*Math.Sin(r / R * ro + phi);

                    x = r * Math.Cos(alpha)+centerX;
                    y = r * Math.Sin(alpha)+centerY;


                    Color col;
                    if (nearestButton.Checked)
                        col = Nearest(x, y);
                    else if (bilearButton.Checked)
                        col = Bilear(x, y);
                    else 
                        col = Bicubic(x, y);
                    temp.SetPixel(i, j, col);
                }
            }
            newPic.Image = temp;
            myImage = temp;
            waterButton.Enabled = true;
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforeDT);
            infoLabel.Text = "水纹变换完成！"+ "耗时："+ts.TotalMilliseconds.ToString()+"ms";;
        }

        private void savePic_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap save_pic = new Bitmap(newPic.Image);
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.Title = "保存图片";
                saveDlg.OverwritePrompt = true;
                saveDlg.Filter = "BMP文件(*.bmp)|*.bmp|" + "JPEG文件(*.jpg)|*.jpg|" + "PNG文件(*.png)|*.png";
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    string savename = saveDlg.FileName;
                    string strfilextn = savename.Remove(0, savename.Length - 3);
                    switch (strfilextn)
                    {
                        case "bmp":
                            save_pic.Save(savename, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case "jpg":
                            save_pic.Save(savename, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case "png":
                            save_pic.Save(savename, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("还没有执行变换，无法保存图片");
                return;
            }


        }

        private void dynamicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您正在尝试动态展示，动态展示中使用最近邻以保证流畅性.");
            Bitmap currentImage = myImage;
            Bitmap temp = new Bitmap(currentImage.Width, currentImage.Height);

            double R, ro, phi, k;
            try
            {
                R = Convert.ToDouble(radiusText2.Text);
                ro = Convert.ToDouble(roText.Text); phi = Convert.ToDouble(phiText.Text);
                k = Convert.ToDouble(kValue.Text);
            }
            catch
            {
                MessageBox.Show("你输入了非法字符，请重新输入！");
                return;
            }

            double Rmax = Math.Min(currentImage.Height / 2, currentImage.Width);
            if (R > Rmax)
            {
                MessageBox.Show("您输入的半径超出了图片的最大尺寸！，将使用最大半径" + Rmax.ToString());
                Radius.Text = Rmax.ToString();
                R = Rmax;
            }

            double centerX = currentImage.Width / 2.0;
            double centerY = currentImage.Height / 2.0;
            double x, y;//反变换所得原图中的x,y
            double _x, _y;//所需坐标
            double r;//极坐标变换
            double theta;//极坐标变换
            double step = 0.1;

            infoLabel.Text = "正在动态水纹展示";
            progressBar.Maximum = temp.Width*(Convert.ToInt32((2 * Math.PI)/step)+2);
            progressBar.Value = 0;
            progressBar.Visible = true;
            infoLabel.Visible = true;
            changePic.Enabled = false;
            for (phi = 0; phi < 2 * Math.PI; phi += step)
            {
                //Console.WriteLine(progressBar.Value);
                for (int i = 0; i < temp.Width; i++)
                {
                    progressBar.Value = progressBar.Value + 1;
                    Application.DoEvents();
                    for (int j = 0; j < temp.Height; j++)
                    {
                        _x = i - centerX;
                        _y = j - centerY;
                        r = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
                        theta = Math.Atan2(_y, _x);
                        if (r > R)
                        {
                            temp.SetPixel(i, j, currentImage.GetPixel(i, j));
                            continue;
                        }
                        double alpha = theta - k * Math.Sin(r / R * ro + phi);

                        x = r * Math.Cos(alpha) + centerX;
                        y = r * Math.Sin(alpha) + centerY;


                        Color col;
                        col = Nearest(x, y);
                        temp.SetPixel(i, j, col);
                    }
                }
                newPic.Image = temp;
            }
            infoLabel.Text = "水纹动态变换完成！";
            changePic.Enabled = true;
        }

        private void changePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG" + "|All Files (*.*)|*.*";//兼容各种格式的图片
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                myImage = new Bitmap(ofdlg.FileName);
                if (myImage.Height * myImage.Width > 400000)
                {
                    DialogResult dr = MessageBox.Show("检测到您的图片较大，插值时间可能较长，是否压缩？", "是否压缩图片", MessageBoxButtons.YesNoCancel);
                    if ( dr== System.Windows.Forms.DialogResult.Yes)
                    {
                        myImage = new Bitmap(myImage, 400, 400);
                    }
                }
                pictureBox1.Image = myImage;
                picHeight = myImage.Height;
                picWidth = myImage.Width;
                newPic.Image = myImage;
            }
        }

        private void original_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 temp = new Form2(new Bitmap(newPic.Image));
                temp.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("请先进行变换再查看原图！");
                return;
            }

        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BSpine.BPic temp = new BSpine.BPic(new Bitmap(myImage,400,400));
            temp.ShowDialog();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {
            newPic.Image = pictureBox1.Image;
            myImage = new Bitmap(this.pictureBox1.Image, 400, 400);
        }

        public class Matrix
        {
            public double[,] m_data;
            public Matrix(int row,int col)
            {
                m_data = new double[row, col];
            }
            
            public int Row
            {
                get
                {
                    return m_data.GetLength(0);
                }
            }
            public int Col
            {
                get
                {
                    return m_data.GetLength(1);
                }
            }
            public Matrix(Matrix m)
            {
                m_data = new double[m.Row, m.Col];
                for (int i = 0; i < m.Row; i++)
                    for (int j = 0; j < m.Col; j++)
                        m_data[i, j] = m[i, j];
            }

            public double this[int row, int col]
            {
                get
                {
                    return m_data[row, col];
                }
                set
                {
                    m_data[row, col] = value;
                }
            }

            public static Matrix operator *(Matrix lhs, Matrix rhs)
            {
                Matrix ret = new Matrix(lhs.Row, rhs.Col);
                double temp;
                for (int i = 0; i < lhs.Row; i++)
                {
                    for (int j = 0; j < rhs.Col; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < lhs.Col; k++)
                        {
                            temp += lhs[i, k] * rhs[k, j];
                        }
                        ret[i, j] = temp;
                    }
                }
                return ret;
            }

        }
            
    }
}
