using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem.POS
{
    public partial class frmDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public frmDetails()
        {
            InitializeComponent();
            // Set the form's region to create rounded corners
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
            // Event handlers for resizing
            this.MouseDown += frmDetails_MouseDown;
            this.MouseMove += frmDetails_MouseMove;
            this.MouseUp += frmDetails_MouseUp;

            
        }

        //to avoid flicker forms
        protected override CreateParams CreateParams
        {
            get
            {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                //BORDER RADIUS
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS | CS_DROPSHADOW;

                return cp;
            }
        }

        //UI - FORM BORDER RADIUS
        // Constants for WinAPI calls
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        const int CS_DROPSHADOW = 0x20000;

        // Round the form corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        //MOVE FORM
        public Point mouseLocation;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
                this.Opacity = 0.8;
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        //exit button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(231, 184, 8);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.NavajoWhite;
        }

        public int id = 0;
        private void frmDetails_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                cm = new SqlCommand("SELECT * FROM tblGown WHERE gownID = @ID", con);
                cm.Parameters.AddWithValue("@ID", id);

                con.Open();
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    lblName.Text = dr["gownName"].ToString();
                    lblPrice.Text = dr["gownPrice"].ToString();
                    lblDesc.Text = dr["description"].ToString();
                    lblSize.Text = dr["size"].ToString();
                    lblColor.Text = dr["color"].ToString();
                    lblCondition.Text = dr["condition"].ToString();
                    lblCategory.Text = dr["category"].ToString();
                    lblStatus.Text = dr["gownStatus"].ToString();

                    if (!dr.IsDBNull(dr.GetOrdinal("gownPic")))
                    {
                        byte[] ImageArray = (byte[])dr["gownPic"];
                        using (MemoryStream ms = new MemoryStream(ImageArray))
                        {
                            gpic.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Handle situation where the image field is NULL in the database
                        // For example, set a default image or display a placeholder
                        gpic.Image = null; // Set a default image or display a placeholder
                    }
                }
                dr.Close();
                con.Close();
            }
        }

        // RESIZING FORM
        private void frmDetails_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void frmDetails_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void frmDetails_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void lblDesc_TextChanged(object sender, EventArgs e)
        {
            lblDesc.BackColor = Color.FromArgb(36, 36, 36); // You can change this color to your preference
            lblDesc.ForeColor = Color.White;
            lblDesc.SelectionLength = 0;
        }

        private void lblDesc_EnabledChanged(object sender, EventArgs e)
        {
                lblDesc.BackColor = Color.FromArgb(36,36,36); // You can change this color to your preference
                lblDesc.ForeColor = Color.White;
            
        }
    }

}
