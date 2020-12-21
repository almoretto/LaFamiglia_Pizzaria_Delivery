using BusinessRules.People;
using UserInterface.Querries;
using Entities.Enums;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using Entities.People;
using UserInterface.Modules;

namespace UserInterface.People
{
    public partial class frmUserCRUD : Form
    {
        private bool newregister;
        public frmUserCRUD()
        {
            InitializeComponent();
            IdFieldMasks.AplyEvents(txtUserId);
            IdFieldMasks.AplyEvents(txtUserType);
        }
        private void frmUserCRUD_Load(object sender, EventArgs e)
        {

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
            FrmGenericQuerries formUserQuery = new FrmGenericQuerries("Pesquisa de Usuários", Status.Todos);
            formUserQuery.queryList = users;
            formUserQuery.ShowDialog();

            int returnControl = formUserQuery.returnControl;
            //Break if returno control is invalid
            if (returnControl < 1) { return; }

            txtUserId.Text = returnControl.ToString();
            txtUserId_Validating(txtUserId, new CancelEventArgs());
        }

        private void btnUserTypeSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtUserId_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserId.Text.Trim() == string.Empty) { return; }

            User userToDisplay = new UserBus()
                .FindById(Convert.ToInt32(txtUserId.Text.Trim()));
            
            if (userToDisplay==null)
            {
                btnDelete.Enabled = false;
                return;
            }
            newregister = false;
            
            txtUserName.Text = userToDisplay.Name;
            txtUserLogin.Text = userToDisplay.Login;
            txtUserPassword.Text = userToDisplay.Password;
            txtUserType.Text = userToDisplay.UserType.Id.ToString();

            txtUserType_Validating(txtUserType, new CancelEventArgs());

            IdFieldMasks.MakeMask(txtUserId, new EventArgs());
            IdFieldMasks.MakeMask(txtUserType, new EventArgs());

            uscStatus.StartStatus(userToDisplay.UserStatus);
            btnDelete.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtUserType_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserType.Text.Trim()==string.Empty)
            {
                lblDspUserType.Text = string.Empty;
                return;
            }
            UserType typeToDisplay = new UserTypeBus()
                .GetUserTypeById(Convert.ToInt32(txtUserType.Text.Trim()));
            if (typeToDisplay==null)
            {
                MessageBox.Show("Tipo de usuário não encontrado",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUserType.Select();
                return;
            }

            lblDspUserType.Text = typeToDisplay.Description;
        }
        public void ClearForm()
        {

        }
    }
}
