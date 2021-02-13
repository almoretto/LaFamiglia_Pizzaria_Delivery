using BusinessRules.People;
using Entities;
using Entities.System;
using System;
using System.Reflection; //For the Semanthics version capture 
using System.Windows.Forms;


namespace UserInterface.Login
{
    public partial class FrmLogin : Form
    {
        public bool flgLogin;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            /*
             * In the string.Format() the firt parameter is the interpolation of the variables see bellow
             * Same as Console.WriteLine("Valores retornados : {0} , {1}, {2} ", valor, str1, str2);
             * The string "Version: {0}.{1}.{2}.{3}" is already on the text property of the label.
             */
            lblVersion.Text = string.Format(lblVersion.Text,
                version.Major,
                version.Minor,
                version.Build,
                version.Revision);
            LoadUsers();
        }

        private void LoadUsers()
        {
            var uList = new UserBus().GetActiveUsers();
            if (uList.Count > 0)
            {
                foreach (var item in uList)
                {
                    cmbUsers.Items.Add(new CmbUsersItens(item.Login, item.Id, item.Password));
                }
            }

        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Dispose();//This method close the FRMLogin, but need to Closse in this case ALL the Application
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show(
                    "Selecione um usuário para entrar no sistema!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show(
                    "Você deve informar uma senha para acessar!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            CmbUsersItens selectedItem = (CmbUsersItens)cmbUsers.SelectedItem;
            if (selectedItem.Password != txtPassword.Text.Trim())
            {
                MessageBox.Show(
                    "Senha digitada não confere!" +
                    "Tente Novamente",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //Setting flag for program not close.
            flgLogin = true;
            //Creating An instance of the Session of the 
            Session.User = new Entity(selectedItem.Id, selectedItem.Login);
            Session.UserType = new UserTypeBus().GetUserType(selectedItem.Id);
            this.Close();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(btnLogin, new EventArgs());
            }
            else
            {
                return;
            }
           
        }
    }
}
