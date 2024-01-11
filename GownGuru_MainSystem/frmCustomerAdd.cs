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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem
{
    public partial class frmCustomerAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();

        public frmCustomerAdd()
        {
            InitializeComponent();
            SetDoubleBuffer(pnlInvalidName, true);
            SetDoubleBuffer(pnlInvalidGender, true);
            SetDoubleBuffer(pnlInvalidEmail, true);
            SetDoubleBuffer(pnlInvalidPhoneNo,true);
            SetDoubleBuffer(pnlInvalidAdd,true);

            pnlInvalidName.Visible = false;
            pnlInvalidGender.Visible = false;
            pnlInvalidEmail.Visible = false;   
            pnlInvalidPhoneNo.Visible = false;
            pnlInvalidAdd.Visible = false;
            
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void Clear()
        {
            txtCustName.Clear();
            cbGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //validation methods
        private bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, @"^[a-zA-Z0-9]+$"))
            {
                pnlInvalidName.Visible = true;
                return false;
            }
            return true;
        }
        private bool IsValidGender(string gender)
        {
            if (cbGender.SelectedIndex == -1)
            {
                pnlInvalidGender.Visible = true;
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
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) ||  !Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
            {
                pnlInvalidEmail.Visible = true;
                return false;
            }
            return true;
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber) || !Regex.IsMatch(phoneNumber, @"^(09)\d{9}$"))
            {
                pnlInvalidPhoneNo.Visible = true;
                return false;
            }
            return true;
        }
        private void ResetValidationPanels()
        {
            pnlInvalidName.Visible = false;
            pnlInvalidGender.Visible = false;
            pnlInvalidEmail.Visible = false;
            pnlInvalidPhoneNo.Visible = false;
            pnlInvalidAdd.Visible = false;
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool anyInvalid = false;

                // Reset visibility of all panels
                ResetValidationPanels();

                if (!IsValidName(txtCustName.Text))
                    anyInvalid = true;
                
                if (!IsValidGender(txtEmail.Text))
                    anyInvalid = true;
                
                if (!IsValidEmail(txtEmail.Text))
                    anyInvalid = true;
                
                if (!IsValidPhoneNumber(txtPhone.Text))
                    anyInvalid = true;
                
                if (!IsValidField(txtAddress.Text,pnlInvalidAdd))
                    anyInvalid= true;
                
                if (anyInvalid)
                    return;
                

                if (MessageBox.Show("Are you sure you want to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblCustomer(customerName,gender,email,customerPhone,customerAddress)VALUES(@customerName,@gender,@email,@customerPhone,@customerAddress)", con);
                    cm.Parameters.AddWithValue("@customerName", txtCustName.Text);
                    cm.Parameters.AddWithValue("@gender", cbGender.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@customerPhone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@customerAddress", txtAddress.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully saved!");
                    Clear();

                    // Log activity in tblActivityLog
                    string activity = "Added a customer";
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

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool anyInvalid = false;

                // Reset visibility of all panels
                ResetValidationPanels();
                
                if (!IsValidName(txtCustName.Text))
                    anyInvalid = true;

                if (!IsValidGender(txtEmail.Text))
                    anyInvalid = true;
                
                if (!IsValidEmail(txtEmail.Text))
                    anyInvalid = true;
                
                if (!IsValidPhoneNumber(txtPhone.Text))
                    anyInvalid = true;
                
                if (!IsValidField(txtAddress.Text, pnlInvalidAdd))
                    anyInvalid = true;
                
                if (anyInvalid)
                    return;
                

                if (MessageBox.Show("Are you sure you want to update this customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblCustomer SET customerName = @customerName, gender = @gender, email = @email, customerPhone = @customerPhone, customerAddress = @customerAddress WHERE customerId LIKE '" + lblCustId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@customerName", txtCustName.Text);
                    cm.Parameters.AddWithValue("@gender", cbGender.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@customerPhone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@customerAddress", txtAddress.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully updated!");
                    this.Dispose();

                    // Log activity in tblActivityLog
                    string activity = "Updated customer detials";
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


        //UI
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
            btnSave.BackColor= Color.Bisque;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Tan;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Bisque;
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

        //invalid pnl visibility
        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidName.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidEmail.Visible = false;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidPhoneNo.Visible = false;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            pnlInvalidAdd.Visible = false;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlInvalidGender.Visible = false;
        }
    }
}
