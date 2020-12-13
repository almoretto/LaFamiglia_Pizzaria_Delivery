using System;
using System.Windows.Forms;
using UserInterface.Login;

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
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                {
                    control.BackgroundImage = Properties.Resources.background2;
                    control.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
            FrmLogin formLogin = new FrmLogin();
            formLogin.ShowDialog();

        }
    }
}
