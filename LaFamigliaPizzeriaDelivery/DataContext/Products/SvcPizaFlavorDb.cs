using DataContext.Modules;
using Entities.Enums;
using Entities.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataContext.Products
{
    public class SvcPizaFlavorDb
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

        //public List<Additional> GetActiveAdditional()
        //{
        //    List<Additional> additionalList = new List<Additional>();

        //    using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
        //    {
        //        try
        //        {
        //            dbContext.Open();
        //            MySqlCommand command = new MySqlCommand();
        //            command = dbContext.CreateCommand();
        //            command.CommandText = "select * from adicional where Situacao=1;";

        //            MySqlDataReader dataReader = command.ExecuteReader();

        //            while (dataReader.Read())
        //            {

        //                Additional newAdditional = new Additional();

        //                newAdditional.Id = Convert.ToInt32(dataReader["Id"].ToString());
        //                newAdditional.Description = dataReader["Descricao"].ToString();

        //                if (!(dataReader["Observacao"] is DBNull))
        //                {
        //                    newAdditional.Remark = dataReader["Observacao"].ToString();
        //                }

        //                newAdditional.Price = Convert.ToDouble(dataReader["Valor"].ToString());
        //                newAdditional.AdditionalStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
        //                newAdditional.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
        //                newAdditional.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());

        //                additionalList.Add(newAdditional);
        //            }
        //        }
        //        catch (MySqlException ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            dbContext.Close();
        //        }
        //    }
        //    return additionalList;
        //}

        //public Additional FindById(int id)
        //{
        //    Additional additionalFound = new Additional();
        //    using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
        //    {
        //        try
        //        {
        //            dbContext.Open();
        //            MySqlCommand command = new MySqlCommand();
        //            command = dbContext.CreateCommand();

        //            //Sql command
        //            command.CommandText = "select * from adicional where id = @Id;";
        //            //Sql Parameter
        //            command.Parameters.AddWithValue("Id", id);

        //            MySqlDataReader dataReader = command.ExecuteReader();

        //            while (dataReader.Read())
        //            {
        //                additionalFound.Id = Convert.ToInt32(dataReader["Id"].ToString());
        //                additionalFound.Description = dataReader["Descricao"].ToString();

        //                if (!(dataReader["Observacao"] is DBNull))
        //                {
        //                    additionalFound.Remark = dataReader["Observacao"].ToString();
        //                }

        //                additionalFound.Price = Convert.ToDouble(dataReader["Valor"].ToString());
        //                additionalFound.AdditionalStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
        //                additionalFound.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
        //                additionalFound.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());
        //            }
        //        }
        //        catch (MySqlException ex)
        //        {
        //            throw new System.Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            dbContext.Close();
        //        }
        //    }
        //    return additionalFound;
        //}

        //public bool CreateAdditional(Additional newAdditional)
        //{
        //    bool returnValue = false;
        //    using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
        //    {
        //        try
        //        {
        //            dbContext.Open();
        //            MySqlCommand command = new MySqlCommand();
        //            command = dbContext.CreateCommand();

        //            //Sql command for Create new register on DB
        //            command.CommandText = @"insert into 
        //                                    adicional( 
        //                                        Descricao, 
        //                                        Observacao, 
        //                                        Valor, 
        //                                        Situacao, 
        //                                        DataAlteracao, 
        //                                        IdUsuarioAlteracao)
        //                                    values( 
        //                                        @Descricao, 
        //                                        @Observacao, 
        //                                        @Valor, 
        //                                        @Situacao, 
        //                                        @DataAlteracao, 
        //                                        @IdUsuarioAlteracao);";
        //            //Insert parameters
        //            command.Parameters.AddWithValue("Descricao", newAdditional.Description);
        //            command.Parameters.AddWithValue("Observacao", newAdditional.Remark);
        //            command.Parameters.AddWithValue("Valor", newAdditional.Price);
        //            command.Parameters.AddWithValue("Situacao", (int)newAdditional.AdditionalStatus);
        //            command.Parameters.AddWithValue("DataAlteracao", newAdditional.LastChangeDate);
        //            command.Parameters.AddWithValue("IdUsuarioAlteracao", newAdditional.LastChangeUserId);

        //            //Execute Insert
        //            int insertResult = command.ExecuteNonQuery();

        //            if (insertResult < 1) { returnValue = false; }
        //            else { returnValue = true; }
        //        }
        //        catch (MySqlException ex)
        //        {
        //            throw new System.Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            dbContext.Close();
        //        }
        //        return returnValue;
        //    }
        //}

        //public bool UpdateAdditional(Additional additionalToUpdate)
        //{
        //    bool returnValue = false;
        //    using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
        //    {
        //        try
        //        {
        //            dbContext.Open();
        //            MySqlCommand command = new MySqlCommand();
        //            command = dbContext.CreateCommand();

        //            //Sql command for Create new register on DB
        //            command.CommandText = @"update adicional 
        //                                        set  
        //                                            Descricao = @Descricao, 
        //                                            Observacao = @Observacao, 
        //                                            Valor = @Valor, 
        //                                            Situacao = @Situacao, 
        //                                            DataAlteracao = @DataAlteracao, 
        //                                            IdUsuarioAlteracao = @IdUsuarioAlteracao
        //                                        WHERE 
        //                                            Id = @id";
        //            //Insert parameters
        //            command.Parameters.AddWithValue("Id", additionalToUpdate.Id);
        //            command.Parameters.AddWithValue("Descricao", additionalToUpdate.Description);
        //            command.Parameters.AddWithValue("Observacao", additionalToUpdate.Remark);
        //            command.Parameters.AddWithValue("Valor", additionalToUpdate.Price);
        //            command.Parameters.AddWithValue("Situacao", (int)additionalToUpdate.AdditionalStatus);
        //            command.Parameters.AddWithValue("DataAlteracao", additionalToUpdate.LastChangeDate);
        //            command.Parameters.AddWithValue("IdUsuarioAlteracao", additionalToUpdate.LastChangeUserId);

        //            //Execute Insert
        //            int insertResult = command.ExecuteNonQuery();

        //            if (insertResult < 1) { returnValue = false; }
        //            else { returnValue = true; }
        //        }
        //        catch (MySqlException ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            dbContext.Close();
        //        }
        //        return returnValue;
        //    }
        //}

        //public bool DeleteAdditional(int additionalToDelete)
        //{
        //    bool returnValue = false;
        //    using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
        //    {
        //        try
        //        {
        //            dbContext.Open();
        //            MySqlCommand command = new MySqlCommand();
        //            command = dbContext.CreateCommand();

        //            //Sql command for Create new register on DB
        //            command.CommandText = @"DELETE from adicional 
        //                                    WHERE Id = @id";
        //            //Insert parameters
        //            command.Parameters.AddWithValue("Id", additionalToDelete);

        //            //Execute Insert
        //            int insertResult = command.ExecuteNonQuery();

        //            if (insertResult < 1) { returnValue = false; }
        //            else { returnValue = true; }
        //        }
        //        catch (MySqlException ex)
        //        {
        //            throw new System.Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            dbContext.Close();
        //        }
        //        return returnValue;
        //    }
        //}

        public int FindNextCode()
        {
            string sql = "Show table status like 'saborpizza';";
            return _dbFunctions.FindNextCode(sql);
        }
    }
}
