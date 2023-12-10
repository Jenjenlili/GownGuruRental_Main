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
        public Point mouseLocation;
        public MAIN()
        {
            InitializeComponent();
            CustomDesign();
        }
       
        //move form
        private void customPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void customPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        //change color btn
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(231, 184, 8);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnMax_MouseEnter(object sender, EventArgs e)
        {
            btnMax.BackColor = Color.FromArgb(231, 184, 8);
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(231, 184, 8);
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            btnMax.BackColor = Color.Transparent;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmenu_MouseEnter(object sender, EventArgs e)
        {
            btnmenu.BackColor = Color.FromArgb(231, 184, 8);
        }

        private void btnmenu_MouseLeave(object sender, EventArgs e)
        {
            btnmenu.BackColor = Color.Transparent;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ResetButtonAppearance(btnDashboard);

            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
                
            }
            
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(231, 184, 8);
        }
          
        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Transparent;
        }  
              
        //sidebar slide  
        bool sidebarExpanded = false;
        private void btnmenu_Click_1(object sender, EventArgs e)
        {
            pnlArchiveSubTab.Visible = false;
            pnlGownsSubTab.Visible = false;
            pnlSettingsSubTab.Visible = false;
            ResetButtonAppearance(btnDashboard);

            if (sidebarExpanded)
            {
                sidebarExpanded = false;
                //pnlLogo.Visible = false;
                sidebarTimer.Start();
            }
            else
            {
                //pnlLogo.Visible = true;
                sidebarExpanded = true;
                sidebarTimer.Start();
            }

        }
        private void sidebarTimer_Tick_1(object sender, EventArgs e)
        {
            const int expandWidth = 276; // Change this to your desired expanded width
            const int collapseWidth = 38; // Change this to your desired collapsed width
            const int step = 10;

            if (sidebarExpanded)
            {
                if (sidebar.Width < expandWidth)
                {
                    sidebar.Width += step;
                }
                else
                {
                    sidebar.Width = expandWidth;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                if (sidebar.Width > collapseWidth)
                {
                    sidebar.Width -= step;
                }
                else
                {
                    sidebar.Width = collapseWidth;
                    sidebarTimer.Stop();
                }
            }
        }

        //btn click
        private void ResetButtonAppearance(Button button)
        {
            // Reset the button's appearance to its original state
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.BackColor = Color.FromArgb(249, 211, 66);
            btnDashboard.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsDashboard.png");

            btnGown.ForeColor = Color.Black;
            btnGown.BackColor = Color.FromArgb(249, 211, 66);
            btnGown.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\icondGown.png");

            btnPOS.ForeColor = Color.Black;
            btnPOS.BackColor = Color.FromArgb(249, 211, 66);
            btnPOS.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconPOS.png");

            btnSettings.ForeColor = Color.Black;
            btnSettings.BackColor = Color.FromArgb(249, 211, 66);
            btnSettings.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsSettings-26.png");

            btnCategory.ForeColor = Color.Black;
            btnCategory.BackColor = Color.FromArgb(247, 199, 17);

            btnRented.ForeColor = Color.Black;
            btnRented.BackColor = Color.FromArgb(247, 199, 17);

            btnReturned.ForeColor = Color.Black;
            btnReturned.BackColor = Color.FromArgb(247, 199, 17);

            btnAcc.ForeColor = Color.Black;
            btnAcc.BackColor = Color.FromArgb(247, 199, 17);

            btnTransacLog.ForeColor = Color.Black;
            btnTransacLog.BackColor = Color.FromArgb(247, 199, 17);

            btnArchives.ForeColor = Color.Black;
            btnArchives.BackColor = Color.FromArgb(247, 199, 17);

            btnArchEmp.ForeColor = Color.Black;
            btnArchEmp.BackColor = Color.FromArgb(231, 184, 8);

            btnArchGown.ForeColor = Color.Black;
            btnArchGown.BackColor = Color.FromArgb(231, 184, 8);

        }
        private void btnDashboard_MouseClick_1(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnDashboard);

            btnDashboard.ForeColor = Color.White;
            btnDashboard.BackColor = Color.FromArgb(36, 36, 36);
            btnDashboard.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconsDashboardWhite.png");

            hideSubTab();
        }
        private void btnGown_MouseClick_1(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnGown);

            btnGown.ForeColor = Color.White;
            btnGown.BackColor = Color.FromArgb(36, 36, 36);
            btnGown.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconGownWhite.png");
        }
        private void btnPOS_MouseClick_1(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnPOS);

            btnPOS.ForeColor = Color.White;
            btnPOS.BackColor = Color.FromArgb(36, 36, 36);
            btnPOS.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconPOSWhite.png");

            hideSubTab();

        }
        private void btnSettings_MouseClick_1(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnSettings);

            btnSettings.ForeColor = Color.White;
            btnSettings.BackColor = Color.FromArgb(36, 36, 36);
            btnSettings.Image = Image.FromFile(@"C:\Liyan\GownGuruSystem\iconSettingsWhite-26.png");
        }
        private void btnCategory_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnCategory);
            btnCategory.ForeColor = Color.White;
            btnCategory.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnRented_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnRented);
            btnRented.ForeColor = Color.White;
            btnRented.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnReturned_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnReturned);
            btnReturned.ForeColor = Color.White;
            btnReturned.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnAcc_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnAcc);
            btnAcc.ForeColor = Color.White;
            btnAcc.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnTransacLog_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnTransacLog);
            btnTransacLog.ForeColor = Color.White;
            btnTransacLog.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnArchives_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnArchives);
            btnArchives.ForeColor = Color.White;
            btnArchives.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnArchEmp_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnArchEmp);
            btnArchEmp.ForeColor = Color.White;
            btnArchEmp.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void btnArchGown_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonAppearance(btnArchGown);
            btnArchGown.ForeColor = Color.White;
            btnArchGown.BackColor = Color.FromArgb(36, 36, 36);
        }



        //SUB TABS
        private void CustomDesign()
        {
            pnlGownsSubTab.Visible = false;
            pnlSettingsSubTab.Visible = false;
            pnlArchiveSubTab.Visible = false;

        }
        private void hideSubTab()
        {
            if (pnlGownsSubTab.Visible == true)
            {
                pnlGownsSubTab.Visible = false;
            }
            if (pnlSettingsSubTab.Visible == true)
            {
                pnlSettingsSubTab.Visible = false;
            }
            if (pnlArchiveSubTab.Visible == true)
            {
                pnlArchiveSubTab.Visible = false;
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


        private void btnGown_Click_1(object sender, EventArgs e)
        {
            showSubTab(pnlGownsSubTab);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubTab(pnlSettingsSubTab);
            pnlArchiveSubTab.Visible = false;

        }
        private void btnArchives_Click_1(object sender, EventArgs e)
        {
            if (pnlArchiveSubTab.Visible)
            {
                pnlArchiveSubTab.Visible = false;
            }
            else
            {
                hideSubTab();
                pnlSettingsSubTab.Visible = true;
                pnlArchiveSubTab.Visible = true;
            }
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            pnlArchiveSubTab.Visible = false;
        }

        private void btnTransacLog_Click(object sender, EventArgs e)
        {
            pnlArchiveSubTab.Visible = false;
        }

       
    }
}
