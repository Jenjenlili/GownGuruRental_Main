using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem.SETTINGS
{
    public partial class frmEmployeeAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public frmEmployeeAdd()
        {
            InitializeComponent();
            SetDoubleBuffer(panel2, true);
            SetDoubleBuffer(pnlInvalidUsrname, true);
            SetDoubleBuffer(pnlInvalidFn, true);
            SetDoubleBuffer(pnlInvalidPass, true);
            SetDoubleBuffer(pnlPassNotMatch, true);
            SetDoubleBuffer(pnlInvalidPhoneNo, true);
            SetDoubleBuffer(pnlInvalidAdd, true);
            SetDoubleBuffer(pnlInvalidRole, true);

            pnlInvalidUsrname.Visible = false;
            pnlInvalidFn.Visible = false;
            pnlInvalidPass.Visible = false;
            pnlPassNotMatch.Visible = false;
            pnlInvalidPhoneNo.Visible = false;
            pnlInvalidAdd.Visible = false;
            pnlInvalidRole.Visible = false;

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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Clear()
        {
            txtUsername.Clear();
            txtFullname.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            txtPhoneNum.Clear();
            txtAddress.Clear();
            txtRole.Clear();
        }
       
        //validation methods
        private bool IsValidUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || !Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                pnlInvalidUsrname.Visible = true;
                return false;
            }
            return true;
        }

        private bool IsValidField(string field, Panel panel)
        {
            if (string.IsNullOrWhiteSpace(field))
            {
                panel.Visible = true; // Set panel visibility to true if the field is invalid
                return false;
            }
            else
            {
                panel.Visible = false; // Set panel visibility to false if the field is valid
                return true;
            }
        }

        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || !Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$"))
            {
                pnlInvalidPass.Visible = true;
                return false;
            }
            return true;
        }

        private bool ArePasswordsMatching(string password, string reenteredPassword)
        {
            if (password != reenteredPassword)
            {
                pnlPassNotMatch.Visible = true;
                return false;
            }
            return true;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber) || !Regex.IsMatch(phoneNumber, @"^(63|09)\d{9}$"))
            {
                pnlInvalidPhoneNo.Visible = true;
                return false;
            }
            return true;
        }
        private void ResetValidationPanels()
        {
            pnlInvalidUsrname.Visible = false;
            pnlInvalidFn.Visible = false;
            pnlInvalidPass.Visible = false;
            pnlPassNotMatch.Visible = false;
            pnlInvalidPhoneNo.Visible = false;
            pnlInvalidAdd.Visible = false;
            pnlInvalidRole.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                bool anyInvalid = false;

                // Reset visibility of all panels
                ResetValidationPanels();

                // Perform validation for each field individually
                if (!IsValidUsername(txtUsername.Text))
                    anyInvalid = true;

                if (!IsValidField(txtFullname.Text, pnlInvalidFn)) // display the panel for blank fullname
                    anyInvalid = true;

                if (!IsValidPassword(txtPass.Text))
                    anyInvalid = true;

                if (!ArePasswordsMatching(txtPass.Text, txtRePass.Text))
                    anyInvalid = true;
                if (!IsValidField(txtRePass.Text, pnlPassNotMatch)) // display the panel for blank pass
                    anyInvalid = true;

                if (!IsValidPhoneNumber(txtPhoneNum.Text))
                    anyInvalid = true;

                if (!IsValidField(txtAddress.Text, pnlInvalidAdd)) // display the panel for blank address
                    anyInvalid = true;

                if (!IsValidField(txtRole.Text, pnlInvalidRole)) // display the panel for blank role
                    anyInvalid = true;

                if (anyInvalid)
                    return; // Stop processing if any validation failed

                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO tblEmployee(Username, fullname, Password, empPhone, empAddress, role)VALUES(@username,@fullname,@password,@empPhone,@empAddress,@role)", con);
                    cm.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cm.Parameters.AddWithValue("@fullname", txtFullname.Text);
                    cm.Parameters.AddWithValue("@Password", txtPass.Text);
                    cm.Parameters.AddWithValue("@empPhone", txtPhoneNum.Text);
                    cm.Parameters.AddWithValue("@empAddress", txtAddress.Text);
                    cm.Parameters.AddWithValue("@Role", txtRole.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully saved!");
                    Clear();

                    // Log activity in tblActivityLog
                    string activity = "Added an employee";
                    SqlCommand logCommand = new SqlCommand("INSERT INTO tblActivityLog (username, role, timestamp, activity) VALUES (@username, @role, GETDATE(), @activity)", con);
                    logCommand.Parameters.AddWithValue("@username", SessionManager.Get("Username") as string);
                    logCommand.Parameters.AddWithValue("@role", SessionManager.Get("Role") as string);
                    logCommand.Parameters.AddWithValue("@activity", activity);

                    con.Open();
                    logCommand.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool anyInvalid = false;

                // Reset visibility of all panels
                ResetValidationPanels();

                // Perform validation for each field individually
                if (!IsValidUsername(txtUsername.Text))
                    anyInvalid = true;

                if (!IsValidField(txtFullname.Text, pnlInvalidFn)) // display the panel for blank fullname
                    anyInvalid = true;

                if (!IsValidPassword(txtPass.Text))
                    anyInvalid = true;

                if (!ArePasswordsMatching(txtPass.Text, txtRePass.Text))
                    anyInvalid = true;
                if (!IsValidField(txtRePass.Text, pnlPassNotMatch)) // display the panel for blank pass
                    anyInvalid = true;

                if (!IsValidPhoneNumber(txtPhoneNum.Text))
                    anyInvalid = true;

                if (!IsValidField(txtAddress.Text, pnlInvalidAdd)) // display the panel for blank address
                    anyInvalid = true;

                if (!IsValidField(txtRole.Text, pnlInvalidRole)) // display the panel for blank role
                    anyInvalid = true;

                if (anyInvalid)
                    return; // Stop processing if any validation failed

                if (MessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblEmployee SET fullname = @fullname, Password = @Password, empPhone = @empPhone, empAddress = @empAddress, role = @role WHERE username LIKE '" + txtUsername.Text + "' ", con);
                    cm.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cm.Parameters.AddWithValue("@fullname", txtFullname.Text);
                    cm.Parameters.AddWithValue("@Password", txtPass.Text);
                    cm.Parameters.AddWithValue("@empPhone", txtPhoneNum.Text);
                    cm.Parameters.AddWithValue("@empAddress", txtAddress.Text);
                    cm.Parameters.AddWithValue("@role", txtRole.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully updated!");
                    this.Dispose();

                    // Log activity in tblActivityLog
                    string activity = "Updated an employee details";
                    SqlCommand logCommand = new SqlCommand("INSERT INTO tblActivityLog (username, role, timestamp, activity) VALUES (@username, @role, GETDATE(), @activity)", con);
                    logCommand.Parameters.AddWithValue("@username", SessionManager.Get("Username") as string);
                    logCommand.Parameters.AddWithValue("@role", SessionManager.Get("Role") as string);
                    logCommand.Parameters.AddWithValue("@activity", activity);

                    con.Open();
                    logCommand.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.FromArgb(231, 184, 8);
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.NavajoWhite;
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Tan;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Bisque;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Tan;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Bisque;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Firebrick;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(255, 178, 174);
        }

        //move form
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidUsrname.Visible = false;
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidFn.Visible = false;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidPass.Visible = false;
        }

        private void txtRePass_TextChanged(object sender, EventArgs e)
        {
            pnlPassNotMatch.Visible = false;
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidPhoneNo.Visible = false;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidAdd.Visible = false;
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidRole.Visible = false;
        }
    }
}
