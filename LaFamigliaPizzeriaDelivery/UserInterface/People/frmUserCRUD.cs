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
using Entities.System;

namespace UserInterface.People
{
    public partial class FrmUserCRUD : Form
    {
        private bool newregister;

        public FrmUserCRUD()
        {
            InitializeComponent();
            IdFieldMasks.AplyEvents(txtUserId);
            IdFieldMasks.AplyEvents(txtUserType);
        }
        private void frmUserCRUD_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        #region --== Buttons ==--

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
            btnUserSearch.Focus();
        }

        private void btnUserTypeSearch_Click(object sender, EventArgs e)
        {
            List<EntityViewSearch> userTypes = new UserTypeBus().GetEntityViewSearch();
            if (userTypes.Count < 1)
            {
                //verify if list is empty
                MessageBox.Show("Sem dados para exibir!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            //send list to Generic search form
            FrmGenericQuerries formUserTypeQuery = new FrmGenericQuerries("Pesquisa de Tipos de Usuários", Status.Todos);
            formUserTypeQuery.queryList = userTypes;
            formUserTypeQuery.ShowDialog();

            int returnControl = formUserTypeQuery.returnControl;
            //Break if returno control is invalid
            if (returnControl < 1) { return; }

            txtUserType.Text = returnControl.ToString();
            txtUserType_Validating(txtUserType, new CancelEventArgs());
            IdFieldMasks.MakeMask(txtUserType, new EventArgs());
            btnUserTypeSearch.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((txtUserId.Text.Trim() == string.Empty) || (newregister)) { return; }

            User userToDelete = new UserBus().FindById(Convert.ToInt32(txtUserId.Text.Trim()));

            if (MessageBox.Show("Realmente deseja excluir?",
                this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new UserBus().DeleteUser(userToDelete))
                {
                    MessageBox.Show("Usuário excluído com sucesso!",
                           this.Text,
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Não foi possível concluir a exclusão!",
                            this.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else { return; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!FieldsVerification()) { return; }
            UserBus _userBus = new UserBus();
            User userToCreate = new User();
            UserType type = new UserTypeBus().GetUserTypeById(Convert.ToInt32(txtUserType.Text.Trim()));
            userToCreate.Name = txtUserName.Text.Trim();
            userToCreate.Login = txtUserLogin.Text.Trim();
            userToCreate.Password = txtUserPassword.Text.Trim();
            userToCreate.UserType = type;
            userToCreate.UserStatus = uscStatus.CurrentStatus;
            userToCreate.LastChangeUserId = Session.User.Id;

            if (newregister)//Record new register to DB
            {
                if (_userBus.CreateUser(userToCreate))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Não foi possível concluir o registro!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else //Alters existent register on Db
            {
                userToCreate.Id = Convert.ToInt32(txtUserId.Text.Trim());
                if (_userBus.UpdateUser(userToCreate))
                {
                    MessageBox.Show("Usuário Atualizado com sucesso!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Não foi possível concluir o atualização!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        #endregion

        #region --== Event Methods ==--
        private void txtUserId_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserId.Text.Trim() == string.Empty) { return; }

            User userToDisplay = new UserBus()
                .FindById(Convert.ToInt32(txtUserId.Text.Trim()));

            if (userToDisplay == null)
            {
                btnDelete.Enabled = false;
                ClearForm();
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

        private void txtUserType_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserType.Text.Trim() == string.Empty)
            {
                lblDspUserType.Text = string.Empty;
                return;
            }
            UserType typeToDisplay = new UserTypeBus()
                .GetUserTypeById(Convert.ToInt32(txtUserType.Text.Trim()));
            if (typeToDisplay == null)
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

        #endregion

        #region --== Auxiliary Method ==--
        private bool FieldsVerification()
        {
            if (txtUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve informar um nome de usuário!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (txtUserLogin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve informar um login de usuário!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (txtUserPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve informar uma senha!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (txtUserPassword.Text.Trim() != txtPasswordConfirmation.Text.Trim())
            {
                MessageBox.Show("Senha e Confirmação não coincidem!",
                   this.Text,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
            if ((txtUserType.Text.Trim() == string.Empty) || (lblDspUserType.Text == string.Empty))
            {
                MessageBox.Show("Você deve Selecionar um perfil de acesso!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void ClearForm()
        {
            txtUserId.Text = string.Empty;
            txtUserId.Text = new UserBus().FindNextCode().ToString();
            txtUserName.Text = string.Empty;
            txtUserLogin.Text = string.Empty;
            txtUserPassword.Text = string.Empty;
            txtPasswordConfirmation.Text = string.Empty;
            txtUserType.Text = string.Empty;
            lblDspUserType.Text = string.Empty;
            btnDelete.Enabled = false;
            uscStatus.StartStatus(Status.Ativo);
            IdFieldMasks.MakeMask(txtUserId, new EventArgs());
            IdFieldMasks.MakeMask(txtUserType, new EventArgs());
            newregister = true;
            Functions.SetSelectedFocus(txtUserName);
        }

        #endregion
    }
}
