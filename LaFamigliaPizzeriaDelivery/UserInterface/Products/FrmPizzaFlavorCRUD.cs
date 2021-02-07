using BusinessRules.Products;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Modules;

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

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }



        #endregion

        #region --== Action Methods ==--
        private void TxtFlavorId_Validating(object sender, CancelEventArgs e)
        {

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
            IdFieldMasks.MakeMask(txtFlavorId, new EventArgs());
            MonetaryMask.MakeMask(txtFlavorPriceAdditional, new EventArgs());
            newregister = true;
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
