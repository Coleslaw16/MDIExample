//MDI application which imports images onto SDI and allows the swapping of images between two SDI
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class MDIS : Form
    {
        public int count = 0;
        public MDIS()
        {
            InitializeComponent();
        }

        private void makeNewMdiChild()
        {
            MDIApplication.ImageHolder child = new MDIApplication.ImageHolder(this);
            child.Show();
            this.ActiveMdiChild.Text = "Part " + Convert.ToString(count);
            count += 1;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeNewMdiChild();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int len;

            string fileName = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|Bitmap files (*.bmp)|*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                Bitmap img = new Bitmap(fileName);
                makeNewMdiChild();
                ImageHolder activeChild = this.ActiveMdiChild as ImageHolder;
                len = fileName.Length;
                if (len > 40)
                    activeChild.Text = fileName.Substring(0, 35) + "..." + fileName.Substring(len - 4, 4);
                else
                    activeChild.Text = fileName;
                activeChild.loadImage(fileName);
            }            
        }

        private void swapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int first = count + 1;
            int Second = count + 1;
            if (!string.IsNullOrWhiteSpace(xHolder.Text))
                 first = int.Parse(xHolder.Text);
            if (!string.IsNullOrWhiteSpace(yHolder.Text))
                 Second = int.Parse(yHolder.Text);
            if(first < this.MdiChildren.Length && Second < this.MdiChildren.Length)
            {
                ImageHolder temp = (ImageHolder)(this.MdiChildren[first]);
                temp.sendImageX();
                ImageHolder temp2 = (ImageHolder)(this.MdiChildren[Second]);
                temp2.sendImageY();
                temp.setBackgroundY();
                temp2.setBackgroundX();
            }           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
