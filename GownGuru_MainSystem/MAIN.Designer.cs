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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.btnmenu = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.pnlSettingsSubTab = new GownGuru_MainSystem.CustomPanel();
            this.pnlArchiveSubTab = new GownGuru_MainSystem.CustomPanel();
            this.btnArchGown = new GownGuru_MainSystem.CustomButton();
            this.btnArchEmp = new GownGuru_MainSystem.CustomButton();
            this.btnArchives = new GownGuru_MainSystem.CustomButton();
            this.btnTransacLog = new GownGuru_MainSystem.CustomButton();
            this.btnAcc = new GownGuru_MainSystem.CustomButton();
            this.btnSettings = new GownGuru_MainSystem.CustomButton();
            this.btnPOS = new GownGuru_MainSystem.CustomButton();
            this.pnlGownsSubTab = new System.Windows.Forms.Panel();
            this.btnReturned = new GownGuru_MainSystem.CustomButton();
            this.btnCategory = new GownGuru_MainSystem.CustomButton();
            this.btnRented = new GownGuru_MainSystem.CustomButton();
            this.btnGown = new GownGuru_MainSystem.CustomButton();
            this.btnDashboard = new GownGuru_MainSystem.CustomButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.customPanel1 = new GownGuru_MainSystem.CustomPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnlSettingsSubTab.SuspendLayout();
            this.pnlArchiveSubTab.SuspendLayout();
            this.pnlGownsSubTab.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.BackgroundImage = global::GownGuru_MainSystem.Properties.Resources.menu;
            this.btnmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.Location = new System.Drawing.Point(8, 1);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(41, 40);
            this.btnmenu.TabIndex = 0;
            this.btnmenu.TabStop = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click_1);
            this.btnmenu.MouseEnter += new System.EventHandler(this.btnmenu_MouseEnter);
            this.btnmenu.MouseLeave += new System.EventHandler(this.btnmenu_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::GownGuru_MainSystem.Properties.Resources.iconLogout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(3, 682);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(53, 40);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 0;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // sidebar
            // 
            this.sidebar.AllowDrop = true;
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.sidebar.Controls.Add(this.pnlSettingsSubTab);
            this.sidebar.Controls.Add(this.btnSettings);
            this.sidebar.Controls.Add(this.btnPOS);
            this.sidebar.Controls.Add(this.pnlGownsSubTab);
            this.sidebar.Controls.Add(this.btnGown);
            this.sidebar.Controls.Add(this.btnDashboard);
            this.sidebar.Controls.Add(this.pnlLogo);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(276, 725);
            this.sidebar.MinimumSize = new System.Drawing.Size(38, 725);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(276, 725);
            this.sidebar.TabIndex = 25;
            // 
            // pnlSettingsSubTab
            // 
            this.pnlSettingsSubTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlSettingsSubTab.BorderRadius = 0;
            this.pnlSettingsSubTab.Controls.Add(this.pnlArchiveSubTab);
            this.pnlSettingsSubTab.Controls.Add(this.btnArchives);
            this.pnlSettingsSubTab.Controls.Add(this.btnTransacLog);
            this.pnlSettingsSubTab.Controls.Add(this.btnAcc);
            this.pnlSettingsSubTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettingsSubTab.ForeColor = System.Drawing.Color.Black;
            this.pnlSettingsSubTab.GradientAngle = 80F;
            this.pnlSettingsSubTab.GradientBottomColor = System.Drawing.Color.Transparent;
            this.pnlSettingsSubTab.GradientTopColor = System.Drawing.Color.Transparent;
            this.pnlSettingsSubTab.Location = new System.Drawing.Point(0, 538);
            this.pnlSettingsSubTab.Name = "pnlSettingsSubTab";
            this.pnlSettingsSubTab.Size = new System.Drawing.Size(276, 209);
            this.pnlSettingsSubTab.TabIndex = 30;
            // 
            // pnlArchiveSubTab
            // 
            this.pnlArchiveSubTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlArchiveSubTab.BorderRadius = 0;
            this.pnlArchiveSubTab.Controls.Add(this.btnArchGown);
            this.pnlArchiveSubTab.Controls.Add(this.btnArchEmp);
            this.pnlArchiveSubTab.ForeColor = System.Drawing.Color.Black;
            this.pnlArchiveSubTab.GradientAngle = 80F;
            this.pnlArchiveSubTab.GradientBottomColor = System.Drawing.Color.Transparent;
            this.pnlArchiveSubTab.GradientTopColor = System.Drawing.Color.Transparent;
            this.pnlArchiveSubTab.Location = new System.Drawing.Point(2, 116);
            this.pnlArchiveSubTab.Name = "pnlArchiveSubTab";
            this.pnlArchiveSubTab.Size = new System.Drawing.Size(275, 84);
            this.pnlArchiveSubTab.TabIndex = 28;
            // 
            // btnArchGown
            // 
            this.btnArchGown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(8)))));
            this.btnArchGown.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(8)))));
            this.btnArchGown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArchGown.BorderColor = System.Drawing.Color.White;
            this.btnArchGown.BorderRadius = 13;
            this.btnArchGown.BorderSize = 0;
            this.btnArchGown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchGown.FlatAppearance.BorderSize = 0;
            this.btnArchGown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchGown.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchGown.ForeColor = System.Drawing.Color.Black;
            this.btnArchGown.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnArchGown.Location = new System.Drawing.Point(19, 40);
            this.btnArchGown.Name = "btnArchGown";
            this.btnArchGown.Size = new System.Drawing.Size(282, 36);
            this.btnArchGown.TabIndex = 26;
            this.btnArchGown.Text = "         Gowns";
            this.btnArchGown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchGown.TextColor = System.Drawing.Color.Black;
            this.btnArchGown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArchGown.UseVisualStyleBackColor = false;
            this.btnArchGown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnArchGown_MouseClick);
            // 
            // btnArchEmp
            // 
            this.btnArchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(8)))));
            this.btnArchEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(8)))));
            this.btnArchEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArchEmp.BorderColor = System.Drawing.Color.White;
            this.btnArchEmp.BorderRadius = 13;
            this.btnArchEmp.BorderSize = 0;
            this.btnArchEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchEmp.FlatAppearance.BorderSize = 0;
            this.btnArchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchEmp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchEmp.ForeColor = System.Drawing.Color.Black;
            this.btnArchEmp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnArchEmp.Location = new System.Drawing.Point(19, 2);
            this.btnArchEmp.Name = "btnArchEmp";
            this.btnArchEmp.Size = new System.Drawing.Size(305, 36);
            this.btnArchEmp.TabIndex = 25;
            this.btnArchEmp.Text = "         Former Employee";
            this.btnArchEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchEmp.TextColor = System.Drawing.Color.Black;
            this.btnArchEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArchEmp.UseVisualStyleBackColor = false;
            this.btnArchEmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnArchEmp_MouseClick);
            // 
            // btnArchives
            // 
            this.btnArchives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnArchives.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnArchives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArchives.BorderColor = System.Drawing.Color.White;
            this.btnArchives.BorderRadius = 13;
            this.btnArchives.BorderSize = 0;
            this.btnArchives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchives.FlatAppearance.BorderSize = 0;
            this.btnArchives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchives.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchives.ForeColor = System.Drawing.Color.Black;
            this.btnArchives.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArchives.Location = new System.Drawing.Point(20, 81);
            this.btnArchives.Name = "btnArchives";
            this.btnArchives.Size = new System.Drawing.Size(316, 36);
            this.btnArchives.TabIndex = 22;
            this.btnArchives.Text = "       Archives";
            this.btnArchives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchives.TextColor = System.Drawing.Color.Black;
            this.btnArchives.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnArchives.UseVisualStyleBackColor = false;
            this.btnArchives.Click += new System.EventHandler(this.btnArchives_Click_1);
            this.btnArchives.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnArchives_MouseClick);
            // 
            // btnTransacLog
            // 
            this.btnTransacLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnTransacLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnTransacLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTransacLog.BorderColor = System.Drawing.Color.White;
            this.btnTransacLog.BorderRadius = 13;
            this.btnTransacLog.BorderSize = 0;
            this.btnTransacLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransacLog.FlatAppearance.BorderSize = 0;
            this.btnTransacLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacLog.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacLog.ForeColor = System.Drawing.Color.Black;
            this.btnTransacLog.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTransacLog.Location = new System.Drawing.Point(20, 42);
            this.btnTransacLog.Name = "btnTransacLog";
            this.btnTransacLog.Size = new System.Drawing.Size(306, 36);
            this.btnTransacLog.TabIndex = 24;
            this.btnTransacLog.Text = "       Transaction Log";
            this.btnTransacLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransacLog.TextColor = System.Drawing.Color.Black;
            this.btnTransacLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransacLog.UseVisualStyleBackColor = false;
            this.btnTransacLog.Click += new System.EventHandler(this.btnTransacLog_Click);
            this.btnTransacLog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTransacLog_MouseClick);
            // 
            // btnAcc
            // 
            this.btnAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnAcc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcc.BorderColor = System.Drawing.Color.White;
            this.btnAcc.BorderRadius = 13;
            this.btnAcc.BorderSize = 0;
            this.btnAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcc.FlatAppearance.BorderSize = 0;
            this.btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcc.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.ForeColor = System.Drawing.Color.Black;
            this.btnAcc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAcc.Location = new System.Drawing.Point(20, 3);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(316, 36);
            this.btnAcc.TabIndex = 21;
            this.btnAcc.Text = "       Accounts";
            this.btnAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcc.TextColor = System.Drawing.Color.Black;
            this.btnAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAcc.UseVisualStyleBackColor = false;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            this.btnAcc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAcc_MouseClick);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.BorderColor = System.Drawing.Color.White;
            this.btnSettings.BorderRadius = 13;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = global::GownGuru_MainSystem.Properties.Resources.iconsSettings_26;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 490);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(276, 48);
            this.btnSettings.TabIndex = 29;
            this.btnSettings.Text = "        SETTINGS";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextColor = System.Drawing.Color.Black;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseClick_1);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnPOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPOS.BorderColor = System.Drawing.Color.White;
            this.btnPOS.BorderRadius = 13;
            this.btnPOS.BorderSize = 0;
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.Black;
            this.btnPOS.Image = global::GownGuru_MainSystem.Properties.Resources.iconPOS;
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPOS.Location = new System.Drawing.Point(0, 442);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(276, 48);
            this.btnPOS.TabIndex = 29;
            this.btnPOS.Text = "        POS";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.TextColor = System.Drawing.Color.Black;
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPOS_MouseClick_1);
            // 
            // pnlGownsSubTab
            // 
            this.pnlGownsSubTab.Controls.Add(this.btnReturned);
            this.pnlGownsSubTab.Controls.Add(this.btnCategory);
            this.pnlGownsSubTab.Controls.Add(this.btnRented);
            this.pnlGownsSubTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGownsSubTab.Location = new System.Drawing.Point(0, 325);
            this.pnlGownsSubTab.Name = "pnlGownsSubTab";
            this.pnlGownsSubTab.Size = new System.Drawing.Size(276, 117);
            this.pnlGownsSubTab.TabIndex = 29;
            // 
            // btnReturned
            // 
            this.btnReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnReturned.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnReturned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturned.BorderColor = System.Drawing.Color.White;
            this.btnReturned.BorderRadius = 13;
            this.btnReturned.BorderSize = 0;
            this.btnReturned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturned.FlatAppearance.BorderSize = 0;
            this.btnReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturned.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturned.ForeColor = System.Drawing.Color.Black;
            this.btnReturned.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReturned.Location = new System.Drawing.Point(15, 75);
            this.btnReturned.Name = "btnReturned";
            this.btnReturned.Size = new System.Drawing.Size(321, 36);
            this.btnReturned.TabIndex = 23;
            this.btnReturned.Text = "       Returned";
            this.btnReturned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturned.TextColor = System.Drawing.Color.Black;
            this.btnReturned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturned.UseVisualStyleBackColor = false;
            this.btnReturned.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReturned_MouseClick);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCategory.BorderColor = System.Drawing.Color.White;
            this.btnCategory.BorderRadius = 13;
            this.btnCategory.BorderSize = 0;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCategory.Location = new System.Drawing.Point(15, 2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(311, 36);
            this.btnCategory.TabIndex = 21;
            this.btnCategory.Text = "       Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextColor = System.Drawing.Color.Black;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCategory_MouseClick);
            // 
            // btnRented
            // 
            this.btnRented.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnRented.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(17)))));
            this.btnRented.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRented.BorderColor = System.Drawing.Color.White;
            this.btnRented.BorderRadius = 13;
            this.btnRented.BorderSize = 0;
            this.btnRented.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRented.FlatAppearance.BorderSize = 0;
            this.btnRented.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRented.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRented.ForeColor = System.Drawing.Color.Black;
            this.btnRented.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRented.Location = new System.Drawing.Point(16, 38);
            this.btnRented.Name = "btnRented";
            this.btnRented.Size = new System.Drawing.Size(320, 36);
            this.btnRented.TabIndex = 22;
            this.btnRented.Text = "       Rented";
            this.btnRented.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRented.TextColor = System.Drawing.Color.Black;
            this.btnRented.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRented.UseVisualStyleBackColor = false;
            this.btnRented.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRented_MouseClick);
            // 
            // btnGown
            // 
            this.btnGown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnGown.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnGown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGown.BorderColor = System.Drawing.Color.White;
            this.btnGown.BorderRadius = 13;
            this.btnGown.BorderSize = 0;
            this.btnGown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGown.FlatAppearance.BorderSize = 0;
            this.btnGown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGown.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGown.ForeColor = System.Drawing.Color.Black;
            this.btnGown.Image = global::GownGuru_MainSystem.Properties.Resources.icondGown;
            this.btnGown.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGown.Location = new System.Drawing.Point(0, 277);
            this.btnGown.Name = "btnGown";
            this.btnGown.Size = new System.Drawing.Size(276, 48);
            this.btnGown.TabIndex = 29;
            this.btnGown.Text = "        GOWNS";
            this.btnGown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGown.TextColor = System.Drawing.Color.Black;
            this.btnGown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGown.UseVisualStyleBackColor = false;
            this.btnGown.Click += new System.EventHandler(this.btnGown_Click_1);
            this.btnGown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGown_MouseClick_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.BorderRadius = 13;
            this.btnDashboard.BorderSize = 0;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 229);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(276, 48);
            this.btnDashboard.TabIndex = 29;
            this.btnDashboard.Text = "        DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextColor = System.Drawing.Color.Black;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDashboard_MouseClick_1);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox2);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 41);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(276, 188);
            this.pnlLogo.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::GownGuru_MainSystem.Properties.Resources.Final_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(47, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnmenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 41);
            this.panel1.TabIndex = 27;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick_1);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.Controls.Add(this.btnClose);
            this.customPanel1.Controls.Add(this.btnMax);
            this.customPanel1.Controls.Add(this.btnMin);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 80F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.Transparent;
            this.customPanel1.GradientTopColor = System.Drawing.Color.Transparent;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1173, 35);
            this.customPanel1.TabIndex = 26;
            this.customPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customPanel1_MouseDown);
            this.customPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customPanel1_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1141, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 14;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1122, 4);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(19, 21);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 15;
            this.btnMax.TabStop = false;
            this.btnMax.MouseEnter += new System.EventHandler(this.btnMax_MouseEnter);
            this.btnMax.MouseLeave += new System.EventHandler(this.btnMax_MouseLeave);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1100, 4);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(19, 21);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 16;
            this.btnMin.TabStop = false;
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 82);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1170, 726);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1170, 726);
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnlSettingsSubTab.ResumeLayout(false);
            this.pnlArchiveSubTab.ResumeLayout(false);
            this.pnlGownsSubTab.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnmenu;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Timer sidebarTimer;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Panel panel1;
        private CustomButton btnSettings;
        private CustomButton btnPOS;
        private System.Windows.Forms.Panel pnlGownsSubTab;
        private CustomButton btnReturned;
        private CustomButton btnCategory;
        private CustomButton btnRented;
        private CustomButton btnGown;
        private CustomButton btnDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomButton btnTransacLog;
        private CustomButton btnAcc;
        private CustomButton btnArchives;
        private CustomPanel pnlArchiveSubTab;
        private CustomButton btnArchGown;
        private CustomButton btnArchEmp;
        private CustomPanel pnlSettingsSubTab;
        private System.Windows.Forms.Button button1;
    }
}

