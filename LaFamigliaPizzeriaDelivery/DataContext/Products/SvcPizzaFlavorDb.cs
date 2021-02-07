using DataContext.Modules;
using Entities.Enums;
using Entities.Products;
using Entities.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataContext.Products
{
    public class SvcPizzaFlavorDb
    {
        private readonly DbFunctions _dbFunctions = new DbFunctions();

        public List<EntityViewSearch> GetEntityViewSearch(Status status)
        {
            List<EntityViewSearch> entityList = new List<EntityViewSearch>();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    string query = @"Select 
                                        Id, Descricao, Situacao 
                                     From 
                                        saborpizza";

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
                        EntityViewSearch newEntity = new EntityViewSearch
                        {
                            Id = Convert.ToInt32(dataReader["Id"].ToString()),
                            Description = dataReader["Descricao"].ToString(),
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

        public List<PizzaFlavor> GetActiveFlavors()
        {
            List<PizzaFlavor> flavorsList = new List<PizzaFlavor>();

            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();
                    command.CommandText = "select * from saborpizza where Situacao=1;";

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {

                        PizzaFlavor newPizzaFlavor = new PizzaFlavor();

                        newPizzaFlavor.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        newPizzaFlavor.Description = dataReader["Descricao"].ToString();

                        if (!(dataReader["Observacao"] is DBNull))
                        {
                            newPizzaFlavor.FlavorRemark = dataReader["Observacao"].ToString();
                        }

                        newPizzaFlavor.AdditionalPrice = Convert.ToDouble(dataReader["ValorAcrescimo"].ToString());
                        newPizzaFlavor.FlavorStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        newPizzaFlavor.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        newPizzaFlavor.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());

                        flavorsList.Add(newPizzaFlavor);
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
            return flavorsList;
        }

        public PizzaFlavor FindById(int id)
        {
            PizzaFlavor pizzaFlavorFound = new PizzaFlavor();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = "select * from saborpizza where id = @Id;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("Id", id);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        pizzaFlavorFound.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        pizzaFlavorFound.Description = dataReader["Descricao"].ToString();

                        if (!(dataReader["Observacao"] is DBNull))
                        {
                            pizzaFlavorFound.FlavorRemark = dataReader["Observacao"].ToString();
                        }

                        pizzaFlavorFound.AdditionalPrice = Convert.ToDouble(dataReader["Valor"].ToString());
                        pizzaFlavorFound.FlavorStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        pizzaFlavorFound.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        pizzaFlavorFound.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());
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
            return pizzaFlavorFound;
        }

        public bool CreatePizzaFlavor(PizzaFlavor newPizzaFlavor)
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
                                            saborpizza( 
                                                Descricao, 
                                                Observacao, 
                                                ValorAcrescimo, 
                                                Situacao, 
                                                DataAlteracao, 
                                                IdUsuarioAlteracao)
                                            values( 
                                                @Descricao, 
                                                @Observacao, 
                                                @ValorAcrescimo, 
                                                @Situacao, 
                                                @DataAlteracao, 
                                                @IdUsuarioAlteracao);";
                    //Insert parameters
                    command.Parameters.AddWithValue("Descricao", newPizzaFlavor.Description);
                    command.Parameters.AddWithValue("Observacao", newPizzaFlavor.FlavorRemark);
                    command.Parameters.AddWithValue("ValorAcrescimo", newPizzaFlavor.AdditionalPrice);
                    command.Parameters.AddWithValue("Situacao", (int)newPizzaFlavor.FlavorStatus);
                    command.Parameters.AddWithValue("DataAlteracao", newPizzaFlavor.LastChangeDate);
                    command.Parameters.AddWithValue("IdUsuarioAlteracao", newPizzaFlavor.LastChangeUserId);

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

        public bool UpdatePizzaFlavor(PizzaFlavor flavorToUpdate)
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
                    command.CommandText = @"update saborpizza 
                                                set  
                                                    Descricao = @Descricao, 
                                                    Observacao = @Observacao, 
                                                    ValorAcrescimo = @ValorAcrescimo, 
                                                    Situacao = @Situacao, 
                                                    DataAlteracao = @DataAlteracao, 
                                                    IdUsuarioAlteracao = @IdUsuarioAlteracao
                                                WHERE 
                                                    Id = @id";
                    //Insert parameters
                    command.Parameters.AddWithValue("Id", flavorToUpdate.Id);
                    command.Parameters.AddWithValue("Descricao", flavorToUpdate.Description);
                    command.Parameters.AddWithValue("Observacao", flavorToUpdate.FlavorRemark);
                    command.Parameters.AddWithValue("ValorAcrescimo", flavorToUpdate.AdditionalPrice);
                    command.Parameters.AddWithValue("Situacao", (int)flavorToUpdate.FlavorStatus);
                    command.Parameters.AddWithValue("DataAlteracao", flavorToUpdate.LastChangeDate);
                    command.Parameters.AddWithValue("IdUsuarioAlteracao", flavorToUpdate.LastChangeUserId);

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

        public bool DeletePizzaFlavor(int flavorToDelete)
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
                    command.CommandText = @"DELETE from saborpizza 
                                            WHERE Id = @id";
                    //Insert parameters
                    command.Parameters.AddWithValue("Id", flavorToDelete);

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
            string sql = "Show table status like 'saborpizza';";
            return _dbFunctions.FindNextCode(sql);
        }
    }
}
