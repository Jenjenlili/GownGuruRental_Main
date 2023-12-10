using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem
{
    internal class CustomPanel : Panel
    {
        private int borderRadius = 30;
        private float gradientAngle = 80F;
        private Color gradientTopColor = Color.White;
        private Color gradientBottomColor = Color.White;

        public CustomPanel()
        {
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);

        }

        public int BorderRadius
        { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        public float GradientAngle
        { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }
        public Color GradientTopColor
        { get => gradientTopColor; set { gradientTopColor = value; this.Invalidate(); } }
        public Color GradientBottomColor
        { get => gradientBottomColor; set { gradientBottomColor = value; this.Invalidate(); } }

        private GraphicsPath GetGraphicsPath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.GradientBottomColor, this.GradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            //brder
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetGraphicsPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else this.Region = new Region(rectangleF);

        }


    }
}
