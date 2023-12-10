using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem.LOGIN
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = LIYAN\\SQLEXPRESS; Initial Catalog = Finals; Integrated Security = True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Point mouseLocation;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tblEmployee WHERE username= '" + Username.Text + "' and password= '" + Password.Text + "'", con);
                con.Open();
                dr = cm.ExecuteReader();

                if (dr.Read() == true)
                {
                    pnlInvalidUsr.Visible = false;
                    pnlInvalidPass.Visible = false;
                    new MAIN().Show();
                    this.Hide();
                }
                else if (dr.Read() == false) { }
                {
                    pnlInvalidUsr.Visible = true;
                    pnlInvalidPass.Visible = true;
                }

            }
            catch
            {

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
                Password.PasswordChar = false;
            }
            else
            {
                Password.PasswordChar = true;
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
    }
}
