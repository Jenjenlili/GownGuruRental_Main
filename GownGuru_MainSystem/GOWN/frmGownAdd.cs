using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem.GOWN
{
    public partial class frmGownAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmGownAdd()
        {
            InitializeComponent();
            LoadCategory();
            SetDoubleBuffer(panel2, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            // Set the form's region to create rounded corners
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
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
                //BORDER RADIUS
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS | CS_DROPSHADOW;

                return cp;
            }
        }
        //UI - FORM BORDER RADIUS
        // Constants for WinAPI calls
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        const int CS_DROPSHADOW = 0x20000;

        // Round the form corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
        // to show records on dgv
        public void LoadCategory()
        {
            cbCategory.Items.Clear();
            cm = new SqlCommand("SELECT categoryName FROM tblCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //browse image
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filPath = ofd.FileName;
                txtPic.Image = new Bitmap(filPath);
            }
        }

        //to clear
        public void Clear()
        {
            txtName.Clear();
            txtDesc.Clear();
            txtColor.Clear();
            cbStatus.Text = "";
            cbSize.Text = "";
            txtRprice.Clear();
            dtDateAdded.Text = "";
            cbCondition.Text = "";
            txtDesc.Clear();
            cbCategory.Text = "";
            txtPic.Text = "";

        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this gown??", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblGown(gownName,description,size,color,condition,gownPrice,dateAdded,category,gownStatus,gownPic)VALUES(@gownName,@description,@size,@color,@condition,@gownPrice,@dateAdded,@category,@gownStatus,@gownPic)", con);
                    cm.Parameters.AddWithValue("@gownName", txtName.Text);
                    cm.Parameters.AddWithValue("@description", txtDesc.Text);
                    cm.Parameters.AddWithValue("@size", cbSize.Text);
                    cm.Parameters.AddWithValue("@color", txtColor.Text);
                    cm.Parameters.AddWithValue("@condition", cbCondition.Text);
                    cm.Parameters.AddWithValue("@gownPrice", double.Parse(txtRprice.Text));
                    cm.Parameters.AddWithValue("@dateAdded", dtDateAdded.Value.ToString("yyyy-MM-dd"));
                    cm.Parameters.AddWithValue("@category", cbCategory.Text);
                    cm.Parameters.AddWithValue("@gownStatus", cbStatus.Text);

                    Image temp = new Bitmap(txtPic.Image);
                    MemoryStream ms = new MemoryStream();
                    temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    Byte[] BtyArray = ms.ToArray();
                    cm.Parameters.AddWithValue("@gownPic", BtyArray);

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Gown has been successfully saved!");
                    Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this gown?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblGown SET gownName = @gownName, description = @description, size = @size, color = @color, condition = @condition, gownPrice = @gownPrice, dateAdded = @dateAdded, category = @category, gownStatus = @gownStatus, gownPic = @gownPic WHERE gownID LIKE '" + lblGownID.Text + "' ", con);
                    cm.Parameters.AddWithValue("@gownName", txtName.Text);
                    cm.Parameters.AddWithValue("@description", txtDesc.Text);
                    cm.Parameters.AddWithValue("@size", cbSize.Text);
                    cm.Parameters.AddWithValue("@color", txtColor.Text);
                    cm.Parameters.AddWithValue("@condition", cbCondition.Text);
                    cm.Parameters.AddWithValue("@gownPrice", double.Parse(txtRprice.Text));
                    cm.Parameters.AddWithValue("@dateAdded", dtDateAdded.Value.ToString("yyyy-MM-dd"));
                    cm.Parameters.AddWithValue("@category", cbCategory.Text);
                    cm.Parameters.AddWithValue("@gownStatus", cbStatus.Text);
                    
                    if (txtPic.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            txtPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            byte[] imageByteArray = ms.ToArray();
                            cm.Parameters.AddWithValue("@gownPic", imageByteArray);
                        }
                    }
                    else
                    {
                        cm.Parameters.AddWithValue("@gownPic", DBNull.Value);
                    }

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Gown has been successfully updated!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //UI
        private void btnBrowse_MouseEnter(object sender, EventArgs e)
        {
            btnBrowse.BackColor = Color.Tan;
        }

        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
            btnBrowse.BackColor = Color.Bisque;
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Tan;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Bisque;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Tan;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Bisque;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Firebrick;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(255, 178, 174);
        }

        private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.FromArgb(231, 184, 8);
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.NavajoWhite;
        }

        //move form
        public Point mouseLocation;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
                this.Opacity = 0.8;
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
