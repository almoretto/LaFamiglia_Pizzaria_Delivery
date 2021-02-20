using DataContext.Modules;
using Entities.Enums;
using Entities.Products;
using Entities.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataContext.Products
{
    public class SvcPizzaSizeDb
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
                                        tamanhopizza";

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

        public List<PizzaSize> GetActiveSizes()
        {
            List<PizzaSize> sizesList = new List<PizzaSize>();

            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();
                    command.CommandText = "select * from tamanhopizza where Situacao=1;";

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {

                        PizzaSize newPizzaSize = new PizzaSize();

                        newPizzaSize.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        newPizzaSize.Description = dataReader["Descricao"].ToString();

                        if (!(dataReader["Observacao"] is DBNull))
                        {
                            newPizzaSize.SizeRemark = dataReader["Observacao"].ToString();
                        }
                        newPizzaSize.FlvorsQty = Convert.ToInt32(dataReader["Qtesabores"].ToString());
                        newPizzaSize.AdditionalPrice = Convert.ToDouble(dataReader["Valor"].ToString());
                        newPizzaSize.SizeStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        newPizzaSize.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        newPizzaSize.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());

                        sizesList.Add(newPizzaSize);
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
            return sizesList;
        }

        public PizzaSize FindById(int id)
        {
            PizzaSize PizzaSizeFound = new PizzaSize();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = "select * from tamanhopizza where id = @Id;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("Id", id);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        PizzaSizeFound.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        PizzaSizeFound.Description = dataReader["Descricao"].ToString();

                        if (!(dataReader["Observacao"] is DBNull))
                        {
                            PizzaSizeFound.SizeRemark = dataReader["Observacao"].ToString();
                        }
                        PizzaSizeFound.FlvorsQty = Convert.ToInt32(dataReader["Qtesabores"].ToString());
                        PizzaSizeFound.AdditionalPrice = Convert.ToDouble(dataReader["Valor"].ToString());
                        PizzaSizeFound.SizeStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        PizzaSizeFound.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        PizzaSizeFound.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());
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
            return PizzaSizeFound;
        }

        public bool CreatePizzaSize(PizzaSize newPizzaSize)
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
                                            tamanhopizza( 
                                                Descricao, 
                                                Observacao,
                                                Valor,
                                                Qtesabores,
                                                Situacao, 
                                                DataAlteracao, 
                                                IdUsuarioAlteracao)
                                            values( 
                                                @Descricao, 
                                                @Observacao,
                                                @Valor, 
                                                @Qtesabores,
                                                @Situacao, 
                                                @DataAlteracao, 
                                                @IdUsuarioAlteracao);";
                    //Insert parameters
                    command.Parameters.AddWithValue("Descricao", newPizzaSize.Description);
                    command.Parameters.AddWithValue("Observacao", newPizzaSize.SizeRemark);
                    command.Parameters.AddWithValue("Qtesabores", newPizzaSize.FlvorsQty);
                    command.Parameters.AddWithValue("Valor", newPizzaSize.AdditionalPrice);
                    command.Parameters.AddWithValue("Situacao", (int)newPizzaSize.SizeStatus);
                    command.Parameters.AddWithValue("DataAlteracao", newPizzaSize.LastChangeDate);
                    command.Parameters.AddWithValue("IdUsuarioAlteracao", newPizzaSize.LastChangeUserId);

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

        public bool UpdatePizzaSize(PizzaSize SizeToUpdate)
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
                    command.CommandText = @"update tamanhopizza 
                                                set  
                                                    Descricao = @Descricao, 
                                                    Observacao = @Observacao,
                                                    Valor = @Valor, 
                                                    Qtesabores = @Qtesabores,
                                                    Situacao = @Situacao, 
                                                    DataAlteracao = @DataAlteracao, 
                                                    IdUsuarioAlteracao = @IdUsuarioAlteracao
                                                WHERE 
                                                    Id = @id";
                    //Insert parameters
                    command.Parameters.AddWithValue("Id", SizeToUpdate.Id);
                    command.Parameters.AddWithValue("Descricao", SizeToUpdate.Description);
                    command.Parameters.AddWithValue("Observacao", SizeToUpdate.SizeRemark);
                    command.Parameters.AddWithValue("Qtesabores", SizeToUpdate.FlvorsQty);
                    command.Parameters.AddWithValue("Valor", SizeToUpdate.AdditionalPrice);
                    command.Parameters.AddWithValue("Situacao", (int)SizeToUpdate.SizeStatus);
                    command.Parameters.AddWithValue("DataAlteracao", SizeToUpdate.LastChangeDate);
                    command.Parameters.AddWithValue("IdUsuarioAlteracao", SizeToUpdate.LastChangeUserId);

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

        public bool DeletePizzaSize(int SizeToDelete)
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
                    command.CommandText = @"DELETE from tamanhopizza 
                                            WHERE Id = @id";
                    //Insert parameters
                    command.Parameters.AddWithValue("Id", SizeToDelete);

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
            string sql = "Show table status like 'tamanhopizza';";
            return _dbFunctions.FindNextCode(sql);
        }
    }
}
