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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gownReturnedBox = new GownGuru_MainSystem.CustomPanel();
            this.ReturnedTotal = new System.Windows.Forms.Label();
            this.lblReturned = new System.Windows.Forms.Label();
            this.inPossessionBox = new GownGuru_MainSystem.CustomPanel();
            this.InPossessionTotal = new System.Windows.Forms.Label();
            this.lblInPossession = new System.Windows.Forms.Label();
            this.damageLostBox = new GownGuru_MainSystem.CustomPanel();
            this.DamLostTotal = new System.Windows.Forms.Label();
            this.lblDamLost = new System.Windows.Forms.Label();
            this.revenueBox = new GownGuru_MainSystem.CustomPanel();
            this.RevenueTotal = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.gownRentedBox = new GownGuru_MainSystem.CustomPanel();
            this.RentedTotal = new System.Windows.Forms.Label();
            this.lblRented = new System.Windows.Forms.Label();
            this.customerBox = new GownGuru_MainSystem.CustomPanel();
            this.CustomerTotal = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.AvailableGownBox = new GownGuru_MainSystem.CustomPanel();
            this.GAvailableTotal = new System.Windows.Forms.Label();
            this.lblGAvailable = new System.Windows.Forms.Label();
            this.GownBox = new GownGuru_MainSystem.CustomPanel();
            this.GownTotal = new System.Windows.Forms.Label();
            this.lblGown = new System.Windows.Forms.Label();
            this.pnlTodayTransac = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvTodayTransac = new System.Windows.Forms.DataGridView();
            this.rentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gownReturnedBox.SuspendLayout();
            this.inPossessionBox.SuspendLayout();
            this.damageLostBox.SuspendLayout();
            this.revenueBox.SuspendLayout();
            this.gownRentedBox.SuspendLayout();
            this.customerBox.SuspendLayout();
            this.AvailableGownBox.SuspendLayout();
            this.GownBox.SuspendLayout();
            this.pnlTodayTransac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayTransac)).BeginInit();
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
            // gownReturnedBox
            // 
            this.gownReturnedBox.BackColor = System.Drawing.Color.Black;
            this.gownReturnedBox.BorderRadius = 40;
            this.gownReturnedBox.Controls.Add(this.ReturnedTotal);
            this.gownReturnedBox.Controls.Add(this.lblReturned);
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
            // ReturnedTotal
            // 
            this.ReturnedTotal.AutoSize = true;
            this.ReturnedTotal.BackColor = System.Drawing.Color.Transparent;
            this.ReturnedTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ReturnedTotal.ForeColor = System.Drawing.Color.White;
            this.ReturnedTotal.Location = new System.Drawing.Point(23, 89);
            this.ReturnedTotal.Name = "ReturnedTotal";
            this.ReturnedTotal.Size = new System.Drawing.Size(25, 28);
            this.ReturnedTotal.TabIndex = 9;
            this.ReturnedTotal.Text = "0";
            // 
            // lblReturned
            // 
            this.lblReturned.AutoSize = true;
            this.lblReturned.BackColor = System.Drawing.Color.Transparent;
            this.lblReturned.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblReturned.ForeColor = System.Drawing.Color.White;
            this.lblReturned.Location = new System.Drawing.Point(23, 31);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(177, 26);
            this.lblReturned.TabIndex = 8;
            this.lblReturned.Text = "Gown Returned";
            // 
            // inPossessionBox
            // 
            this.inPossessionBox.BackColor = System.Drawing.Color.Black;
            this.inPossessionBox.BorderRadius = 40;
            this.inPossessionBox.Controls.Add(this.InPossessionTotal);
            this.inPossessionBox.Controls.Add(this.lblInPossession);
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
            // InPossessionTotal
            // 
            this.InPossessionTotal.AutoSize = true;
            this.InPossessionTotal.BackColor = System.Drawing.Color.Transparent;
            this.InPossessionTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.InPossessionTotal.ForeColor = System.Drawing.Color.White;
            this.InPossessionTotal.Location = new System.Drawing.Point(22, 89);
            this.InPossessionTotal.Name = "InPossessionTotal";
            this.InPossessionTotal.Size = new System.Drawing.Size(25, 28);
            this.InPossessionTotal.TabIndex = 11;
            this.InPossessionTotal.Text = "0";
            // 
            // lblInPossession
            // 
            this.lblInPossession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInPossession.AutoSize = true;
            this.lblInPossession.BackColor = System.Drawing.Color.Transparent;
            this.lblInPossession.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblInPossession.ForeColor = System.Drawing.Color.White;
            this.lblInPossession.Location = new System.Drawing.Point(22, 31);
            this.lblInPossession.Name = "lblInPossession";
            this.lblInPossession.Size = new System.Drawing.Size(149, 26);
            this.lblInPossession.TabIndex = 10;
            this.lblInPossession.Text = "In Possession";
            // 
            // damageLostBox
            // 
            this.damageLostBox.BackColor = System.Drawing.Color.Black;
            this.damageLostBox.BorderRadius = 40;
            this.damageLostBox.Controls.Add(this.DamLostTotal);
            this.damageLostBox.Controls.Add(this.lblDamLost);
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
            // DamLostTotal
            // 
            this.DamLostTotal.AutoSize = true;
            this.DamLostTotal.BackColor = System.Drawing.Color.Transparent;
            this.DamLostTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DamLostTotal.ForeColor = System.Drawing.Color.White;
            this.DamLostTotal.Location = new System.Drawing.Point(22, 89);
            this.DamLostTotal.Name = "DamLostTotal";
            this.DamLostTotal.Size = new System.Drawing.Size(25, 28);
            this.DamLostTotal.TabIndex = 13;
            this.DamLostTotal.Text = "0";
            // 
            // lblDamLost
            // 
            this.lblDamLost.AutoSize = true;
            this.lblDamLost.BackColor = System.Drawing.Color.Transparent;
            this.lblDamLost.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblDamLost.ForeColor = System.Drawing.Color.White;
            this.lblDamLost.Location = new System.Drawing.Point(22, 31);
            this.lblDamLost.Name = "lblDamLost";
            this.lblDamLost.Size = new System.Drawing.Size(173, 26);
            this.lblDamLost.TabIndex = 12;
            this.lblDamLost.Text = "Damaged/Lost";
            this.lblDamLost.Click += new System.EventHandler(this.label13_Click);
            // 
            // revenueBox
            // 
            this.revenueBox.BackColor = System.Drawing.Color.Black;
            this.revenueBox.BorderRadius = 40;
            this.revenueBox.Controls.Add(this.RevenueTotal);
            this.revenueBox.Controls.Add(this.lblRevenue);
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
            // RevenueTotal
            // 
            this.RevenueTotal.AutoSize = true;
            this.RevenueTotal.BackColor = System.Drawing.Color.Transparent;
            this.RevenueTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.RevenueTotal.ForeColor = System.Drawing.Color.White;
            this.RevenueTotal.Location = new System.Drawing.Point(22, 89);
            this.RevenueTotal.Name = "RevenueTotal";
            this.RevenueTotal.Size = new System.Drawing.Size(25, 28);
            this.RevenueTotal.TabIndex = 15;
            this.RevenueTotal.Text = "0";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenue.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Location = new System.Drawing.Point(22, 31);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(105, 26);
            this.lblRevenue.TabIndex = 14;
            this.lblRevenue.Text = "Revenue";
            // 
            // gownRentedBox
            // 
            this.gownRentedBox.BackColor = System.Drawing.Color.Black;
            this.gownRentedBox.BorderRadius = 40;
            this.gownRentedBox.Controls.Add(this.RentedTotal);
            this.gownRentedBox.Controls.Add(this.lblRented);
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
            // RentedTotal
            // 
            this.RentedTotal.AutoSize = true;
            this.RentedTotal.BackColor = System.Drawing.Color.Transparent;
            this.RentedTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.RentedTotal.ForeColor = System.Drawing.Color.White;
            this.RentedTotal.Location = new System.Drawing.Point(23, 88);
            this.RentedTotal.Name = "RentedTotal";
            this.RentedTotal.Size = new System.Drawing.Size(25, 28);
            this.RentedTotal.TabIndex = 7;
            this.RentedTotal.Text = "0";
            // 
            // lblRented
            // 
            this.lblRented.AutoSize = true;
            this.lblRented.BackColor = System.Drawing.Color.Transparent;
            this.lblRented.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblRented.ForeColor = System.Drawing.Color.White;
            this.lblRented.Location = new System.Drawing.Point(23, 30);
            this.lblRented.Name = "lblRented";
            this.lblRented.Size = new System.Drawing.Size(157, 26);
            this.lblRented.TabIndex = 6;
            this.lblRented.Text = "Gown Rented";
            // 
            // customerBox
            // 
            this.customerBox.BackColor = System.Drawing.Color.Black;
            this.customerBox.BorderRadius = 40;
            this.customerBox.Controls.Add(this.CustomerTotal);
            this.customerBox.Controls.Add(this.lblCustomers);
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
            // CustomerTotal
            // 
            this.CustomerTotal.AutoSize = true;
            this.CustomerTotal.BackColor = System.Drawing.Color.Transparent;
            this.CustomerTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CustomerTotal.ForeColor = System.Drawing.Color.White;
            this.CustomerTotal.Location = new System.Drawing.Point(22, 88);
            this.CustomerTotal.Name = "CustomerTotal";
            this.CustomerTotal.Size = new System.Drawing.Size(25, 28);
            this.CustomerTotal.TabIndex = 5;
            this.CustomerTotal.Text = "0";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomers.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCustomers.Location = new System.Drawing.Point(22, 30);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(125, 26);
            this.lblCustomers.TabIndex = 4;
            this.lblCustomers.Text = "Customers";
            // 
            // AvailableGownBox
            // 
            this.AvailableGownBox.BackColor = System.Drawing.Color.Black;
            this.AvailableGownBox.BorderRadius = 40;
            this.AvailableGownBox.Controls.Add(this.GAvailableTotal);
            this.AvailableGownBox.Controls.Add(this.lblGAvailable);
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
            // GAvailableTotal
            // 
            this.GAvailableTotal.AutoSize = true;
            this.GAvailableTotal.BackColor = System.Drawing.Color.Transparent;
            this.GAvailableTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.GAvailableTotal.ForeColor = System.Drawing.Color.White;
            this.GAvailableTotal.Location = new System.Drawing.Point(22, 88);
            this.GAvailableTotal.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.GAvailableTotal.Name = "GAvailableTotal";
            this.GAvailableTotal.Size = new System.Drawing.Size(25, 28);
            this.GAvailableTotal.TabIndex = 3;
            this.GAvailableTotal.Text = "0";
            // 
            // lblGAvailable
            // 
            this.lblGAvailable.AutoSize = true;
            this.lblGAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblGAvailable.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblGAvailable.ForeColor = System.Drawing.Color.White;
            this.lblGAvailable.Location = new System.Drawing.Point(22, 30);
            this.lblGAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblGAvailable.Name = "lblGAvailable";
            this.lblGAvailable.Size = new System.Drawing.Size(189, 26);
            this.lblGAvailable.TabIndex = 2;
            this.lblGAvailable.Text = "Available Gown ";
            // 
            // GownBox
            // 
            this.GownBox.BackColor = System.Drawing.Color.Black;
            this.GownBox.BorderRadius = 40;
            this.GownBox.Controls.Add(this.GownTotal);
            this.GownBox.Controls.Add(this.lblGown);
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
            // GownTotal
            // 
            this.GownTotal.AutoSize = true;
            this.GownTotal.BackColor = System.Drawing.Color.Transparent;
            this.GownTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.GownTotal.ForeColor = System.Drawing.Color.White;
            this.GownTotal.Location = new System.Drawing.Point(22, 88);
            this.GownTotal.Name = "GownTotal";
            this.GownTotal.Size = new System.Drawing.Size(25, 28);
            this.GownTotal.TabIndex = 1;
            this.GownTotal.Text = "0";
            // 
            // lblGown
            // 
            this.lblGown.AutoSize = true;
            this.lblGown.BackColor = System.Drawing.Color.Transparent;
            this.lblGown.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblGown.ForeColor = System.Drawing.Color.White;
            this.lblGown.Location = new System.Drawing.Point(21, 30);
            this.lblGown.Name = "lblGown";
            this.lblGown.Size = new System.Drawing.Size(75, 26);
            this.lblGown.TabIndex = 0;
            this.lblGown.Text = "Gown";
            // 
            // pnlTodayTransac
            // 
            this.pnlTodayTransac.BackColor = System.Drawing.Color.Black;
            this.pnlTodayTransac.Controls.Add(this.label17);
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(19, 53);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 21);
            this.label17.TabIndex = 15;
            this.label17.Text = "Search:";
            // 
            // dgvTodayTransac
            // 
            this.dgvTodayTransac.AllowUserToAddRows = false;
            this.dgvTodayTransac.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTodayTransac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodayTransac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTodayTransac.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodayTransac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodayTransac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodayTransac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            // 
            // rentDate
            // 
            this.rentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rentDate.HeaderText = "Rent Date";
            this.rentDate.MinimumWidth = 8;
            this.rentDate.Name = "rentDate";
            this.rentDate.ReadOnly = true;
            // 
            // gown
            // 
            this.gown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gown.HeaderText = "Gown";
            this.gown.MinimumWidth = 8;
            this.gown.Name = "gown";
            this.gown.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer.HeaderText = "Customer";
            this.customer.MinimumWidth = 8;
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // conditionBefore
            // 
            this.conditionBefore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.conditionBefore.HeaderText = "Condition Before";
            this.conditionBefore.MinimumWidth = 8;
            this.conditionBefore.Name = "conditionBefore";
            this.conditionBefore.ReadOnly = true;
            // 
            // conditionAfter
            // 
            this.conditionAfter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.conditionAfter.HeaderText = "Condition After";
            this.conditionAfter.MinimumWidth = 8;
            this.conditionAfter.Name = "conditionAfter";
            this.conditionAfter.ReadOnly = true;
            // 
            // returnDate
            // 
            this.returnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.returnDate.HeaderText = "Return Date";
            this.returnDate.MinimumWidth = 8;
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(102, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 32);
            this.textBox1.TabIndex = 3;
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
            this.pnlTodayTransac.ResumeLayout(false);
            this.pnlTodayTransac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayTransac)).EndInit();
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
        private System.Windows.Forms.Label lblGown;
        private System.Windows.Forms.Label GownTotal;
        private System.Windows.Forms.Label GAvailableTotal;
        private System.Windows.Forms.Label lblGAvailable;
        private System.Windows.Forms.Label CustomerTotal;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label RentedTotal;
        private System.Windows.Forms.Label lblRented;
        private System.Windows.Forms.Label RevenueTotal;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label DamLostTotal;
        private System.Windows.Forms.Label lblDamLost;
        private System.Windows.Forms.Label InPossessionTotal;
        private System.Windows.Forms.Label lblInPossession;
        private System.Windows.Forms.Label ReturnedTotal;
        private System.Windows.Forms.Label lblReturned;
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
        private System.Windows.Forms.Label label17;
    }
}