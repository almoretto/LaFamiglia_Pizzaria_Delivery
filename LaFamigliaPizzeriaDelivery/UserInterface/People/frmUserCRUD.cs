using BusinessRules.People;
using Entities.Enums;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.People
{
    public partial class frmUserCRUD : Form
    {
        public frmUserCRUD()
        {
            InitializeComponent();
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            List<EntityViewSearch> users = new UserBus().GetEntityViewSearch(Status.Todos);
            if (users.Count < 1)
            {
                //verify if list is empty
                MessageBox.Show("Sem dados para exibir!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            //send list to Generic search form

        }

        private void btnUserTypeSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
