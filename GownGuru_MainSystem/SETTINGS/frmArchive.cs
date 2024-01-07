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
    public partial class frmArchive : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmArchive()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvGownArchive, true);
            LoadArchiveGown();
            panel2.Focus();
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
        public void LoadArchiveGown()
        {
            int i = 0;
            dgvGownArchive.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblGown WHERE archived = 'YES' AND CONCAT(gownID,gownName,description,size,color,condition,gownPrice,dateAdded,category,gownStatus) LIKE '%" + searchBox.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvGownArchive.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void dgvGownArchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvGownArchive.Columns[e.ColumnIndex].Name;
            if (colName == "restore")
            {
                if (MessageBox.Show("Are you sure you want to restore this gown?", "Restore Gown", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("UPDATE tblGown SET archived = 'NO' WHERE gownID LIKE '" + dgvGownArchive.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully restored!");

                    // Log activity in tblActivityLog
                    string activity = "Restored the gown data";
                    SqlCommand logCommand = new SqlCommand("INSERT INTO tblActivityLog (username, role, timestamp, activity) VALUES (@username, @role, GETDATE(), @activity)", con);
                    logCommand.Parameters.AddWithValue("@username", SessionManager.Get("Username") as string);
                    logCommand.Parameters.AddWithValue("@role", SessionManager.Get("Role") as string);
                    logCommand.Parameters.AddWithValue("@activity", activity);

                    con.Open();
                    logCommand.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            LoadArchiveGown();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            LoadArchiveGown();
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
