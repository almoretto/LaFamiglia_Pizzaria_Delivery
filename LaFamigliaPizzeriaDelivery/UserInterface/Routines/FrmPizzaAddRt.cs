using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessRules.Products;
using Entities.Enums;
using Entities.Products;
using Entities.Views;
using UserInterface.Modules;
using UserInterface.Querries;

namespace UserInterface.Routines
{
    public partial class FrmPizzaAddRt : Form
    {
        private int sizeControl { get; set; }       
        private int flavorsControl { get; set; }
        private int edgeControl { get; set; }

        public PizzaSize SelectedSize { get; private set; }
        public PizzaEdgeFilling SelectedEdge { get; private set; }
        public List<PizzaFlavor> PizzaFlavorsSelected { get; private set; }
     
        public List<EntityViewProducts> listOfSize { get; set; } = new List<EntityViewProducts>();
        public double Total { get; private set; }

        private List<PizzaFlavor> PizzaFlavorList = new List<PizzaFlavor>();


        public FrmPizzaAddRt()
        {
            InitializeComponent();
            IdFieldMasks.AplyEvents(txtSizeId);
            IdFieldMasks.AplyEvents(txtEdgeId);

        }
        private void FrmPizzaAddRt_Load(object sender, System.EventArgs e)
        {

            grbPizzaFlavor.Enabled = false;
            chkEdge.Checked = false;
            grbEdge.Enabled = chkEdge.Checked;
            txtSizeId.Focus();
            btnTotalize.Text = string.Empty;
            PrepareGrid();
            ClearForm();

        }

        #region --== Buttons ==--
        private void BtnSizeSearch_Click(object sender, EventArgs e)
        {
            PizzaSizeBus sizeBus = new PizzaSizeBus();
            FrmGenericQueriesProducts selectSize = new FrmGenericQueriesProducts("Seleção de tamanhos", Status.Ativo);
            listOfSize = sizeBus.GetEntityViewProducts(Status.Ativo);
            selectSize.queryList = listOfSize;
            selectSize.ShowDialog();
            sizeControl = selectSize.returnControl;
            if (sizeControl < 0)
            { return; }

            txtSizeId.Text = sizeControl.ToString();
            IdFieldMasks.MakeMask(txtSizeId, new EventArgs());
            TxtSizeId_Validating(txtSizeId, new CancelEventArgs());
            grbPizzaFlavor.Enabled = true;
        }

        private void BtnEdgeSearch_Click(object sender, EventArgs e)
        {
            PizzaEdgeBus edgeBus = new PizzaEdgeBus();
            FrmGenericQueriesProducts selectEdge = new FrmGenericQueriesProducts("Seleção de tamanhos", Status.Ativo);
            listOfSize = edgeBus.GetEntityViewProducts(Status.Ativo);
            selectEdge.queryList = listOfSize;
            selectEdge.ShowDialog();
            edgeControl = selectEdge.returnControl;
            if (sizeControl < 0)
            { return; }

            txtEdgeId.Text = edgeControl.ToString();
            IdFieldMasks.MakeMask(txtEdgeId, new EventArgs());
            TxtEdgeId_Validating(txtEdgeId, new CancelEventArgs());
        }

