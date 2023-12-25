namespace GownGuru_MainSystem
{
    partial class MAIN
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new GownGuru_MainSystem.CustomButton();
            this.btnTransactionLog = new GownGuru_MainSystem.CustomButton();
            this.btnArchive = new GownGuru_MainSystem.CustomButton();
            this.btnFormerEmp = new GownGuru_MainSystem.CustomButton();
            this.btnEmployee = new GownGuru_MainSystem.CustomButton();
            this.btnPOS = new GownGuru_MainSystem.CustomButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.PictureBox();
            this.btnCustomers = new GownGuru_MainSystem.CustomButton();
            this.pnlGown = new System.Windows.Forms.Panel();
            this.btnReturned = new GownGuru_MainSystem.CustomButton();
            this.btnRented = new GownGuru_MainSystem.CustomButton();
            this.btnCategory = new GownGuru_MainSystem.CustomButton();
            this.btnManage = new GownGuru_MainSystem.CustomButton();
            this.btnGown = new GownGuru_MainSystem.CustomButton();
            this.btnDashboard = new GownGuru_MainSystem.CustomButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.GownTimer = new System.Windows.Forms.Timer(this.components);
            this.SettingsTimer = new System.Windows.Forms.Timer(this.components);
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlForms = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.pnlGown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 48);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel7
            // 
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Controls.Add(this.btnMin);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1151, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 48);
            this.panel7.TabIndex = 14;
            // 
            // btnMin
            // 
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::GownGuru_MainSystem.Properties.Resources.minimizeWhite;
            this.btnMin.Location = new System.Drawing.Point(12, 6);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(23, 35);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 11;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click_1);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMax);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1198, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 48);
            this.panel4.TabIndex = 11;
            // 
            // btnMax
            // 
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::GownGuru_MainSystem.Properties.Resources.MaxWhite;
            this.btnMax.Location = new System.Drawing.Point(12, 5);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(23, 35);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 12;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click_1);
            this.btnMax.MouseEnter += new System.EventHandler(this.btnMax_MouseEnter);
            this.btnMax.MouseLeave += new System.EventHandler(this.btnMax_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1245, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 48);
            this.panel5.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::GownGuru_MainSystem.Properties.Resources.XWhite;
            this.btnExit.Location = new System.Drawing.Point(12, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 35);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 13;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.sidebar.Controls.Add(this.pnlSettings);
            this.sidebar.Controls.Add(this.btnPOS);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.btnCustomers);
            this.sidebar.Controls.Add(this.pnlGown);
            this.sidebar.Controls.Add(this.btnDashboard);
            this.sidebar.Controls.Add(this.pictureBox2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(303, 745);
            this.sidebar.TabIndex = 2;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnSettings);
            this.pnlSettings.Controls.Add(this.btnTransactionLog);
            this.pnlSettings.Controls.Add(this.btnArchive);
            this.pnlSettings.Controls.Add(this.btnFormerEmp);
            this.pnlSettings.Controls.Add(this.btnEmployee);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 443);
            this.pnlSettings.MaximumSize = new System.Drawing.Size(307, 260);
            this.pnlSettings.MinimumSize = new System.Drawing.Size(307, 57);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(307, 57);
            this.pnlSettings.TabIndex = 10;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSettings.BorderRadius = 14;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = global::GownGuru_MainSystem.Properties.Resources.iconsSettings_26;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(303, 50);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "         Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextColor = System.Drawing.Color.Black;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTransactionLog
            // 
            this.btnTransactionLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnTransactionLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnTransactionLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransactionLog.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTransactionLog.BorderRadius = 10;
            this.btnTransactionLog.BorderSize = 0;
            this.btnTransactionLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactionLog.FlatAppearance.BorderSize = 0;
            this.btnTransactionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionLog.ForeColor = System.Drawing.Color.Black;
            this.btnTransactionLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionLog.Location = new System.Drawing.Point(3, 205);
            this.btnTransactionLog.Name = "btnTransactionLog";
            this.btnTransactionLog.Size = new System.Drawing.Size(319, 50);
            this.btnTransactionLog.TabIndex = 8;
            this.btnTransactionLog.Text = "           Transaction Log";
            this.btnTransactionLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionLog.TextColor = System.Drawing.Color.Black;
            this.btnTransactionLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransactionLog.UseVisualStyleBackColor = false;
            this.btnTransactionLog.Click += new System.EventHandler(this.btnTransactionLog_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnArchive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArchive.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnArchive.BorderRadius = 14;
            this.btnArchive.BorderSize = 0;
            this.btnArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchive.FlatAppearance.BorderSize = 0;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.ForeColor = System.Drawing.Color.Black;
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(3, 155);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(319, 50);
            this.btnArchive.TabIndex = 7;
            this.btnArchive.Text = "           Archive";
            this.btnArchive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.TextColor = System.Drawing.Color.Black;
            this.btnArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnFormerEmp
            // 
            this.btnFormerEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnFormerEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnFormerEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFormerEmp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFormerEmp.BorderRadius = 14;
            this.btnFormerEmp.BorderSize = 0;
            this.btnFormerEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormerEmp.FlatAppearance.BorderSize = 0;
            this.btnFormerEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormerEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormerEmp.ForeColor = System.Drawing.Color.Black;
            this.btnFormerEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormerEmp.Location = new System.Drawing.Point(3, 105);
            this.btnFormerEmp.Name = "btnFormerEmp";
            this.btnFormerEmp.Size = new System.Drawing.Size(319, 50);
            this.btnFormerEmp.TabIndex = 6;
            this.btnFormerEmp.Text = "           Former Employee";
            this.btnFormerEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormerEmp.TextColor = System.Drawing.Color.Black;
            this.btnFormerEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFormerEmp.UseVisualStyleBackColor = false;
            this.btnFormerEmp.Click += new System.EventHandler(this.btnFormerEmp_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEmployee.BorderRadius = 14;
            this.btnEmployee.BorderSize = 0;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(3, 56);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(319, 50);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "           Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextColor = System.Drawing.Color.Black;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnPOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPOS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPOS.BorderRadius = 14;
            this.btnPOS.BorderSize = 0;
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.Black;
            this.btnPOS.Image = global::GownGuru_MainSystem.Properties.Resources.iconPOS;
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.Location = new System.Drawing.Point(0, 393);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(303, 50);
            this.btnPOS.TabIndex = 12;
            this.btnPOS.Text = "         POS";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.TextColor = System.Drawing.Color.Black;
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.logout);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 697);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(303, 48);
            this.panel6.TabIndex = 10;
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Image = global::GownGuru_MainSystem.Properties.Resources.iconLogout;
            this.logout.Location = new System.Drawing.Point(6, 6);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(46, 38);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 4;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseEnter += new System.EventHandler(this.logout_MouseEnter);
            this.logout.MouseLeave += new System.EventHandler(this.logout_MouseLeave);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCustomers.BorderRadius = 14;
            this.btnCustomers.BorderSize = 0;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Image = global::GownGuru_MainSystem.Properties.Resources.iconsCustomers_26;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 343);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(303, 50);
            this.btnCustomers.TabIndex = 11;
            this.btnCustomers.Text = "         Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextColor = System.Drawing.Color.Black;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // pnlGown
            // 
            this.pnlGown.Controls.Add(this.btnReturned);
            this.pnlGown.Controls.Add(this.btnRented);
            this.pnlGown.Controls.Add(this.btnCategory);
            this.pnlGown.Controls.Add(this.btnManage);
            this.pnlGown.Controls.Add(this.btnGown);
            this.pnlGown.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGown.Location = new System.Drawing.Point(0, 293);
            this.pnlGown.MaximumSize = new System.Drawing.Size(309, 265);
            this.pnlGown.MinimumSize = new System.Drawing.Size(309, 50);
            this.pnlGown.Name = "pnlGown";
            this.pnlGown.Size = new System.Drawing.Size(309, 50);
            this.pnlGown.TabIndex = 3;
            // 
            // btnReturned
            // 
            this.btnReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnReturned.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnReturned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturned.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReturned.BorderRadius = 14;
            this.btnReturned.BorderSize = 0;
            this.btnReturned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturned.FlatAppearance.BorderSize = 0;
            this.btnReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturned.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturned.ForeColor = System.Drawing.Color.Black;
            this.btnReturned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturned.Location = new System.Drawing.Point(3, 208);
            this.btnReturned.Name = "btnReturned";
            this.btnReturned.Size = new System.Drawing.Size(319, 50);
            this.btnReturned.TabIndex = 8;
            this.btnReturned.Text = "           Returned";
            this.btnReturned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturned.TextColor = System.Drawing.Color.Black;
            this.btnReturned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturned.UseVisualStyleBackColor = false;
            this.btnReturned.Click += new System.EventHandler(this.btnReturned_Click);
            // 
            // btnRented
            // 
            this.btnRented.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnRented.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnRented.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRented.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRented.BorderRadius = 14;
            this.btnRented.BorderSize = 0;
            this.btnRented.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRented.FlatAppearance.BorderSize = 0;
            this.btnRented.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRented.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRented.ForeColor = System.Drawing.Color.Black;
            this.btnRented.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRented.Location = new System.Drawing.Point(3, 158);
            this.btnRented.Name = "btnRented";
            this.btnRented.Size = new System.Drawing.Size(319, 50);
            this.btnRented.TabIndex = 7;
            this.btnRented.Text = "           Rented";
            this.btnRented.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRented.TextColor = System.Drawing.Color.Black;
            this.btnRented.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRented.UseVisualStyleBackColor = false;
            this.btnRented.Click += new System.EventHandler(this.btnRented_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCategory.BorderRadius = 14;
            this.btnCategory.BorderSize = 0;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(3, 108);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(319, 50);
            this.btnCategory.TabIndex = 6;
            this.btnCategory.Text = "           Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextColor = System.Drawing.Color.Black;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnManage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(42)))));
            this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnManage.BorderRadius = 14;
            this.btnManage.BorderSize = 0;
            this.btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.Black;
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.Location = new System.Drawing.Point(3, 58);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(319, 50);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "           Manage";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.TextColor = System.Drawing.Color.Black;
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnGown
            // 
            this.btnGown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnGown.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnGown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGown.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGown.BorderRadius = 14;
            this.btnGown.BorderSize = 0;
            this.btnGown.FlatAppearance.BorderSize = 0;
            this.btnGown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGown.ForeColor = System.Drawing.Color.Black;
            this.btnGown.Image = global::GownGuru_MainSystem.Properties.Resources.icondGown;
            this.btnGown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGown.Location = new System.Drawing.Point(0, 3);
            this.btnGown.Name = "btnGown";
            this.btnGown.Size = new System.Drawing.Size(303, 50);
            this.btnGown.TabIndex = 4;
            this.btnGown.Text = "         Gown";
            this.btnGown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGown.TextColor = System.Drawing.Color.Black;
            this.btnGown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGown.UseVisualStyleBackColor = false;
            this.btnGown.Click += new System.EventHandler(this.btnGown_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDashboard.BorderRadius = 14;
            this.btnDashboard.BorderSize = 0;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = global::GownGuru_MainSystem.Properties.Resources.iconsHome_24;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 243);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(303, 50);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "         Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextColor = System.Drawing.Color.Black;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::GownGuru_MainSystem.Properties.Resources.Final_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(303, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMenu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 48);
            this.panel3.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::GownGuru_MainSystem.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(6, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(46, 38);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 4;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // GownTimer
            // 
            this.GownTimer.Interval = 5;
            this.GownTimer.Tick += new System.EventHandler(this.GownTimer_Tick);
            // 
            // SettingsTimer
            // 
            this.SettingsTimer.Interval = 5;
            this.SettingsTimer.Tick += new System.EventHandler(this.SettingsTimer_Tick);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // pnlForms
            // 
            this.pnlForms.Location = new System.Drawing.Point(306, 51);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(985, 694);
            this.pnlForms.TabIndex = 3;
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1297, 745);
            this.ControlBox = false;
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.pnlGown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidebar;
        private CustomButton btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnMenu;
        private CustomButton btnGown;
        private System.Windows.Forms.Panel pnlGown;
        private CustomButton btnReturned;
        private CustomButton btnRented;
        private CustomButton btnCategory;
        private CustomButton btnManage;
        private CustomButton btnSettings;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.Panel pnlSettings;
        private CustomButton btnTransactionLog;
        private CustomButton btnArchive;
        private CustomButton btnFormerEmp;
        private CustomButton btnEmployee;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer GownTimer;
        private System.Windows.Forms.Timer SettingsTimer;
        private CustomButton btnPOS;
        private CustomButton btnCustomers;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Panel pnlForms;
    }
}