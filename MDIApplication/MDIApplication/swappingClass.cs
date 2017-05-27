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
    static class swappingClass
    {
        public static Bitmap x;
        public static Bitmap y;
        public static bool nullx;
        public static bool nully;

        public static Bitmap setX
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }

        }
        public static Bitmap setY
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }

        }
        public static bool nullX
        {
            get
            {
                return nullx;
            }
            set
            {
                nullx = value;
            }

        }
        public static bool nullY
        {
            get
            {
                return nully;
            }
            set
            {
                nully = value;
            }

        }
    }
}
