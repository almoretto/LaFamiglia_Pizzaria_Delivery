using Entities.Enums;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserInterface.Modules;
using BusinessRules.People;

namespace UserInterface.Querries
{
    public partial class FrmGenericQuerriesClient : Form
    {

        public int returnControl = 0;
        public FrmGenericQuerriesClient(Status status)
        {
            InitializeComponent();
            if (status == Status.Ativo)
            {
                rbtAllActive.Checked = true;
            }
            else if (status == Status.Inativo)
            {
                rbtAllInactive.Checked = true;
            }
            else
            {
                rbtAll.Checked = true;
            }
        }

        private void FrmGenericQuerries_Load(object sender, EventArgs e)
        {
            Form form = new Form()
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };
            ClearForm();
            ListViewConstructor();
            GetClients();
        }

        #region --== Buttons and Events ==--
        private void lstResult_DoubleClick(object sender, EventArgs e)
        {
            //Call the confirm button
            btnConfirmation_Click(btnConfirmation, new EventArgs());
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            if (lstResult.SelectedIndices.Count <= 0) { return; }
            var selectedIndex = Convert.ToInt32(lstResult.SelectedIndices[0]);
            if (selectedIndex >= 0)//Verifies if the index is a valid index
            {
                //Get the first column of the line item on the selected index
                returnControl = Convert.ToInt32(lstResult.Items[selectedIndex].Text);
                btnExit_Click(btnExit, new EventArgs());
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtAllActive_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtAllActive.Checked) { return; }
            GetClients();
        }

        private void rbtAllInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtAllInactive.Checked) { return; }
            GetClients();
        }

        private void rbtAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtAll.Checked) { return; }
            GetClients();
        }

        private void txtGenericSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtGenericClientSearch.Text.Trim().Length < 3) { return; }

            GetClients();
        }
        #endregion

        #region --== Auxiliary Methods ==--
        private void GetClients()
        {
            Status status;

            if (rbtAllActive.Checked)
            {
                status = Status.Ativo;
            }
            else if (rbtAllInactive.Checked)
            {
                status = Status.Inativo;
            }
            else
            {
                status = Status.Todos;
            }

            lstResult.Items.Clear();
            List<EntityViewClient> listClients = new ClientBus().GetEntityViewClient(status, txtGenericClientSearch.Text);

            if (listClients.Count < 1) { return; }

            foreach (EntityViewClient client in listClients)
            {
                string[] line = new string[4];
                line[0] = client.Id.ToString();
                line[1] = client.Name;
                line[2] = client.Phone;
                line[3] = client.CellPhone;

                ListViewItem items = new ListViewItem(line);
                lstResult.Items.Add(items);
            }
            Functions.ListViewColor(lstResult);
        }
        private void ListViewConstructor()
        {
            lstResult.Clear();
            lstResult.View = View.Details;
            lstResult.Columns.Add("Código", 60, HorizontalAlignment.Right);
            lstResult.Columns.Add("Nome", 270, HorizontalAlignment.Left);
            lstResult.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            lstResult.Columns.Add("Celular", 120, HorizontalAlignment.Left);
        }
        public void ClearForm()
        {
            txtGenericClientSearch.Text = string.Empty;
            returnControl = 0;
        }

        #endregion

        /* Method unused on this form
        private void FillListView(List<EntityViewSearch> list)
        {
            //Method to populate view
            lstResult.Clear();
            lstResult.View = View.Details;

            lstResult.Columns.Add("Código", 50, HorizontalAlignment.Right);
            lstResult.Columns.Add("Descrição", 280, HorizontalAlignment.Left);

            foreach (var item in list)
            {
                if (!rbtAll.Checked)
                {
                    if (rbtAllActive.Checked && item.Status != Status.Ativo)
                    {
                        continue;
                    }
                    else if (rbtAllInactive.Checked && item.Status != Status.Inativo)
                    {
                        continue;
                    }
                }
                string[] line = new string[2];
                line[0] = item.Id.ToString();
                line[1] = item.Description;
                ListViewItem listLine = new ListViewItem(line);
                lstResult.Items.Add(listLine);
            }
            Functions.ListViewColor(lstResult);
        }
        */
    }
}
