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
    public partial class FrmPizzaEdgeCRUD : Form
    {
        private bool newregister;
        int returnControl = 0;
        public FrmPizzaEdgeCRUD()
        {
            InitializeComponent();
            MonetaryMask.AplyEvents(txtEdgeAdditionalPrice);
            IdFieldMasks.AplyEvents(txtEdgeId);
        }

        private void FrmPizzaEdgeCRUD_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        #region --== Button Methods ==--
        private void BtnEdgeSearch_Click(object sender, EventArgs e)
        {
            List<EntityViewProducts> pizzaEdges = new PizzaEdgeBus().GetEntityViewProducts(Status.Todos);
            if (pizzaEdges.Count < 1)
            {
                //verify if list is empty
                MessageBox.Show("Sem dados para exibir!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            //send list to Generic search form
            FrmGenericQueriesProducts FrmPizzaEdgeQuery = new FrmGenericQueriesProducts("Pesquisa de Sabor de Bordas", Status.Todos);
            FrmPizzaEdgeQuery.queryList = pizzaEdges;
            FrmPizzaEdgeQuery.ShowDialog();

            returnControl = FrmPizzaEdgeQuery.returnControl;
            //Break if returno control is invalid
            if (returnControl < 1) { return; }

            txtEdgeId.Text = returnControl.ToString();
            TxtEdgeId_Validating(txtEdgeId, new CancelEventArgs());
            btnEdgeSearch.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!FieldsVerification()) { return; }
            //Fields to save to DB on Aditional Table
            PizzaEdgeBus _edgeBus = new PizzaEdgeBus();
            PizzaEdgeFilling pizzaEdgeToCreate = new PizzaEdgeFilling();
            pizzaEdgeToCreate.Description = txtEdgeDescription.Text.Trim();
            pizzaEdgeToCreate.EdgeRemark = txtEdgeRemark.Text.Trim();
            MonetaryMask.UnMakeMask(txtEdgeAdditionalPrice, new EventArgs());
            pizzaEdgeToCreate.AdditionalPrice = Convert.ToDouble(txtEdgeAdditionalPrice.Text);
            pizzaEdgeToCreate.EdgeStatus = edgeStatus.CurrentStatus;
            pizzaEdgeToCreate.LastChangeDate = DateTime.Now;
            pizzaEdgeToCreate.LastChangeUserId = Session.User.Id;

            if (newregister)//Record new register to DB
            {
                if (_edgeBus.CreatePizzaEdge(pizzaEdgeToCreate))
                {
                    MessageBox.Show("Borda cadastrada com sucesso!",
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
                pizzaEdgeToCreate.Id = Convert.ToInt32(txtEdgeId.Text.Trim());
                if (_edgeBus.UpdatePizzaEdge(pizzaEdgeToCreate))
                {
                    MessageBox.Show("Borda Atualizado com sucesso!",
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
            IdFieldMasks.UnMakeMask(txtEdgeId, new EventArgs());
            int pizzaEdgeToDelete = Convert.ToInt32(txtEdgeId.Text.Trim());
            PizzaEdgeBus _edgeBus = new PizzaEdgeBus();
            if (_edgeBus.DeletePizzaEdge(pizzaEdgeToDelete))
            {
                MessageBox.Show("Borda excluído com sucesso!",
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
        private void TxtEdgeId_Validating(object sender, CancelEventArgs e)
        {
            if (txtEdgeId.Text.Trim() == string.Empty) { return; }

            PizzaEdgeFilling pizzaEdgeToDisplay = new PizzaEdgeBus()
                .FindById(Convert.ToInt32(txtEdgeId.Text.Trim()));

            if (pizzaEdgeToDisplay.Description == null || pizzaEdgeToDisplay.Id == 0)
            {
                btnDelete.Enabled = false;
                ClearForm();
                return;
            }

            newregister = false;

            txtEdgeDescription.Text = pizzaEdgeToDisplay.Description;
            txtEdgeRemark.Text = pizzaEdgeToDisplay.EdgeRemark;
            txtEdgeAdditionalPrice.Text = pizzaEdgeToDisplay.AdditionalPrice.ToString("C2");
            edgeStatus.StartStatus(pizzaEdgeToDisplay.EdgeStatus);
            btnDelete.Enabled = true;

            IdFieldMasks.MakeMask(txtEdgeId, new EventArgs());
        }

        #endregion

        #region --== Auxiliary Methods ==--
        public void ClearForm()
        {

            txtEdgeId.Text = string.Empty;
            txtEdgeId.Text = new PizzaEdgeBus().FindNextCode().ToString();
            txtEdgeDescription.Text = string.Empty;
            txtEdgeRemark.Text = string.Empty;
            txtEdgeAdditionalPrice.Text = string.Empty;
            btnDelete.Enabled = false;
            edgeStatus.StartStatus(Status.Ativo);
            newregister = true;
            IdFieldMasks.MakeMask(txtEdgeId, new EventArgs());
            MonetaryMask.MakeMask(txtEdgeAdditionalPrice, new EventArgs());
            Functions.SetSelectedFocus(txtEdgeDescription);

        }

        private bool FieldsVerification()
        {
            if (txtEdgeDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve informar uma descrição para o Adicional!",
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
