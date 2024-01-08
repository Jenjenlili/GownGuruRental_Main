using GownGuru_MainSystem.POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem
{
    public partial class frmPOS : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmPOS()
        {
            InitializeComponent();
            SetDoubleBuffer(panel1, true);
            SetDoubleBuffer(cbStat, true);
            SetDoubleBuffer(cbCategory, true);
            lblCategory.Visible = true;
            lblStatus.Visible = true;
            lblSearch.Visible = true;

            
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

        private void cbCategory_Click(object sender, EventArgs e)
        {
            lblCategory.Visible = false;
        }

        private void cbCategory_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                lblCategory.Visible = true;
            }
        }

        private void cbStat_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
        }

        private void cbStat_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbStat.Text))
            {
                lblStatus.Visible = true;
            }
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

        private void frmPOS_Load(object sender, EventArgs e)
        {
            lblCategory.Visible = true;
            lblStatus.Visible = true;
            lblSearch.Visible = true;
            LoadGown();
            LoadCategoriesIntoComboBox();
            LoadStatusIntoComboBox();
            GetCustomer();
        }
        private void LoadGown()
        {
            cm = new SqlCommand("SELECT * FROM tblGown WHERE archived = 'NO'", con);
            con.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                byte[] ImageArray = (byte[])dr["gownPic"];
                AddGowns(
                         dr["gownID"].ToString(),
                         dr["gownName"].ToString(),
                         Image.FromStream(new MemoryStream(ImageArray)),
                         dr["gownPrice"].ToString()
                );
            }
            dr.Close();
            con.Close();
        }
        private void AddGowns(string id, string name, Image gpic, string price)
        {
            var w = new ucGown()
            {
                gName = name,
                gImage = gpic,
                gPrice = price,
                id = Convert.ToInt32(id)
            };

            flowLayoutPanel1.Controls.Add(w);
            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucGown)ss;

                bool found = false; // Flag to determine if the item is found in the DataGridView

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (Convert.ToInt32(row.Cells["dgvGownId"].Value) == wdg.id)
                    {
                        int currentQty = int.Parse(row.Cells["dgvQty"].Value.ToString()) + 1;
                        row.Cells["dgvQty"].Value = currentQty;
                        row.Cells["dgvAmount"].Value = currentQty * int.Parse(row.Cells["dgvPrice"].Value.ToString());
                        row.Cells["dgvPrice"].Value = wdg.gPrice;

                        found = true;
                        break;
                    }
                }

                if (!found) // If the item is not found, add it to the DataGridView
                {
                    dataGridView.Rows.Add(new object[] { 0, 0, wdg.id, wdg.gName, 1, wdg.gPrice, wdg.gPrice });
                }

                GetTotal(); // Calculate total after updating or adding the item
            };
        }

        private void GetTotal()
        {
            double tot = 0;
            txtTotal.Text = "00";
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                tot += double.Parse(row.Cells["dgvAmount"].Value.ToString());
            }
            txtTotal.Text = tot.ToString("N0");
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) // Check if it's the first column and a valid row
            {
                e.Value = e.RowIndex + 1; // Display row numbers starting from 1 instead of 0
            }
        }
        private void txtRec_TextChanged_1(object sender, EventArgs e)
        {
            double amt = 0;
            double rec = 0;
            double.TryParse(txtTotal.Text, out amt);
            double.TryParse(txtRec.Text, out rec);
            double change = rec - amt;
            txtChange.Text = Math.Abs(change).ToString("N0");
        }

        private void Clear()
        {
            dataGridView.Rows.Clear();
            txtTotal.Text = "00";
            txtChange.Text = "00";
            txtRec.Text = "00";
            cbCategory.SelectedIndex = -1;
            txtCustSearch.Clear();
            txtCid.Clear();
            txtCname.Clear();
            cbStat.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            dtRent.Value = DateTime.Now;
            dtReturn.Value = DateTime.Now;

            LoadCategoriesIntoComboBox();
            LoadStatusIntoComboBox();
            flowLayoutPanel1.Controls.Clear();
            LoadGown();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCategory.Visible = true;
            lblStatus.Visible = true;
            lblSearch.Visible = true;   
            Clear();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var gown = (ucGown)item;
                gown.Visible = gown.gName.ToLower().Contains(searchBox.Text.Trim().ToLower());
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cbCategory.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                // Perform filtering based on selected category
                FilterGownsByCategory(selectedCategory);
            }
        }

        private void LoadCategoriesIntoComboBox()
        {
            cbCategory.Items.Clear();

            using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT category FROM tblGown", con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string category = reader["category"].ToString();
                        cbCategory.Items.Add(category);
                    }
                }
                con.Close();
            }
        }

        private void FilterGownsByCategory(string selectedCategory)
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "SELECT * FROM tblGown WHERE category = @category AND archived = 'NO'";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@category", selectedCategory);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        byte[] ImageArray = (byte[])reader["gownPic"];
                        AddGowns(reader["gownID"].ToString(), reader["gownName"].ToString(), Image.FromStream(new MemoryStream(ImageArray)), reader["gownPrice"].ToString());
                    }
                }
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCid.Text == "")
                {
                    MessageBox.Show("Please select a customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dataGridView.Rows.Count == 0) // Check if no gown is selected
                {
                    MessageBox.Show("Please select gown(s)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to rent this gown(s)?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        int gownId = Convert.ToInt32(row.Cells["dgvGownId"].Value);
                        int qty = Convert.ToInt32(row.Cells["dgvQty"].Value);
                        double price = Convert.ToDouble(row.Cells["dgvPrice"].Value);
                        double total = Convert.ToDouble(txtTotal.Text);
                        // Assuming txtRec and txtChange are TextBox controls, use Text property for their values
                        double received = Convert.ToDouble(txtRec.Text);
                        double change = Convert.ToDouble(txtChange.Text);
                        string status = cbStatus.Text;

                        // Inserting into tblRent
                        cm = new SqlCommand("INSERT INTO tblRent (rentDate, returnDate, gownID, customerID, qty, price, total, receive, change, status) " +
                                            "VALUES (@rentDate, @returnDate, @gownID, @customerID, @qty, @price, @total, @receive, @change, @status)", con);
                        cm.Parameters.AddWithValue("@rentDate", dtRent.Value);
                        cm.Parameters.AddWithValue("@returnDate", dtReturn.Value);
                        cm.Parameters.AddWithValue("@gownID", gownId);
                        cm.Parameters.AddWithValue("@customerID", Convert.ToInt32(txtCid.Text));
                        cm.Parameters.AddWithValue("@qty", qty);
                        cm.Parameters.AddWithValue("@price", price);
                        cm.Parameters.AddWithValue("@total", total);
                        cm.Parameters.AddWithValue("@receive", received);
                        cm.Parameters.AddWithValue("@change", change);
                        cm.Parameters.AddWithValue("@status", status);
                        cm.ExecuteNonQuery();

                        // Updating gown status in tblGown
                        cm = new SqlCommand("UPDATE tblGown SET gownStatus = @gownStatus WHERE gownID = @gownID", con);
                        cm.Parameters.AddWithValue("@gownStatus", "In-possession"); // Change to the status you need
                        cm.Parameters.AddWithValue("@gownID", gownId);
                        cm.ExecuteNonQuery();

                        // Log activity in tblActivityLog
                        string activity = "Rented a gown for the customer";
                        SqlCommand logCommand = new SqlCommand("INSERT INTO tblActivityLog (username, role, timestamp, activity) VALUES (@username, @role, GETDATE(), @activity)", con);
                        logCommand.Parameters.AddWithValue("@username", SessionManager.Get("Username") as string);
                        logCommand.Parameters.AddWithValue("@role", SessionManager.Get("Role") as string);
                        logCommand.Parameters.AddWithValue("@activity", activity);

                        con.Open();
                        logCommand.ExecuteNonQuery();
                        con.Close();
                    }

                    con.Close();
                    MessageBox.Show("Gown(s) have been successfully rented!");
                    Clear();
                    LoadGown();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        public void GetCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblCustomer WHERE CONCAT(customerID,customerName) LIKE '%" + txtCustSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void txtCustSearch_TextChanged(object sender, EventArgs e)
        {
            GetCustomer();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCid.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCname.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void cbStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cbStat.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedStatus))
            {
                // Perform filtering based on selected category
                FilterGownsByStatus(selectedStatus);
            }
        }
        private void LoadStatusIntoComboBox()
        {
            cbStat.Items.Clear();

            using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT gownStatus FROM tblGown", con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["gownStatus"].ToString();
                        cbStat.Items.Add(status);
                    }
                }
                con.Close();
            }
        }

        private void FilterGownsByStatus(string selectedStatus)
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "SELECT * FROM tblGown WHERE gownStatus = @gownStatus";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@gownStatus", selectedStatus);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        byte[] ImageArray = (byte[])reader["gownPic"];
                        AddGowns(reader["gownID"].ToString(), reader["gownName"].ToString(), Image.FromStream(new MemoryStream(ImageArray)), reader["gownPrice"].ToString());
                    }
                }
                con.Close();
            }
        }

        private void txtRec_Click(object sender, EventArgs e)
        {
            txtRec.Text = "";
        }


    }
}
