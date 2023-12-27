namespace GownGuru_MainSystem
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTodayTransac = new System.Windows.Forms.Panel();
            this.dgvTodayTransac = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gownReturnedBox = new GownGuru_MainSystem.CustomPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inPossessionBox = new GownGuru_MainSystem.CustomPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.damageLostBox = new GownGuru_MainSystem.CustomPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.revenueBox = new GownGuru_MainSystem.CustomPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gownRentedBox = new GownGuru_MainSystem.CustomPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customerBox = new GownGuru_MainSystem.CustomPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AvailableGownBox = new GownGuru_MainSystem.CustomPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GownBox = new GownGuru_MainSystem.CustomPanel();
            this.GownCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTodayTransac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayTransac)).BeginInit();
            this.gownReturnedBox.SuspendLayout();
            this.inPossessionBox.SuspendLayout();
            this.damageLostBox.SuspendLayout();
            this.revenueBox.SuspendLayout();
            this.gownRentedBox.SuspendLayout();
            this.customerBox.SuspendLayout();
            this.AvailableGownBox.SuspendLayout();
            this.GownBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.gownReturnedBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.inPossessionBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.damageLostBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.revenueBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gownRentedBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AvailableGownBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GownBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(993, 308);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pnlTodayTransac
            // 
            this.pnlTodayTransac.BackColor = System.Drawing.Color.Black;
            this.pnlTodayTransac.Controls.Add(this.dgvTodayTransac);
            this.pnlTodayTransac.Controls.Add(this.textBox1);
            this.pnlTodayTransac.Controls.Add(this.label16);
            this.pnlTodayTransac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTodayTransac.Location = new System.Drawing.Point(0, 308);
            this.pnlTodayTransac.Name = "pnlTodayTransac";
            this.pnlTodayTransac.Size = new System.Drawing.Size(993, 386);
            this.pnlTodayTransac.TabIndex = 0;
            this.pnlTodayTransac.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTodayTransac_Paint);
            // 
            // dgvTodayTransac
            // 
            this.dgvTodayTransac.AllowUserToAddRows = false;
            this.dgvTodayTransac.AllowUserToDeleteRows = false;
            this.dgvTodayTransac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTodayTransac.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodayTransac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodayTransac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodayTransac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodayTransac.ColumnHeadersHeight = 34;
            this.dgvTodayTransac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTodayTransac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentDate,
            this.gown,
            this.customer,
            this.conditionBefore,
            this.conditionAfter,
            this.returnDate,
            this.total});
            this.dgvTodayTransac.Location = new System.Drawing.Point(23, 97);
            this.dgvTodayTransac.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTodayTransac.Name = "dgvTodayTransac";
            this.dgvTodayTransac.ReadOnly = true;
            this.dgvTodayTransac.RowHeadersVisible = false;
            this.dgvTodayTransac.RowHeadersWidth = 62;
            this.dgvTodayTransac.RowTemplate.Height = 28;
            this.dgvTodayTransac.Size = new System.Drawing.Size(948, 261);
            this.dgvTodayTransac.TabIndex = 4;
            this.dgvTodayTransac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodayTransac_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "  Search Here";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(18, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(221, 26);
            this.label16.TabIndex = 2;
            this.label16.Text = "Today\'s Transaction";
            // 
            // gownReturnedBox
            // 
            this.gownReturnedBox.BackColor = System.Drawing.Color.Black;
            this.gownReturnedBox.BorderRadius = 40;
            this.gownReturnedBox.Controls.Add(this.label8);
            this.gownReturnedBox.Controls.Add(this.label9);
            this.gownReturnedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gownReturnedBox.ForeColor = System.Drawing.Color.Black;
            this.gownReturnedBox.GradientAngle = 80F;
            this.gownReturnedBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.gownReturnedBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.gownReturnedBox.Location = new System.Drawing.Point(751, 161);
            this.gownReturnedBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.gownReturnedBox.Name = "gownReturnedBox";
            this.gownReturnedBox.Size = new System.Drawing.Size(235, 137);
            this.gownReturnedBox.TabIndex = 3;
            this.gownReturnedBox.Paint += new System.Windows.Forms.PaintEventHandler(this.gownReturnedBox_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gown Returned";
            // 
            // inPossessionBox
            // 
            this.inPossessionBox.BackColor = System.Drawing.Color.Black;
            this.inPossessionBox.BorderRadius = 40;
            this.inPossessionBox.Controls.Add(this.label10);
            this.inPossessionBox.Controls.Add(this.label11);
            this.inPossessionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inPossessionBox.ForeColor = System.Drawing.Color.Black;
            this.inPossessionBox.GradientAngle = 80F;
            this.inPossessionBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.inPossessionBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.inPossessionBox.Location = new System.Drawing.Point(503, 161);
            this.inPossessionBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.inPossessionBox.Name = "inPossessionBox";
            this.inPossessionBox.Size = new System.Drawing.Size(234, 137);
            this.inPossessionBox.TabIndex = 3;
            this.inPossessionBox.Paint += new System.Windows.Forms.PaintEventHandler(this.inPossessionBox_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(22, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "In Possession";
            // 
            // damageLostBox
            // 
            this.damageLostBox.BackColor = System.Drawing.Color.Black;
            this.damageLostBox.BorderRadius = 40;
            this.damageLostBox.Controls.Add(this.label12);
            this.damageLostBox.Controls.Add(this.label13);
            this.damageLostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.damageLostBox.ForeColor = System.Drawing.Color.Black;
            this.damageLostBox.GradientAngle = 80F;
            this.damageLostBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.damageLostBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.damageLostBox.Location = new System.Drawing.Point(255, 161);
            this.damageLostBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.damageLostBox.Name = "damageLostBox";
            this.damageLostBox.Size = new System.Drawing.Size(234, 137);
            this.damageLostBox.TabIndex = 3;
            this.damageLostBox.Paint += new System.Windows.Forms.PaintEventHandler(this.damageLostBox_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(22, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 28);
            this.label12.TabIndex = 13;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(22, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 26);
            this.label13.TabIndex = 12;
            this.label13.Text = "Damaged/Lost";
            // 
            // revenueBox
            // 
            this.revenueBox.BackColor = System.Drawing.Color.Black;
            this.revenueBox.BorderRadius = 40;
            this.revenueBox.Controls.Add(this.label14);
            this.revenueBox.Controls.Add(this.label15);
            this.revenueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revenueBox.ForeColor = System.Drawing.Color.Black;
            this.revenueBox.GradientAngle = 80F;
            this.revenueBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.revenueBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.revenueBox.Location = new System.Drawing.Point(7, 161);
            this.revenueBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.revenueBox.Name = "revenueBox";
            this.revenueBox.Size = new System.Drawing.Size(234, 137);
            this.revenueBox.TabIndex = 2;
            this.revenueBox.Paint += new System.Windows.Forms.PaintEventHandler(this.revenueBox_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(22, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 28);
            this.label14.TabIndex = 15;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(22, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 26);
            this.label15.TabIndex = 14;
            this.label15.Text = "Revenue";
            // 
            // gownRentedBox
            // 
            this.gownRentedBox.BackColor = System.Drawing.Color.Black;
            this.gownRentedBox.BorderRadius = 40;
            this.gownRentedBox.Controls.Add(this.label6);
            this.gownRentedBox.Controls.Add(this.label7);
            this.gownRentedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gownRentedBox.ForeColor = System.Drawing.Color.Black;
            this.gownRentedBox.GradientAngle = 80F;
            this.gownRentedBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.gownRentedBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.gownRentedBox.Location = new System.Drawing.Point(751, 10);
            this.gownRentedBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 7);
            this.gownRentedBox.Name = "gownRentedBox";
            this.gownRentedBox.Size = new System.Drawing.Size(235, 137);
            this.gownRentedBox.TabIndex = 2;
            this.gownRentedBox.Paint += new System.Windows.Forms.PaintEventHandler(this.gownRentedBox_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gown Rented";
            // 
            // customerBox
            // 
            this.customerBox.BackColor = System.Drawing.Color.Black;
            this.customerBox.BorderRadius = 40;
            this.customerBox.Controls.Add(this.label4);
            this.customerBox.Controls.Add(this.label5);
            this.customerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerBox.ForeColor = System.Drawing.Color.Black;
            this.customerBox.GradientAngle = 80F;
            this.customerBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.customerBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.customerBox.Location = new System.Drawing.Point(503, 10);
            this.customerBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 7);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(234, 137);
            this.customerBox.TabIndex = 2;
            this.customerBox.Paint += new System.Windows.Forms.PaintEventHandler(this.customerBox_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customers";
            // 
            // AvailableGownBox
            // 
            this.AvailableGownBox.BackColor = System.Drawing.Color.Black;
            this.AvailableGownBox.BorderRadius = 40;
            this.AvailableGownBox.Controls.Add(this.label2);
            this.AvailableGownBox.Controls.Add(this.label3);
            this.AvailableGownBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableGownBox.ForeColor = System.Drawing.Color.Black;
            this.AvailableGownBox.GradientAngle = 80F;
            this.AvailableGownBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.AvailableGownBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.AvailableGownBox.Location = new System.Drawing.Point(255, 10);
            this.AvailableGownBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 7);
            this.AvailableGownBox.Name = "AvailableGownBox";
            this.AvailableGownBox.Size = new System.Drawing.Size(234, 137);
            this.AvailableGownBox.TabIndex = 1;
            this.AvailableGownBox.Paint += new System.Windows.Forms.PaintEventHandler(this.AvailableGownBox_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available Gown ";
            // 
            // GownBox
            // 
            this.GownBox.BackColor = System.Drawing.Color.Black;
            this.GownBox.BorderRadius = 40;
            this.GownBox.Controls.Add(this.GownCount);
            this.GownBox.Controls.Add(this.label1);
            this.GownBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GownBox.ForeColor = System.Drawing.Color.Black;
            this.GownBox.GradientAngle = 80F;
            this.GownBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.GownBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.GownBox.Location = new System.Drawing.Point(7, 10);
            this.GownBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 7);
            this.GownBox.Name = "GownBox";
            this.GownBox.Size = new System.Drawing.Size(234, 137);
            this.GownBox.TabIndex = 0;
            this.GownBox.Tag = "";
            this.GownBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GownBox_Paint);
            // 
            // GownCount
            // 
            this.GownCount.AutoSize = true;
            this.GownCount.BackColor = System.Drawing.Color.Transparent;
            this.GownCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.GownCount.ForeColor = System.Drawing.Color.White;
            this.GownCount.Location = new System.Drawing.Point(22, 88);
            this.GownCount.Name = "GownCount";
            this.GownCount.Size = new System.Drawing.Size(25, 28);
            this.GownCount.TabIndex = 1;
            this.GownCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gown";
            // 
            // rentDate
            // 
            this.rentDate.HeaderText = "Rent Date";
            this.rentDate.MinimumWidth = 8;
            this.rentDate.Name = "rentDate";
            this.rentDate.ReadOnly = true;
            this.rentDate.Width = 150;
            // 
            // gown
            // 
            this.gown.HeaderText = "Gown";
            this.gown.MinimumWidth = 8;
            this.gown.Name = "gown";
            this.gown.ReadOnly = true;
            this.gown.Width = 150;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.MinimumWidth = 8;
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            this.customer.Width = 150;
            // 
            // conditionBefore
            // 
            this.conditionBefore.HeaderText = "Condition Before";
            this.conditionBefore.MinimumWidth = 8;
            this.conditionBefore.Name = "conditionBefore";
            this.conditionBefore.ReadOnly = true;
            this.conditionBefore.Width = 150;
            // 
            // conditionAfter
            // 
            this.conditionAfter.HeaderText = "Condition After";
            this.conditionAfter.MinimumWidth = 8;
            this.conditionAfter.Name = "conditionAfter";
            this.conditionAfter.ReadOnly = true;
            this.conditionAfter.Width = 150;
            // 
            // returnDate
            // 
            this.returnDate.HeaderText = "Return Date";
            this.returnDate.MinimumWidth = 8;
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            this.returnDate.Width = 150;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 694);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTodayTransac);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTodayTransac.ResumeLayout(false);
            this.pnlTodayTransac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayTransac)).EndInit();
            this.gownReturnedBox.ResumeLayout(false);
            this.gownReturnedBox.PerformLayout();
            this.inPossessionBox.ResumeLayout(false);
            this.inPossessionBox.PerformLayout();
            this.damageLostBox.ResumeLayout(false);
            this.damageLostBox.PerformLayout();
            this.revenueBox.ResumeLayout(false);
            this.revenueBox.PerformLayout();
            this.gownRentedBox.ResumeLayout(false);
            this.gownRentedBox.PerformLayout();
            this.customerBox.ResumeLayout(false);
            this.customerBox.PerformLayout();
            this.AvailableGownBox.ResumeLayout(false);
            this.AvailableGownBox.PerformLayout();
            this.GownBox.ResumeLayout(false);
            this.GownBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomPanel GownBox;
        private CustomPanel AvailableGownBox;
        private CustomPanel customerBox;
        private CustomPanel gownRentedBox;
        private CustomPanel revenueBox;
        private CustomPanel damageLostBox;
        private CustomPanel inPossessionBox;
        private CustomPanel gownReturnedBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GownCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlTodayTransac;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvTodayTransac;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gown;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}