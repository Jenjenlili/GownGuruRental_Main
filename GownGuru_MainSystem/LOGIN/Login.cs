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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Point mouseLocation;

        public Login()
        {
            InitializeComponent();
            SetDoubleBuffer(customPanel1, true);
            SetDoubleBuffer(pnlInvalidPass, true);
            SetDoubleBuffer(pnlInvalidUsr, true);
            SetDoubleBuffer(txtUsername, true);
            SetDoubleBuffer(txtPassword, true);
            SetDoubleBuffer(pnlBG, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            // Set the form's region to create rounded corners
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tblEmployee WHERE username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", con);
                con.Open();
                dr = cm.ExecuteReader();

                if (dr.Read() == true)
                {
                    new MAIN().Show();
                    this.Hide();
                    pnlInvalidUsr.Visible = false;
                    pnlInvalidPass.Visible = false;
                }
                else if (dr.Read() == false)
                {
                    pnlInvalidUsr.Visible = true;
                    pnlInvalidPass.Visible = true;
                    txtUsername.Text = "";
                    txtPassword.Text = "";

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }


        }

        private void Username__TextChanged(object sender, EventArgs e)
        {  
            pnlInvalidUsr.Visible = false;
        }

        private void Password__TextChanged(object sender, EventArgs e)
        {
            pnlInvalidPass.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void customPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void customPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Username_Load(object sender, EventArgs e)
        {

        }
    }
}
