using BusinessRules.People;
using Entities.Enums;
using Entities.People;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using UserInterface.Modules;
using UserInterface.Querries;
using UserInterface.Controls;

namespace UserInterface.People
{
    public partial class FrmClientCRUD : Form
    {
        public bool RecordControl;
        public bool SuccessControl;
        public int EditControlCode;

        public FrmClientCRUD()
        {
            InitializeComponent();
            IdFieldMasks.AplyEvents(txtClientId);
        }

        private void FrmClientCRUD_Load(object sender, EventArgs e)
        {
            ListViewConstructor();
            btnCancel_Click(btnCancel, new EventArgs());

            if (EditControlCode>0)
            {
                txtClientId.Enabled = false;
                
                btnClientSearch.Enabled = false;
                btnCancel.Enabled = false;
                
                txtClientId.Text = EditControlCode.ToString();
                txtClientId_Validating(txtClientId, new CancelEventArgs());
            }
        }
        
        #region --== Buttons ==--
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAddressSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            FrmGenericQuerriesClient frmSearchClient = new FrmGenericQuerriesClient(Status.Todos);
            frmSearchClient.grbStatus.Enabled = true;
            frmSearchClient.ShowDialog();

            int returnControl = frmSearchClient.returnControl;

            if (returnControl < 1) { return; }

            txtClientId.Text = returnControl.ToString();
            //validating

            btnClientSearch.Focus();

        }

        private void txtClientId_Validating(object sender, CancelEventArgs e)
        {
            if (txtClientId.Text.Trim() == string.Empty) { return; }
            Client clientToFind = new ClientBus().FindById(Convert.ToInt32(txtClientId.Text.Trim()));
            if (clientToFind == null)
            {
                if (EditControlCode>0)
                {
                    MessageBox.Show("Não foi possível alterar este registro!\nEste formulário será fechado",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    this.Close();
                }
                MessageBox.Show("Nada encontrado!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnDelete.Enabled = false;
                return;
            }
            RecordControl = false;

            txtClientName.Text = clientToFind.Name;
            mTxtPhone.Text = clientToFind.Phone.ToString();
            mTxtCellPhone.Text = clientToFind.CellPhone.ToString();

            ClearAddressFields();

            foreach (var end in clientToFind.Addresses)
            {
                FillAddressList(end);
            }
            uscStatus.StartStatus(clientToFind.Status);
            
            IdFieldMasks.MakeMask(txtClientId, new EventArgs());
            btnDelete.Enabled = true;
        }

       

        #endregion

        #region --== Auxiliary Methods ==--
        public void InitializeEdition(int editCode)
        {
            SuccessControl = false;
            EditControlCode = editCode;
        }
        
        private void ListViewConstructor()
        {
            lstAddresses.Clear();
            lstAddresses.CheckBoxes = true;
            lstAddresses.View = View.Details;
            lstAddresses.Columns.Add("Delivery", 50, HorizontalAlignment.Right);
            lstAddresses.Columns.Add("Rua", 180, HorizontalAlignment.Left);
            lstAddresses.Columns.Add("Número", 50, HorizontalAlignment.Right);
            lstAddresses.Columns.Add("Complemento", 160, HorizontalAlignment.Left);
            lstAddresses.Columns.Add("Bairro", 80, HorizontalAlignment.Left);
            lstAddresses.Columns.Add("Cidade", 80, HorizontalAlignment.Left);
        }

        private void ClearAddressFields()
        {
            txtAddress.Text = string.Empty;
            txtAddress2nd.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtDistrict.Text = string.Empty;
            txtStNumber.Text = string.Empty;
            chkStdAddress.Checked = false;
        }

        private void FillAddressList(Address end)
        {
            string[] addressLine = new string[6];

            addressLine[0] = string.Empty;
            addressLine[1] = end.Adrress;
            addressLine[2] = end.Number.ToString();
            addressLine[3] = end.Address2nd;
            addressLine[4] = end.District;
            addressLine[5] = end.City;

            ListViewItem lineItem = new ListViewItem(addressLine);
            if (end.DeliveryAddress)
            {
                lineItem.Checked = true;
            }

            lstAddresses.Items.Add(lineItem);
        }

        #endregion
    }
}
