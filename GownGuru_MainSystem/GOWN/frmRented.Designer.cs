namespace GownGuru_MainSystem.GOWN
{
    partial class frmRented
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturn = new GownGuru_MainSystem.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dgvRented = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GownID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gownName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRented)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl1.BackColor = System.Drawing.Color.Transparent;
            this.pnl1.Controls.Add(this.panel2);
            this.pnl1.Controls.Add(this.pictureBox1);
            this.pnl1.Controls.Add(this.lblSearch);
            this.pnl1.Controls.Add(this.label16);
            this.pnl1.Controls.Add(this.searchBox);
            this.pnl1.Location = new System.Drawing.Point(-11, 1);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1015, 110);
            this.pnl1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(765, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 110);
            this.panel2.TabIndex = 105;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Bisque;
            this.btnReturn.BackgroundColor = System.Drawing.Color.Bisque;
            this.btnReturn.BorderColor = System.Drawing.Color.Tan;
            this.btnReturn.BorderRadius = 10;
            this.btnReturn.BorderSize = 2;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(29, 56);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(163, 38);
            this.btnReturn.TabIndex = 82;
            this.btnReturn.Text = "Return Gown";
            this.btnReturn.TextColor = System.Drawing.Color.Black;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::GownGuru_MainSystem.Properties.Resources.search_whitebg;
            this.pictureBox1.Location = new System.Drawing.Point(311, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearch.Location = new System.Drawing.Point(238, 65);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 21);
            this.lblSearch.TabIndex = 104;
            this.lblSearch.Text = "Search";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(30, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(226, 37);
            this.label16.TabIndex = 3;
            this.label16.Text = "Rented Gowns";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(37, 60);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(302, 32);
            this.searchBox.TabIndex = 4;
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // dgvRented
            // 
            this.dgvRented.AllowUserToAddRows = false;
            this.dgvRented.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRented.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRented.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRented.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRented.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRented.ColumnHeadersHeight = 43;
            this.dgvRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRented.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.rentID,
            this.rentDate,
            this.returnDate,
            this.GownID,
            this.gownName,
            this.customerID,
            this.customerName,
            this.qty,
            this.price,
            this.total,
            this.status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRented.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRented.EnableHeadersVisualStyles = false;
            this.dgvRented.Location = new System.Drawing.Point(12, 120);
            this.dgvRented.Name = "dgvRented";
            this.dgvRented.ReadOnly = true;
            this.dgvRented.RowHeadersVisible = false;
            this.dgvRented.RowHeadersWidth = 62;
            this.dgvRented.Size = new System.Drawing.Size(967, 552);
            this.dgvRented.TabIndex = 11;
            this.dgvRented.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRented_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 71;
            // 
            // rentID
            // 
            this.rentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rentID.HeaderText = "Rent Id";
            this.rentID.MinimumWidth = 8;
            this.rentID.Name = "rentID";
            this.rentID.ReadOnly = true;
            this.rentID.Width = 109;
            // 
            // rentDate
            // 
            this.rentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rentDate.HeaderText = "Rent Date";
            this.rentDate.MinimumWidth = 8;
            this.rentDate.Name = "rentDate";
            this.rentDate.ReadOnly = true;
            // 
            // returnDate
            // 
            this.returnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.returnDate.HeaderText = "Return Date";
            this.returnDate.MinimumWidth = 8;
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            // 
            // GownID
            // 
            this.GownID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GownID.HeaderText = "Gown Id";
            this.GownID.MinimumWidth = 8;
            this.GownID.Name = "GownID";
            this.GownID.ReadOnly = true;
            this.GownID.Visible = false;
            this.GownID.Width = 121;
            // 
            // gownName
            // 
            this.gownName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gownName.HeaderText = "Gown Name";
            this.gownName.MinimumWidth = 8;
            this.gownName.Name = "gownName";
            this.gownName.ReadOnly = true;
            // 
            // customerID
            // 
            this.customerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerID.HeaderText = "Customer Id";
            this.customerID.MinimumWidth = 8;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Visible = false;
            this.customerID.Width = 154;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerName.HeaderText = "Customer Name";
            this.customerName.MinimumWidth = 8;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 80;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // frmRented
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(993, 694);
            this.ControlBox = false;
            this.Controls.Add(this.dgvRented);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRented";
            this.Text = "frmRented";
            this.Load += new System.EventHandler(this.frmRented_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRented)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dgvRented;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel2;
        public CustomButton btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GownID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gownName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}