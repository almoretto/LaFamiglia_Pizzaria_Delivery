﻿using BusinessRules.People;
using Entities.Enums;
using Entities.People;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using UserInterface.Modules;
using UserInterface.Querries;
using Entities.System;
using System.Collections.Generic;

namespace UserInterface.People
{
    public partial class FrmClientCRUD : Form
    {
        public bool NewRegister = false;
        public bool SuccessControl;
        private bool PermitCheck;
        public int EditControlCode;

        public FrmClientCRUD()
        {
            InitializeComponent();
            IdFieldMasks.AplyEvents(txtClientId);
        }

        private void FrmClientCRUD_Load(object sender, EventArgs e)
        {
            ListViewConstructor();
            ClearForm();


            if (EditControlCode > 0)
            {
                txtClientId.Enabled = false;

                btnClientSearch.Enabled = false;
                btnCancel.Enabled = false;

                txtClientId.Text = EditControlCode.ToString();
                TxtClientId_Validating(txtClientId, new CancelEventArgs());
            }
        }

        #region --== Buttons ==--
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidadeClientFields()) { return; }

            Client clientToSendToDB = new Client();
            clientToSendToDB.Name = txtClientName.Text.Trim();
            clientToSendToDB.Phone = Functions.RemoveMaskFromMaskedFields(mTxtPhone);
            clientToSendToDB.CellPhone = Functions.RemoveMaskFromMaskedFields(mTxtCellPhone);

            clientToSendToDB.LastChangeDateTime = DateTime.Now;
            clientToSendToDB.LastChangeUserId = Session.User.Id;
            clientToSendToDB.Status = uscStatus.CurrentStatus;

            clientToSendToDB.Addresses = CreateAddressList();

            ClientBus clientBus = new ClientBus();

