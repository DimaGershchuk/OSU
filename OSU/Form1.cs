using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSU
{
    public partial class Form1 : Form
    {
        public Bitmap Handlertexure = Resource1.Handler, TargetTexture = Resource1.Target;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            UpdateStyles();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var localPosition = this.PointToClient(Cursor.Position);
            g.DrawImage(Handlertexure, new Rectangle(localPosition.X, localPosition.Y, 100, 100));
            g.DrawImage(TargetTexture, new Rectangle(0, 0, 100, 100));

        }
    }
}
