using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem.LOGIN
{
    public class customTxtBox : TextBox
    {
        // Border Color
        private Color _borderColor = Color.Gray;
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        // Border Color when Focused
        private Color _borderColorFocus = Color.Blue;
        public Color BorderColorFocus
        {
            get { return _borderColorFocus; }
            set { _borderColorFocus = value; }
        }

        // Border Radius
        private int _borderRadius = 5;
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen borderPen = new Pen(Focused ? _borderColorFocus : _borderColor);
            borderPen.Width = 2; // Set the border thickness
            g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
            borderPen.Dispose();
        }
    }
}

