using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MDIApplication
{
    public partial class ImageHolder : Form
    {
        public ImageHolder(MDIS parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }


        public void loadImage(string fname)
        {
            int minWidth = 100;
            int minHeight = 50;
            int maxWidth = 1024;
            int maxHeight = 800;
            Bitmap img = new Bitmap(fname);
            pictureBox1.Image = img;
            if (img.Width + 15 > minWidth)
                this.Width = img.Width + 15;
            else
                this.Width = minWidth;
            if (img.Height > minHeight)
                this.Height = img.Height + 40;
            else
                this.Height = minHeight;
            if (img.Width > maxWidth)
                this.Width = maxWidth;
            if (img.Height > maxHeight)
                this.Height = maxHeight;

        }

        public void sendImageX()
        {
            Bitmap a;
            if(pictureBox1.Image != null)
            {
                 a = new Bitmap(pictureBox1.Image);
                 swappingClass.setX = a;
                 swappingClass.nullx = false;
            }
            else
                swappingClass.nullx = true;

        }
        public void sendImageY()
        {
            Bitmap a;
            if (pictureBox1.Image != null)
            {
                a = new Bitmap(pictureBox1.Image);
                swappingClass.setY = a;
                swappingClass.nully = false;
            }
            else
                swappingClass.nully = true;
        }
        public void setBackgroundX()
        {
            if (swappingClass.nullx == false)
            {
                pictureBox1.Image = swappingClass.x;
                this.Size = swappingClass.x.Size;
            }
            else
                pictureBox1.Image = null;
        }
        public void setBackgroundY()
        {
            if (swappingClass.nully == false)
            {
                pictureBox1.Image = swappingClass.y;
                this.Size = swappingClass.y.Size;
            }
            else
                pictureBox1.Image = null;
        }
    }
}
