using Entities.Enums;
using System.Windows.Forms;
using UserInterface.Modules;
using UserInterface.Querries;

namespace UserInterface.People
{
    public partial class FrmClientCRUD : Form
    {
        public FrmClientCRUD()
        {
            InitializeComponent();
            IdFieldMasks.AplyEvents(txtClientId);
        }

        private void FrmClientCRUD_Load(object sender, System.EventArgs e)
        {

        }
        #region --== Buttons ==--
        private void btnSave_Click(object sender, System.EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {

        }

        private void btnAddressSave_Click(object sender, System.EventArgs e)
        {

        }

        private void btnDeleteAddress_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnClientSearch_Click(object sender, System.EventArgs e)
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
        #endregion

        private void txtClientId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtClientId.Text.Trim() == string.Empty) { return; }

        }
    }
}
