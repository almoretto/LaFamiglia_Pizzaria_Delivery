
namespace UserInterface.Routines
{
    partial class FrmPizzaAddRt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaAddRt));
            this.lblSizePrice = new System.Windows.Forms.Label();
            this.btnSizeSearch = new System.Windows.Forms.Button();
            this.txtSizeId = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSizeId = new System.Windows.Forms.Label();
            this.grbPizzaFlavor = new System.Windows.Forms.GroupBox();
            this.btnFlavorDelete = new System.Windows.Forms.Button();
            this.lblSlash = new System.Windows.Forms.Label();
            this.btnAddFlavors = new System.Windows.Forms.Button();
            this.lblFlavorTotalPrice = new System.Windows.Forms.Label();
            this.lblTitleTotalPrice = new System.Windows.Forms.Label();
            this.lblQtySelectedFlavors = new System.Windows.Forms.Label();
            this.lblQtyMaxFlavor = new System.Windows.Forms.Label();
            this.lvwSelectedFlavors = new System.Windows.Forms.ListView();
            this.lvwPizzaOrder = new System.Windows.Forms.ListView();
            this.grbEdge = new System.Windows.Forms.GroupBox();
            this.lblEdgePrice = new System.Windows.Forms.Label();
            this.btnEdgeSearch = new System.Windows.Forms.Button();
            this.txtEdgeId = new System.Windows.Forms.TextBox();
            this.lblEdgeName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEdge = new System.Windows.Forms.CheckBox();
            this.lblPizzaTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTotalize = new System.Windows.Forms.Button();
            this.flwAddtitionalCRUD = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbPizzaFlavor.SuspendLayout();
            this.grbEdge.SuspendLayout();
            this.flwAddtitionalCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSizePrice
            // 
            this.lblSizePrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSizePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSizePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSizePrice.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizePrice.Location = new System.Drawing.Point(534, 32);
            this.lblSizePrice.Name = "lblSizePrice";
            this.lblSizePrice.Size = new System.Drawing.Size(164, 28);
            this.lblSizePrice.TabIndex = 28;
            this.lblSizePrice.Text = "Valor";
            this.lblSizePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSizeSearch
            // 
            this.btnSizeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSizeSearch.Image")));
            this.btnSizeSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSizeSearch.Location = new System.Drawing.Point(155, 32);
            this.btnSizeSearch.Name = "btnSizeSearch";
            this.btnSizeSearch.Size = new System.Drawing.Size(29, 28);
            this.btnSizeSearch.TabIndex = 24;
            this.btnSizeSearch.UseVisualStyleBackColor = true;
            this.btnSizeSearch.Click += new System.EventHandler(this.BtnSizeSearch_Click);
            // 
            // txtSizeId
            // 
            this.txtSizeId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSizeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSizeId.Location = new System.Drawing.Point(13, 32);
            this.txtSizeId.Name = "txtSizeId";
            this.txtSizeId.Size = new System.Drawing.Size(136, 28);
            this.txtSizeId.TabIndex = 23;
            this.txtSizeId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSizeId_Validating);
            // 
            // lblSize
            // 
            this.lblSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSize.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(190, 32);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(338, 28);
            this.lblSize.TabIndex = 27;
            this.lblSize.Text = "Tamanho da PIzza";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSizeId
            // 
            this.lblSizeId.AutoSize = true;
            this.lblSizeId.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeId.Location = new System.Drawing.Point(9, 9);
            this.lblSizeId.Name = "lblSizeId";
            this.lblSizeId.Size = new System.Drawing.Size(147, 20);
            this.lblSizeId.TabIndex = 25;
            this.lblSizeId.Text = "Tamanho da PIzza";
            // 
            // grbPizzaFlavor
            // 
            this.grbPizzaFlavor.Controls.Add(this.btnFlavorDelete);
            this.grbPizzaFlavor.Controls.Add(this.lblSlash);
            this.grbPizzaFlavor.Controls.Add(this.btnAddFlavors);
            this.grbPizzaFlavor.Controls.Add(this.lblFlavorTotalPrice);
            this.grbPizzaFlavor.Controls.Add(this.lblTitleTotalPrice);
            this.grbPizzaFlavor.Controls.Add(this.lblQtySelectedFlavors);
            this.grbPizzaFlavor.Controls.Add(this.lblQtyMaxFlavor);
            this.grbPizzaFlavor.Controls.Add(this.lvwSelectedFlavors);
            this.grbPizzaFlavor.Controls.Add(this.lvwPizzaOrder);
            this.grbPizzaFlavor.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPizzaFlavor.Location = new System.Drawing.Point(20, 66);
            this.grbPizzaFlavor.Name = "grbPizzaFlavor";
            this.grbPizzaFlavor.Size = new System.Drawing.Size(950, 227);
            this.grbPizzaFlavor.TabIndex = 29;
            this.grbPizzaFlavor.TabStop = false;
            this.grbPizzaFlavor.Text = "Sabores da Pizza";
            // 
            // btnFlavorDelete
            // 
            this.btnFlavorDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlavorDelete.Image = global::UserInterface.Properties.Resources.RedTrash;
            this.btnFlavorDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFlavorDelete.Location = new System.Drawing.Point(916, 152);
            this.btnFlavorDelete.Name = "btnFlavorDelete";
            this.btnFlavorDelete.Size = new System.Drawing.Size(26, 26);
            this.btnFlavorDelete.TabIndex = 34;
            this.btnFlavorDelete.UseVisualStyleBackColor = true;
            this.btnFlavorDelete.Click += new System.EventHandler(this.BtnFlavorDelete_Click);
            // 
            // lblSlash
            // 
            this.lblSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSlash.Font = new System.Drawing.Font("Futura Bk BT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.Location = new System.Drawing.Point(477, 153);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(83, 30);
            this.lblSlash.TabIndex = 33;
            this.lblSlash.Text = "00/00";
            // 
            // btnAddFlavors
            // 
            this.btnAddFlavors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlavors.Image = global::UserInterface.Properties.Resources.pizzaSlice1;
            this.btnAddFlavors.Location = new System.Drawing.Point(0, 151);
            this.btnAddFlavors.Name = "btnAddFlavors";
            this.btnAddFlavors.Size = new System.Drawing.Size(62, 45);
            this.btnAddFlavors.TabIndex = 32;
            this.btnAddFlavors.Text = "1+";
            this.btnAddFlavors.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddFlavors.UseVisualStyleBackColor = true;
            this.btnAddFlavors.Click += new System.EventHandler(this.BtnAddFlavors_Click);
            // 
            // lblFlavorTotalPrice
            // 
            this.lblFlavorTotalPrice.BackColor = System.Drawing.Color.Beige;
            this.lblFlavorTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlavorTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFlavorTotalPrice.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlavorTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblFlavorTotalPrice.Location = new System.Drawing.Point(812, 200);
            this.lblFlavorTotalPrice.Name = "lblFlavorTotalPrice";
            this.lblFlavorTotalPrice.Size = new System.Drawing.Size(130, 24);
            this.lblFlavorTotalPrice.TabIndex = 31;
            this.lblFlavorTotalPrice.Text = "R$";
            this.lblFlavorTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleTotalPrice
            // 
            this.lblTitleTotalPrice.AutoSize = true;
            this.lblTitleTotalPrice.Location = new System.Drawing.Point(623, 202);
            this.lblTitleTotalPrice.Name = "lblTitleTotalPrice";
            this.lblTitleTotalPrice.Size = new System.Drawing.Size(183, 20);
            this.lblTitleTotalPrice.TabIndex = 30;
            this.lblTitleTotalPrice.Text = "Valor Total Sabores:";
            // 
            // lblQtySelectedFlavors
            // 
            this.lblQtySelectedFlavors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQtySelectedFlavors.Font = new System.Drawing.Font("Futura Bk BT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtySelectedFlavors.Location = new System.Drawing.Point(566, 152);
            this.lblQtySelectedFlavors.Name = "lblQtySelectedFlavors";
            this.lblQtySelectedFlavors.Size = new System.Drawing.Size(259, 30);
            this.lblQtySelectedFlavors.TabIndex = 28;
            this.lblQtySelectedFlavors.Text = "Sabores adicionados.";
            this.lblQtySelectedFlavors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtyMaxFlavor
            // 
            this.lblQtyMaxFlavor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQtyMaxFlavor.Font = new System.Drawing.Font("Futura Bk BT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyMaxFlavor.Location = new System.Drawing.Point(68, 148);
            this.lblQtyMaxFlavor.Name = "lblQtyMaxFlavor";
            this.lblQtyMaxFlavor.Size = new System.Drawing.Size(403, 32);
            this.lblQtyMaxFlavor.TabIndex = 27;
            this.lblQtyMaxFlavor.Text = "Quantidade máxima de sabores: ";
            this.lblQtyMaxFlavor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwSelectedFlavors
            // 
            this.lvwSelectedFlavors.BackColor = System.Drawing.Color.Ivory;
            this.lvwSelectedFlavors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwSelectedFlavors.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSelectedFlavors.FullRowSelect = true;
            this.lvwSelectedFlavors.GridLines = true;
            this.lvwSelectedFlavors.HideSelection = false;
            this.lvwSelectedFlavors.Location = new System.Drawing.Point(477, 27);
            this.lvwSelectedFlavors.MultiSelect = false;
            this.lvwSelectedFlavors.Name = "lvwSelectedFlavors";
            this.lvwSelectedFlavors.Size = new System.Drawing.Size(465, 118);
            this.lvwSelectedFlavors.TabIndex = 2;
            this.lvwSelectedFlavors.UseCompatibleStateImageBehavior = false;
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
            this.lvwPizzaOrder.Location = new System.Drawing.Point(6, 27);
            this.lvwPizzaOrder.Name = "lvwPizzaOrder";
            this.lvwPizzaOrder.Size = new System.Drawing.Size(465, 118);
            this.lvwPizzaOrder.TabIndex = 1;
            this.lvwPizzaOrder.UseCompatibleStateImageBehavior = false;
            this.lvwPizzaOrder.SelectedIndexChanged += new System.EventHandler(this.LvwPizzaOrder_SelectedIndexChanged);
            this.lvwPizzaOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LvwPizzaOrder_MouseDown);
            // 
            // grbEdge
            // 
            this.grbEdge.Controls.Add(this.lblEdgePrice);
            this.grbEdge.Controls.Add(this.btnEdgeSearch);
            this.grbEdge.Controls.Add(this.txtEdgeId);
            this.grbEdge.Controls.Add(this.lblEdgeName);
            this.grbEdge.Controls.Add(this.label3);
            this.grbEdge.Location = new System.Drawing.Point(20, 325);
            this.grbEdge.Name = "grbEdge";
            this.grbEdge.Size = new System.Drawing.Size(950, 78);
            this.grbEdge.TabIndex = 30;
            this.grbEdge.TabStop = false;
            this.grbEdge.Text = "Sabor Borda";
            // 
            // lblEdgePrice
            // 
            this.lblEdgePrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEdgePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEdgePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEdgePrice.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgePrice.Location = new System.Drawing.Point(527, 43);
            this.lblEdgePrice.Name = "lblEdgePrice";
            this.lblEdgePrice.Size = new System.Drawing.Size(164, 28);
            this.lblEdgePrice.TabIndex = 33;
            this.lblEdgePrice.Text = "Valor";
            this.lblEdgePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEdgeSearch
            // 
            this.btnEdgeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdgeSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnEdgeSearch.Image")));
            this.btnEdgeSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdgeSearch.Location = new System.Drawing.Point(148, 43);
            this.btnEdgeSearch.Name = "btnEdgeSearch";
            this.btnEdgeSearch.Size = new System.Drawing.Size(29, 28);
            this.btnEdgeSearch.TabIndex = 30;
            this.btnEdgeSearch.UseVisualStyleBackColor = true;
            this.btnEdgeSearch.Click += new System.EventHandler(this.BtnEdgeSearch_Click);
            // 
            // txtEdgeId
            // 
            this.txtEdgeId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdgeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdgeId.Location = new System.Drawing.Point(6, 43);
            this.txtEdgeId.Name = "txtEdgeId";
            this.txtEdgeId.Size = new System.Drawing.Size(136, 28);
            this.txtEdgeId.TabIndex = 29;
            this.txtEdgeId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEdgeId_Validating);
            // 
            // lblEdgeName
            // 
            this.lblEdgeName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEdgeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEdgeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEdgeName.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgeName.Location = new System.Drawing.Point(183, 43);
            this.lblEdgeName.Name = "lblEdgeName";
            this.lblEdgeName.Size = new System.Drawing.Size(338, 28);
            this.lblEdgeName.TabIndex = 32;
            this.lblEdgeName.Text = "Borda";
            this.lblEdgeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Codigo da Borda";
            // 
            // chkEdge
            // 
            this.chkEdge.AutoSize = true;
            this.chkEdge.Location = new System.Drawing.Point(20, 300);
            this.chkEdge.Name = "chkEdge";
            this.chkEdge.Size = new System.Drawing.Size(155, 24);
            this.chkEdge.TabIndex = 31;
            this.chkEdge.Text = "Adicionar Borda";
            this.chkEdge.UseVisualStyleBackColor = true;
            this.chkEdge.CheckedChanged += new System.EventHandler(this.ChkEdge_CheckedChanged);
            // 
            // lblPizzaTotal
            // 
            this.lblPizzaTotal.BackColor = System.Drawing.Color.Olive;
            this.lblPizzaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPizzaTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPizzaTotal.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaTotal.ForeColor = System.Drawing.Color.White;
            this.lblPizzaTotal.Location = new System.Drawing.Point(548, 437);
            this.lblPizzaTotal.Name = "lblPizzaTotal";
            this.lblPizzaTotal.Size = new System.Drawing.Size(139, 24);
            this.lblPizzaTotal.TabIndex = 35;
            this.lblPizzaTotal.Text = "R$";
            this.lblPizzaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Valor Total Pizza:";
            // 
            // btnTotalize
            // 
            this.btnTotalize.AutoSize = true;
            this.btnTotalize.BackgroundImage = global::UserInterface.Properties.Resources.refreshcart;
            this.btnTotalize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTotalize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTotalize.FlatAppearance.BorderSize = 0;
            this.btnTotalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalize.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalize.ForeColor = System.Drawing.Color.Red;
            this.btnTotalize.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTotalize.Location = new System.Drawing.Point(459, 413);
            this.btnTotalize.Name = "btnTotalize";
            this.btnTotalize.Size = new System.Drawing.Size(83, 54);
            this.btnTotalize.TabIndex = 37;
            this.btnTotalize.Text = "1";
            this.btnTotalize.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTotalize.UseVisualStyleBackColor = true;
            this.btnTotalize.Click += new System.EventHandler(this.BtnTotalize_Click);
            // 
            // flwAddtitionalCRUD
            // 
            this.flwAddtitionalCRUD.Controls.Add(this.btnCancel);
            this.flwAddtitionalCRUD.Controls.Add(this.btnSave);
            this.flwAddtitionalCRUD.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flwAddtitionalCRUD.Location = new System.Drawing.Point(693, 409);
            this.flwAddtitionalCRUD.Name = "flwAddtitionalCRUD";
            this.flwAddtitionalCRUD.Size = new System.Drawing.Size(277, 52);
            this.flwAddtitionalCRUD.TabIndex = 36;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(158, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(36, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Enviar Pedido";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmPizzaAddRt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 468);
            this.Controls.Add(this.btnTotalize);
            this.Controls.Add(this.flwAddtitionalCRUD);
            this.Controls.Add(this.lblPizzaTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkEdge);
            this.Controls.Add(this.grbEdge);
            this.Controls.Add(this.grbPizzaFlavor);
            this.Controls.Add(this.lblSizePrice);
            this.Controls.Add(this.btnSizeSearch);
            this.Controls.Add(this.txtSizeId);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblSizeId);
            this.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPizzaAddRt";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Pizza";
            this.Load += new System.EventHandler(this.FrmPizzaAddRt_Load);
            this.grbPizzaFlavor.ResumeLayout(false);
            this.grbPizzaFlavor.PerformLayout();
            this.grbEdge.ResumeLayout(false);
            this.grbEdge.PerformLayout();
            this.flwAddtitionalCRUD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSizePrice;
        private System.Windows.Forms.Button btnSizeSearch;
        private System.Windows.Forms.TextBox txtSizeId;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizeId;
        private System.Windows.Forms.GroupBox grbPizzaFlavor;
        private System.Windows.Forms.ListView lvwSelectedFlavors;
        private System.Windows.Forms.Label lblQtySelectedFlavors;
        private System.Windows.Forms.Label lblQtyMaxFlavor;
        private System.Windows.Forms.Label lblFlavorTotalPrice;
        private System.Windows.Forms.Label lblTitleTotalPrice;
        private System.Windows.Forms.GroupBox grbEdge;
        private System.Windows.Forms.Label lblEdgePrice;
        private System.Windows.Forms.Button btnEdgeSearch;
        private System.Windows.Forms.TextBox txtEdgeId;
        private System.Windows.Forms.Label lblEdgeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEdge;
        private System.Windows.Forms.Label lblPizzaTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTotalize;
        private System.Windows.Forms.FlowLayoutPanel flwAddtitionalCRUD;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddFlavors;
        public System.Windows.Forms.ListView lvwPizzaOrder;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.Button btnFlavorDelete;
    }
}