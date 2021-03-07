using BusinessRules.People;
using Entities.Enums;
using Entities.People;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UserInterface.Modules;
using UserInterface.People;
using UserInterface.Querries;

namespace UserInterface.Routines
{
    public partial class FrmOrderRt : Form
    {
        private int ReturnControl = 0;
        private Client ClientInOrder { get; set; }

        //Constructor of the form class
        public FrmOrderRt()
        {
            InitializeComponent();

            IdFieldMasks.AplyEvents(txtClientId);
            MonetaryMask.AplyEvents(txtDeliveryPrice);

        }
        private void FrmOrderRt_Load(object sender, EventArgs e)
        {
            grpClientAddress.Enabled = false;
            grpOrder.Enabled = false;
            grpDeliveryData.Enabled = false;
            btnClientEdit.Enabled = false;
            ClearForm();

        }

        #region --== Buttons Methods ==--
        private void BtnClientSearch_Click(object sender, EventArgs e)
        {
            FrmGenericQuerriesClient frmSearchClient = new FrmGenericQuerriesClient(Status.Ativo);
            frmSearchClient.grbStatus.Enabled = false;
            frmSearchClient.ShowDialog();
            ReturnControl = frmSearchClient.returnControl;

            if (ReturnControl < 1)
            { return; }

            txtClientId.Text = ReturnControl.ToString();
            TxtClientId_Validating(txtClientId, new CancelEventArgs());

            IdFieldMasks.MakeMask(txtClientId, new EventArgs());
            btnClientSearch.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            if (txtClientId.Text.Trim().Equals(string.Empty))
            { return; }

            FrmClientCRUD formClient = new FrmClientCRUD();
            formClient.WindowState = FormWindowState.Normal;
            formClient.StartPosition = FormStartPosition.CenterParent;
            formClient.InitializeEdition(Convert.ToInt32(txtClientId.Text.Trim()));
            formClient.ShowDialog();

            if (formClient.SuccessControl == true)
            {
                TxtClientId_Validating(txtClientId, new CancelEventArgs());
            }
        }

        private void btnChangeDeliveryAddress_Click(object sender, EventArgs e)
        {
            if (txtClientId.Text.Trim().Equals(string.Empty))
            { return; }

            List<EntityViewSearch> addressList = new List<EntityViewSearch>();
            AddressBus _addBus = new AddressBus();
            addressList = _addBus.GetEntityViewSearch(Convert.ToInt32(txtClientId.Text.Trim()));

            if (addressList.Count < 1)
            {
                MessageBox.Show("Não localizado endereços para este Cliente!",
                               this.Text,
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            FrmGenericQuerries addressQuery = new FrmGenericQuerries("Endereços do Cliente: " + lblClientName.Text, Status.Ativo);
            addressQuery.grbStatus.Enabled = false;
            addressQuery.queryList = addressList;
            addressQuery.ShowDialog();

            int formReturn = addressQuery.returnControl;
            if (formReturn < 1)
            { return; }


        }

        #endregion

        #region --== Action Methods ==--
        private void MtxtContact_Validating(object sender, CancelEventArgs e)
        {
            var contactNumber = Functions.RemoveMaskFromMaskedFields(mtxtContact);

            if (contactNumber == null) { return; }

            ClientInOrder = new ClientBus().FindClientByContact((long)contactNumber);

            //Refactoring decision for nullable object because the instance is allways notnull
            //An entity on database always has an Id and a name or other field that is required.
            if (ClientInOrder.Name == null || ClientInOrder.Id == 0)
            {
                btnClientEdit.Enabled = false;
                DialogResult = MessageBox.Show("Cliente não encontrado" +
                                               "\n Desaja cadastrar novo?",
                               this.Text,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    //Initializing the form for including new client or find a client from another way
                    FrmClientCRUD clForm = new FrmClientCRUD();
                    clForm.WindowState = FormWindowState.Normal;
                    clForm.StartPosition = FormStartPosition.CenterParent;
                    clForm.ShowDialog();
                }
                else
                {
                    mtxtContact.Focus();
                    mtxtContact.Text = string.Empty;
                    MessageBox.Show("Tente localizar com outro contato",
                               this.Text,
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                grpClientAddress.Enabled = true;
                btnClientEdit.Enabled = true;

                MessageBox.Show(ClientInOrder.Name,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtClientId.Text = ClientInOrder.Id.ToString();
                IdFieldMasks.MakeMask(txtClientId, new EventArgs());

                lblClientName.Text = ClientInOrder.Name;

                FillAddressFields(ClientInOrder);

                grpOrder.Enabled = true;
                grpDeliveryData.Enabled = true;

            }
        }

        private void TxtClientId_Validating(object sender, CancelEventArgs e)
        {
            if (txtClientId.Text.Trim().Equals(string.Empty))
            { return; }

            ClientInOrder = new ClientBus().FindClientFullEntity(Convert.ToInt32(txtClientId.Text.Trim()));

            if (ClientInOrder.Name == null || ClientInOrder.Id == 0)
            { return; }

            lblClientName.Text = ClientInOrder.Name;

            if (ClientInOrder.Phone == null || ClientInOrder.Phone == 0)
            { mtxtContact.Text = ClientInOrder.Phone.ToString(); }
            else
            {
                mtxtContact.Text = ClientInOrder.CellPhone.ToString();
            }

            grpClientAddress.Enabled = true;
            btnClientEdit.Enabled = true;

            FillAddressFields(ClientInOrder);

            grpOrder.Enabled = true;
            grpDeliveryData.Enabled = true;

        }

        #endregion


        #region --== Auxiliary Methods ==--
        private void FillAddressFields(Client client)
        {
            Client clientInOrder = new Client();
            clientInOrder = client;
            Address stdAddress = (from addr
                                     in clientInOrder.Addresses
                                  where addr.DeliveryAddress = true
                                  select addr).FirstOrDefault();
            if (stdAddress == null) { return; }

            lblDeliveryAddressId.Text = stdAddress.Id.ToString();
            lblClientStreet.Text = stdAddress.Adrress;
            lblStreetNumber.Text = stdAddress.Number;
            lblStreetAdd2.Text = stdAddress.Address2nd;
            lblDistrict.Text = stdAddress.District;
            lblCity.Text = stdAddress.City;
        }

        private void ClearForm()
        {
            txtClientId.Text = string.Empty;
            mtxtContact.Text = string.Empty;

            lblDeliveryAddressId.Text = string.Empty;
            lblClientStreet.Text = string.Empty;
            lblStreetNumber.Text = string.Empty;
            lblStreetAdd2.Text = string.Empty;
            lblDistrict.Text = string.Empty;
            lblCity.Text = string.Empty;

            grpClientAddress.Enabled = false;
            btnClientEdit.Enabled = false;
            //grpOrder.Enabled = true;
            //grpDeliveryData.Enabled = true;
        }


        #endregion


    }
}
