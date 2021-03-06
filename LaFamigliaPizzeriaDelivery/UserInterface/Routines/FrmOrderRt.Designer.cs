
namespace UserInterface.Routines
{
    partial class FrmOrderRt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderRt));
            this.tbcOrders = new System.Windows.Forms.TabControl();
            this.tbpInOrder = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderTotalPrice = new System.Windows.Forms.Label();
            this.lblsOrderTotalPrice = new System.Windows.Forms.Label();
            this.grpDeliveryData = new System.Windows.Forms.GroupBox();
            this.lblDeliveryPrice = new System.Windows.Forms.Label();
            this.txtDeliveryPrice = new System.Windows.Forms.TextBox();
            this.chkPhoneDelivery = new System.Windows.Forms.CheckBox();
            this.flwAddtitionalCRUD = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.grpAdditionalOrder = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grpPizzaOrder = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvwPizzaOrder = new System.Windows.Forms.ListView();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.grpClientAddress = new System.Windows.Forms.GroupBox();
            this.lblDeliveryAddressId = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnChangeDeliveryAddress = new System.Windows.Forms.Button();
            this.lblChangeDeliveryAddress = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblStreetAdd2 = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.lblClientStreet = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.lblAddClient = new System.Windows.Forms.Label();
            this.btnClientEdit = new System.Windows.Forms.Button();
            this.lblClientId = new System.Windows.Forms.Label();
            this.mtxtContact = new System.Windows.Forms.MaskedTextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.tbpProdOrder = new System.Windows.Forms.TabPage();
            this.tbcOrders.SuspendLayout();
            this.tbpInOrder.SuspendLayout();
            this.grpDeliveryData.SuspendLayout();
            this.flwAddtitionalCRUD.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.grpAdditionalOrder.SuspendLayout();
            this.grpPizzaOrder.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.grpClientAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcOrders
            // 
            this.tbcOrders.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcOrders.Controls.Add(this.tbpInOrder);
            this.tbcOrders.Controls.Add(this.tbpProdOrder);
            this.tbcOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcOrders.Location = new System.Drawing.Point(0, 0);
            this.tbcOrders.Name = "tbcOrders";
            this.tbcOrders.SelectedIndex = 0;
            this.tbcOrders.Size = new System.Drawing.Size(1182, 641);
            this.tbcOrders.TabIndex = 0;
            // 
            // tbpInOrder
            // 
            this.tbpInOrder.BackColor = System.Drawing.Color.White;
            this.tbpInOrder.Controls.Add(this.label3);
            this.tbpInOrder.Controls.Add(this.label4);
            this.tbpInOrder.Controls.Add(this.label1);
            this.tbpInOrder.Controls.Add(this.label2);
            this.tbpInOrder.Controls.Add(this.lblOrderTotalPrice);
            this.tbpInOrder.Controls.Add(this.lblsOrderTotalPrice);
            this.tbpInOrder.Controls.Add(this.grpDeliveryData);
            this.tbpInOrder.Controls.Add(this.flwAddtitionalCRUD);
            this.tbpInOrder.Controls.Add(this.grpOrder);
            this.tbpInOrder.Controls.Add(this.grpClient);
            this.tbpInOrder.Location = new System.Drawing.Point(4, 32);
            this.tbpInOrder.Name = "tbpInOrder";
            this.tbpInOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInOrder.Size = new System.Drawing.Size(1174, 605);
            this.tbpInOrder.TabIndex = 0;
            this.tbpInOrder.Text = "Entrada de Pedido";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Beige;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "R$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Valor Adicionais:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "R$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Valor Pizzas:";
            // 
            // lblOrderTotalPrice
            // 
            this.lblOrderTotalPrice.BackColor = System.Drawing.Color.Olive;
            this.lblOrderTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrderTotalPrice.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblOrderTotalPrice.Location = new System.Drawing.Point(592, 574);
            this.lblOrderTotalPrice.Name = "lblOrderTotalPrice";
            this.lblOrderTotalPrice.Size = new System.Drawing.Size(208, 24);
            this.lblOrderTotalPrice.TabIndex = 29;
            this.lblOrderTotalPrice.Text = "R$";
            this.lblOrderTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsOrderTotalPrice
            // 
            this.lblsOrderTotalPrice.AutoSize = true;
            this.lblsOrderTotalPrice.Location = new System.Drawing.Point(414, 576);
            this.lblsOrderTotalPrice.Name = "lblsOrderTotalPrice";
            this.lblsOrderTotalPrice.Size = new System.Drawing.Size(172, 20);
            this.lblsOrderTotalPrice.TabIndex = 28;
            this.lblsOrderTotalPrice.Text = "Valor Total Pedido:";
            // 
            // grpDeliveryData
            // 
            this.grpDeliveryData.Controls.Add(this.lblDeliveryPrice);
            this.grpDeliveryData.Controls.Add(this.txtDeliveryPrice);
            this.grpDeliveryData.Controls.Add(this.chkPhoneDelivery);
            this.grpDeliveryData.Location = new System.Drawing.Point(9, 496);
            this.grpDeliveryData.Name = "grpDeliveryData";
            this.grpDeliveryData.Size = new System.Drawing.Size(373, 100);
            this.grpDeliveryData.TabIndex = 7;
            this.grpDeliveryData.TabStop = false;
            this.grpDeliveryData.Text = "Dados de Entrega";
            // 
            // lblDeliveryPrice
            // 
            this.lblDeliveryPrice.AutoSize = true;
            this.lblDeliveryPrice.Location = new System.Drawing.Point(33, 65);
            this.lblDeliveryPrice.Name = "lblDeliveryPrice";
            this.lblDeliveryPrice.Size = new System.Drawing.Size(130, 20);
            this.lblDeliveryPrice.TabIndex = 12;
            this.lblDeliveryPrice.Text = "Valor Entrega:";
            // 
            // txtDeliveryPrice
            // 
            this.txtDeliveryPrice.BackColor = System.Drawing.Color.Olive;
            this.txtDeliveryPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeliveryPrice.ForeColor = System.Drawing.Color.White;
            this.txtDeliveryPrice.Location = new System.Drawing.Point(169, 63);
            this.txtDeliveryPrice.Name = "txtDeliveryPrice";
            this.txtDeliveryPrice.Size = new System.Drawing.Size(166, 28);
            this.txtDeliveryPrice.TabIndex = 11;
            this.txtDeliveryPrice.Text = "R$";
            // 
            // chkPhoneDelivery
            // 
            this.chkPhoneDelivery.AutoSize = true;
            this.chkPhoneDelivery.Location = new System.Drawing.Point(37, 28);
            this.chkPhoneDelivery.Name = "chkPhoneDelivery";
            this.chkPhoneDelivery.Size = new System.Drawing.Size(212, 24);
            this.chkPhoneDelivery.TabIndex = 0;
            this.chkPhoneDelivery.Text = "Pedido por Telefone?";
            this.chkPhoneDelivery.UseVisualStyleBackColor = true;
            // 
            // flwAddtitionalCRUD
            // 
            this.flwAddtitionalCRUD.Controls.Add(this.btnCancel);
            this.flwAddtitionalCRUD.Controls.Add(this.btnSave);
            this.flwAddtitionalCRUD.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flwAddtitionalCRUD.Location = new System.Drawing.Point(841, 546);
            this.flwAddtitionalCRUD.Name = "flwAddtitionalCRUD";
            this.flwAddtitionalCRUD.Size = new System.Drawing.Size(325, 52);
            this.flwAddtitionalCRUD.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(206, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(84, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Enviar Pedido";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.grpAdditionalOrder);
            this.grpOrder.Controls.Add(this.grpPizzaOrder);
            this.grpOrder.Location = new System.Drawing.Point(8, 170);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(1158, 320);
            this.grpOrder.TabIndex = 1;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Composição do Pedido";
            // 
            // grpAdditionalOrder
            // 
            this.grpAdditionalOrder.Controls.Add(this.button3);
            this.grpAdditionalOrder.Controls.Add(this.button4);
            this.grpAdditionalOrder.Controls.Add(this.listView1);
            this.grpAdditionalOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpAdditionalOrder.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdditionalOrder.Location = new System.Drawing.Point(3, 164);
            this.grpAdditionalOrder.Name = "grpAdditionalOrder";
            this.grpAdditionalOrder.Size = new System.Drawing.Size(1152, 153);
            this.grpAdditionalOrder.TabIndex = 1;
            this.grpAdditionalOrder.TabStop = false;
            this.grpAdditionalOrder.Text = "Seleção de Adicionais";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::UserInterface.Properties.Resources.RedTrash;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(1120, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::UserInterface.Properties.Resources.Addnew1;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(1120, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 26);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1108, 124);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // grpPizzaOrder
            // 
            this.grpPizzaOrder.Controls.Add(this.button2);
            this.grpPizzaOrder.Controls.Add(this.button1);
            this.grpPizzaOrder.Controls.Add(this.lvwPizzaOrder);
            this.grpPizzaOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPizzaOrder.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPizzaOrder.Location = new System.Drawing.Point(3, 24);
            this.grpPizzaOrder.Name = "grpPizzaOrder";
            this.grpPizzaOrder.Size = new System.Drawing.Size(1152, 134);
            this.grpPizzaOrder.TabIndex = 0;
            this.grpPizzaOrder.TabStop = false;
            this.grpPizzaOrder.Text = "Seleção de Pizzas";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::UserInterface.Properties.Resources.RedTrash;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(1120, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::UserInterface.Properties.Resources.Addnew1;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1120, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lvwPizzaOrder
            // 
            this.lvwPizzaOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvwPizzaOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwPizzaOrder.CheckBoxes = true;
            this.lvwPizzaOrder.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPizzaOrder.FullRowSelect = true;
            this.lvwPizzaOrder.GridLines = true;
            this.lvwPizzaOrder.HideSelection = false;
            this.lvwPizzaOrder.Location = new System.Drawing.Point(6, 22);
            this.lvwPizzaOrder.Name = "lvwPizzaOrder";
            this.lvwPizzaOrder.Size = new System.Drawing.Size(1108, 106);
            this.lvwPizzaOrder.TabIndex = 0;
            this.lvwPizzaOrder.UseCompatibleStateImageBehavior = false;
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.grpClientAddress);
            this.grpClient.Controls.Add(this.lblClientName);
            this.grpClient.Controls.Add(this.btnAddClient);
            this.grpClient.Controls.Add(this.lblAddClient);
            this.grpClient.Controls.Add(this.btnClientEdit);
            this.grpClient.Controls.Add(this.lblClientId);
            this.grpClient.Controls.Add(this.mtxtContact);
            this.grpClient.Controls.Add(this.lblContact);
            this.grpClient.Controls.Add(this.btnClientSearch);
            this.grpClient.Controls.Add(this.txtClientId);
            this.grpClient.Location = new System.Drawing.Point(8, 6);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(1158, 158);
            this.grpClient.TabIndex = 0;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Cliente";
            // 
            // grpClientAddress
            // 
            this.grpClientAddress.Controls.Add(this.lblDeliveryAddressId);
            this.grpClientAddress.Controls.Add(this.lblCity);
            this.grpClientAddress.Controls.Add(this.btnChangeDeliveryAddress);
            this.grpClientAddress.Controls.Add(this.lblChangeDeliveryAddress);
            this.grpClientAddress.Controls.Add(this.lblDistrict);
            this.grpClientAddress.Controls.Add(this.lblStreetAdd2);
            this.grpClientAddress.Controls.Add(this.lblStreetNumber);
            this.grpClientAddress.Controls.Add(this.lblClientStreet);
            this.grpClientAddress.Location = new System.Drawing.Point(515, 17);
            this.grpClientAddress.Name = "grpClientAddress";
            this.grpClientAddress.Size = new System.Drawing.Size(637, 128);
            this.grpClientAddress.TabIndex = 19;
            this.grpClientAddress.TabStop = false;
            this.grpClientAddress.Text = "Endereço";
            // 
            // lblDeliveryAddressId
            // 
            this.lblDeliveryAddressId.AutoSize = true;
            this.lblDeliveryAddressId.Location = new System.Drawing.Point(270, 100);
            this.lblDeliveryAddressId.Name = "lblDeliveryAddressId";
            this.lblDeliveryAddressId.Size = new System.Drawing.Size(0, 20);
            this.lblDeliveryAddressId.TabIndex = 26;
            this.lblDeliveryAddressId.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCity.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(372, 62);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(259, 24);
            this.lblCity.TabIndex = 25;
            this.lblCity.Text = "Cidade";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeDeliveryAddress
            // 
            this.btnChangeDeliveryAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDeliveryAddress.Image = global::UserInterface.Properties.Resources.ChangeAddres2_resize;
            this.btnChangeDeliveryAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChangeDeliveryAddress.Location = new System.Drawing.Point(6, 95);
            this.btnChangeDeliveryAddress.Name = "btnChangeDeliveryAddress";
            this.btnChangeDeliveryAddress.Size = new System.Drawing.Size(26, 26);
            this.btnChangeDeliveryAddress.TabIndex = 24;
            this.btnChangeDeliveryAddress.UseVisualStyleBackColor = true;
            // 
            // lblChangeDeliveryAddress
            // 
            this.lblChangeDeliveryAddress.AutoSize = true;
            this.lblChangeDeliveryAddress.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeDeliveryAddress.Location = new System.Drawing.Point(38, 98);
            this.lblChangeDeliveryAddress.Name = "lblChangeDeliveryAddress";
            this.lblChangeDeliveryAddress.Size = new System.Drawing.Size(220, 20);
            this.lblChangeDeliveryAddress.TabIndex = 23;
            this.lblChangeDeliveryAddress.Text = "Alterar endereço de entrega";
            // 
            // lblDistrict
            // 
            this.lblDistrict.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDistrict.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(202, 64);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(164, 24);
            this.lblDistrict.TabIndex = 22;
            this.lblDistrict.Text = "Bairro";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStreetAdd2
            // 
            this.lblStreetAdd2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblStreetAdd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStreetAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStreetAdd2.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAdd2.Location = new System.Drawing.Point(6, 64);
            this.lblStreetAdd2.Name = "lblStreetAdd2";
            this.lblStreetAdd2.Size = new System.Drawing.Size(190, 24);
            this.lblStreetAdd2.TabIndex = 21;
            this.lblStreetAdd2.Text = "Complemento";
            this.lblStreetAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblStreetNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStreetNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStreetNumber.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNumber.Location = new System.Drawing.Point(485, 28);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(146, 24);
            this.lblStreetNumber.TabIndex = 20;
            this.lblStreetNumber.Text = "Número";
            this.lblStreetNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClientStreet
            // 
            this.lblClientStreet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClientStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClientStreet.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientStreet.Location = new System.Drawing.Point(6, 28);
            this.lblClientStreet.Name = "lblClientStreet";
            this.lblClientStreet.Size = new System.Drawing.Size(473, 24);
            this.lblClientStreet.TabIndex = 19;
            this.lblClientStreet.Text = "Nome";
            this.lblClientStreet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClientName
            // 
            this.lblClientName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClientName.Font = new System.Drawing.Font("Futura Bk BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(11, 108);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(498, 37);
            this.lblClientName.TabIndex = 18;
            this.lblClientName.Text = "Nome";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddClient
            // 
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Image")));
            this.btnAddClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddClient.Location = new System.Drawing.Point(376, 57);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(26, 26);
            this.btnAddClient.TabIndex = 17;
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClient.Location = new System.Drawing.Point(306, 32);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(151, 20);
            this.lblAddClient.TabIndex = 16;
            this.lblAddClient.Text = "Busca/Editar/Novo";
            // 
            // btnClientEdit
            // 
            this.btnClientEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnClientEdit.Image")));
            this.btnClientEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientEdit.Location = new System.Drawing.Point(344, 57);
            this.btnClientEdit.Name = "btnClientEdit";
            this.btnClientEdit.Size = new System.Drawing.Size(26, 26);
            this.btnClientEdit.TabIndex = 15;
            this.btnClientEdit.UseVisualStyleBackColor = true;
            this.btnClientEdit.Click += new System.EventHandler(this.btnClientEdit_Click);
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientId.Location = new System.Drawing.Point(149, 32);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(151, 20);
            this.lblClientId.TabIndex = 14;
            this.lblClientId.Text = "Código do Cliente:";
            // 
            // mtxtContact
            // 
            this.mtxtContact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtxtContact.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtContact.Location = new System.Drawing.Point(11, 55);
            this.mtxtContact.Mask = "(00) 0 0000-0000";
            this.mtxtContact.Name = "mtxtContact";
            this.mtxtContact.Size = new System.Drawing.Size(136, 28);
            this.mtxtContact.TabIndex = 13;
            this.mtxtContact.Validating += new System.ComponentModel.CancelEventHandler(this.MtxtContact_Validating);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(7, 32);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(73, 20);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Contato:";
            // 
            // btnClientSearch
            // 
            this.btnClientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnClientSearch.Image")));
            this.btnClientSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientSearch.Location = new System.Drawing.Point(312, 57);
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.Size = new System.Drawing.Size(26, 26);
            this.btnClientSearch.TabIndex = 11;
            this.btnClientSearch.UseVisualStyleBackColor = true;
            this.btnClientSearch.Click += new System.EventHandler(this.BtnClientSearch_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientId.Location = new System.Drawing.Point(153, 55);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(136, 28);
            this.txtClientId.TabIndex = 10;
            this.txtClientId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClientId_Validating);
            // 
            // tbpProdOrder
            // 
            this.tbpProdOrder.BackColor = System.Drawing.Color.White;
            this.tbpProdOrder.Location = new System.Drawing.Point(4, 32);
            this.tbpProdOrder.Name = "tbpProdOrder";
            this.tbpProdOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProdOrder.Size = new System.Drawing.Size(1174, 605);
            this.tbpProdOrder.TabIndex = 1;
            this.tbpProdOrder.Text = "Produção de Pedidos";
            // 
            // FrmOrderRt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 641);
            this.Controls.Add(this.tbcOrders);
            this.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderRt";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOrderRt";
            this.Load += new System.EventHandler(this.FrmOrderRt_Load);
            this.tbcOrders.ResumeLayout(false);
            this.tbpInOrder.ResumeLayout(false);
            this.tbpInOrder.PerformLayout();
            this.grpDeliveryData.ResumeLayout(false);
            this.grpDeliveryData.PerformLayout();
            this.flwAddtitionalCRUD.ResumeLayout(false);
            this.grpOrder.ResumeLayout(false);
            this.grpAdditionalOrder.ResumeLayout(false);
            this.grpPizzaOrder.ResumeLayout(false);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.grpClientAddress.ResumeLayout(false);
            this.grpClientAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcOrders;
        private System.Windows.Forms.TabPage tbpInOrder;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.TabPage tbpProdOrder;
        private System.Windows.Forms.FlowLayoutPanel flwAddtitionalCRUD;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpClientAddress;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblStreetAdd2;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label lblClientStreet;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label lblAddClient;
        private System.Windows.Forms.Button btnClientEdit;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.MaskedTextBox mtxtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnChangeDeliveryAddress;
        private System.Windows.Forms.Label lblChangeDeliveryAddress;
        private System.Windows.Forms.GroupBox grpAdditionalOrder;
        private System.Windows.Forms.GroupBox grpPizzaOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvwPizzaOrder;
        private System.Windows.Forms.GroupBox grpDeliveryData;
        private System.Windows.Forms.CheckBox chkPhoneDelivery;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblDeliveryPrice;
        private System.Windows.Forms.TextBox txtDeliveryPrice;
        private System.Windows.Forms.Label lblOrderTotalPrice;
        private System.Windows.Forms.Label lblsOrderTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDeliveryAddressId;
    }
}