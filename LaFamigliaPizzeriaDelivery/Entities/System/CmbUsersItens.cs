
namespace Entities.System
{
    public class CmbUsersItens
    {

        public string Login { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }

        public CmbUsersItens(string login, int id, string password)
        {
            Login = login;
            Id = id;
            Password = password;
        }
        public override string ToString()
        {
            return Login;
        }
    }
}
