namespace GownGuru_MainSystem.POS
{
    partial class ucGown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGown));
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.txtPic = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnDetails.ForeColor = System.Drawing.Color.Black;
            this.btnDetails.Location = new System.Drawing.Point(0, 306);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(230, 52);
            this.btnDetails.TabIndex = 11;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(22, 16);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(16, 23);
            this.txtName.TabIndex = 9;
            this.txtName.Text = ".";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtName.MouseEnter += new System.EventHandler(this.txtName_MouseEnter);
            this.txtName.MouseLeave += new System.EventHandler(this.txtName_MouseLeave);
            // 
            // txtPic
            // 
            this.txtPic.BackColor = System.Drawing.Color.White;
            this.txtPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPic.Image = ((System.Drawing.Image)(resources.GetObject("txtPic.Image")));
            this.txtPic.Location = new System.Drawing.Point(0, 0);
            this.txtPic.Margin = new System.Windows.Forms.Padding(6);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(230, 223);
            this.txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtPic.TabIndex = 8;
            this.txtPic.TabStop = false;
            this.txtPic.Click += new System.EventHandler(this.txtPic_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(81, 42);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(18, 27);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Text = ".";
            this.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPrice.MouseEnter += new System.EventHandler(this.txtPrice_MouseEnter);
            this.txtPrice.MouseLeave += new System.EventHandler(this.txtPrice_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 83);
            this.panel1.TabIndex = 12;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // ucGown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtPic);
            this.Name = "ucGown";
            this.Size = new System.Drawing.Size(230, 358);
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.PictureBox txtPic;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Panel panel1;
    }
}
