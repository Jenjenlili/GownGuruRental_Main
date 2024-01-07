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
    public partial class frmRented : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmRented()
        {
            InitializeComponent();
            SetDoubleBuffer(pnl1,true); SetDoubleBuffer(panel2,true);
            SetDoubleBuffer(btnReturn,true);
            SetDoubleBuffer(dgvRented,true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

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
                return cp;
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

        
        public void LoadRented()
        {
            int i = 0;
            dgvRented.Rows.Clear();
            cm = new SqlCommand("SELECT rentID, rentDate, returnDate, R.gownID, G.gownName, R.customerID, C.customerName, qty, price, total, status " +
                                "FROM tblRent AS R " +
                                "JOIN tblCustomer AS C ON R.customerID = C.customerID " +
                                "JOIN tblGown AS G ON R.gownID = G.gownID ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvRented.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr[2].ToString()).ToString("dd/MM/yyyy"),
                    dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvRented_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadRented();
            /*string colName = dgvRented.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this rented gown?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tblRent WHERE rentID LIKE '" + dgvRented.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
                LoadRented();
            }*/
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturnGown formModule = new frmReturnGown();
            formModule.ShowDialog();
        }
    }
}
