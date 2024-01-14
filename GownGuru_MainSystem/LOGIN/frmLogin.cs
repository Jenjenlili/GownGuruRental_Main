using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GownGuru_MainSystem.MAIN;

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
            SetDoubleBuffer(pnlInactive, true);
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
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidUsr.Visible = false;
            pnlInactive.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidPass.Visible = false;
            pnlInactive.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tblEmployee WHERE username COLLATE Latin1_General_CS_AS = @username AND password COLLATE Latin1_General_CS_AS = @password", con);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);

                con.Open();
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    pnlInvalidUsr.Visible = false;
                    pnlInvalidPass.Visible = false;
                    pnlInactive.Visible = false;

                    string username = txtUsername.Text;
                    string role = dr["role"].ToString();
                   
                    string empStatus = dr["empStatus"].ToString(); // Get the status from the database

                    if (empStatus == "Inactive")
                    {
                        pnlInactive.Visible = true;
                    }
                    else
                    {
                        dr.Close();
                       
                        string activity = "Logged in";

                        // Store username and role in the session during successful login
                        SessionManager.Set("Username", username);
                        SessionManager.Set("Role", role);

                        // Log employee activity
                        SqlCommand logCommand = new SqlCommand("INSERT INTO tblActivityLog (username, role, timestamp, activity) VALUES (@username, @role, GETDATE(), @activity)", con);
                        logCommand.Parameters.AddWithValue("@username", username);
                        logCommand.Parameters.AddWithValue("@role", role);
                        logCommand.Parameters.AddWithValue("@activity", activity);
                        logCommand.ExecuteNonQuery();

                        new MAIN().Show();
                        this.Hide();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid login attempt.");
                    pnlInvalidUsr.Visible = true;
                    pnlInvalidPass.Visible = true;

                    //txtUsername.Text = "";
                    //txtPassword.Text = "";
                    txtUsername.Focus();
                    
                }

                con.Close();
            }
            catch (OutOfMemoryException ex)
            {
                // Handle the out-of-memory exception here
                MessageBox.Show("Out of memory: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

    }
   
}
