using DataContext.Modules;
using Entities.Order;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Order
{
    public class SvcOrderDb
    {
        private readonly DbFunctions _dbFunctions = new DbFunctions();
        
        public bool InsertOrder(PizzaOrder pizzaOrder)
        {
            bool returnValue = false;
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command for Create new register on DB
                    command.CommandText = @"insert into 
                                            adicional( 
                                                Descricao, 
                                                Observacao, 
                                                Valor, 
                                                Situacao, 
                                                DataAlteracao, 
                                                IdUsuarioAlteracao)
                                            values( 
                                                @Descricao, 
                                                @Observacao, 
                                                @Valor, 
                                                @Situacao, 
                                                @DataAlteracao, 
                                                @IdUsuarioAlteracao);";
                    //Insert parameters
                    command.Parameters.AddWithValue("Descricao", newAdditional.Description);
                    command.Parameters.AddWithValue("Observacao", newAdditional.Remark);
                    command.Parameters.AddWithValue("Valor", newAdditional.Price);
                    command.Parameters.AddWithValue("Situacao", (int)newAdditional.AdditionalStatus);
                    command.Parameters.AddWithValue("DataAlteracao", newAdditional.LastChangeDate);
                    command.Parameters.AddWithValue("IdUsuarioAlteracao", newAdditional.LastChangeUserId);

                    //Execute Insert
                    int insertResult = command.ExecuteNonQuery();

                    if (insertResult < 1) { returnValue = false; }
                    else { returnValue = true; }
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
                    return returnValue;
        }
        
        public int FindNextOrderCode()
        {
            string sql = "Show table status like 'Pedido';";
            return _dbFunctions.FindNextCode(sql);
        }
        public int FindNextItemCode()
        {
            string sql = "Show table status like 'ItemPedidoPizza';";
            return _dbFunctions.FindNextCode(sql);
        }
        public int FindNexAdditionaltCode()
        {
            string sql = "Show table status like 'ItemPedidoAdicional';";
            return _dbFunctions.FindNextCode(sql);
        }
        public int FindNextItemFlavorCode()
        {
            string sql = "Show table status like 'ItemPizzaSabor';";
            return _dbFunctions.FindNextCode(sql);
        }
    }
}
