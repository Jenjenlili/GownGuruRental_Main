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

namespace GownGuru_MainSystem.GOWN
{
    public partial class frmReturnGown : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmReturnGown()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvGownOnRent, true);
            SetDoubleBuffer(panel1,true);
            SetDoubleBuffer(panel2,true);
            SetDoubleBuffer(panel4,true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            // Set the form's region to create rounded corners
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
            
            LoadRented();
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
        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.FromArgb(231, 184, 8);
        }
        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.Transparent;
        }
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.Tan;
        }
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.Bisque;
        }
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Firebrick;
        }
        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(255, 178, 174);
        }
        private void txtSearchRented_MouseClick(object sender, MouseEventArgs e)
        {
            lblSearch.Visible = false;
        }
        private void txtSearchRented_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                lblSearch.Visible = true;
            }
        }

        public void LoadRented()
        {
            int i = 0;
            dgvGownOnRent.Rows.Clear();
            cm = new SqlCommand("SELECT rentID, rentDate, returnDate, R.gownID, G.gownName, R.customerID, C.customerName, qty, price, total " +
                                "FROM tblRent AS R JOIN tblCustomer AS C ON R.customerID = C.customerID " +
                                "JOIN tblGown AS G ON R.gownID = G.gownID " +
                                "WHERE CONCAT(rentID, rentDate, returnDate, R.gownID, G.gownName, R.customerID, C.customerName, qty, price, total) LIKE '%" + searchBox.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvGownOnRent.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateFine();
        }
        private void CalculateFine()
        {
            DateTime d1 = dtReturndate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);

            if (NrOfDays <= 0)
            {
                txtDelay.Text = "0";
                txtFine.Text = "0";
            }
            else
            {
                txtDelay.Text = NrOfDays.ToString();
                int fineForDelay = NrOfDays * 250; // Fine for delay

                // Perform a null check before accessing SelectedItem
                if (cbStatus.SelectedItem != null)
                {
                    string selectedStatus = cbStatus.SelectedItem.ToString();

                    if (selectedStatus.Equals("Lost", StringComparison.OrdinalIgnoreCase))
                    {
                        txtFine.Text = (fineForDelay + 500).ToString(); // Fine for lost item along with delay
                    }
                    else if (selectedStatus.Equals("Damaged", StringComparison.OrdinalIgnoreCase))
                    {
                        txtFine.Text = (fineForDelay + 300).ToString(); // Fine for damaged item along with delay
                    }
                    else
                    {
                        txtFine.Text = fineForDelay.ToString(); // Only fine for delay
                    }
                }
                else
                {
                    txtFine.Text = fineForDelay.ToString(); // Only fine for delay if status is not selected
                }
            }
            CalculateOverallTotal();
        }
        private void CalculateOverallTotal()
        {
            if (double.TryParse(txtTotal.Text, out double total) && double.TryParse(txtFine.Text, out double fine))
            {
                if (txtDelay.Text == "0")
                {
                    if (cbStatus.SelectedItem != null)
                    {
                        string selectedStatus = cbStatus.SelectedItem.ToString();

                        if (selectedStatus.Equals("Lost", StringComparison.OrdinalIgnoreCase))
                        {
                            fine = 500; // Set fine to 500 for Lost item without delay
                            txtFine.Text = fine.ToString();
                        }
                        else if (selectedStatus.Equals("Damaged", StringComparison.OrdinalIgnoreCase))
                        {
                            fine = 300; // Set fine to 300 for Damaged item without delay
                            txtFine.Text = fine.ToString();
                        }
                    }
                }
                double overallTotal = total + fine;
                // Display the overall total in a TextBox or wherever you wish to show it
                txtOverallTotal.Text = overallTotal.ToString();
            }
            else
            {
                // Handle parsing errors or indicate the issue
                txtOverallTotal.Text = "Error calculating overall total";
            }
        }
    
        public void Clear()
        {
            txtRentId.Clear();
            txtGownId.Clear();
            txtCId.Clear();
            txtCustname.Clear();
            dtReturndate.Value = DateTime.Now;
            dtRentdate.Value = DateTime.Now;
            txtDelay.Clear();
            txtFine.Clear();
            txtTotal.Clear();
            txtOverallTotal.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // to make cells clickable
        private void dgvGownOnRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRentId.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGownId.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCId.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCustname.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtReturndate.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtRentdate.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTotal.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[10].Value.ToString();
            CalculateFine();
            CalculateOverallTotal();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            LoadRented();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRentId.Text == "")
                {
                    MessageBox.Show("Please select rented gown!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to return this gown?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblReturn(rentID,gownID,customerID,rentDate,returnDate,conditionAfter,delay,status,fine,total)VALUES(@rentID,@gownID,@customerID,@rentDate,@returnDate,@conditionAfter,@delay,@status,@fine,@total)", con);
                    cm.Parameters.AddWithValue("@rentID", Convert.ToInt16(txtRentId.Text));
                    cm.Parameters.AddWithValue("@gownID", Convert.ToInt16(txtGownId.Text));
                    cm.Parameters.AddWithValue("@customerID", Convert.ToInt16(txtCId.Text));
                    cm.Parameters.AddWithValue("@rentDate", dtRentdate.Value);
                    cm.Parameters.AddWithValue("@returnDate", dtReturndate.Value);
                    cm.Parameters.AddWithValue("@conditionAfter", cbConditionAft.Text);
                    cm.Parameters.AddWithValue("@delay", Convert.ToInt16(txtDelay.Text));
                    cm.Parameters.AddWithValue("@status", cbStatus.Text);
                    cm.Parameters.AddWithValue("@fine", Convert.ToDouble(txtFine.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToDouble(txtOverallTotal.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Gown has been successfully returned!");

                    cm = new SqlCommand("UPDATE tblGown SET gownStatus = @gownStatus WHERE gownID LIKE '" + txtGownId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@gownStatus", cbStatus.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();

                    cm = new SqlCommand("DELETE FROM tblRent WHERE rentID = @rentID", con);
                    cm.Parameters.AddWithValue("@rentID", txtRentId.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadRented();

                    // Log activity in tblActivityLog
                    string activity = "Returned the gown";
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


    }
}
