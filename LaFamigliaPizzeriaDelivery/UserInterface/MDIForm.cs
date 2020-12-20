﻿using System;
using System.Windows.Forms;
using UserInterface.Login;
using UserInterface.People;

namespace UserInterface
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }
        private void MDIForm_Load(object sender, EventArgs e)
        {
            mnsMdiPrincipal.Visible = false;
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                {
                    //application of the images on the form OnLoad
                    control.BackgroundImage = Properties.Resources.background2;
                    control.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
            FrmLogin formLogin = new FrmLogin(); //instance of the login form
            formLogin.ShowDialog();
            if (formLogin.flgLogin==false)//test of the flag
            {
                Application.Exit();
                //This test verifies if the Form of the login concluded the validation if not the application is closed.
            }
            mnsMdiPrincipal.Visible = true;
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        { Application.Exit(); }
        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        { OpenForms(new frmUserCRUD());}
        private void OpenForms(Form selectedForm)
        {
            selectedForm.WindowState = FormWindowState.Normal;
            selectedForm.StartPosition = FormStartPosition.Manual;
            selectedForm.MdiParent = this;
            selectedForm.Top = 25;
            selectedForm.Left = 25;
            selectedForm.Show();
        }
    }
}