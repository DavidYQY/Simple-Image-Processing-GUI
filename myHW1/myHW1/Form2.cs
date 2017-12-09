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
    public partial class Form2 : Form
    {
        public Form2(Bitmap image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            double ratio = image.Width /(double) image.Height;
          //  Console.WriteLine(ratio);
            int maxWidth = 1280, maxHeight = 720;
            if (ratio > 16 / 9)
            {// 宽图
                if (image.Width > maxWidth)
                {
                    this.Width = maxWidth;
                    this.Height = Convert.ToInt32(maxWidth / ratio);
                }
                else
                {
                    this.Width = image.Width;
                    this.Height = image.Height;
                }

            }
            else
            {//高图
                if(image.Height>maxHeight)
                {
                    //Console.WriteLine("hi");
                    this.Width = Convert.ToInt32(ratio * maxHeight);
                    this.Height = maxHeight;
                    //Console.WriteLine(this.Width + " "+this.Height);
                }
                else
                {
                    
                    this.Width = image.Width;
                    this.Height = image.Height;
                }
            }
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
