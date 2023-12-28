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
        {
            int i = 0;
            dgvFormerEmp.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblEmployee WHERE CONCAT(username, fullname, password, empPhone, empAddress, role) LIKE '%" + searchBox.Text + "%'", con);
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
            con.Open();
            cm = new SqlCommand(@"INSERT INTO tblFormerEmp (username, fullname, password, empPhone, empAddress, role)
                              SELECT username, fullname, password, empPhone, empAddress, role
                              FROM tblEmployee
                              WHERE username = @Username", con);
            cm.ExecuteNonQuery();
            con.Close() ;
            LoadEmployee();
        }
    }
}
