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
using System.Data.SqlClient;

namespace GownGuru_MainSystem
{
    public partial class frmDashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmDashboard()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvTodayTransac, true);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
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

            SetDoubleBuffer(GownBox, true);
        }
        private void AvailableGownBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            AvailableGownBox.BackColor = Color.FromArgb(90, AvailableGownBox.BackColor);

            SetDoubleBuffer(AvailableGownBox, true);
        }
        private void customerBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            customerBox.BackColor = Color.FromArgb(90, customerBox.BackColor);

            SetDoubleBuffer(customerBox, true);
        }
        private void gownRentedBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            gownRentedBox.BackColor = Color.FromArgb(90, gownRentedBox.BackColor);

            SetDoubleBuffer(gownRentedBox, true);
        }
        private void revenueBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            revenueBox.BackColor = Color.FromArgb(90, revenueBox.BackColor);

            SetDoubleBuffer(revenueBox, true);
        }
        private void damageLostBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            damageLostBox.BackColor = Color.FromArgb(90, damageLostBox.BackColor);

            SetDoubleBuffer(damageLostBox, true);
        }
        private void inPossessionBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            inPossessionBox.BackColor = Color.FromArgb(90, inPossessionBox.BackColor);

            SetDoubleBuffer(inPossessionBox, true);
        }
        private void gownReturnedBox_Paint(object sender, PaintEventArgs e)
        {
            //opacity of panel
            gownReturnedBox.BackColor = Color.FromArgb(90, gownReturnedBox.BackColor);

            SetDoubleBuffer(gownReturnedBox, true);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            SetDoubleBuffer(tableLayoutPanel1, true);
        }
        private void pnlTodayTransac_Paint(object sender, PaintEventArgs e)
        {
            pnlTodayTransac.BackColor = Color.FromArgb(90, pnlTodayTransac.BackColor);

            SetDoubleBuffer(pnlTodayTransac, true);
        }
        private void searchBox_Click(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
        }
        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                lblSearch.Visible = true;
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // Get count of customers
                cm = new SqlCommand("SELECT COUNT(*) FROM tblCustomer", con);
                int clientcount = (int)cm.ExecuteScalar();
                CustomerTotal.Text = clientcount.ToString();

                // Get count of gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblGown", con);
                int gowncount = (int)cm.ExecuteScalar();
                GownTotal.Text = gowncount.ToString();

                // Get count of available gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblGown WHERE gownStatus = 'Available'", con);
                int availableGownCount = (int)cm.ExecuteScalar();
                GAvailableTotal.Text = availableGownCount.ToString();

                // Get count of rented gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblRent", con);
                int rentedcount = (int)cm.ExecuteScalar();
                RentedTotal.Text = rentedcount.ToString();

                // Get count of returned gowns excluding 'lost' status
                cm = new SqlCommand("SELECT COUNT(*) FROM tblReturn WHERE status != 'Lost'", con);
                int nonLostReturnedCount = (int)cm.ExecuteScalar();
                ReturnedTotal.Text = nonLostReturnedCount.ToString();

                // Get count of returned gowns
                /*cm = new SqlCommand("SELECT COUNT(*) FROM tblGown WHERE gstatus = 'returned'", con);
                int returnedcount = (int)cm.ExecuteScalar();
                lblReturned.Text = returnedcount.ToString();*/

                // Get count of damaged or lost gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblGown WHERE gownStatus IN ('damaged', 'lost')", con);
                int damlostcount = (int)cm.ExecuteScalar();
                DamLostTotal.Text = damlostcount.ToString();

                // Get count of gowns in possession
                cm = new SqlCommand("SELECT COUNT(*) FROM tblRent WHERE status = 'In-possession'", con);
                int inpossessioncount = (int)cm.ExecuteScalar();
                InPossessionTotal.Text = inpossessioncount.ToString();

                // Get total revenue from tblReturn
                cm = new SqlCommand("SELECT SUM(total) FROM tblReturn", con);
                object totalSum = cm.ExecuteScalar();

                if (totalSum != null && totalSum != DBNull.Value)
                {
                    decimal revenue = Convert.ToDecimal(totalSum);
                    Revenue.Text = revenue.ToString();
                }
                else
                {
                    Revenue.Text = "0"; // If there are no records or sum is null
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadTodayRent()
        {
            int i = 0;
            dgvTodayTransac.Rows.Clear();
            DateTime today = DateTime.Today;

            cm = new SqlCommand("SELECT rentID, rentDate, returnDate, R.gownID, G.gownName, R.customerID, C.customerName, qty, price, total, status " +
                                "FROM tblRent AS R " +
                                "JOIN tblCustomer AS C ON R.customerID = C.customerID " +
                                "JOIN tblGown AS G ON R.gownID = G.gownID " +
                                "WHERE CONVERT(date, rentDate) = '" + today.ToString("yyyy-MM-dd") + "' " +
                                "AND CONCAT(G.gownName, R.customerID, C.customerName) LIKE '%" + searchBox.Text + "%'", con);

            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvTodayTransac.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr[2].ToString()).ToString("dd/MM/yyyy"),
                    dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            LoadTodayRent();
        }
    }
}
