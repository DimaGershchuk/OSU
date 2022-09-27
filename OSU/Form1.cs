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

        private Point _targetPosition = Point.Empty;
        private Point _direction = Point.Empty;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            timer2.Interval = r.Next(25, 500);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var localPosition = this.PointToClient(Cursor.Position);
            _targetPosition.X += _direction.X;
            _targetPosition.X -= _direction.Y;
            var handlerRect = new Rectangle(localPosition.X - 50, localPosition.Y - 50, 100, 100);
            var targetRect = new Rectangle(_targetPosition.X - 50, _targetPosition.Y - 50, 100,100);
            g.DrawImage(Handlertexure, handlerRect);
            g.DrawImage(TargetTexture, targetRect);
            

        }
    }
}
