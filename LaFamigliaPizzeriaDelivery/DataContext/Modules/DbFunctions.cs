using MySql.Data.MySqlClient;
using System;

namespace DataContext.Modules
{
    public class DbFunctions
    {
        public int FindNextCode(string sql, string selectedTable)
        {
            int actualId = -1;
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();
                    command.CommandText = "ANALYZE TABLE @table;";
                    command.Parameters.AddWithValue("table", selectedTable);
                    int rows = command.ExecuteNonQuery();
                    //Sql command
                    command.CommandText = sql;

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {

                        if (dataReader["Auto_increment"].ToString() == string.Empty)
                        { actualId = 1; }
                        else
                        { actualId = Convert.ToInt32(dataReader["Auto_increment"].ToString()); }

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

        public string OptimizeTables()
        {
            string status = "NoK";
            string msg = "";
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = @"
                                            OPTIMIZE TABLE adicional;
                                            OPTIMIZE TABLE adicional_hst;
                                            OPTIMIZE TABLE cliente;
                                            OPTIMIZE TABLE cliente_hst;
                                            OPTIMIZE TABLE endereco;
                                            OPTIMIZE TABLE enderecopadrao;
                                            OPTIMIZE TABLE itempedidoadicional;
                                            OPTIMIZE TABLE itempedidoadicional_hst;
                                            OPTIMIZE TABLE itempedidopizza;
                                            OPTIMIZE TABLE itempedidopizza_hst;
                                            OPTIMIZE TABLE itempizzasabor;
                                            OPTIMIZE TABLE itempizzasabor_hst;
                                            OPTIMIZE TABLE pedido;
                                            OPTIMIZE TABLE pedido_hst;
                                            OPTIMIZE TABLE saborborda;
                                            OPTIMIZE TABLE saborborda_hst;
                                            OPTIMIZE TABLE saborpizza;
                                            OPTIMIZE TABLE saborpizza_hst;
                                            OPTIMIZE TABLE statuspedido;
                                            OPTIMIZE TABLE tamanhopizza;
                                            OPTIMIZE TABLE tamanhopizza_hst;
                                            OPTIMIZE TABLE tipousuario;
                                            OPTIMIZE TABLE usuario;
                                            OPTIMIZE TABLE usuario_hst;";

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        if (dataReader["Msg_type"].ToString() == "status")
                        { status = dataReader["Msg_text"].ToString().ToLower(); }
                        else
                        { msg = dataReader["Msg_text"].ToString(); }
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
            if (status == "ok")
            {
                return status;
            }
            else
            {
                return msg;
            }

        }
    }
}
