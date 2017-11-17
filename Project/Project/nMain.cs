﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class nMain : Form
    {
        public nMain()
        {
            InitializeComponent();
            infoStaff.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelsideMenu.Width >= 200)
            {
                logo.Location = new Point(0, 55);
                logo.Size = new Size(50, 25);
                labelName.Visible = false;
                panelsideMenu.Width = 50;
                btninfoApplication.Location = new Point(12, 425);
            }
            else
            {
                logo.Location = new Point(48, 39);
                logo.Size = new Size(100,50);
                labelName.Visible = true;
                panelsideMenu.Width = 200;
                btninfoApplication.Location = new Point(170, 425);
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            infoStaff.BringToFront();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            infoManagement.BringToFront();
        }

        private void btnDebt_Click(object sender, EventArgs e)
        {
            infoDebt.BringToFront();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            infoList.BringToFront();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            infochangePassword.BringToFront();
        }

        private void btninfoApplication_Click(object sender, EventArgs e)
        {
            infoApplication.BringToFront();
        }
    }
}