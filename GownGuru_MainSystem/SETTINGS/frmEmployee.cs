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
    public partial class frmEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmEmployee()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvEmployee, true);
            LoadEmployee();
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

        public void LoadEmployee()
        {  //empStatus LIKE 'Active' AND
            dgvEmployee.Rows.Clear();
            int i = 0;
            cm = new SqlCommand("SELECT * FROM tblEmployee WHERE empStatus = 'Active' AND CONCAT(Username, fullname, Password, empPhone, empAddress, role) LIKE '%" + searchBox.Text + "%'", con); // Fetch only active employees
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvEmployee.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeAdd userModule = new frmEmployeeAdd();
            userModule.btnSave.Enabled = true;
            userModule.btnUpdate.Enabled = false;
            userModule.ShowDialog();
            LoadEmployee();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployee.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                frmEmployeeAdd userModule = new frmEmployeeAdd();
                userModule.txtUsername.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtFullname.Text = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtPass.Text = dgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPhoneNum.Text = dgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.txtAddress.Text = dgvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                userModule.txtRole.Text = dgvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();

                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.txtUsername.Enabled = false;
                userModule.ShowDialog();
            }
            else if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to remove this employee?", "Remove Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("UPDATE tblEmployee SET empStatus = 'Inactive' WHERE Username LIKE '" + dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully removed!");
                }
            }
            LoadEmployee();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            LoadEmployee();
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
