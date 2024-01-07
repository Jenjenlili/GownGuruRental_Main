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
    public partial class frmActivityLog : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmActivityLog()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvActivityLog, true);
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

        private void pnlActivityLog_Paint(object sender, PaintEventArgs e)
        {
            pnlActLog.BackColor = Color.FromArgb(90, pnlActLog.BackColor);

            SetDoubleBuffer(pnlActLog, true);
        }

        private void frmActivityLog_Load(object sender, EventArgs e)
        {
            try
            {
                dgvActivityLog.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM tblActivityLog ORDER BY timestamp DESC", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvActivityLog.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToDateTime(dr[3].ToString()), dr[4].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