            if (NewRegister) //insert into BD
            {
                if (clientBus.CreateClient(clientToSendToDB))
                {
                    MessageBox.Show(
                        "Cliente inserido com sucesso!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtClientId.Text = string.Empty;
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
                    MessageBox.Show(
                        "Cliente não foi inserido, operação em RollBack!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else //Edit
            {
                clientToSendToDB.Id = Convert.ToInt32(txtClientId.Text);

                if (clientBus.EditClient(clientToSendToDB))
                {
                    MessageBox.Show(
                        "Cliente alterado com sucesso!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtClientId.Text = string.Empty;
                                       
                    if (EditControlCode > 0)
                    {
                        SuccessControl = true;
                        this.Close();
                    }
                    else
                    {
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Cliente não foi alterado, operação em RollBack!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtClientId.Text.Trim() == string.Empty) { return; }

            ClientBus clientBus = new ClientBus();
            Client clientToDelete = clientBus.FindClientFullEntity(Convert.ToInt32(txtClientId.Text.Trim()));

            if (clientToDelete == null)
            {
                if (EditControlCode > 0)
                {
                    MessageBox.Show("Não foi possível deletar este registro!\nEste formulário será fechado",
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

            NewRegister = false;

            if (MessageBox.Show("Registro será apagado tem certeza?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clientBus.DeleteClient(clientToDelete))
                {
                    MessageBox.Show("Deletado com secesso!",
                       this.Text,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Registro não pode ser deletado",
                       this.Text,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnAddressSave_Click(object sender, EventArgs e)
        {
            Address addressToAdd = new Address();

            if (!ValidadeAddressFields()) { return; }

            addressToAdd.Adrress = txtAddress.Text.Trim();
            addressToAdd.Number = txtStNumber.Text;
            addressToAdd.Address2nd = txtAddress2nd.Text.Trim();
            addressToAdd.District = txtDistrict.Text.Trim();
            addressToAdd.City = txtCity.Text.Trim();
            addressToAdd.Id = 0;

            if (NewRegister == false)
            {
                addressToAdd.Client = new ClientBus().FindClientFullEntity(Convert.ToInt32(txtClientId.Text.Trim()));
                addressToAdd.Id = Convert.ToInt32(lblAddressId.Text);
            }

            addressToAdd.DeliveryAddress = chkStdAddress.Checked;

            FillAddressList(addressToAdd);
            ClearAddressFields();
        }

        private void LstAddresses_DoubleClick(object sender, EventArgs e)
        {
            BtnAddressEdit_Click(btnAddressEdit, new EventArgs());
        }

        private void BtnDeleteAddress_Click(object sender, EventArgs e)
        {
            if (lstAddresses.SelectedIndices.Count <= 0) { return; }

            int selectedAddressIndex = Convert.ToInt32(lstAddresses.SelectedIndices[0]);

            if (selectedAddressIndex >= 0) { lstAddresses.Items[selectedAddressIndex].Remove(); }
        }

        private void BtnAddressEdit_Click(object sender, EventArgs e)
        {
            if (lstAddresses.SelectedIndices.Count <= 0) { return; }

            int selectedAddressIndex = Convert.ToInt32(lstAddresses.SelectedIndices[0]);

            if (selectedAddressIndex >= 0)
            {
                Address addressToEdit = new Address();
                addressToEdit.DeliveryAddress = lstAddresses.Items[selectedAddressIndex].Checked;
                addressToEdit.Adrress = lstAddresses.Items[selectedAddressIndex].SubItems[1].Text;
                addressToEdit.Number = lstAddresses.Items[selectedAddressIndex].SubItems[2].Text;
                addressToEdit.Address2nd = lstAddresses.Items[selectedAddressIndex].SubItems[3].Text;
                addressToEdit.District = lstAddresses.Items[selectedAddressIndex].SubItems[4].Text;
                addressToEdit.City = lstAddresses.Items[selectedAddressIndex].SubItems[5].Text;
                addressToEdit.Client = new ClientBus().FindClientById(Convert.ToInt32(txtClientId.Text));
                addressToEdit.Id = Convert.ToInt32(lstAddresses.Items[selectedAddressIndex].SubItems[6].Text);

                FillAddressFields(addressToEdit);

                lstAddresses.Items[selectedAddressIndex].Remove();
            }
        }

        private void BtnClientSearch_Click(object sender, EventArgs e)
        {
            FrmGenericQuerriesClient frmSearchClient = new FrmGenericQuerriesClient(Status.Todos);
            frmSearchClient.grbStatus.Enabled = true;
            frmSearchClient.ShowDialog();

            int returnControl = frmSearchClient.returnControl;

            if (returnControl < 1) { return; }

            txtClientId.Text = returnControl.ToString();
            lstAddresses.Items.Clear();
            TxtClientId_Validating(txtClientId, new CancelEventArgs());

            btnClientSearch.Focus();

        }

        private void TxtClientId_Validating(object sender, CancelEventArgs e)
        {
            if (txtClientId.Text.Trim() == string.Empty) { return; }

            Client clientToFind = new ClientBus().FindClientFullEntity(Convert.ToInt32(txtClientId.Text.Trim()));

            if (clientToFind.Name == null || clientToFind.Id == 0)
            {
                if (EditControlCode > 0)
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
            NewRegister = false;

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
            btnClientSearch.Focus();
            btnDelete.Enabled = true;
        }

        private void btnCEPSeek_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCEPSeek.Text))
            {
                using (var correios = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var seekResult = correios.consultaCEP(txtCEPSeek.Text.Trim());
                        txtAddress.Text = seekResult.end;
                        txtCity.Text = seekResult.cidade;
                        txtDistrict.Text = seekResult.bairro;
                        txtAddress2nd.Text = seekResult.complemento2;
                        txtAddress2nd.Text += " " + txtCEPSeek.Text.Trim();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "WebServiceCorreios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor informar CEP", "WebServiceCorreios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            lstAddresses.MultiSelect = false;
            lstAddresses.CheckBoxes = true;
            lstAddresses.View = View.Details;
            lstAddresses.Columns.Add("Delivery", 50, HorizontalAlignment.Right);
            lstAddresses.Columns.Add("Rua", 180, HorizontalAlignment.Left);
            lstAddresses.Columns.Add("Número", 80, HorizontalAlignment.Right);
            lstAddresses.Columns.Add("Complemento", 160, HorizontalAlignment.Left);
            lstAddresses.Columns.Add("Bairro", 80, HorizontalAlignment.Left);
            lstAddresses.Columns.Add("Cidade", 180, HorizontalAlignment.Left);
            lstAddresses.Columns.Add("Id", 10);

        }

        private void ClearForm()
        {
            ClearAddressFields();
            txtClientId.Text = new ClientBus().FindNextCode().ToString();
            txtClientName.Text = string.Empty;
            mTxtPhone.Text = string.Empty;
            mTxtCellPhone.Text = string.Empty;
            lstAddresses.Items.Clear();
            btnDelete.Enabled = false;
            IdFieldMasks.MakeMask(txtClientId, new EventArgs());
            NewRegister = true;
            uscStatus.StartStatus(Status.Ativo);
            Functions.SetSelectedFocus(txtClientName);
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

        private void FillAddressList(Address address)
        {
            string[] addressLine = new string[7];

            addressLine[0] = string.Empty;
            addressLine[1] = address.Adrress;
            addressLine[2] = address.Number.ToString();
            addressLine[3] = address.Address2nd;
            addressLine[4] = address.District;
            addressLine[5] = address.City;
            addressLine[6] = address.Id.ToString();

            ListViewItem lineItem = new ListViewItem(addressLine);
            if (address.DeliveryAddress)
            {
                lineItem.Checked = true;
            }

            lstAddresses.Items.Add(lineItem);
        }

        private void FillAddressFields(Address address)
        {
            txtAddress.Text = address.Adrress;
            txtAddress2nd.Text = address.Address2nd;
            txtCity.Text = address.City;
            txtDistrict.Text = address.District;
            txtStNumber.Text = address.Number;
            chkStdAddress.Checked = address.DeliveryAddress;
            lblAddressId.Text = address.Id.ToString();

        }

        private bool CheckUniqueDlvryAddress()
        {
            foreach (ListViewItem item in lstAddresses.Items)
            {
                if (item.Checked) { return true; }
            }
            return false;
        }

        private bool ValidadeAddressFields()
        {
            if (txtAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Endereço é obrigatório!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (txtStNumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Número é obrigatório!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (txtDistrict.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bairro é obrigatório!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (txtCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Cidade é obrigatória!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidadeClientFields()
        {
            if (txtClientName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome do cliente é obrigatório!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if ((mTxtPhone.Text.Trim() == string.Empty) && (mTxtCellPhone.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Pelo menos um número de telefone é obrigatório!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (lstAddresses.Items.Count < 1)
            {
                MessageBox.Show("Pelo menos um endereço é obrigatório!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            int countChk = 0;
            foreach (ListViewItem item in lstAddresses.Items)
            {
                if (item.Checked)
                {
                    countChk++;
                }
            }
            if (countChk == 0)
            {
                MessageBox.Show("Deve haver um e apenas um endereço padrão informado!",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return false;
            }
            if (countChk > 1)
            {
                MessageBox.Show("Existe mais de um endereço padrão apenas 1 é permitido!",
                     this.Text,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private List<Address> CreateAddressList()
        {
            List<Address> addresses = new List<Address>();
            Client cli = new Client();
            foreach (ListViewItem item in lstAddresses.Items)
            {
                Address addressToAdd = new Address();
                addressToAdd.Id = 0;
                if (!NewRegister)
                {
                    cli = new ClientBus()
                       .FindClientFullEntity(Convert.ToInt32(txtClientId.Text.Trim()));
                    addressToAdd.Id = Convert.ToInt32(item.SubItems[6].Text);
                }

                addressToAdd.Client = cli;
                addressToAdd.DeliveryAddress = item.Checked;
                addressToAdd.Adrress = item.SubItems[1].Text;
                addressToAdd.Number = item.SubItems[2].Text;
                addressToAdd.Address2nd = item.SubItems[3].Text;
                addressToAdd.District = item.SubItems[4].Text;
                addressToAdd.City = item.SubItems[5].Text;
                addresses.Add(addressToAdd);
            }

            return addresses;
        }
        #endregion

        #region --== Events ==--
        private void LstAddresses_MouseDown(object sender, MouseEventArgs e)
        {
            PermitCheck = true;
        }

        private void LstAddresses_MouseUp(object sender, MouseEventArgs e)
        {
            PermitCheck = false;
        }

        private void LstAddresses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (PermitCheck)
            {
                e.NewValue = e.CurrentValue;
                return;
            }

            if (CheckUniqueDlvryAddress() && e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("Deve existir apenas um endereço padrão!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        #endregion

       
    }
}
