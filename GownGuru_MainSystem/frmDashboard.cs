using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace GownGuru_MainSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            SetDoubleBuffer(GownBox, true);
            SetDoubleBuffer(AvailableGownBox, true);
            SetDoubleBuffer(customerBox, true);
            SetDoubleBuffer(gownRentedBox, true);
            SetDoubleBuffer(revenueBox, true);
            SetDoubleBuffer(damageLostBox, true);
            SetDoubleBuffer(inPossessionBox, true);
            SetDoubleBuffer(gownReturnedBox, true);
        }
        //to avoid flicker elements
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctl, new object[] { DoubleBuffered });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //to avoid flicker forms
        protected override CreateParams CreateParams
        {
            get
            {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        private void GownBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            GownBox.BackColor = Color.FromArgb(90, GownBox.BackColor);

            
        }

        private void AvailableGownBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            AvailableGownBox.BackColor = Color.FromArgb(90, AvailableGownBox.BackColor);

            //SetDoubleBuffer(AvailableGownBox, true);
        }

        private void customerBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            customerBox.BackColor = Color.FromArgb(90, customerBox.BackColor);

            //SetDoubleBuffer(customerBox, true);
        }

        private void gownRentedBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            gownRentedBox.BackColor = Color.FromArgb(90, gownRentedBox.BackColor);

            //SetDoubleBuffer(gownRentedBox, true);
        }

        private void revenueBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            revenueBox.BackColor = Color.FromArgb(90, revenueBox.BackColor);

            //SetDoubleBuffer(revenueBox, true);
        }

        private void damageLostBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            damageLostBox.BackColor = Color.FromArgb(90, damageLostBox.BackColor);

            //SetDoubleBuffer(damageLostBox, true);
        }

        private void inPossessionBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            inPossessionBox.BackColor = Color.FromArgb(90, inPossessionBox.BackColor);

            //SetDoubleBuffer(inPossessionBox, true);
        }

        private void gownReturnedBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            gownReturnedBox.BackColor = Color.FromArgb(90, gownReturnedBox.BackColor);

            //SetDoubleBuffer(gownReturnedBox, true);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            SetDoubleBuffer(tableLayoutPanel1, true);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
