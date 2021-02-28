using BusinessRules.People;
using Entities.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Modules;
using UserInterface.People;

namespace UserInterface.Routines
{
    public partial class FrmOrderRt : Form
    {
        public FrmOrderRt()
        {
            InitializeComponent();
        }

        private void MtxtContact_Validating(object sender, CancelEventArgs e)
        {
            var contactNumber = Functions.RemoveMaskFromMaskedFields(mtxtContact);

            if (contactNumber == null) { return; }

            var onlineClient = new ClientBus().FindClientByContact((long)contactNumber);

            //Refactoring decision for nullable object because the instance is allways notnull
            //An entity on database always has an Id and a name or other field that is required.
            if (onlineClient.Name == null || onlineClient.Id == 0)
            {
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
                MessageBox.Show(onlineClient.Name,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
