using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Modules
{
    public class DbFunctions
    {
        public int FindNextCode(string sql)
        {
            int actualId = -1;
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = sql;

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        actualId = Convert.ToInt32(dataReader["Auto_increment"].ToString());
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    dbContext.Close();
                }
            }
            return actualId;
        }
    }
}
