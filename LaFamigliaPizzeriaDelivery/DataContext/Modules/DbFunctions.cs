using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

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
       
        public bool OptimizeAll()
        {
            /*Runs a Stored Procedure for optimize and analize all tables in database
             * This SP recalculate the Auto Incremental PK fields for the show table status works properly
             * This method was created because the find next code above never brings the real
             * next ID number 
             */

            bool result = false;
            //string message="Não Executado";
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                  //Creating the comand and indicating the SP, conn
                    MySqlCommand command = new MySqlCommand("SPOptimizeAll", dbContext);
                  //Configuring the type of command  
                    command.CommandType = CommandType.StoredProcedure;
                    //Opening DB Connection
                    dbContext.Open();
                    //Executing Command
                    command.ExecuteNonQuery();
                    //Closing Connection
                    dbContext.Close();
                    //Returning true valeu for validation 
                    result = true;
                    
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show(ex.Message, 
                        "Databade Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    throw new DBConcurrencyException(ex.Message);
                }
            }
            return result;
        }
    }
}
