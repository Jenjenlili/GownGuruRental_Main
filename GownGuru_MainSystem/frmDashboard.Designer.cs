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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.GownBox = new GownGuru_MainSystem.CustomPanel();
            this.AvailableGownBox = new GownGuru_MainSystem.CustomPanel();
            this.customerBox = new GownGuru_MainSystem.CustomPanel();
            this.gownRentedBox = new GownGuru_MainSystem.CustomPanel();
            this.revenueBox = new GownGuru_MainSystem.CustomPanel();
            this.damageLostBox = new GownGuru_MainSystem.CustomPanel();
            this.inPossessionBox = new GownGuru_MainSystem.CustomPanel();
            this.gownReturnedBox = new GownGuru_MainSystem.CustomPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.GownBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GownBox
            // 
            this.GownBox.BackColor = System.Drawing.Color.Black;
            this.GownBox.BorderRadius = 40;
            this.GownBox.Controls.Add(this.label1);
            this.GownBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GownBox.ForeColor = System.Drawing.Color.Black;
            this.GownBox.GradientAngle = 80F;
            this.GownBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.GownBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.GownBox.Location = new System.Drawing.Point(7, 10);
            this.GownBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 7);
            this.GownBox.Name = "GownBox";
            this.GownBox.Size = new System.Drawing.Size(234, 135);
            this.GownBox.TabIndex = 0;
            this.GownBox.Tag = "";
            this.GownBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GownBox_Paint);
            // 
            // AvailableGownBox
            // 
            this.AvailableGownBox.BackColor = System.Drawing.Color.Black;
            this.AvailableGownBox.BorderRadius = 40;
            this.AvailableGownBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableGownBox.ForeColor = System.Drawing.Color.Black;
            this.AvailableGownBox.GradientAngle = 80F;
            this.AvailableGownBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.AvailableGownBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.AvailableGownBox.Location = new System.Drawing.Point(255, 10);
            this.AvailableGownBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 7);
            this.AvailableGownBox.Name = "AvailableGownBox";
            this.AvailableGownBox.Size = new System.Drawing.Size(234, 135);
            this.AvailableGownBox.TabIndex = 1;
            this.AvailableGownBox.Paint += new System.Windows.Forms.PaintEventHandler(this.AvailableGownBox_Paint);
            // 
            // customerBox
            // 
            this.customerBox.BackColor = System.Drawing.Color.Black;
            this.customerBox.BorderRadius = 40;
            this.customerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerBox.ForeColor = System.Drawing.Color.Black;
            this.customerBox.GradientAngle = 80F;
            this.customerBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.customerBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.customerBox.Location = new System.Drawing.Point(503, 10);
            this.customerBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 7);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(234, 135);
            this.customerBox.TabIndex = 2;
            this.customerBox.Paint += new System.Windows.Forms.PaintEventHandler(this.customerBox_Paint);
            // 
            // gownRentedBox
            // 
            this.gownRentedBox.BackColor = System.Drawing.Color.Black;
            this.gownRentedBox.BorderRadius = 40;
            this.gownRentedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gownRentedBox.ForeColor = System.Drawing.Color.Black;
            this.gownRentedBox.GradientAngle = 80F;
            this.gownRentedBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.gownRentedBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.gownRentedBox.Location = new System.Drawing.Point(751, 10);
            this.gownRentedBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 7);
            this.gownRentedBox.Name = "gownRentedBox";
            this.gownRentedBox.Size = new System.Drawing.Size(235, 135);
            this.gownRentedBox.TabIndex = 2;
            this.gownRentedBox.Paint += new System.Windows.Forms.PaintEventHandler(this.gownRentedBox_Paint);
            // 
            // revenueBox
            // 
            this.revenueBox.BackColor = System.Drawing.Color.Black;
            this.revenueBox.BorderRadius = 40;
            this.revenueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revenueBox.ForeColor = System.Drawing.Color.Black;
            this.revenueBox.GradientAngle = 80F;
            this.revenueBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.revenueBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.revenueBox.Location = new System.Drawing.Point(7, 159);
            this.revenueBox.Margin = new System.Windows.Forms.Padding(7);
            this.revenueBox.Name = "revenueBox";
            this.revenueBox.Size = new System.Drawing.Size(234, 139);
            this.revenueBox.TabIndex = 2;
            this.revenueBox.Paint += new System.Windows.Forms.PaintEventHandler(this.revenueBox_Paint);
            // 
            // damageLostBox
            // 
            this.damageLostBox.BackColor = System.Drawing.Color.Black;
            this.damageLostBox.BorderRadius = 40;
            this.damageLostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.damageLostBox.ForeColor = System.Drawing.Color.Black;
            this.damageLostBox.GradientAngle = 80F;
            this.damageLostBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.damageLostBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.damageLostBox.Location = new System.Drawing.Point(255, 159);
            this.damageLostBox.Margin = new System.Windows.Forms.Padding(7);
            this.damageLostBox.Name = "damageLostBox";
            this.damageLostBox.Size = new System.Drawing.Size(234, 139);
            this.damageLostBox.TabIndex = 3;
            this.damageLostBox.Paint += new System.Windows.Forms.PaintEventHandler(this.damageLostBox_Paint);
            // 
            // inPossessionBox
            // 
            this.inPossessionBox.BackColor = System.Drawing.Color.Black;
            this.inPossessionBox.BorderRadius = 40;
            this.inPossessionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inPossessionBox.ForeColor = System.Drawing.Color.Black;
            this.inPossessionBox.GradientAngle = 80F;
            this.inPossessionBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.inPossessionBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.inPossessionBox.Location = new System.Drawing.Point(503, 159);
            this.inPossessionBox.Margin = new System.Windows.Forms.Padding(7);
            this.inPossessionBox.Name = "inPossessionBox";
            this.inPossessionBox.Size = new System.Drawing.Size(234, 139);
            this.inPossessionBox.TabIndex = 3;
            this.inPossessionBox.Paint += new System.Windows.Forms.PaintEventHandler(this.inPossessionBox_Paint);
            // 
            // gownReturnedBox
            // 
            this.gownReturnedBox.BackColor = System.Drawing.Color.Black;
            this.gownReturnedBox.BorderRadius = 40;
            this.gownReturnedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gownReturnedBox.ForeColor = System.Drawing.Color.Black;
            this.gownReturnedBox.GradientAngle = 80F;
            this.gownReturnedBox.GradientBottomColor = System.Drawing.Color.Transparent;
            this.gownReturnedBox.GradientTopColor = System.Drawing.Color.Transparent;
            this.gownReturnedBox.Location = new System.Drawing.Point(751, 159);
            this.gownReturnedBox.Margin = new System.Windows.Forms.Padding(7);
            this.gownReturnedBox.Name = "gownReturnedBox";
            this.gownReturnedBox.Size = new System.Drawing.Size(235, 139);
            this.gownReturnedBox.TabIndex = 3;
            this.gownReturnedBox.Paint += new System.Windows.Forms.PaintEventHandler(this.gownReturnedBox_Paint);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(993, 305);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gown";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 694);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.GownBox.ResumeLayout(false);
            this.GownBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
    }
}