﻿namespace GownGuru_MainSystem.SETTINGS
{
    partial class frmFormerEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dgvFormerEmp = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.restore = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormerEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Location = new System.Drawing.Point(-6, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 110);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search box :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(30, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(283, 37);
            this.label16.TabIndex = 3;
            this.label16.Text = "Former Employees";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(159, 58);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(302, 32);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dgvFormerEmp
            // 
            this.dgvFormerEmp.AllowUserToAddRows = false;
            this.dgvFormerEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFormerEmp.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormerEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFormerEmp.ColumnHeadersHeight = 30;
            this.dgvFormerEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFormerEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.username,
            this.fullname,
            this.password,
            this.phone,
            this.address,
            this.role,
            this.restore});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormerEmp.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvFormerEmp.Location = new System.Drawing.Point(12, 115);
            this.dgvFormerEmp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFormerEmp.Name = "dgvFormerEmp";
            this.dgvFormerEmp.RowHeadersVisible = false;
            this.dgvFormerEmp.RowHeadersWidth = 62;
            this.dgvFormerEmp.RowTemplate.Height = 28;
            this.dgvFormerEmp.Size = new System.Drawing.Size(970, 562);
            this.dgvFormerEmp.TabIndex = 14;
            this.dgvFormerEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormerEmp_CellContentClick);
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.no.DefaultCellStyle = dataGridViewCellStyle11;
            this.no.Frozen = true;
            this.no.HeaderText = "No.";
            this.no.MinimumWidth = 8;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 76;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.username.DefaultCellStyle = dataGridViewCellStyle12;
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 134;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.fullname.DefaultCellStyle = dataGridViewCellStyle13;
            this.fullname.HeaderText = "Full Name";
            this.fullname.MinimumWidth = 8;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.password.DefaultCellStyle = dataGridViewCellStyle14;
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.phone.DefaultCellStyle = dataGridViewCellStyle15;
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 8;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.address.DefaultCellStyle = dataGridViewCellStyle16;
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.role.DefaultCellStyle = dataGridViewCellStyle17;
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 8;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GownGuru_MainSystem.Properties.Resources.restore;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 8;
            // 
            // restore
            // 
            this.restore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.restore.HeaderText = "";
            this.restore.Image = global::GownGuru_MainSystem.Properties.Resources.restore;
            this.restore.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.restore.MinimumWidth = 8;
            this.restore.Name = "restore";
            this.restore.Width = 8;
            // 
            // frmFormerEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(993, 694);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvFormerEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFormerEmp";
            this.Text = "frmFormerEmp";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormerEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox searchBox;
        public System.Windows.Forms.DataGridView dgvFormerEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewImageColumn restore;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}