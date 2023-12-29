using GownGuru_MainSystem.LOGIN;
using GownGuru_MainSystem.GOWN;
using GownGuru_MainSystem.SETTINGS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GownGuru_MainSystem
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            CustomDesign();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            openChildForm(new frmDashboard());
        }
        //to avoid flicker elements
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctl, new object[] { DoubleBuffered });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //to avoid flicker forms
        protected override CreateParams CreateParams
        {
            get
            {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                //BORDER RADIUS
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS | CS_DROPSHADOW;

                return cp;
            }
        }
        //UI - FORM BORDER RADIUS
        // Constants for WinAPI calls
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        const int CS_DROPSHADOW = 0x20000;

        // Round the form corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                CenterToScreen();
            }
            SetDoubleBuffer(btnMax, true);

            // Set the form's region to create rounded corners
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
            SetDoubleBuffer(btnMin, true);
            
        }

        //move form
        public Point mouseLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
                this.Opacity = 0.8;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        //CHANGE COLOR OF BUTTONS
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(231, 184, 8);
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Transparent;
        }

        private void btnMax_MouseEnter(object sender, EventArgs e)
        {
            btnMax.BackColor = Color.FromArgb(231, 184, 8);
        }
        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            btnMax.BackColor = Color.Transparent;
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(231, 184, 8);
        }
        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.Transparent;
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.FromArgb(231, 184, 8);
        }
        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Transparent;
        }

        private void logout_MouseEnter(object sender, EventArgs e)
        {
            logout.BackColor = Color.FromArgb(231, 184, 8);
        }
        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.BackColor = Color.Transparent;
        }


        private void ResetButtonAppearance(Button button)
        {
            // Reset the button's appearance to its original state
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.BackColor = Color.FromArgb(236, 208, 98);
            btnDashboard.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsHome-24.png");

            btnGown.ForeColor = Color.Black;
            btnGown.BackColor = Color.FromArgb(236, 208, 98);
            btnGown.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\icondGown.png");

            btnManage.ForeColor = Color.Black;
            btnManage.BackColor = Color.FromArgb(233, 201, 75);

            btnCategory.ForeColor = Color.Black;
            btnCategory.BackColor = Color.FromArgb(233, 201, 75);

            btnRented.ForeColor = Color.Black;
            btnRented.BackColor = Color.FromArgb(233, 201, 75);

            btnReturned.ForeColor = Color.Black;
            btnReturned.BackColor = Color.FromArgb(233, 201, 75);

            btnCustomers.ForeColor = Color.Black;
            btnCustomers.BackColor = Color.FromArgb(236, 208, 98);
            btnCustomers.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsCustomers-26.png");

            btnPOS.ForeColor = Color.Black;
            btnPOS.BackColor = Color.FromArgb(236, 208, 98);
            btnPOS.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconPOS.png");

            btnSettings.ForeColor = Color.Black;
            btnSettings.BackColor = Color.FromArgb(236, 208, 98);
            btnSettings.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsSettings-26.png");

            btnEmployee.ForeColor = Color.Black;
            btnEmployee.BackColor = Color.FromArgb(233, 201, 75);

            btnFormerEmp.ForeColor = Color.Black;
            btnFormerEmp.BackColor = Color.FromArgb(233, 201, 75);

            btnArchive.ForeColor = Color.Black;
            btnArchive.BackColor = Color.FromArgb(233, 201, 75);

            btnTransactionLog.ForeColor = Color.Black;
            btnTransactionLog.BackColor = Color.FromArgb(233, 201, 75);

        }

        //SUB TABS
        private void CustomDesign()
        {
            pnlGown.Visible = false;
            pnlSettings.Visible = false;

        }
        private void hideSubTab()
        {
            if (pnlGown.Visible == true)
            {
                pnlGown.Visible = false;
            }
            if (pnlSettings.Visible == true)
            {
                pnlSettings.Visible = false;
            }
        }

        private void showSubTab(Panel SubTab)
        {
            if (SubTab.Visible == false)
            {
                hideSubTab();
                SubTab.Visible = true;
            }
            else
            {
                SubTab.Visible = false;
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDashboard());

            ResetButtonAppearance(btnDashboard);

            btnDashboard.ForeColor = Color.White;
            btnDashboard.BackColor = Color.FromArgb(36, 36, 36);
            btnDashboard.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconHome-24 white.png");

            hideSubTab();

            SetDoubleBuffer(btnDashboard, true);
        }
        private void btnGown_Click(object sender, EventArgs e)
        {
            showSubTab(pnlGown);
            //GownTimer.Start();

            ResetButtonAppearance(btnGown);

            btnGown.ForeColor = Color.White;
            btnGown.BackColor = Color.FromArgb(36, 36, 36);
            btnGown.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconGownWhite.png");

            SetDoubleBuffer(btnGown, true);
        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer());

            ResetButtonAppearance(btnCustomers);

            btnCustomers.ForeColor = Color.White;
            btnCustomers.BackColor = Color.FromArgb(36, 36, 36);
            btnCustomers.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsCustomersWhite.png");

            hideSubTab();

            SetDoubleBuffer(btnCustomers, true);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPOS());
            ResetButtonAppearance(btnPOS);

            btnPOS.ForeColor = Color.White;
            btnPOS.BackColor = Color.FromArgb(36, 36, 36);
            btnPOS.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconPOSWhite.png");

            hideSubTab();

            SetDoubleBuffer(btnPOS, true);
        }
        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            showSubTab(pnlSettings);
            //SettingsTimer.Start();

            ResetButtonAppearance(btnSettings);

            btnSettings.ForeColor = Color.White;
            btnSettings.BackColor = Color.FromArgb(36, 36, 36);
            btnSettings.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconSettingsWhite-26.png");

            SetDoubleBuffer(btnSettings, true);
        }

        private void btnManage_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmManage());

            ResetButtonAppearance(btnManage);
            btnManage.ForeColor = Color.White;
            btnManage.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmCategory());

            ResetButtonAppearance(btnCategory);
            btnCategory.ForeColor = Color.White;
            btnCategory.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnRented_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmRented());

            ResetButtonAppearance(btnRented);
            btnRented.ForeColor = Color.White;
            btnRented.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnReturned_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmReturned());

            ResetButtonAppearance(btnReturned);
            btnReturned.ForeColor = Color.White;
            btnReturned.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmployee());

            ResetButtonAppearance(btnEmployee);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnFormerEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new frmFormerEmp());

            ResetButtonAppearance(btnFormerEmp);
            btnFormerEmp.ForeColor = Color.White;
            btnFormerEmp.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            openChildForm(new frmArchive());

            ResetButtonAppearance(btnArchive);
            btnArchive.ForeColor = Color.White;
            btnArchive.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnTransactionLog_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTransacLog());

            ResetButtonAppearance(btnTransactionLog);
            btnTransactionLog.ForeColor = Color.White;
            btnTransactionLog.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            ResetButtonAppearance(btnDashboard);

            // Adjust the anchor and position when the sidebar is collapsed or expanded
            if (sideBarCollapsed)
            {
                CenterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                sidebar.Width = ExpandedSidebarWidth;
                CenterPanel.Location = new Point(sidebar.Width, CenterPanel.Location.Y);
                CenterPanel.Width = this.Width - sidebar.Width; // Adjust the width based on the current form width minus the sidebar width
            }
            else
            {
                CenterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                sidebar.Width = CollapsedSidebarWidth;
                CenterPanel.Location = new Point(sidebar.Width, CenterPanel.Location.Y);
                CenterPanel.Width = this.Width - sidebar.Width; // Adjust the width based on the current form width minus the sidebar width
            }
        }

        bool sideBarCollapsed;
        private const int CollapsedSidebarWidth = 40; // Define the collapsed sidebar width
        private const int ExpandedSidebarWidth = 200; // Define the expanded sidebar width
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarCollapsed)
            {
                sidebar.Width += 10;
                if (sidebar.Width >= ExpandedSidebarWidth) // Change the condition to fit your desired width
                {
                    sideBarCollapsed = false;
                    SidebarTimer.Stop();
                    sidebar.Width = ExpandedSidebarWidth; // Set the width directly to the desired value
                }
            }
            else
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= CollapsedSidebarWidth)
                {
                    sideBarCollapsed = true;
                    SidebarTimer.Stop();
                    sidebar.Width = CollapsedSidebarWidth; // Set the width directly to the minimum size
                }
            }
        }


        //toshow subform form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(childForm);
            CenterPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDashboard());

            hideSubTab();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
            //SetDoubleBuffer(sidebar, true);
        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {
            SetDoubleBuffer(CenterPanel, true);
        }


    }
}
