using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSpine
{
    public partial class BPic : Form
    {
        int clickTimes = 0;
        bool change = false;
        bool transform = false;
        Point initital=new Point();
        Point target=new Point();
        Bitmap myImage;
        private Color Bilear(double indexX, double indexY)
        {
            int picHeight = myImage.Height;
            int picWidth = myImage.Width;
            int x = (int)Math.Floor(indexX);
            int y = (int)Math.Floor(indexY);
            double w1 = indexX - x;
            double w2 = indexY - y;

            if (x >=picWidth  - 1 || y >= picHeight - 1)
                return myImage.GetPixel(picWidth - 1, picHeight - 1);
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
                 myImage.GetPixel(x + 1, y + 1).R * (w1) * (w2);
            G = myImage.GetPixel(x, y).G * (1 - w1) * (1 - w2) +
                myImage.GetPixel(x + 1, y).G * (w1) * (1 - w2) +
                myImage.GetPixel(x + 1, y + 1).G * (1 - w1) * (w2) +
                 myImage.GetPixel(x, y + 1).G * (w1) * (w2);
            B = myImage.GetPixel(x, y).B * (1 - w1) * (1 - w2) +
                myImage.GetPixel(x + 1, y).B * (w1) * (1 - w2) +
                myImage.GetPixel(x, y + 1).B * (1 - w1) * (w2) +
                 myImage.GetPixel(x + 1, y + 1).B * (w1) * (w2);
            return Color.FromArgb((int)R, (int)G, (int)B);
        }
        private Color Bicubic(double indexX, double indexY)
        {
            int picHeight = myImage.Height;
            int picWidth = myImage.Width;
            int i = (int)Math.Floor(indexX);
            int j = (int)Math.Floor(indexY);
            double u = indexX - i;
            double v = indexY - j;

            if (i >= picWidth - 2 || j >= picHeight - 2)
                return myImage.GetPixel(picWidth - 1, picHeight - 1);
            if (i <= 0 && j <= 0)
                return myImage.GetPixel(0, 0);
            if (i <= 0)
                return myImage.GetPixel(0, j);
            if (j <= 0)
                return myImage.GetPixel(i, 0);

            double R, G, B;

            Matrix A = new Matrix(1, 4);
            for (int k = 0; k < 4; k++)
                A[0, k] = aux_bicubic(u + 1 - k);
            Matrix C = new Matrix(4, 1);
            for (int k = 0; k < 4; k++)
                C[k, 0] = aux_bicubic(v + 1 - k);

            Matrix m_B = new Matrix(4, 4);//跟B重名了
            for (int k1 = 0; k1 < 4; k1++)
                for (int k2 = 0; k2 < 4; k2++)
                    m_B[k1, k2] = myImage.GetPixel(i + k1 - 1, j + k2 - 1).R;
            R = (A * m_B * C)[0, 0];
            for (int k1 = 0; k1 < 4; k1++)
                for (int k2 = 0; k2 < 4; k2++)
                    m_B[k1, k2] = myImage.GetPixel(i + k1 - 1, j + k2 - 1).G;
            G = (A * m_B * C)[0, 0];
            for (int k1 = 0; k1 < 4; k1++)
                for (int k2 = 0; k2 < 4; k2++)
                    m_B[k1, k2] = myImage.GetPixel(i + k1 - 1, j + k2 - 1).B;
            B = (A * m_B * C)[0, 0];

            if (R < 0) R = 0; if (R > 255) R = 255;
            if (G < 0) G = 0; if (G > 255) G = 255;
            if (B < 0) B = 0; if (B > 255) B = 255;

            return Color.FromArgb((int)R, (int)G, (int)B);
        }
        private Color Nearest(double indexX, double indexY)
        {
            int picHeight = myImage.Height;
            int picWidth = myImage.Width;
            int x = (int)Math.Floor(indexX);
            int y = (int)Math.Floor(indexY);
            double w1 = indexX - x;
            double w2 = indexY - y;

            if (x >= picWidth - 2 || y >= picHeight - 2)
                return myImage.GetPixel(picWidth - 1, picHeight - 1);
            if (x <= 0 && y <= 0)
                return myImage.GetPixel(0, 0);
            if (x <= 0)
                return myImage.GetPixel(0, y);
            if (y <= 0)
                return myImage.GetPixel(x, 0);

            if (w1 > 0.5) x = x + 1;
            if (w2 > 0.5) y = y + 1;
            if (x >= picWidth) x = picWidth - 1; if (x < 0) x = 0;
            if (y >= picHeight) y = picHeight - 1; if (y < 0) y = 0;

            return myImage.GetPixel(x, y);
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
        private double G(int i, double t)
        {
            double ans = 0;
            if (i == 0)
            {
                ans = -Math.Pow(t, 3) + 3 * Math.Pow(t, 2) - 3 * t + 1;
            }
            else if (i == 1)
            {
                ans = 3 * Math.Pow(t, 3) - 6 * Math.Pow(t, 2) + 4;
            }
            else if (i == 2)
            {
                ans = -3 * Math.Pow(t, 3) + 3 * Math.Pow(t, 2) + 3 * t + 1;
            }
            else if (i == 3)
            {
                ans = Math.Pow(t, 3);
            }
            ans = ans * 1 / (6.0);
            return ans;
        }
        public BPic()
        {
            InitializeComponent();
            myPic.Image = new Bitmap(BSpine.Properties.Resources.LENA,400,400);
            myImage = new Bitmap(myPic.Image);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mouse_pos = myPic.PointToClient(Control.MousePosition);
            if(!transform)
            {
                if (change)
                {
                    Refresh();
                    if (clickTimes == 0)
                    {
                        labelY.Text = "0";
                        labelX.Text = "0";
                        labelX2.Text = "100";
                        labelY2.Text = "100";
                        change = false;
                    }
                    else
                    {
                        Graphics lines = myPic.CreateGraphics();
                        Pen LinePen = new Pen(Color.Green, 2);//画线
                        Pen PointPen1 = new Pen(Color.Red, 4);
                        Pen PointPen2 = new Pen(Color.Blue, 4);
                        int num = 5;
                        if (clickTimes % 2 == 1)
                        {
                            //infoLabel.Text = "正在等待确认目标点...";
                            lines.DrawLine(LinePen, initital, mouse_pos);
                            lines.DrawEllipse(PointPen1, initital.X - num, initital.Y - num, 10, 10);
                            labelX.Text = initital.X.ToString();
                            labelY.Text = initital.Y.ToString();
                            if (mouse_pos.X < 0 || mouse_pos.X > myPic.Width) labelX2.Text = "0";
                            else
                                labelX2.Text = (mouse_pos.X).ToString();
                            if (mouse_pos.Y < 0) labelY2.Text = "0";
                            else
                                labelY2.Text = mouse_pos.Y.ToString();
                        }
                        else
                        {
                            //infoLabel.Text = "目标点确认完毕，可以进行变换";
                            lines.DrawLine(LinePen, initital, target);
                            lines.DrawEllipse(PointPen1, initital.X - num, initital.Y - num, 10, 10);
                            lines.DrawEllipse(PointPen2, target.X - num, target.Y - num, 10, 10);
                            change = false;
                            labelX2.Text = target.X.ToString();
                            labelY2.Text = target.Y.ToString();
                        }
                    }
                }
                else
                {
                    //infoLabel.Text="请单击鼠标以选择起始点...";
                    if (clickTimes == 0)
                    {
                        if (mouse_pos.X < 0 || mouse_pos.X > myPic.Width) labelX.Text = "0";
                        else
                            labelX.Text = (mouse_pos.X).ToString();
                        if (mouse_pos.Y < 0) labelY.Text = "0";
                        else
                            labelY.Text = mouse_pos.Y.ToString();
                    }
                }
            }
            else//变换中
            {

            }
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myPic_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseLoc = (MouseEventArgs)e;
            clickTimes += 1;
            change = true;
            if (clickTimes % 2 == 1)
            {//选点
                initital.X = mouseLoc.X;
                initital.Y = mouseLoc.Y;
            }
            else
            {
                target.X = mouseLoc.X;
                target.Y = mouseLoc.Y;
            }
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            clickTimes = 0;
            initital = new Point(0, 0);
            target = new Point(0, 0);
            change = true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.Control;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(clickTimes==0 || clickTimes % 2 == 1)
            {
                MessageBox.Show("请单击鼠标选择起点和终点！");
                return;
            }
            infoLabel.Text = "正在B样条变形";
            transform = true;
            int Nx, Ny;
            try
            {
                Nx = Convert.ToInt32(m_Nx.Text);
                Ny = Convert.ToInt32(m_Ny.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("你输入了非法字符！请重新输入！");
                return;
            }
            if(Nx>40 || Ny > 40)
            {
                MessageBox.Show("将采取Nx=40,Ny=40");
                Nx = 40;Ny = 40;
                m_Nx.Text = "40";
                m_Ny.Text = "40";
            }
            Bitmap newPic = new Bitmap(myPic.Image);
            Bitmap oldPic = new Bitmap(myPic.Image);
            myImage = oldPic;
            Point m_Point = new Point(initital.X / Nx, initital.Y / Ny);
            initital = new Point(m_Point.X * Nx, m_Point.Y * Ny);
            double dx = target.X - initital.X;
            double dy = target.Y - initital.Y;
            double C = 3;
            if (dx > C * Nx) dx = C * Nx;
            if (dy > C * Ny) dy = C * Ny;
            if (positive.Checked)//采取正变换法
            {
                double[,] vx = new double[4 * Nx, 4 * Ny];
                double[,] vy = new double[4 * Nx, 4 * Ny];

                progressBar.Maximum = 8 * Nx;
                progressBar.Visible = true;
                progressBar.Value = 0;
                
                for (int x0 = -2 * Nx; x0 < 2 * Nx; x0++)
                {
                    progressBar.Value = x0 + 2 * Nx;
                    Application.DoEvents();
                    for (int y0 = -2 * Ny; y0 < 2 * Ny; y0++)
                    {
                        int x = x0 + initital.X;
                        int y = y0 + initital.Y;
                        //Console.WriteLine(x + " " + y);
                        int i = x / Nx - 1;
                        int j = y / Ny - 1;
                        double u = (double)x / Nx - x / Nx;
                        double v = (double)y / Ny - y / Ny;
                        bool flag = false;
                        for (int l = 0; l <= 3; l++)
                            for (int m = 0; m <= 3; m++)
                                if ((i + l) == m_Point.X && (j + m) == m_Point.Y)
                                {
                                    double temp = G(l, u) * G(m, v);
                                    //Console.WriteLine(temp);
                                    vx[x0 + 2 * Nx, y0 + 2 * Ny] = x + temp * dx;
                                    vy[x0 + 2 * Nx, y0 + 2 * Ny] = y + temp * dy;
                                    flag = true;
                                    //Console.WriteLine((i + l) + " " + (j + m));
                                }
                        if(!flag)
                            Console.WriteLine(x + " " + i + " " + y + " " + j + m_Point.X + " " + m_Point.Y);
                    }
                }
                for (int x0 = -2 * Nx; x0 < 2 * Nx; x0++)
                {
                    progressBar.Value = x0 + 6 * Nx;
                    Application.DoEvents();
                    for (int y0 = -2 * Ny; y0 < 2 * Ny; y0++)
                    {
                        int x = x0 + initital.X;
                        int y = y0 + initital.Y;
                        if (x < 0) x = 0;
                        if (x >= oldPic.Width) x = oldPic.Width - 1;
                        if (y < 0) y = 0;
                        if (y >= oldPic.Height) y = oldPic.Height - 1;
                        Color col;

                        //最近邻
                        double disMin = 10000;
                        int ansX = 0, ansY = 0;
                        for (int i = 0; i < 4 * Nx; i++)
                            for (int j = 0; j < 4 * Ny; j++)
                            {
                                double dis = Math.Pow(vx[i, j] - x, 2) + Math.Pow(vy[i, j] - y, 2);
                                if (dis < disMin)
                                {
                                    ansX = i - 2 * Nx + initital.X;
                                    if (ansX < 0) ansY = 0;
                                    if (ansX >= oldPic.Width) ansX = oldPic.Width - 1;
                                    ansY = j - 2 * Ny + initital.Y;
                                    if (ansY < 0) ansY = 0;
                                    if (ansY >= oldPic.Height) ansY = oldPic.Height - 1;
                                    disMin = dis;
                                }
                            }
                        //Console.WriteLine("(" + x + " " + y + ")" + "(" + ansX + " " + ansY + ")");
                        col = oldPic.GetPixel(ansX, ansY);
                        //col = Color.Green;
                        newPic.SetPixel(x, y, col);
                    }
                }
            }
            if (negative.Checked)
            {
                progressBar.Maximum = 4 * Nx;
                progressBar.Visible = true;
                progressBar.Value = 0;
                double ansX=0, ansY=0;
                for(int x0=-2*Nx; x0<2*Nx; x0++)
                {
                    progressBar.Value = x0 + 2 * Nx;
                    Application.DoEvents();
                    for (int y0=-2*Ny;y0<2*Ny;y0++)
                    {
                        int x = x0 + m_Point.X*Nx;
                        if (x < 0) x = 0;
                        if (x >= oldPic.Width - 1) x = oldPic.Width - 1;
                        int y = y0 + m_Point.Y*Ny;
                        if (y < 0) y = 0;
                        if (y > oldPic.Height - 1) y = oldPic.Height - 1;
                        //Console.WriteLine(x + " " + y);
                        int i = x / Nx - 1;
                        int j = y / Ny - 1;
                        double u = (double)x / Nx - x / Nx;
                        double v = (double)y / Ny - y / Ny;
                        bool flag = false;
                        for (int l = 0; l <=3; l++)
                            for (int m = 0; m <=3; m++)
                                if ((i + l) == m_Point.X && (j + m) == m_Point.Y)
                                {
                                    double temp = G(l, u) * G(m, v);
                                    //Console.WriteLine(temp);
                                    ansX = x - temp * dx;
                                    ansY = y - temp * dy;
                                    flag = true;
                                    //Console.WriteLine((i + l) + " " + (j + m));
                                }
                        if (!flag)
                            Console.WriteLine(x+" "+i+" "+y+" "+j+m_Point.X+" "+m_Point.Y);
                        Color col;
                        if (radioButton1.Checked)
                            col = Nearest(ansX, ansY);
                        else if (radioButton2.Checked)
                            col = Bilear(ansX, ansY);
                        else
                            col = Bicubic(ansX, ansY);
                        newPic.SetPixel(x, y, col);
                    }
                }
            }
            myPic.Image = newPic;
            myImage = newPic;
            infoLabel.Text = "B样条变形完成！";
            transform = false;
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap save_pic = new Bitmap(myPic.Image);
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
            catch (NullReferenceException)
            {
                MessageBox.Show("还没有执行变换，无法保存图片");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myPic.Image = new Bitmap(BSpine.Properties.Resources.LENA, 400, 400);
            myImage = new Bitmap(myPic.Image);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public class Matrix
        {
            public double[,] m_data;
            public Matrix(int row, int col)
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
