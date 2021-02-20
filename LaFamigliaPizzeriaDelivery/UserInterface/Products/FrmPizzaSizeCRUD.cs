using BusinessRules;
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
    public partial class FrmPizzaSizeCRUD : Form
    {
        private bool newregister;
        int returnControl = 0;

        public FrmPizzaSizeCRUD()
        {
            InitializeComponent();
            MonetaryMask.AplyEvents(txtSizePriceAdditional);
            IdFieldMasks.AplyEvents(txtSizeId);
        }

        private void FrmPizzaSizeCRUD_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        #region --== Button Methods ==--
        private void BtnSizeSearch_Click(object sender, EventArgs e)
        {
            List<EntityViewSearch> pizzaSizes = new PizzaSizeBus().GetEntityViewSearch(Status.Todos);
            if (pizzaSizes.Count < 1)
            {
                //verify if list is empty
                MessageBox.Show("Sem dados para exibir!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            //send list to Generic search form
            FrmGenericQuerries FrmPizzaSizeQuery = new FrmGenericQuerries("Pesquisa de Adicionais", Status.Todos);
            FrmPizzaSizeQuery.queryList = pizzaSizes;
            FrmPizzaSizeQuery.ShowDialog();

            returnControl = FrmPizzaSizeQuery.returnControl;
            //Break if returno control is invalid
            if (returnControl < 1) { return; }

            txtSizeId.Text = returnControl.ToString();
            TxtSizeId_Validating(txtSizeId, new CancelEventArgs());
            btnSizeSearch.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!FieldsVerification()) { return; }
            //Fields to save to DB on Aditional Table
            PizzaSizeBus _szeBus = new PizzaSizeBus();
            PizzaSize pizzaSizeToCreate = new PizzaSize();
            pizzaSizeToCreate.Description = txtSizeDescription.Text.Trim();
            pizzaSizeToCreate.FlvorsQty = Convert.ToInt32(txtQtyFlavors.Text.Trim());
            pizzaSizeToCreate.SizeRemark = txtSizeRemark.Text.Trim();
            MonetaryMask.UnMakeMask(txtSizePriceAdditional, new EventArgs());
            pizzaSizeToCreate.AdditionalPrice = Convert.ToDouble(txtSizePriceAdditional.Text);
            pizzaSizeToCreate.SizeStatus = szeStatus.CurrentStatus;
            pizzaSizeToCreate.LastChangeDate = DateTime.Now;
            pizzaSizeToCreate.LastChangeUserId = Session.User.Id;

            if (newregister)//Record new register to DB
            {
                if (_szeBus.CreatePizzaSize(pizzaSizeToCreate))
                {
                    MessageBox.Show("Sabor cadastrado com sucesso!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (Functions.OptimizeAll())
                    {
                        lblSaveOptimize.Text = "DBOTMZ";
                        ClearForm();
                    }
                    else
                    {
                        lblSaveOptimize.Text = "DB!OTMZ";
                        ClearForm();
                        this.Close();
                    }

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
                pizzaSizeToCreate.Id = Convert.ToInt32(txtSizeId.Text.Trim());
                if (_szeBus.UpdatePizzaSize(pizzaSizeToCreate))
                {
                    MessageBox.Show("Sabor Atualizado com sucesso!",
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
            IdFieldMasks.UnMakeMask(txtSizeId, new EventArgs());
            int pizzaSizeToDelete = Convert.ToInt32(txtSizeId.Text.Trim());
            PizzaSizeBus _szeBus = new PizzaSizeBus();
            if (_szeBus.DeletePizzaSize(pizzaSizeToDelete))
            {
                MessageBox.Show("Sabor excluído com sucesso!",
                                      this.Text,
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Não foi possível excluir o registro!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Close();
        }

        #endregion

        #region --== Action Methods ==--
        private void TxtSizeId_Validating(object sender, CancelEventArgs e)
        {
            if (txtSizeId.Text.Trim() == string.Empty) { return; }

            PizzaSize pizzaSizeToDisplay = new PizzaSizeBus()
                .FindById(Convert.ToInt32(txtSizeId.Text.Trim()));

            if (pizzaSizeToDisplay == null)
            {
                btnDelete.Enabled = false;
                ClearForm();
                return;
            }

            newregister = false;

            txtSizeDescription.Text = pizzaSizeToDisplay.Description;
            txtQtyFlavors.Text = pizzaSizeToDisplay.FlvorsQty.ToString();
            txtSizeRemark.Text = pizzaSizeToDisplay.SizeRemark;
            txtSizePriceAdditional.Text = pizzaSizeToDisplay.AdditionalPrice.ToString("C2");
            szeStatus.StartStatus(pizzaSizeToDisplay.SizeStatus);
            btnDelete.Enabled = true;

            IdFieldMasks.MakeMask(txtSizeId, new EventArgs());
        }

        #endregion

        #region --== Auxiliary Methods ==--
        public void ClearForm()
        {

            txtSizeId.Text = string.Empty;
            txtSizeId.Text = new PizzaSizeBus().FindNextCode().ToString();
            txtSizeDescription.Text = string.Empty;
            txtQtyFlavors.Text = string.Empty;
            txtSizeRemark.Text = string.Empty;
            txtSizePriceAdditional.Text = string.Empty;
            btnDelete.Enabled = false;
            szeStatus.StartStatus(Status.Ativo);
            newregister = true;
            IdFieldMasks.MakeMask(txtSizeId, new EventArgs());
            MonetaryMask.MakeMask(txtSizePriceAdditional, new EventArgs());
            Functions.SetSelectedFocus(txtSizeDescription);

        }

        private bool FieldsVerification()
        {
            if (txtSizeDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve informar uma descrição para o tamanho!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if ((txtQtyFlavors.Text.Trim() == string.Empty)||Convert.ToInt32(txtQtyFlavors.Text.Trim())<=0)
            {
                MessageBox.Show("Você deve informar pelo menos \n uma unidade de quantidade de sabores!",
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
