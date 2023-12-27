﻿using System;
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
    public partial class frmManage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allea\source\repos\GownGuru_MainSystem\GownGuru_MainSystem\GownGuruDB.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public frmManage()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvGown, true);
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
            dgvGown.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblGown WHERE CONCAT(gownID,gownName,description,size,color,condition,price,dateAdded,category,gownStatus) LIKE '%" + searchBox.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvGown.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());

            }
            dr.Close();
            con.Close();
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

        private void dgvGown_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvGown.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                frmGownAdd gownAdd = new frmGownAdd();
                gownAdd.lblGid.Text = dgvGown.Rows[e.RowIndex].Cells[1].Value.ToString();
                gownAdd.txtName.Text = dgvGown.Rows[e.RowIndex].Cells[2].Value.ToString();
                gownAdd.txtDesc.Text = dgvGown.Rows[e.RowIndex].Cells[3].Value.ToString();
                gownAdd.cbSize.Text = dgvGown.Rows[e.RowIndex].Cells[4].Value.ToString();
                gownAdd.txtColor.Text = dgvGown.Rows[e.RowIndex].Cells[5].Value.ToString();
                gownAdd.cbCondition.Text = dgvGown.Rows[e.RowIndex].Cells[6].Value.ToString();
                gownAdd.txtRprice.Text = dgvGown.Rows[e.RowIndex].Cells[7].Value.ToString();
                gownAdd.dtDateAdded.Text = dgvGown.Rows[e.RowIndex].Cells[8].Value.ToString();
                gownAdd.cbCategory.Text = dgvGown.Rows[e.RowIndex].Cells[9].Value.ToString();
                gownAdd.cbStatus.Text = dgvGown.Rows[e.RowIndex].Cells[10].Value.ToString();
                gownAdd.txtPic.Text = dgvGown.Rows[e.RowIndex].Cells[11].Value.ToString();
                gownAdd.btnSave.Enabled = false;
                gownAdd.btnUpdate.Enabled = true;
                gownAdd.ShowDialog();
            }
            else if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this gown?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tblGown WHERE gownID LIKE '" + dgvGown.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadGown();
        }
    }
}
