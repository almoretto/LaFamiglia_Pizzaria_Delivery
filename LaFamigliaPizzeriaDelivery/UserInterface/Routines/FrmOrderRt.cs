using BusinessRules.People;
using BusinessRules.Products;
using Entities.Enums;
using Entities.Order;
using Entities.People;
using Entities.Products;
using Entities.System;
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
        private Address DeliveryAddress { get; set; }

        private PizzaSize PizzaSize { get; set; } = null;
        private PizzaEdgeFilling PizzaEdge { get; set; } = null;
        private List<PizzaFlavor> PizzaFlavors { get; set; } //selectedFlavors
        private List<Additional> ListAdditionals { get; set; } = new List<Additional>();

        public PizzaOrder PizzaOrder { get; private set; } //order finish
        public List<OrderItem> OrderItems { get; private set; } //order finish
        public List<OrderPizzaFlavors> OrderPizzaFlavors { get; private set; } //order finish
        public List<OrderAdditional> OrderAdditionals { get; private set; } //order finish

        private double pizzaSub = 0.0d;
        private double adtcSub = 0.0d;
        private double total = 0.0d;
        private double deliveryPrice = 0.0d;
        private double pizzaItemTotal = 0.0d;

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
            btnTotalize.Text = string.Empty;
            PrepareGrid();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnClientEdit_Click(object sender, EventArgs e)
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

        private void BtnChangeDeliveryAddress_Click(object sender, EventArgs e)
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

            Address selectedAddress = _addBus.FindAddressById(formReturn);
            if (selectedAddress.Adrress == string.Empty || selectedAddress == null)
            { return; }

            DeliveryAddress = selectedAddress;
            FillAddressFields();
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            FrmClientCRUD formClient = new FrmClientCRUD();
            formClient.WindowState = FormWindowState.Normal;
            formClient.StartPosition = FormStartPosition.CenterParent;
            formClient.ShowDialog();

        }

        //add and delete additional on order
        private void BtnAddtionalDelete_Click(object sender, EventArgs e)
        {
            if (lvwPizzaAdditionals.SelectedIndices.Count < 1)
            { return; }

            int additionalToRemove = Convert.ToInt32(lvwPizzaAdditionals.SelectedIndices[0]);

            if (additionalToRemove >= 0)
            { lvwPizzaAdditionals.Items[additionalToRemove].Remove(); }

            BtnSubTotal_Click(btnSubTotal, new EventArgs());
            BtnTotalize_Click(btnTotalize, new EventArgs());

        }

        private void BtnAdditionalAdd_Click(object sender, EventArgs e)
        {
            AdditionalBus adtcBus = new AdditionalBus();
            List<EntityViewProducts> listAdditional = adtcBus.GetEntityViewProducts(Status.Ativo);

            if (listAdditional.Count < 1)
            {
                MessageBox.Show("Nenhum adicional encontrado",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            FrmGenericQueriesProducts formProdAdditional = new FrmGenericQueriesProducts("Lista de Adicionais", Status.Ativo);
            formProdAdditional.grbStatus.Enabled = false;
            formProdAdditional.queryList = listAdditional;
            formProdAdditional.ShowDialog();
            int returnControl = formProdAdditional.returnControl;

            if (returnControl < 1)
            { return; }

            FillAdditionalGrid(returnControl);

            BtnSubTotal_Click(btnSubTotal, new EventArgs());
            BtnTotalize_Click(btnTotalize, new EventArgs());

        }

        //Add and delete Pizza configurations to 

        private void BtnPizzaItemAdd_Click(object sender, EventArgs e)
        {
            FrmPizzaAddRt addPizza = new FrmPizzaAddRt();
            addPizza.ShowDialog();

            if (addPizza.SelectedSize.Id == 0)
            {
                MessageBox.Show("Necessário selecionar pelo menos uma pizza!\n Tente Novamente",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                PizzaSize = new PizzaSize();
                PizzaEdge = new PizzaEdgeFilling();
                PizzaFlavors = new List<PizzaFlavor>();
                PizzaFlavors.Clear();

                PizzaSize = addPizza.SelectedSize;

                if (addPizza.SelectedEdge.Id > 0)
                { PizzaEdge = addPizza.SelectedEdge; }

                PizzaFlavors = addPizza.PizzaFlavorsSelected;
                pizzaItemTotal = addPizza.Total;
            }
            FillPizzaGrid();

        }

        private void BtnPizzaItemDelete_Click(object sender, EventArgs e)
        {
            if (lvwPizzaOrder.SelectedIndices.Count < 1)
            { return; }

            int pizzaToRemove = Convert.ToInt32(lvwPizzaOrder.SelectedIndices[0]);

            if (pizzaToRemove >= 0)
            { lvwPizzaOrder.Items[pizzaToRemove].Remove(); }

            BtnSubTotal_Click(btnSubTotal, new EventArgs());
            BtnTotalize_Click(btnTotalize, new EventArgs());
        }

        //Subtotals buttons
        private void BtnTotalize_Click(object sender, EventArgs e)
        {
            BtnSubTotal_Click(btnSubTotal, new EventArgs());
            Totalize();
            lblOrderTotalPrice.Text = total.ToString("C2");
        }

        private void BtnSubTotal_Click(object sender, EventArgs e)
        {
            SubTotal();
            lblSubAdditional.Text = adtcSub.ToString("C2");
            lblSubPizza.Text = pizzaSub.ToString("C2");
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {

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

                GetDeliveryAddress();
                FillAddressFields();

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

            GetDeliveryAddress();
            FillAddressFields();

            grpOrder.Enabled = true;
            grpDeliveryData.Enabled = true;

        }

        private void ChkPhoneDelivery_CheckedChanged(object sender, EventArgs e)
        {
            txtDeliveryPrice.Text = string.Empty;
            lblDeliveryPrice.Enabled = chkPhoneDelivery.Checked;
            txtDeliveryPrice.Enabled = chkPhoneDelivery.Checked;
            MonetaryMask.MakeMask(txtDeliveryPrice, new EventArgs());
        }

        private void TxtDeliveryPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!chkPhoneDelivery.Checked)
            { return; }


            deliveryPrice = Convert.ToDouble(txtDeliveryPrice.Text.Replace("R$", "").Trim());
            txtDeliveryPrice.Text = deliveryPrice.ToString("C2");

            if (deliveryPrice < 0.0)
            {
                MessageBox.Show("Valor de entrega não pode ser negativo!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Totalize();
        }


        #endregion


        #region --== Auxiliary Methods ==--

        private void GetDeliveryAddress()
        {
            DeliveryAddress = (from addr
                                    in ClientInOrder.Addresses
                               where addr.DeliveryAddress = true
                               select addr).FirstOrDefault();

            if (DeliveryAddress == null)
            { return; }
        }

        private void FillAddressFields()
        {

            lblDeliveryAddressId.Text = DeliveryAddress.Id.ToString();
            lblClientStreet.Text = DeliveryAddress.Adrress;
            lblStreetNumber.Text = DeliveryAddress.Number;
            lblStreetAdd2.Text = DeliveryAddress.Address2nd;
            lblDistrict.Text = DeliveryAddress.District;
            lblCity.Text = DeliveryAddress.City;
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

            lvwPizzaOrder.Items.Clear();
            lvwPizzaAdditionals.Items.Clear();

            lblSubAdditional.Text = "R$ 0,00";
            lblSubPizza.Text = "R$ 0,00";
            lblOrderTotalPrice.Text = "R$ 0,00";
            btnTotalize.Text = string.Empty;

            IdFieldMasks.MakeMask(txtClientId, new EventArgs());
            MonetaryMask.MakeMask(txtDeliveryPrice, new EventArgs());
            chkPhoneDelivery.Checked = false;
            ChkPhoneDelivery_CheckedChanged(chkPhoneDelivery, new EventArgs());
            mtxtContact.Focus();
            mtxtContact.Select(0, 0);

        }

        private void PrepareGrid()
        {
            //PizzaGrid
            lvwPizzaOrder.MultiSelect = false;
            lvwPizzaOrder.Clear();
            lvwPizzaOrder.View = View.Details;
            lvwPizzaOrder.Columns.Add("PizzaSizeId", 0, HorizontalAlignment.Right);
            lvwPizzaOrder.Columns.Add("PizzaFlavorId", 0, HorizontalAlignment.Right);
            lvwPizzaOrder.Columns.Add("PizzaEdgeId", 0, HorizontalAlignment.Right);
            lvwPizzaOrder.Columns.Add("Descrição do Item", 980, HorizontalAlignment.Left);
            lvwPizzaOrder.Columns.Add("Valor", 100, HorizontalAlignment.Right);


            //AdditionalGrid
            lvwPizzaAdditionals.MultiSelect = false;
            lvwPizzaAdditionals.Clear();
            lvwPizzaAdditionals.View = View.Details;
            lvwPizzaAdditionals.Columns.Add("PizzaAdditionalId", 0, HorizontalAlignment.Right);
            lvwPizzaAdditionals.Columns.Add("Descrição do Item", 980, HorizontalAlignment.Left);
            lvwPizzaAdditionals.Columns.Add("Valor", 100, HorizontalAlignment.Right);



        }

        private void FillPizzaGrid()
        {

            if (PizzaSize.Description == string.Empty || PizzaSize.Id == 0 || PizzaSize == null)
            {
                MessageBox.Show("Nenhuma Pizza adicionada",
                   this.Text,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            else if (PizzaFlavors.Count <= 0)
            {
                MessageBox.Show("Nenhum Sabor de Pizza adicionado",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }

            string[] line = new string[3];
            line[0] = PizzaSize.Id.ToString();
            line[3] = PizzaSize.Description;

            foreach (PizzaFlavor item in PizzaFlavors)
            {
                line[1] = item.Id.ToString();
                if (PizzaFlavors.Count > 1)
                {
                    line[1] += ";";
                    line[3] += " Sabores: ";
                }
                else
                {
                    line[3] += " Sabor: ";
                }
                line[3] += item.Description;
            }


            if (PizzaEdge.Description != string.Empty || PizzaEdge.Id != 0 || PizzaEdge != null)
            {
                line[2] = PizzaEdge.Id.ToString();
                line[3] += " Com Borda de: " + PizzaEdge.Description;
            }

            line[4] = pizzaItemTotal.ToString("C2");

            ListViewItem itemList = new ListViewItem(line);
            lvwPizzaOrder.Items.Add(itemList);
            Functions.ListViewColor(lvwPizzaOrder);
        }

        private void FillAdditionalGrid(int id)
        {
            AdditionalBus adtcBus = new AdditionalBus();
            Additional additionalToInsert;
            additionalToInsert = adtcBus.FindById(id);

            if (additionalToInsert.Description == string.Empty || additionalToInsert.Id == 0 || additionalToInsert == null)
            {
                MessageBox.Show("Nenhum adicional encontrado",
                   this.Text,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            string[] line = new string[4];
            line[0] = additionalToInsert.Id.ToString();
            line[1] = additionalToInsert.Description;
            line[2] = additionalToInsert.Price.ToString("C2");

            ListViewItem itemList = new ListViewItem(line);
            lvwPizzaAdditionals.Items.Add(itemList);
            Functions.ListViewColor(lvwPizzaAdditionals);


        }

        private void SubTotal()
        {
            pizzaSub = 0.0;
            adtcSub = 0.0;
            ListAdditionals.Clear();

            int items = 0;
            foreach (ListViewItem item in lvwPizzaOrder.Items)
            {
                pizzaSub += (Convert.ToDouble(item.SubItems[4].Text.Replace("R$", "").Trim()));
                items++;
            }

            foreach (ListViewItem item in lvwPizzaAdditionals.Items)
            {
                adtcSub += (Convert.ToDouble(item.SubItems[2].Text.Replace("R$", "").Trim()));
                items++;
                ListAdditionals.Add(new AdditionalBus().FindById(Convert.ToInt32(item.SubItems[0].Text.Trim())));
            }
            btnTotalize.Text = items.ToString();
        }

        private void Totalize()
        {
            total = 0.0;
            total = pizzaSub + adtcSub;
            if (chkPhoneDelivery.Checked)
            {
                deliveryPrice = Convert.ToDouble(txtDeliveryPrice.Text.Replace("R$", "").Trim());
                total += deliveryPrice;
                txtDeliveryPrice.Text = deliveryPrice.ToString("C2");
            }

        }

        private void CreateEntityOrder()
        {
            #region --==Order logic==--
            User sessionUser = new UserBus().FindById(Session.User.Id);
            PizzaOrder = new PizzaOrder(
                ClientInOrder,
                Status.Ativo,
                false,
                DateTime.Now,
                sessionUser,
                DateTime.Now,
                sessionUser);
            SubTotal();
            Totalize();

            if (!PizzaOrder.SetOrderTotal(pizzaSub))
            {
                MessageBox.Show("Não foi possivel definir o valor do pedido!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (!PizzaOrder.SetDelivery(deliveryPrice))
            {
                MessageBox.Show("Não foi possivel definir o valor de entrega!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (!PizzaOrder.SetTotal())
            {
                MessageBox.Show("Não foi possivel definir o Total!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }



            #region --==Order Additional==--

            OrderAdditionals = new List<OrderAdditional>();
            OrderAdditional oAdditional = null;
            var groupQty = ListAdditionals.GroupBy(x => x.Id);
            int qty = 0;
            int keySet = 0;
            foreach (IGrouping<int, Additional> group in groupQty)
            {
                keySet = group.Key;
                foreach (Additional item in group)
                {
                    qty++;
                    oAdditional = new OrderAdditional(PizzaOrder, item, qty, item.Price * qty);
                }
                OrderAdditionals.Add(oAdditional);
            }

            #endregion

            #region --==Order Items and Flavors ==--

            OrderItem oItem;
            OrderPizzaFlavors oPizzaFlavor = new OrderPizzaFlavors();
            List<PizzaFlavor> flavorList = new List<PizzaFlavor>();

            foreach (ListViewItem item in lvwPizzaOrder.Items)
            {
                PizzaSize = new PizzaSizeBus().FindById(Convert.ToInt32(item.SubItems[0].Text.Trim()));
                string[] ids = item.SubItems[1].Text.Trim().Split(';');
                for (int i = 0; i < ids.Count(); i++)
                {
                    PizzaFlavor flavor = new PizzaFlavorBus().FindById(Convert.ToInt32(ids[i]));
                    flavorList.Add(flavor);
                }
                if (item.SubItems[2].Text.Trim() != String.Empty
                    || item.SubItems[2].Text.Trim() != "0"
                    || item.SubItems[2].Text.Trim() != "")
                {
                    PizzaEdge = new PizzaEdgeBus().FindById(Convert.ToInt32(item.SubItems[2].Text.Trim()));
                }
                else
                {
                    PizzaEdge = new PizzaEdgeBus().FindById(1);
                }
                oItem = new OrderItem(PizzaOrder, PizzaSize, Convert.ToDouble(item.SubItems[4].Text.Trim().Replace("R$", "")));
                OrderPizzaFlavors itemPizzaFlavors = new OrderPizzaFlavors(oItem, flavorList);
                if (PizzaEdge != null || PizzaEdge.Description != "")
                {
                    if (!oItem.SetEdge(PizzaEdge))
                    {
                        MessageBox.Show("Não foi possivel inserir a borda!",
                                this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        return;
                    };
                }
                OrderItems.Add(oItem);
                OrderPizzaFlavors.Add(itemPizzaFlavors);
            }

            #endregion
            #endregion
        }

        #endregion

        
    }
}