        private void BtnAddFlavors_Click(object sender, EventArgs e)
        {
            double flavorTotal = 0.0d;
            ListView.SelectedIndexCollection indexes = this.lvwPizzaOrder.SelectedIndices;

            if (lvwSelectedFlavors.Items.Count < 1)
            {
                lblSlash.Text = SelectedSize.FlvorsQty.ToString("00")
                    + " / "
                    + indexes.Count.ToString("00");
            }
            else
            {
                lblSlash.Text = SelectedSize.FlvorsQty.ToString("00")
                   + " / "
                   + lvwSelectedFlavors.Items.Count.ToString("00");
            }
            if (indexes.Count > SelectedSize.FlvorsQty)
            {

                MessageBox.Show("Você selecionou "
                +
                (indexes.Count - SelectedSize.FlvorsQty).ToString()
                + " sabores a mais que o permitido\n"
                + "Por favor reconfigure os sabores\n"
                + "Para ficar no máximo: "
                + SelectedSize.FlvorsQty.ToString() + "sabores.",
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (lvwSelectedFlavors.Items.Count < 1)
            {
                foreach (int index in indexes)
                {
                    string[] line = new string[3];
                    line[0] = lvwPizzaOrder.Items[index].SubItems[0].Text.ToString();
                    line[1] = lvwPizzaOrder.Items[index].SubItems[1].Text.ToString();
                    line[2] = lvwPizzaOrder.Items[index].SubItems[2].Text.ToString();

                    ListViewItem lvItem = new ListViewItem(line);
                    lvwSelectedFlavors.Items.Add(lvItem);
                    lvwSelectedFlavors.View = View.Details;
                    flavorTotal += Convert.ToDouble((lvwPizzaOrder.Items[index].SubItems[2].Text).Replace("R$", "").Trim());
                }

            }
            else if (lvwSelectedFlavors.Items.Count >= 1)
            {
                if (indexes.Count + lvwSelectedFlavors.Items.Count > SelectedSize.FlvorsQty)
                {

                    MessageBox.Show("Você selecionou "
                    +
                    (indexes.Count - SelectedSize.FlvorsQty).ToString()
                    + " sabores a mais que o permitido\n"
                    + "Por favor reconfigure os sabores\n"
                    + "Para ficar no máximo: "
                    + SelectedSize.FlvorsQty.ToString() + "sabores.",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else
                {
                    foreach (int index in indexes)
                    {
                        string[] line = new string[3];
                        line[0] = lvwPizzaOrder.Items[index].SubItems[0].Text.ToString();
                        line[1] = lvwPizzaOrder.Items[index].SubItems[1].Text.ToString();
                        line[2] = lvwPizzaOrder.Items[index].SubItems[2].Text.ToString();

                        ListViewItem lvItem = new ListViewItem(line);
                        lvwSelectedFlavors.Items.Add(lvItem);
                        lvwSelectedFlavors.View = View.Details;
                        flavorTotal += Convert.ToDouble((lvwPizzaOrder.Items[index].SubItems[2].Text).Replace("R$", "").Trim());
                    }
                    lblSlash.Text = SelectedSize.FlvorsQty.ToString("00")
                        + " / "
                        + lvwSelectedFlavors.Items.Count.ToString("00");
                }
            }
            Functions.ListViewColor(lvwSelectedFlavors);
            btnAddFlavors.Text = string.Empty;
            lblFlavorTotalPrice.Text = flavorTotal.ToString("C2");
            Totallize();

        }

        private void BtnFlavorDelete_Click(object sender, EventArgs e)
        {
            if (lvwSelectedFlavors.SelectedIndices.Count < 1)
            { return; }

            int flavorToRemove = Convert.ToInt32(lvwSelectedFlavors.SelectedIndices[0]);
            double totalFlavor = Convert.ToDouble((lblFlavorTotalPrice.Text.Replace("R$", "").Trim()));
            totalFlavor -= Convert.ToDouble((lvwSelectedFlavors.Items[flavorToRemove].SubItems[2].Text).Replace("R$", "").Trim());
            if (flavorToRemove >= 0)
            { lvwSelectedFlavors.Items[flavorToRemove].Remove(); }

            lblSlash.Text = SelectedSize.FlvorsQty.ToString("00")
                    + " / "
                    + lvwSelectedFlavors.Items.Count.ToString("00");
            lblFlavorTotalPrice.Text = totalFlavor.ToString("C2");
        }

        private void BtnTotalize_Click(object sender, EventArgs e)
        {
            Totallize();
            lblPizzaTotal.Text = Total.ToString("C2");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtSizeId.Text == string.Empty || txtSizeId.Text == "")
            { return; }

            if (sizeControl < 0)
            {
                MessageBox.Show("Tamanho não encontrado!\n Selecione um Tamanho!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            PizzaSizeBus sizeBus = new PizzaSizeBus();
            PizzaFlavorBus flavorBus = new PizzaFlavorBus();
            PizzaEdgeBus edgeBus = new PizzaEdgeBus();

            SelectedSize = new PizzaSize();
            SelectedSize = sizeBus.FindById(sizeControl);

            if (edgeControl > 0)
            {
                SelectedEdge = new PizzaEdgeFilling();
                SelectedEdge = edgeBus.FindById(edgeControl);
            }

            PizzaFlavorsSelected = new List<PizzaFlavor>();
            foreach (ListViewItem item in lvwSelectedFlavors.Items)
            {
                flavorsControl = Convert.ToInt32(item.SubItems[0].Text.Trim());
                PizzaFlavorsSelected.Add(flavorBus.FindById(flavorsControl));
            }
            
        }

        #endregion

        #region --== Event Methods ==--

        private void TxtSizeId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            PizzaSizeBus sizeBus = new PizzaSizeBus();
            SelectedSize = sizeBus.FindById(sizeControl);
            lblSize.Text = SelectedSize.Description;
            lblSizePrice.Text = SelectedSize.AdditionalPrice.ToString("C2");
            lblSlash.Text = SelectedSize.FlvorsQty.ToString("00") + " / ";
            lvwSelectedFlavors.Items.Clear();
            lvwPizzaOrder.Items.Clear();
            FillFlavorGrid();
        }

        private void TxtEdgeId_Validating(object sender, CancelEventArgs e)
        {
            PizzaEdgeBus edgeBus = new PizzaEdgeBus();
            SelectedEdge = edgeBus.FindById(sizeControl);
            lblEdgeName.Text = SelectedEdge.Description;
            lblEdgePrice.Text = SelectedEdge.AdditionalPrice.ToString("C2");

        }

        private void ChkEdge_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdge.Checked)
            {
                grbEdge.Enabled = true;
            }
            txtEdgeId.Focus();
            txtEdgeId.Select(0, 0);
            IdFieldMasks.UnMakeMask(txtEdgeId, new EventArgs());
        }

        private void LvwPizzaOrder_MouseDown(object sender, MouseEventArgs e)
        { LvwPizzaOrder_SelectedIndexChanged(lvwPizzaOrder, new EventArgs()); }

        private void LvwPizzaOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.lvwPizzaOrder.SelectedIndices;
            int counter = indexes.Count;
            btnAddFlavors.Text = counter.ToString();
        }
        #endregion

        #region --== Auxiliary Methods ===

        private void ClearForm()
        {
            txtSizeId.Text = string.Empty;
            txtEdgeId.Text = string.Empty;

            lvwPizzaOrder.Items.Clear();
            lvwSelectedFlavors.Items.Clear();

            lblFlavorTotalPrice.Text = "R$ 0,00";
            lblPizzaTotal.Text = "R$ 0,00";
            btnTotalize.Text = string.Empty;

            IdFieldMasks.MakeMask(txtSizeId, new EventArgs());

        }

        private void PrepareGrid()
        {
            //FlavorsGrid
            lvwPizzaOrder.MultiSelect = true;
            lvwPizzaOrder.CheckBoxes = false;
            lvwPizzaOrder.Clear();
            lvwPizzaOrder.View = View.Details;
            lvwPizzaOrder.Columns.Add("Id", 25, HorizontalAlignment.Right);
            lvwPizzaOrder.Columns.Add("Descrição do Sabor", 300, HorizontalAlignment.Left);
            lvwPizzaOrder.Columns.Add("Valor", 100, HorizontalAlignment.Right);


            //SelectedFlavorsGrid
            lvwSelectedFlavors.MultiSelect = false;
            lvwSelectedFlavors.Clear();
            lvwSelectedFlavors.View = View.Details;
            lvwSelectedFlavors.Columns.Add("Id", 25, HorizontalAlignment.Right);
            lvwSelectedFlavors.Columns.Add("Sabor Selecionado", 300, HorizontalAlignment.Left);
            lvwSelectedFlavors.Columns.Add("Valor", 100, HorizontalAlignment.Right);



        }

        private void FillFlavorGrid()
        {
            lvwPizzaOrder.Items.Clear();
            PizzaFlavorBus flavorBus = new PizzaFlavorBus();

            PizzaFlavorList = flavorBus.GetActiveFlavors();

            if (PizzaFlavorList.Count < 1)
            {
                MessageBox.Show("Nenhum sabor encontrado",
                   this.Text,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            string[] line = new string[3];
            ListViewItem itemList;
            foreach (PizzaFlavor flavor in PizzaFlavorList)
            {
                line[0] = flavor.Id.ToString();
                line[1] = flavor.Description;
                line[2] = flavor.AdditionalPrice.ToString("C2");
                itemList = new ListViewItem(line);
                lvwPizzaOrder.Items.Add(itemList);
            }

            Functions.ListViewColor(lvwPizzaOrder);
        }

        private void Totallize()
        {
            Total = 0.0d;

            if (sizeControl < 1)
            {
                MessageBox.Show("Nenhum tamanho selecionado!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Total = SelectedSize.AdditionalPrice;
            if (chkEdge.Checked)
            {
                if (edgeControl >= 1)
                {
                    Total += SelectedEdge.AdditionalPrice;
                }
                else
                {
                    MessageBox.Show("Selecione ao menos uma borda ou desmarque a caixa!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (ListViewItem line in lvwSelectedFlavors.Items)
            {
                double flavorPrice = Convert.ToDouble((line.SubItems[2].Text).Replace("R$", "").Trim());
                if (flavorPrice > 0.0d)
                {
                    Total += flavorPrice;
                }

            }
        }

        #endregion


    }
}
