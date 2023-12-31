namespace GownGuru_MainSystem.LOGIN
{
    partial class frmLogin
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
            this.pnlBG = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.pnlInvalidUsr = new System.Windows.Forms.Panel();
            this.lblInvalidUsr = new System.Windows.Forms.Label();
            this.btnLogin = new GownGuru_MainSystem.AnimatedButton();
            this.pnlInvalidPass = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pnlBG.SuspendLayout();
            this.pnlInvalidUsr.SuspendLayout();
            this.pnlInvalidPass.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.BackgroundImage = global::GownGuru_MainSystem.Properties.Resources.login;
            this.pnlBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBG.Controls.Add(this.label3);
            this.pnlBG.Controls.Add(this.label2);
            this.pnlBG.Controls.Add(this.txtPassword);
            this.pnlBG.Controls.Add(this.txtUsername);
            this.pnlBG.Controls.Add(this.checkBoxShowPass);
            this.pnlBG.Controls.Add(this.pnlInvalidUsr);
            this.pnlBG.Controls.Add(this.btnLogin);
            this.pnlBG.Controls.Add(this.pnlInvalidPass);
            this.pnlBG.Location = new System.Drawing.Point(-28, 12);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(508, 723);
            this.pnlBG.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(100, 421);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(314, 32);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(100, 340);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(314, 32);
            this.txtUsername.TabIndex = 6;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.White;
            this.checkBoxShowPass.Location = new System.Drawing.Point(100, 462);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(154, 25);
            this.checkBoxShowPass.TabIndex = 3;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = false;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // pnlInvalidUsr
            // 
            this.pnlInvalidUsr.BackColor = System.Drawing.Color.Transparent;
            this.pnlInvalidUsr.Controls.Add(this.lblInvalidUsr);
            this.pnlInvalidUsr.Location = new System.Drawing.Point(113, 375);
            this.pnlInvalidUsr.Name = "pnlInvalidUsr";
            this.pnlInvalidUsr.Size = new System.Drawing.Size(303, 25);
            this.pnlInvalidUsr.TabIndex = 4;
            this.pnlInvalidUsr.Visible = false;
            // 
            // lblInvalidUsr
            // 
            this.lblInvalidUsr.AutoSize = true;
            this.lblInvalidUsr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInvalidUsr.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidUsr.ForeColor = System.Drawing.Color.Firebrick;
            this.lblInvalidUsr.Location = new System.Drawing.Point(158, 0);
            this.lblInvalidUsr.Name = "lblInvalidUsr";
            this.lblInvalidUsr.Size = new System.Drawing.Size(145, 21);
            this.lblInvalidUsr.TabIndex = 0;
            this.lblInvalidUsr.Text = "Invalid Username";
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationInterval = 1;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLogin.BackgroundSpeed = 40;
            this.btnLogin.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(208)))), ((int)(((byte)(98)))));
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(208)))), ((int)(((byte)(98)))));
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.CustomButtonText = "Login";
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLogin.Location = new System.Drawing.Point(177, 556);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(167, 53);
            this.btnLogin.SmoothCorrectionFactor = 1.5D;
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TextHoverColor = System.Drawing.Color.White;
            this.btnLogin.UseSmoothSpeedIncrement = true;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlInvalidPass
            // 
            this.pnlInvalidPass.BackColor = System.Drawing.Color.Transparent;
            this.pnlInvalidPass.Controls.Add(this.label1);
            this.pnlInvalidPass.Location = new System.Drawing.Point(113, 457);
            this.pnlInvalidPass.Name = "pnlInvalidPass";
            this.pnlInvalidPass.Size = new System.Drawing.Size(303, 25);
            this.pnlInvalidPass.TabIndex = 5;
            this.pnlInvalidPass.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(164, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invalid Password";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBoxClose);
            this.panel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(466, 39);
            this.panel.TabIndex = 1;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::GownGuru_MainSystem.Properties.Resources.XWhite;
            this.pictureBoxClose.Location = new System.Drawing.Point(428, 10);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBoxClose_MouseEnter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(466, 681);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pnlBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.pnlBG.ResumeLayout(false);
            this.pnlBG.PerformLayout();
            this.pnlInvalidUsr.ResumeLayout(false);
            this.pnlInvalidUsr.PerformLayout();
            this.pnlInvalidPass.ResumeLayout(false);
            this.pnlInvalidPass.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private AnimatedButton btnLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Panel pnlInvalidUsr;
        private System.Windows.Forms.Label lblInvalidUsr;
        private System.Windows.Forms.Panel pnlInvalidPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}