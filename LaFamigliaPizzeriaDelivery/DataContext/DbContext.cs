using MySql.Data.MySqlClient;
using System.Configuration;

namespace DataContext
{
    public class DbContext
    {
        //Method to create an instance of DBContext Class Localy. 
        private static readonly DbContext LaFamigliaDbContext = new DbContext();

        //Method to return the instance created above
        public static DbContext GetInstance()
        {
            return LaFamigliaDbContext;
        }

        //Method to create the DB Connection
        public MySqlConnection GetConnection()
        {
            //This line gets the ConnectionString from app.config file.
            string dbConnection = ConfigurationManager.ConnectionStrings["DataContextConection"].ToString();
            return new MySqlConnection(dbConnection);
        }
    }
}
