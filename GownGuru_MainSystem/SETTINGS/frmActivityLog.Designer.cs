namespace GownGuru_MainSystem.SETTINGS
{
    partial class frmActivityLog
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
            this.dgvActivityLog = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlActLog = new System.Windows.Forms.Panel();
            this.logID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityLog)).BeginInit();
            this.pnlActLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActivityLog
            // 
            this.dgvActivityLog.AllowUserToAddRows = false;
            this.dgvActivityLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivityLog.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivityLog.ColumnHeadersHeight = 35;
            this.dgvActivityLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActivityLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logID,
            this.empName,
            this.role,
            this.timestamp,
            this.activity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivityLog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivityLog.Location = new System.Drawing.Point(44, 137);
            this.dgvActivityLog.Name = "dgvActivityLog";
            this.dgvActivityLog.RowHeadersVisible = false;
            this.dgvActivityLog.RowHeadersWidth = 62;
            this.dgvActivityLog.Size = new System.Drawing.Size(895, 515);
            this.dgvActivityLog.TabIndex = 105;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(37, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 37);
            this.label16.TabIndex = 2;
            this.label16.Text = "Activity Log";
            // 
            // pnlActLog
            // 
            this.pnlActLog.BackColor = System.Drawing.Color.Black;
            this.pnlActLog.Controls.Add(this.label16);
            this.pnlActLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActLog.Location = new System.Drawing.Point(0, 0);
            this.pnlActLog.Name = "pnlActLog";
            this.pnlActLog.Size = new System.Drawing.Size(993, 92);
            this.pnlActLog.TabIndex = 1;
            this.pnlActLog.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlActivityLog_Paint);
            // 
            // logID
            // 
            this.logID.HeaderText = "LogID";
            this.logID.MinimumWidth = 8;
            this.logID.Name = "logID";
            // 
            // empName
            // 
            this.empName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empName.HeaderText = "Employee Name";
            this.empName.MinimumWidth = 8;
            this.empName.Name = "empName";
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 8;
            this.role.Name = "role";
            // 
            // timestamp
            // 
            this.timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timestamp.HeaderText = "Timestamp";
            this.timestamp.MinimumWidth = 8;
            this.timestamp.Name = "timestamp";
            // 
            // activity
            // 
            this.activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.activity.HeaderText = "Activity";
            this.activity.MinimumWidth = 8;
            this.activity.Name = "activity";
            // 
            // frmActivityLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BackgroundImage = global::GownGuru_MainSystem.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 694);
            this.ControlBox = false;
            this.Controls.Add(this.dgvActivityLog);
            this.Controls.Add(this.pnlActLog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActivityLog";
            this.Text = "frmTransacLog";
            this.Load += new System.EventHandler(this.frmActivityLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityLog)).EndInit();
            this.pnlActLog.ResumeLayout(false);
            this.pnlActLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvActivityLog;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlActLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn logID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn activity;
    }
}