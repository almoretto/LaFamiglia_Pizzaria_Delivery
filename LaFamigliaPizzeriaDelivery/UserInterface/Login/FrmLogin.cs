using BusinessRules.People;
using Entities.System;
using System;
using System.Reflection; //For the Semanthics version capture 
using System.Windows.Forms;


namespace UserInterface.Login
{
    public partial class FrmLogin : Form
    {
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
            var uList = new UserBus().GetUsers();
            if (uList.Count>0)
            {
                foreach (var item in uList)
                {
                    cmbUsers.Items.Add(new CmbUsersItens(item.Login, item.Id, item.Password));
                }
            }

        }
    }
}
