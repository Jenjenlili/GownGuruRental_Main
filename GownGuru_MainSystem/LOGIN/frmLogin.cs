using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem.LOGIN
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmLogin()
        {
            InitializeComponent();
            SetDoubleBuffer(panel, true);
            SetDoubleBuffer(pnlBG, true);
            SetDoubleBuffer(txtUsername, true);
            SetDoubleBuffer(txtPassword, true);
            SetDoubleBuffer(pnlInvalidUsr,true);
            SetDoubleBuffer(pnlInvalidPass,true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            // Set the form's region to create rounded corners
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
            pnlInvalidUsr.Visible = false;
            pnlInvalidPass.Visible = false;



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
        
        //move form
        public Point mouseLocation;
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
                this.Opacity = 0.8;
            }
        }
        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            // Identify forms to close without modifying the collection during iteration
            foreach (Form frm in Application.OpenForms)
            {
                if (frm != this) // Exclude the current form (Login form)
                {
                    formsToClose.Add(frm);
                }
            }

            // Close the identified forms
            foreach (Form frm in formsToClose)
            {
                frm.Close();
            }

            // Close the current form (Login form)
            this.Close();
        }

        private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.FromArgb(249, 211, 66);
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.Transparent;
        }

        
        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
            /*if (checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = false; // Show actual text (set PasswordChar to null)
            }
            else
            {
                txtPassword.PasswordChar = true; // Show password characters
            }*/
        }
        private void txtUsername__TextChanged(object sender, EventArgs e)
        {
            pnlInvalidUsr.Visible = false;
        }

        private void txtPassword__TextChanged(object sender, EventArgs e)
        {
            pnlInvalidPass.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tblEmployee WHERE empStatus = 'Active' AND username = @username and password = @password", con);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);

                con.Open();
                dr = cm.ExecuteReader();
                if (dr.Read() == true)
                {
                    // Display the retrieved values for debugging purposes
                    /*for (int i = 0; i < dr.FieldCount; i++)
                    {
                        Console.WriteLine($"{dr.GetName(i)}: {dr.GetValue(i)}");
                    }*/

                    new MAIN().Show();
                    this.Hide();
                    pnlInvalidUsr.Visible = false;
                    pnlInvalidPass.Visible = false;
                }
                else
                {
                    pnlInvalidUsr.Visible = true;
                    pnlInvalidPass.Visible = true;
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                    
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }


        }

        
    }
   
}
