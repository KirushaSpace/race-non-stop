using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Без_тормазов
{ 
    class GameForm : Form
    {
        private readonly Timer timer;
        public readonly Size formSize = new Size(1280, 720);
        private readonly Bitmap car;
        private readonly Image image;
        private Car redCar = new Car(new Vector(50,50), Vector.Zero, 0);

        public GameForm()
        {
            car = images.car;
            ClientSize = formSize;
            image = new Bitmap(formSize.Width, formSize.Height, PixelFormat.Format32bppArgb);
            timer = new Timer { Interval = 10 };
            timer.Tick += TimerTick;
            timer.Start(); 
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint, true); 
            UpdateStyles(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            DrawTo(g);
        } 

        private void DrawTo(Graphics g)
        {
            var posCursor = this.PointToClient(MousePosition);
            g.DrawImage(car, new Point(posCursor.X, posCursor.Y));
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Update();
            Refresh();
            Invalidate();
        }
    }
}
