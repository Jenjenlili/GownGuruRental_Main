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

namespace GownGuru_MainSystem
{
    public partial class frmCustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public frmCustomer()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvCustomer, true);
            LoadCustomer();
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

        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblCustomer WHERE CONCAT(customerName,gender,email,customerPhone,customerAddress) LIKE '%" + searchBox.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCustomer();
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                frmCustomerAdd customerModule = new frmCustomerAdd();
                customerModule.lblCustId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModule.txtCustName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerModule.cbGender.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                customerModule.txtEmail.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                customerModule.txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
                customerModule.txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[6].Value.ToString();
                customerModule.btnSave.Enabled = false;
                customerModule.btnUpdate.Enabled = true;
                customerModule.ShowDialog();
            }
            else if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tblCustomer WHERE customerID LIKE '" + dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadCustomer();
            frmCustomerAdd moduleForm = new frmCustomerAdd();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.ShowDialog();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
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

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}
