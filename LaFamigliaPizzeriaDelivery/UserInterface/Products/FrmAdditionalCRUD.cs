using Entities.Enums;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserInterface.Modules;
using UserInterface.Querries;

namespace UserInterface.Products
{
    public partial class FrmAdditionalCRUD : Form
    {
        public FrmAdditionalCRUD()
        {
            InitializeComponent();
            MonetaryMask.AplyEvents(txtAdditionalPrice);
            IdFieldMasks.AplyEvents(txtAdditionalId);
        }

        #region --== Buttons ==--
        private void FrmAdditionalCRUD_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdditionalSearch_Click(object sender, EventArgs e)
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
            FrmGenericQuerries formAdditionalQuery = new FrmGenericQuerries("Pesquisa de Usuários", Status.Todos);
            formAdditionalQuery.queryList = users;
            formAdditionalQuery.ShowDialog();

            int returnControl = formAdditionalQuery.returnControl;
            //Break if returno control is invalid
            if (returnControl < 1) { return; }

            txtUserId.Text = returnControl.ToString();
            txtUserId_Validating(txtUserId, new CancelEventArgs());
            btnUserSearch.Focus();
        }

        #endregion


        #region --== Event Methods ==--


        #endregion


        #region --== Auxiliary Methods ==--


        #endregion



    }
}
