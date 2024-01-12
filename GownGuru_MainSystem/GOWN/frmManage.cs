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

namespace GownGuru_MainSystem.GOWN
{
    public partial class frmManage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public frmManage()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvGowns, true);
            LoadGown();

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
        public void LoadGown()
        {
            int i = 0;
            dgvGowns.Rows.Clear();
            try
            {
                cm = new SqlCommand("SELECT * FROM tblGown WHERE archived = 'NO' AND CONCAT(gownID,gownName,description,size,color,condition,gownPrice,dateAdded,category,gownStatus) LIKE '%" + searchBox.Text + "%'", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;

                    // Read the image data (assumed to be in the 11th column, index 10)
                    byte[] imageData = dr[10] as byte[];

                    // Convert the byte array to an Image
                    Image img = null;
                    if (imageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            img = Image.FromStream(ms);
                        }
                    }

                    // Add data to the DataGridView, including the image in the 11th cell
                    dgvGowns.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), Convert.ToDateTime(dr[7].ToString()).ToString("MM/dd/yyyy"), dr[8].ToString(), dr[9].ToString(), img);
                }
            }
            catch (OutOfMemoryException ex)
            {
                // Handle the OutOfMemoryException
                MessageBox.Show("Out of Memory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure resources are released in the finally block
                dr?.Close();
                con?.Close();
            }
        }
        private void frmManage_Load(object sender, EventArgs e)
        {
            LoadGown();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            LoadGown();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmGownAdd formModule = new frmGownAdd();
            formModule.btnSave.Enabled = true;
            formModule.btnUpdate.Enabled = false;
            formModule.ShowDialog();
            LoadGown();
        }
        private void dgvGown_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvGowns.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmGownAdd gownAdd = new frmGownAdd();
                gownAdd.lblGownID.Text = dgvGowns.Rows[e.RowIndex].Cells[1].Value.ToString();
                gownAdd.txtName.Text = dgvGowns.Rows[e.RowIndex].Cells[2].Value.ToString();
                gownAdd.txtDesc.Text = dgvGowns.Rows[e.RowIndex].Cells[3].Value.ToString();
                gownAdd.cbSize.Text = dgvGowns.Rows[e.RowIndex].Cells[4].Value.ToString();
                gownAdd.txtColor.Text = dgvGowns.Rows[e.RowIndex].Cells[5].Value.ToString();
                gownAdd.cbCondition.Text = dgvGowns.Rows[e.RowIndex].Cells[6].Value.ToString();
                gownAdd.txtRprice.Text = dgvGowns.Rows[e.RowIndex].Cells[7].Value.ToString();
                gownAdd.dtDateAdded.Text = dgvGowns.Rows[e.RowIndex].Cells[8].Value.ToString();
                gownAdd.cbCategory.Text = dgvGowns.Rows[e.RowIndex].Cells[9].Value.ToString();
                gownAdd.cbStatus.Text = dgvGowns.Rows[e.RowIndex].Cells[10].Value.ToString();

                Image img = dgvGowns.Rows[e.RowIndex].Cells[11].Value as Image;

                if (img != null)
                {
                    gownAdd.txtPic.Image = new Bitmap(img);
                }

                gownAdd.btnSave.Enabled = false;
                gownAdd.btnUpdate.Enabled = true;
                gownAdd.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this gown?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("UPDATE tblGown SET archived = 'YES' WHERE gownID LIKE '" + dgvGowns.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");

                    // Log activity in tblActivityLog
                    string activity = "Removed/Archived a gown";
                    SqlCommand logCommand = new SqlCommand("INSERT INTO tblActivityLog (username, role, timestamp, activity) VALUES (@username, @role, GETDATE(), @activity)", con);
                    logCommand.Parameters.AddWithValue("@username", SessionManager.Get("Username") as string);
                    logCommand.Parameters.AddWithValue("@role", SessionManager.Get("Role") as string);
                    logCommand.Parameters.AddWithValue("@activity", activity);

                    con.Open();
                    logCommand.ExecuteNonQuery();
                    con.Close();
                }
            }
            LoadGown();
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
