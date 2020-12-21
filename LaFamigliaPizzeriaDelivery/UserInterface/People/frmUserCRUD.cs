using BusinessRules.People;
using UserInterface.Querries;
using Entities.Enums;
using Entities.Views;
using System;
using System.Collections.Generic;
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
            FrmGenericQuerries userQuery = new FrmGenericQuerries("Pesquisa de Usuários", Status.Todos);
            userQuery.queryList = users;
            userQuery.ShowDialog();
            int returnControl = userQuery.returnControl;
        }

        private void btnUserTypeSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
