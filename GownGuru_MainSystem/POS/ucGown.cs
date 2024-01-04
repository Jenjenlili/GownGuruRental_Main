using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem.POS
{
    public partial class ucGown : UserControl
    {
        public EventHandler onSelect = null;
        public ucGown()
        {
            InitializeComponent();
        }
        //properties of usercontrol
        public int id { get; set; }
        public string gName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string gPrice
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }

        public Image gImage
        {
            get { return txtPic.Image; }
            set { txtPic.Image = value; }
        }

        private void txtPic_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            // open detail form design latter
            frmDetails details = new frmDetails() { id = id };
            details.ShowDialog();
        }

        private void ucGown_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(250, 242, 212);
        }

        private void ucGown_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
        }

        private void CenterLabels()
        {
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    label.Left = (ClientSize.Width - label.Width) / 2;
                    label.Top = (ClientSize.Height - label.Height) / 2;
                }
            }
        }

        private void ucGown_Resize(object sender, EventArgs e)
        {
            //enterLabels();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            CenterLabels();
        }
    }
}
