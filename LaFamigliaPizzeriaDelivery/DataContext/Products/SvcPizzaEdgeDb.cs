using DataContext.Modules;
using Entities.Enums;
using Entities.Views;
using Entities.Products;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataContext.Products
{
    public class SvcPizzaEdgeDb
    {
        private readonly DbFunctions _dbFunctions = new DbFunctions();

        public List<EntityViewProducts> GetEntityViewProducts(Status status)
        {
            List<EntityViewProducts> entityList = new List<EntityViewProducts>();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    string query = @"Select 
                                        Id, Descricao, Situacao, Valor 
                                     From 
                                        saborborda";

                    if (status != Status.Todos)
                    {
                        query += " Where "
                                + "situacao = @status;";
                    }

                    command.CommandText = query;

                    if (status != Status.Todos)
                    {
                        command.Parameters.AddWithValue("situacao", (int)status);
                    }

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        EntityViewProducts newEntity = new EntityViewProducts
                        {
                            Id = Convert.ToInt32(dataReader["Id"].ToString()),
                            Description = dataReader["Descricao"].ToString(),
                            Price = Convert.ToDouble(dataReader["Valor"].ToString()),
                            Status = (Status)Convert.ToInt32(dataReader["Situacao"])
                        };

                        entityList.Add(newEntity);
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
            return entityList;
        }

        public List<PizzaEdgeFilling> GetActiveEdges()
        {
            List<PizzaEdgeFilling> edgesList = new List<PizzaEdgeFilling>();

            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();
                    command.CommandText = "select * from saborborda where Situacao=1;";

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {

                        PizzaEdgeFilling newPizzaEdge = new PizzaEdgeFilling();

                        newPizzaEdge.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        newPizzaEdge.Description = dataReader["Descricao"].ToString();

                        if (!(dataReader["Observacao"] is DBNull))
                        {
                            newPizzaEdge.EdgeRemark = dataReader["Observacao"].ToString();
                        }

                        newPizzaEdge.AdditionalPrice = Convert.ToDouble(dataReader["Valor"].ToString());
                        newPizzaEdge.EdgeStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        newPizzaEdge.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        newPizzaEdge.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());

                        edgesList.Add(newPizzaEdge);
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
            return edgesList;
        }

        public PizzaEdgeFilling FindById(int id)
        {
            PizzaEdgeFilling pizzaEdgeFound = new PizzaEdgeFilling();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = "select * from saborborda where id = @Id;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("Id", id);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        pizzaEdgeFound.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        pizzaEdgeFound.Description = dataReader["Descricao"].ToString();

                        if (!(dataReader["Observacao"] is DBNull))
                        {
                            pizzaEdgeFound.EdgeRemark = dataReader["Observacao"].ToString();
                        }

                        pizzaEdgeFound.AdditionalPrice = Convert.ToDouble(dataReader["Valor"].ToString());
                        pizzaEdgeFound.EdgeStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        pizzaEdgeFound.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        pizzaEdgeFound.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());
                    }
                }
                catch (MySqlException ex)
                {
                    throw new System.Exception(ex.Message);
                }
                finally
                {
                    dbContext.Close();
                }
            }
            return pizzaEdgeFound;
        }

        public bool CreatePizzaEdge(PizzaEdgeFilling newPizzaEdge)
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
                                            saborborda( 
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
                    command.Parameters.AddWithValue("Descricao", newPizzaEdge.Description);
                    command.Parameters.AddWithValue("Observacao", newPizzaEdge.EdgeRemark);
                    command.Parameters.AddWithValue("Valor", newPizzaEdge.AdditionalPrice);
                    command.Parameters.AddWithValue("Situacao", (int)newPizzaEdge.EdgeStatus);
                    command.Parameters.AddWithValue("DataAlteracao", newPizzaEdge.LastChangeDate);
                    command.Parameters.AddWithValue("IdUsuarioAlteracao", newPizzaEdge.LastChangeUserId);

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
                return returnValue;
            }
        }

        public bool UpdatePizzaEdge(PizzaEdgeFilling edgeToUpdate)
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
                    command.CommandText = @"update saborborda 
                                                set  
                                                    Descricao = @Descricao, 
                                                    Observacao = @Observacao, 
                                                    Valor = @Valor, 
                                                    Situacao = @Situacao, 
                                                    DataAlteracao = @DataAlteracao, 
                                                    IdUsuarioAlteracao = @IdUsuarioAlteracao
                                                WHERE 
                                                    Id = @id";
                    //Insert parameters
                    command.Parameters.AddWithValue("Id", edgeToUpdate.Id);
                    command.Parameters.AddWithValue("Descricao", edgeToUpdate.Description);
                    command.Parameters.AddWithValue("Observacao", edgeToUpdate.EdgeRemark);
                    command.Parameters.AddWithValue("Valor", edgeToUpdate.AdditionalPrice);
                    command.Parameters.AddWithValue("Situacao", (int)edgeToUpdate.EdgeStatus);
                    command.Parameters.AddWithValue("DataAlteracao", edgeToUpdate.LastChangeDate);
                    command.Parameters.AddWithValue("IdUsuarioAlteracao", edgeToUpdate.LastChangeUserId);

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
                return returnValue;
            }
        }

        public bool DeletePizzaEdge(int edgeToDelete)
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
                    command.CommandText = @"DELETE from saborborda 
                                            WHERE Id = @id";
                    //Insert parameters
                    command.Parameters.AddWithValue("Id", edgeToDelete);

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
                return returnValue;
            }
        }

        public int FindNextCode()
        {
            string sql = "Show table status like 'saborborda';";
            return _dbFunctions.FindNextCode(sql);
        }
    }
}
