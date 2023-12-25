using GownGuru_MainSystem.LOGIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GownGuru_MainSystem
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

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
            }
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
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
            }
        }

        //sub buttons collapse
        bool gownCollapsed;
        bool settingsCollapsed;
        private void GownTimer_Tick(object sender, EventArgs e)
        {
            if (gownCollapsed)
            {
                pnlGown.Height -= 30;
                if (pnlGown.Height <= pnlGown.MinimumSize.Height)
                {
                    pnlGown.Height = pnlGown.MinimumSize.Height;
                    gownCollapsed = false;
                    GownTimer.Stop();
                }
            }
            else
            {
                pnlGown.Height += 30;
                if (pnlGown.Height >= pnlGown.MaximumSize.Height)
                {
                    pnlGown.Height = pnlGown.MaximumSize.Height;
                    gownCollapsed = true;
                    GownTimer.Stop();
                }
            }
        }
        private void btnGown_Click(object sender, EventArgs e)
        {
            GownTimer.Start();

            ResetButtonAppearance(btnGown);

            btnGown.ForeColor = Color.White;
            btnGown.BackColor = Color.FromArgb(36, 36, 36);
            btnGown.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconGownWhite.png");

            // Close the settings panel if it's open
            if (settingsCollapsed)
            {
                SettingsTimer.Stop();
                pnlSettings.Height = pnlSettings.MinimumSize.Height;
                settingsCollapsed = false;
            }
        }

        private void SettingsTimer_Tick(object sender, EventArgs e)
        {
            if (settingsCollapsed)
            {
                pnlSettings.Height -= 30;
                if (pnlSettings.Height <= pnlSettings.MinimumSize.Height)
                {
                    pnlSettings.Height = pnlSettings.MinimumSize.Height;
                    settingsCollapsed = false;
                    SettingsTimer.Stop();
                }
            }
            else
            {
                pnlSettings.Height += 30;
                if (pnlSettings.Height >= pnlSettings.MaximumSize.Height)
                {
                    pnlSettings.Height = pnlSettings.MaximumSize.Height;
                    settingsCollapsed = true;
                    SettingsTimer.Stop();
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsTimer.Start();

            ResetButtonAppearance(btnSettings);

            btnSettings.ForeColor = Color.White;
            btnSettings.BackColor = Color.FromArgb(36, 36, 36);
            btnSettings.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconSettingsWhite-26.png");

            // Close the gown panel if it's open
            if (gownCollapsed)
            {
                GownTimer.Stop();
                pnlGown.Height = pnlGown.MinimumSize.Height;
                gownCollapsed = false;
            }
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
            btnDashboard.BackColor = Color.FromArgb(249, 211, 66);
            btnDashboard.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsHome-24.png");

            btnGown.ForeColor = Color.Black;
            btnGown.BackColor = Color.FromArgb(249, 211, 66);
            btnGown.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\icondGown.png");

            btnManage.ForeColor = Color.Black;
            btnManage.BackColor = Color.FromArgb(248, 188, 42);

            btnCategory.ForeColor = Color.Black;
            btnCategory.BackColor = Color.FromArgb(248, 188, 42);

            btnRented.ForeColor = Color.Black;
            btnRented.BackColor = Color.FromArgb(248, 188, 42);

            btnReturned.ForeColor = Color.Black;
            btnReturned.BackColor = Color.FromArgb(248, 188, 42);

            btnCustomers.ForeColor = Color.Black;
            btnCustomers.BackColor = Color.FromArgb(249, 211, 66);
            btnCustomers.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsCustomers-26.png");

            btnPOS.ForeColor = Color.Black;
            btnPOS.BackColor = Color.FromArgb(249, 211, 66);
            btnPOS.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconPOS.png");

            btnSettings.ForeColor = Color.Black;
            btnSettings.BackColor = Color.FromArgb(249, 211, 66);
            btnSettings.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsSettings-26.png");

            btnEmployee.ForeColor = Color.Black;
            btnEmployee.BackColor = Color.FromArgb(248, 188, 42);

            btnFormerEmp.ForeColor = Color.Black;
            btnFormerEmp.BackColor = Color.FromArgb(248, 188, 42);

            btnArchive.ForeColor = Color.Black;
            btnArchive.BackColor = Color.FromArgb(248, 188, 42);

            btnTransactionLog.ForeColor = Color.Black;
            btnTransactionLog.BackColor = Color.FromArgb(248, 188, 42);

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDashboard());

            ResetButtonAppearance(btnDashboard);

            btnDashboard.ForeColor = Color.White;
            btnDashboard.BackColor = Color.FromArgb(36, 36, 36);
            btnDashboard.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconHome-24 white.png");

            // Close the settings panel if it's open
            if (settingsCollapsed)
            {
                SettingsTimer.Stop();
                pnlSettings.Height = pnlSettings.MinimumSize.Height;
                settingsCollapsed = false;
            }
            // Close the gown panel if it's open
            if (gownCollapsed)
            {
                GownTimer.Stop();
                pnlGown.Height = pnlGown.MinimumSize.Height;
                gownCollapsed = false;
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnCustomers);

            btnCustomers.ForeColor = Color.White;
            btnCustomers.BackColor = Color.FromArgb(36, 36, 36);
            btnCustomers.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsCustomersWhite.png");

            // Close the settings panel if it's open
            if (settingsCollapsed)
            {
                SettingsTimer.Stop();
                pnlSettings.Height = pnlSettings.MinimumSize.Height;
                settingsCollapsed = false;
            }
            // Close the gown panel if it's open
            if (gownCollapsed)
            {
                GownTimer.Stop();
                pnlGown.Height = pnlGown.MinimumSize.Height;
                gownCollapsed = false;
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnPOS);

            btnPOS.ForeColor = Color.White;
            btnPOS.BackColor = Color.FromArgb(36, 36, 36);
            btnPOS.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconPOSWhite.png");

            // Close the settings panel if it's open
            if (settingsCollapsed)
            {
                SettingsTimer.Stop();
                pnlSettings.Height = pnlSettings.MinimumSize.Height;
                settingsCollapsed = false;
            }
            // Close the gown panel if it's open
            if (gownCollapsed)
            {
                GownTimer.Stop();
                pnlGown.Height = pnlGown.MinimumSize.Height;
                gownCollapsed = false;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnManage);
            btnManage.ForeColor = Color.White;
            btnManage.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnCategory);
            btnCategory.ForeColor = Color.White;
            btnCategory.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnRented_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnRented);
            btnRented.ForeColor = Color.White;
            btnRented.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnReturned);
            btnReturned.ForeColor = Color.White;
            btnReturned.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnEmployee);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnFormerEmp_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnFormerEmp);
            btnFormerEmp.ForeColor = Color.White;
            btnFormerEmp.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnArchive);
            btnArchive.ForeColor = Color.White;
            btnArchive.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnTransactionLog_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnTransactionLog);
            btnTransactionLog.ForeColor = Color.White;
            btnTransactionLog.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            ResetButtonAppearance(btnDashboard);
            // Close the settings panel if it's open
            if (settingsCollapsed)
            {
                SettingsTimer.Stop();
                pnlSettings.Height = pnlSettings.MinimumSize.Height;
                settingsCollapsed = false;
            }
            // Close the gown panel if it's open
            if (gownCollapsed)
            {
                GownTimer.Stop();
                pnlGown.Height = pnlGown.MinimumSize.Height;
                gownCollapsed = false;
            }

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
                sidebar.Width += 50;
                if (sidebar.Width >= ExpandedSidebarWidth) // Change the condition to fit your desired width
                {
                    sideBarCollapsed = false;
                    SidebarTimer.Stop();
                    sidebar.Width = ExpandedSidebarWidth; // Set the width directly to the desired value
                }
            }
            else
            {
                sidebar.Width -= 50;
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
    }
}
