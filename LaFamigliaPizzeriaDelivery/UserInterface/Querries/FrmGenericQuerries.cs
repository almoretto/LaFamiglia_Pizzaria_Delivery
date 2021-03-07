using Entities.Enums;
using Entities.Views;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using UserInterface.Modules;

namespace UserInterface.Querries
{
    public partial class FrmGenericQuerries : Form
    {
        public List<EntityViewSearch> queryList = new List<EntityViewSearch>();
        public int returnControl = 0;
        public FrmGenericQuerries(string title, Status status)
        {
            InitializeComponent();
            Text = title;
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
            FillListView(queryList);
        }

        private void FillListView(List<EntityViewSearch> list)
        {
            //Method to populate view
            lstResult.Clear();
            lstResult.View = View.Details;

            lstResult.Columns.Add("Código", 50, HorizontalAlignment.Right);
            lstResult.Columns.Add("Descrição", 400, HorizontalAlignment.Left);

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

        private void LstResult_DoubleClick(object sender, EventArgs e)
        {
            //Call the confirm button
            BtnConfirmation_Click(btnConfirmation, new EventArgs());
        }

        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            if (lstResult.SelectedIndices.Count <= 0) { return; }
            var selectedIndex = Convert.ToInt32(lstResult.SelectedIndices[0]);
            if (selectedIndex >= 0)//Verifies if the index is a valid index
            {
                //Get the first column of the line item on the selected index
                returnControl = Convert.ToInt32(lstResult.Items[selectedIndex].Text);
                BtnExit_Click(btnExit, new EventArgs());
            }
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RbtAllActive_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtAllActive.Checked) { return; }
            ClearForm();
            FillListView(queryList);
        }

        private void RbtAllInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtAllInactive.Checked) { return; }
            ClearForm();
            FillListView(queryList);
        }

        private void RbtAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtAll.Checked) { return; }
            ClearForm();
            FillListView(queryList);
        }

        private void TxtGenericSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtGenericSearch.Text.Trim() == string.Empty) { return; }
            List<EntityViewSearch> listQ = new List<EntityViewSearch>
                (from u in queryList
                where u.Description.ToLower()
                .Contains(txtGenericSearch.Text.Trim().ToLower()) 
                select u);

            FillListView(listQ);
        }
       
        public void ClearForm()
        {
            txtGenericSearch.Text = string.Empty;
            returnControl = 0;
        }
    }
}
