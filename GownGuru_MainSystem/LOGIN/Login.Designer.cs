namespace GownGuru_MainSystem.LOGIN
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.Username = new GownGuru_MainSystem.Customized.CustomizedTextbox();
            this.Password = new GownGuru_MainSystem.Customized.CustomizedTextbox();
            this.customPanel1 = new GownGuru_MainSystem.CustomPanel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.btnLogin = new GownGuru_MainSystem.AnimatedButton();
            this.pnlInvalidUsr = new GownGuru_MainSystem.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInvalidPass = new GownGuru_MainSystem.CustomPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.pnlInvalidUsr.SuspendLayout();
            this.pnlInvalidPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowPass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.White;
            this.checkBoxShowPass.Location = new System.Drawing.Point(230, 464);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(147, 27);
            this.checkBoxShowPass.TabIndex = 11;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = false;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Username.BorderColor = System.Drawing.Color.White;
            this.Username.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.Username.BorderRadius = 15;
            this.Username.BorderSize = 1;
            this.Username.Font = new System.Drawing.Font("Perpetua", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(60, 345);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Multiline = false;
            this.Username.Name = "Username";
            this.Username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Username.PasswordChar = false;
            this.Username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Username.PlaceholderText = " Username";
            this.Username.Size = new System.Drawing.Size(327, 44);
            this.Username.TabIndex = 6;
            this.Username.Texts = "";
            this.Username.UnderlinedStyle = false;
            this.Username._TextChanged += new System.EventHandler(this.Username__TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Password.BorderColor = System.Drawing.Color.White;
            this.Password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.Password.BorderRadius = 15;
            this.Password.BorderSize = 1;
            this.Password.Font = new System.Drawing.Font("Perpetua", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(60, 414);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Password.PasswordChar = true;
            this.Password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Password.PlaceholderText = " Password";
            this.Password.Size = new System.Drawing.Size(327, 44);
            this.Password.TabIndex = 6;
            this.Password.Texts = "";
            this.Password.UnderlinedStyle = false;
            this.Password._TextChanged += new System.EventHandler(this.Password__TextChanged);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.Controls.Add(this.pictureBoxClose);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 80F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.Transparent;
            this.customPanel1.GradientTopColor = System.Drawing.Color.Transparent;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(459, 24);
            this.customPanel1.TabIndex = 9;
            this.customPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customPanel1_MouseDown);
            this.customPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customPanel1_MouseMove);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(427, 3);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(28, 22);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 14;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBoxClose_MouseEnter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationInterval = 1;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundSpeed = 40;
            this.btnLogin.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(211)))), ((int)(((byte)(66)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 18;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.CustomButtonText = "Login";
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLogin.Location = new System.Drawing.Point(130, 526);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(178, 54);
            this.btnLogin.SmoothCorrectionFactor = 1.5D;
            this.btnLogin.TabIndex = 1;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.TextHoverColor = System.Drawing.Color.White;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLogin.UseSmoothSpeedIncrement = true;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlInvalidUsr
            // 
            this.pnlInvalidUsr.BackColor = System.Drawing.Color.Transparent;
            this.pnlInvalidUsr.BorderRadius = 0;
            this.pnlInvalidUsr.Controls.Add(this.label1);
            this.pnlInvalidUsr.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInvalidUsr.ForeColor = System.Drawing.Color.Black;
            this.pnlInvalidUsr.GradientAngle = 80F;
            this.pnlInvalidUsr.GradientBottomColor = System.Drawing.Color.Transparent;
            this.pnlInvalidUsr.GradientTopColor = System.Drawing.Color.Transparent;
            this.pnlInvalidUsr.Location = new System.Drawing.Point(63, 394);
            this.pnlInvalidUsr.Name = "pnlInvalidUsr";
            this.pnlInvalidUsr.Size = new System.Drawing.Size(295, 28);
            this.pnlInvalidUsr.TabIndex = 10;
            this.pnlInvalidUsr.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "   Invalid Username*";
            // 
            // pnlInvalidPass
            // 
            this.pnlInvalidPass.BackColor = System.Drawing.Color.Transparent;
            this.pnlInvalidPass.BorderRadius = 0;
            this.pnlInvalidPass.Controls.Add(this.label2);
            this.pnlInvalidPass.ForeColor = System.Drawing.Color.Black;
            this.pnlInvalidPass.GradientAngle = 80F;
            this.pnlInvalidPass.GradientBottomColor = System.Drawing.Color.Transparent;
            this.pnlInvalidPass.GradientTopColor = System.Drawing.Color.Transparent;
            this.pnlInvalidPass.Location = new System.Drawing.Point(63, 464);
            this.pnlInvalidPass.Name = "pnlInvalidPass";
            this.pnlInvalidPass.Size = new System.Drawing.Size(150, 28);
            this.pnlInvalidPass.TabIndex = 10;
            this.pnlInvalidPass.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "   Invalid Password*";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::GownGuru_MainSystem.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(459, 691);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlInvalidUsr);
            this.Controls.Add(this.pnlInvalidPass);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.pnlInvalidUsr.ResumeLayout(false);
            this.pnlInvalidUsr.PerformLayout();
            this.pnlInvalidPass.ResumeLayout(false);
            this.pnlInvalidPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AnimatedButton btnLogin;
        private Customized.CustomizedTextbox Username;
        private System.Windows.Forms.Label label1;
        private CustomPanel customPanel1;
        private CustomPanel pnlInvalidUsr;
        private CustomPanel pnlInvalidPass;
        private System.Windows.Forms.Label label2;
        private Customized.CustomizedTextbox Password;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}