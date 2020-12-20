using System;
using System.Windows.Forms;
using Entities.Enums;

namespace UserInterface.Controls
{
    public partial class UserSituacaoCTRL : UserControl
    {
        public Status CurrentStatus;
        public UserSituacaoCTRL()
        {
            InitializeComponent();
        }
        private void UserSituacaoCTRL_Load(object sender, EventArgs e)
        {
            if (DesignMode) { return; }
            StartStatus(Status.Ativo);
        }
        private void StartStatus(Status status)
        {
            if (DesignMode) { return; }
            CurrentStatus = status;
            if (CurrentStatus == Status.Ativo)
            {
                rbtActive.Checked = true;
            }
            else
            {
                rbtInactive.Checked = true;
            }
        }
        private void RbtActive_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) { return; }
            if (rbtInactive.Checked)
            {
                CurrentStatus = Status.Ativo;
            }
        }
        private void RbtInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) { return; }
            if (rbtInactive.Checked)
            {
                CurrentStatus = Status.Inativo;
            }
        }
    }
}
