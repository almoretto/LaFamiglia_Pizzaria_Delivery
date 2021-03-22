using DataContext.Modules;
using Entities.Order;
using Entities.People;
using MySql.Data.MySqlClient;
using System;
using DataContext.People;
using Entities.Enums;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataContext.Order
{
    public class SvcOrderDb
    {
        private readonly DbFunctions _dbFunctions = new DbFunctions();

        public string InsertOrder(PizzaOrder pizzaOrder)
        {
            string returnValue = "0000000000";
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command for Create new register on DB
                    command.CommandText = @"INSERT INTO 
			                                       pedido( 
                                                          IdCliente,
                                                          OrderNumber  
                                                          IdStatus, 
                                                          ValorPedido, 
                                                          TeleEntrega,
                                                          ValorEntrega,
                                                          ValorTotal,
                                                          DataPedido,
                                                          IdUsuarioPedido,
                                                          DataAlteracao, 
                                                          IdUsuarioAlteracao)
                                                   values( 
                                                          @IdCliente,
                                                          @OrderNumber
                                                          @IdStatus, 
                                                          @ValorPedido, 
                                                          @TeleEntrega,
                                                          @ValorEntrega,
                                                          @ValorTotal,
                                                          @DataPedido,
                                                          @IdUsuarioPedido,
                                                          @DataAlteracao, 
                                                          @IdUsuarioAlteracao);";
                    //Insert parameters
                    command.Parameters.AddWithValue("IdCliente", pizzaOrder.ClientInOrder.Id);
                    command.Parameters.AddWithValue("OrderNumber", pizzaOrder.OrderNumber);
                    command.Parameters.AddWithValue("IdStatus", (int)pizzaOrder.OrderStatus);
                    command.Parameters.AddWithValue("ValorPedido", pizzaOrder.OrderAmount);
                    int tele = 0;
                    if (pizzaOrder.CallCenter)
                    {
                        tele = 1;
                    }
                    command.Parameters.AddWithValue("TeleEntrega", tele);
                    command.Parameters.AddWithValue("ValorEntrega", pizzaOrder.DeliveryAmount);
                    command.Parameters.AddWithValue("ValorTotal", pizzaOrder.OrderTotalAmount);
                    command.Parameters.AddWithValue("DataPedido", pizzaOrder.OrderDate);
                    command.Parameters.AddWithValue("IdUsuarioPedido", pizzaOrder.OrderUser);
                    command.Parameters.AddWithValue("DataAlteracao", pizzaOrder.LastChangeDate);
                    command.Parameters.AddWithValue("IdUsuarioAlteracao", pizzaOrder.LastChangeUser.Id);

                    //Execute Insert
                    int insertResult = command.ExecuteNonQuery();

                    if (insertResult < 1) { returnValue = "0000000000"; }
                    else { returnValue = pizzaOrder.OrderNumber; }
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

        public PizzaOrder GetPizzaOrderByNumber(string ordernumber)
        {

            PizzaOrder orderFound = null;
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = "select * from pedido where PedidoNumero = @PedidoNumero;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("PedidoNumero", ordernumber);

                    MySqlDataReader dataReader = command.ExecuteReader();
                    orderFound = new PizzaOrder();
                    while (dataReader.Read())
                    {
                        orderFound.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        Client clientInOrder = new SvcClientDb()
                            .FindClientById(Convert.ToInt32(dataReader["IdCliente"].ToString()));
                        orderFound.ClientInOrder = clientInOrder;
                        orderFound.OrderNumber = dataReader["OrderNumber"].ToString();
                        orderFound.OrderStatus = (OrderStatus)Convert.ToInt32(dataReader["IdStatus"].ToString());
                        orderFound.SetOrderTotal(Convert.ToDouble(dataReader["ValorPedido"].ToString()));

                        bool delivery = false;
                        if (dataReader["TeleEntrega"].ToString() == "1")
                        { delivery = true; }
                        orderFound.CallCenter = delivery;

                        orderFound.SetDelivery(Convert.ToDouble(dataReader["ValorEntrega"].ToString()));
                        orderFound.SetTotal();
                        orderFound.OrderDate = Convert.ToDateTime(dataReader["DataPedido"].ToString());
                        User user = new SvcUsersDb()
                            .FindById(Convert.ToInt32(dataReader["IdUsuarioPedido"].ToString()));
                        orderFound.OrderUser = user;
                        User sessionUser = new SvcUsersDb()
                            .FindById(Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString()));
                        orderFound.LastChangeUser = sessionUser;
                        orderFound.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
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
            return orderFound;

        }

        public bool InsertAdditionals(List<OrderAdditional> list)
        {
            bool result = false;
            int count = 0;
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();
                    foreach (OrderAdditional item in list)
                    {
                        //Sql command for Create new register on DB
                        command.CommandText = @"INSERT INTO 
			                                       pedido( 
                                                          IdPedido,
                                                          IdAdicional  
                                                          QteAdicional, 
                                                          ValorTotalItem)
                                                   values( 
                                                          @IdPedido,
                                                          @IdAdicional  
                                                          @QteAdicional, 
                                                          @ValorTotalItem);";
                        //Insert parameters
                        command.Parameters.AddWithValue("IdPedido", item.PizzaOrder.Id);
                        command.Parameters.AddWithValue("IdAdicional", item.Additional.Id);
                        command.Parameters.AddWithValue("QteAdicional", item.AdditionalQty);
                        command.Parameters.AddWithValue("ValorTotalItem", item.AdditionalAmount);
                       
                        //Execute Insert
                        int insertResult = command.ExecuteNonQuery();
                        if (insertResult < 1) 
                        {
                            MessageBox.Show("Erro ao inserir registro: "
                                + item.Additional.Description
                                + " \n No pedido: " + item.PizzaOrder.Id,
                                "Insert Order Additionals",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return false; 
                        }
                        else { count++; }
                    }

                    if (count < list.Count)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
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

            return result;
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
