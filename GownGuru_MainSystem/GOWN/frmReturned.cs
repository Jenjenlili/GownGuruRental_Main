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

namespace GownGuru_MainSystem.GOWN
{
    public partial class frmReturned : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmReturned()
        {
            InitializeComponent();
            SetDoubleBuffer(panel2, true);
            SetDoubleBuffer(dgvReturned, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            LoadReturned();
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
        //UI
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

        
        public void LoadReturned()
        {
            int i = 0;
            dgvReturned.Rows.Clear();
            cm = new SqlCommand("SELECT returnID, R.rentID, R.rentDate, R.returnDate, R.gownID, G.gownName, R.customerID, C.customerName, conditionAfter, delay, status, fine, total " +
                                "FROM tblReturn AS R " +
                                "JOIN tblCustomer AS C ON R.customerID = C.customerID " +
                                "JOIN tblGown AS G ON R.gownID = G.gownID", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvReturned.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2].ToString()).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr[3].ToString()).ToString("dd/MM/yyyy"), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
