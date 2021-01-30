using BusinessRules.Products;
using Entities.Enums;
using Entities.Products;
using Entities.System;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using UserInterface.Modules;
using UserInterface.Querries;

namespace UserInterface.Products
{
    public partial class FrmAdditionalCRUD : Form
    {
        private bool newregister;
        int returnControl = 0;
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!FieldsVerification()) { return; }
            //Fields to save to DB on Aditional Table
            AdditionalBus _adtBus = new AdditionalBus();
            Additional additionalToCreate = new Additional();
            additionalToCreate.Description = txtAdditionalDescription.Text.Trim();
            additionalToCreate.Remark = txtAdditionalRemark.Text.Trim();
            MonetaryMask.UnMakeMask(txtAdditionalPrice, new EventArgs());
            additionalToCreate.Price = Convert.ToDouble(txtAdditionalPrice.Text);
            additionalToCreate.AdditionalStatus = adcStatus.CurrentStatus;
            additionalToCreate.LastChangeDate = DateTime.Now;
            additionalToCreate.LastChangeUserId = Session.User.Id;

            if (newregister)//Record new register to DB
            {
                if (_adtBus.CreateAdditional(additionalToCreate))
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
                additionalToCreate.Id = Convert.ToInt32(txtAdditionalId.Text.Trim());
                if (_adtBus.UpdateAdditional(additionalToCreate))
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdditionalSearch_Click(object sender, EventArgs e)
        {
            List<EntityViewSearch> aditional = new AdditionalBus().GetEntityViewSearch(Status.Todos);
            if (aditional.Count < 1)
            {
                //verify if list is empty
                MessageBox.Show("Sem dados para exibir!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            //send list to Generic search form
            FrmGenericQuerries frmAdditionalQuery = new FrmGenericQuerries("Pesquisa de Adicionais", Status.Todos);
            frmAdditionalQuery.queryList = aditional;
            frmAdditionalQuery.ShowDialog();

            returnControl = frmAdditionalQuery.returnControl;
            //Break if returno control is invalid
            if (returnControl < 1) { return; }

            txtAdditionalId.Text = returnControl.ToString();
            TxtAdditionalId_Validating(txtAdditionalId, new CancelEventArgs());
            btnAdditionalSearch.Focus();
        }





        #endregion

        #region --== Event Methods ==--
        private void TxtAdditionalId_Validating(object sender, CancelEventArgs e)
        {
            if (txtAdditionalId.Text.Trim() == string.Empty) { return; }

            Additional additionalToDisplay = new AdditionalBus()
                .FindById(Convert.ToInt32(txtAdditionalId.Text.Trim()));

            if (additionalToDisplay == null)
            {
                btnDelete.Enabled = false;
                ClearForm();
                return;
            }

            newregister = false;

            txtAdditionalDescription.Text = additionalToDisplay.Description;
            txtAdditionalRemark.Text = additionalToDisplay.Remark;
            txtAdditionalPrice.Text = additionalToDisplay.Price.ToString("C2");
            adcStatus.StartStatus(additionalToDisplay.AdditionalStatus);
            btnDelete.Enabled = true;

            IdFieldMasks.MakeMask(txtAdditionalId, new EventArgs());
            MonetaryMask.MakeMask(txtAdditionalPrice, new EventArgs());
        }

        #endregion

        #region --== Auxiliary Methods ==--
        public void ClearForm()
        {
            txtAdditionalId.Text = string.Empty;
            txtAdditionalId.Text = new AdditionalBus().FindNextCode().ToString();
            txtAdditionalDescription.Text = string.Empty;
            txtAdditionalRemark.Text = string.Empty;
            txtAdditionalPrice.Text = string.Empty;
            btnDelete.Enabled = false;
            adcStatus.StartStatus(Status.Ativo);
            IdFieldMasks.MakeMask(txtAdditionalId, new EventArgs());
            MonetaryMask.MakeMask(txtAdditionalPrice, new EventArgs());
            newregister = true;
            Functions.SetSelectedFocus(txtAdditionalDescription);
        }
        
        private bool FieldsVerification()
        {
            if (txtAdditionalDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve informar uma descrição para o Adicional!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (txtAdditionalPrice.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve informar um valor para o adicional!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
           
            return true;
        }
        #endregion


    }
}
