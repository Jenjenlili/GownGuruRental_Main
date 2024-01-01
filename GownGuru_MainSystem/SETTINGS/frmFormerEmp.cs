using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem.SETTINGS
{
    public partial class frmFormerEmp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmFormerEmp()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvFormerEmp, true);
            LoadFormerEmployee();
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
        public void LoadFormerEmployee() 
        { 
            dgvFormerEmp.Rows.Clear();
            int i = 0;
            cm = new SqlCommand("SELECT * FROM tblEmployee WHERE empStatus = 'Inactive' AND CONCAT(Username, fullname, Password, empPhone, empAddress, role) LIKE '%" + searchBox.Text + "%'", con); // Fetch only active employees
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvFormerEmp.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }
    
        private void dgvFormerEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvFormerEmp.Columns[e.ColumnIndex].Name;
            if (colName == "restore")
            {
                if (MessageBox.Show("Are you sure you want to restore this record?", "Restore Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("UPDATE tblEmployee SET empStatus = 'Active' WHERE Username LIKE '" + dgvFormerEmp.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully Restored!");
                }
            }
            LoadFormerEmployee();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            LoadFormerEmployee();
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
    }
}
