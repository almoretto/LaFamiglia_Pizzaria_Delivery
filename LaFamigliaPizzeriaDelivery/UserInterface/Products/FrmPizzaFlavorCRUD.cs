﻿using BusinessRules;
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
    public partial class FrmPizzaFlavorCRUD : Form
    {
        private bool newregister;
        int returnControl = 0;

        public FrmPizzaFlavorCRUD()
        {
            InitializeComponent();
            MonetaryMask.AplyEvents(txtFlavorPriceAdditional);
            IdFieldMasks.AplyEvents(txtFlavorId);
        }

        private void FrmPizzaFlavorCRUD_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        #region --== Button Methods ==--
        private void BtnFlavorSearch_Click(object sender, EventArgs e)
        {
            List<EntityViewProducts> pizzaFlavors = new PizzaFlavorBus().GetEntityViewProducts(Status.Todos);
            if (pizzaFlavors.Count < 1)
            {
                //verify if list is empty
                MessageBox.Show("Sem dados para exibir!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            //send list to Generic search form
            FrmGenericQueriesProducts FrmPizzaFlavorQuery = new FrmGenericQueriesProducts("Pesquisa de Adicionais", Status.Todos);
            FrmPizzaFlavorQuery.queryList = pizzaFlavors;
            FrmPizzaFlavorQuery.ShowDialog();

            returnControl = FrmPizzaFlavorQuery.returnControl;
            //Break if returno control is invalid
            if (returnControl < 1) { return; }

            txtFlavorId.Text = returnControl.ToString();
            TxtFlavorId_Validating(txtFlavorId, new CancelEventArgs());
            btnFlavorSearch.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!FieldsVerification()) { return; }
            //Fields to save to DB on Aditional Table
            PizzaFlavorBus _flvBus = new PizzaFlavorBus();
            PizzaFlavor pizzaFlavorToCreate = new PizzaFlavor();
            pizzaFlavorToCreate.Description = txtFlavorDescription.Text.Trim();
            pizzaFlavorToCreate.FlavorRemark = txtFlavorRemark.Text.Trim();
            MonetaryMask.UnMakeMask(txtFlavorPriceAdditional, new EventArgs());
            pizzaFlavorToCreate.AdditionalPrice = Convert.ToDouble(txtFlavorPriceAdditional.Text);
            pizzaFlavorToCreate.FlavorStatus = flvStatus.CurrentStatus;
            pizzaFlavorToCreate.LastChangeDate = DateTime.Now;
            pizzaFlavorToCreate.LastChangeUserId = Session.User.Id;

            if (newregister)//Record new register to DB
            {
                if (_flvBus.CreatePizzaFlavor(pizzaFlavorToCreate))
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
                pizzaFlavorToCreate.Id = Convert.ToInt32(txtFlavorId.Text.Trim());
                if (_flvBus.UpdatePizzaFlavor(pizzaFlavorToCreate))
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
            IdFieldMasks.UnMakeMask(txtFlavorId, new EventArgs());
            int pizzaFlavorToDelete = Convert.ToInt32(txtFlavorId.Text.Trim());
            PizzaFlavorBus _flvBus = new PizzaFlavorBus();
            if (_flvBus.DeletePizzaFlavor(pizzaFlavorToDelete))
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
        private void TxtFlavorId_Validating(object sender, CancelEventArgs e)
        {
            if (txtFlavorId.Text.Trim() == string.Empty) { return; }

            PizzaFlavor pizzaFlavorToDisplay = new PizzaFlavorBus()
                .FindById(Convert.ToInt32(txtFlavorId.Text.Trim()));

            if (pizzaFlavorToDisplay.Description == null || pizzaFlavorToDisplay.Id == 0)
            {
                btnDelete.Enabled = false;
                ClearForm();
                return;
            }

            newregister = false;

            txtFlavorDescription.Text = pizzaFlavorToDisplay.Description;
            txtFlavorRemark.Text = pizzaFlavorToDisplay.FlavorRemark;
            txtFlavorPriceAdditional.Text = pizzaFlavorToDisplay.AdditionalPrice.ToString("C2");
            flvStatus.StartStatus(pizzaFlavorToDisplay.FlavorStatus);
            btnDelete.Enabled = true;

            IdFieldMasks.MakeMask(txtFlavorId, new EventArgs());
        }

        #endregion

        #region --== Auxiliary Methods ==--
        public void ClearForm()
        {

            txtFlavorId.Text = string.Empty;
            txtFlavorId.Text = new PizzaFlavorBus().FindNextCode().ToString();
            txtFlavorDescription.Text = string.Empty;
            txtFlavorRemark.Text = string.Empty;
            txtFlavorPriceAdditional.Text = string.Empty;
            btnDelete.Enabled = false;
            flvStatus.StartStatus(Status.Ativo);
            newregister = true;
            IdFieldMasks.MakeMask(txtFlavorId, new EventArgs());
            MonetaryMask.MakeMask(txtFlavorPriceAdditional, new EventArgs());
            Functions.SetSelectedFocus(txtFlavorDescription);

        }

        private bool FieldsVerification()
        {
            if (txtFlavorDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve informar uma descrição para o Adicional!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            //if (txtFlavorPriceAdditional.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Você deve informar um valor para o adicional!",
            //        this.Text,
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return false;
            //}

            return true;
        }
        #endregion


    }
}
