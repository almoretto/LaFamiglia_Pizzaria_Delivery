using DataContext.Modules;
using Entities.Enums;
using Entities.People;
using Entities.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataContext.People
{
    public class SvcClientDb
    {
        private readonly DbFunctions _dbFunctions = new DbFunctions();
        public List<EntityViewClient> GetEntityViewClient(Status status, string term)
        {
            List<EntityViewClient> entityList = new List<EntityViewClient>();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    string query = @"Select Id, Nome, Telefone, Celular From cliente";

                    if (status != Status.Todos) { query += " Where situacao = @status"; }

                    if (!term.Trim().Equals(string.Empty))
                    {
                        if (status == Status.Todos)
                        {
                            query += " Where ";
                        }
                        else
                        {
                            query += " AND ";
                        }

                        var searchTerms = term.Split(' ');

                        foreach (var item in searchTerms)
                        {
                            query += " nome LIKE '%" + item + "%' AND";
                        }
                        query = query.Substring(0, query.Length - 3);
                    }

                    command.CommandText = query;

                    if (status != Status.Todos) { command.Parameters.AddWithValue("situacao", (int)status); }

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        EntityViewClient newEntity = new EntityViewClient
                        {
                            Id = Convert.ToInt32(dataReader["Id"].ToString()),
                            Name = dataReader["Nome"].ToString(),
                            Phone = Convert.ToInt64(dataReader["Telefone"]).ToString("(##) ####-####"),
                            CellPhone = Convert.ToInt64(dataReader["Celular"]).ToString("(##) # ####-####"),
                        };

                        entityList.Add(newEntity);
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
            return entityList;
        }

        public Client FindById(int id)
        {
            Client clientFounded = new Client();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = "select * from cliente where id = @codigo;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("codigo", id);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        clientFounded.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        clientFounded.Name = dataReader["Nome"].ToString();

                        if (dataReader["Telefone"] != null 
                            &&
                            dataReader["Telefone"].ToString() != string.Empty)
                        {
                            clientFounded.Phone = Convert
                                .ToInt64(dataReader["Telefone"].ToString());
                        }

                        if (dataReader["Celular"] != null 
                            &&
                            dataReader["Celular"].ToString() != string.Empty)
                        {
                            clientFounded.CellPhone = Convert
                                .ToInt64(dataReader["Celular"].ToString());
                        }

                        clientFounded.Status = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        clientFounded.LastChangeDateTime = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        clientFounded.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());

                        clientFounded.Addresses = new SvcAddressDb().FindByClientId(clientFounded.Id);
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
            return clientFounded;
        }

        public Client FindClientById(int id)
        {
            Client clientFounded = new Client();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = "select * from cliente where id = @codigo;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("codigo", id);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        clientFounded.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        clientFounded.Name = dataReader["Nome"].ToString();
                        
                        //Other way to make the same test as above method
                        if (!(dataReader["Telefone"] is DBNull))
                        {
                            clientFounded.Phone = Convert
                                .ToInt64(dataReader["Telefone"].ToString());
                        }

                        //Other way to make the same test as above method
                        if (!(dataReader["Celular"] is DBNull))
                        {
                            clientFounded.CellPhone = Convert
                                .ToInt64(dataReader["Celular"].ToString());
                        }

                        clientFounded.Status = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        clientFounded.LastChangeDateTime = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        clientFounded.LastChangeUserId = Convert.ToInt32(dataReader["IdUsuarioAlteracao"].ToString());
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
            return clientFounded;
        }

        public bool CreateClient(Client clientToCreate)
        {
            bool success = false;
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                MySqlTransaction clientTransact = null;
                int queryResult = 0;
                int clientId = 0;
                int addressId = 0;
                try
                {
                    dbContext.Open();

                    #region --== creation of a trasaction on db ==--
                    clientTransact = dbContext.BeginTransaction();
                    MySqlCommand sqlCommand = new MySqlCommand();
                    sqlCommand.Connection = dbContext;
                    sqlCommand.Transaction = clientTransact;
                    #endregion


                    #region --== Client Insert ==--
                    sqlCommand.CommandText = @"insert into cliente
                                                 (Nome, 
                                                  Telefone, 
                                                  Celular, 
                                                  Situacao, 
                                                  DataAlteracao, 
                                                  IdUsuarioAlteracao) 
                                               values
                                                 (@Nome, 
                                                  @Telefone, 
                                                  @Celular, 
                                                  @Situacao, 
                                                  @DataAlteracao, 
                                                  @IdUsuarioAlteracao);";

                    sqlCommand.Parameters.AddWithValue("Nome", clientToCreate.Name);
                    sqlCommand.Parameters.AddWithValue("Telefone", clientToCreate.Phone);
                    sqlCommand.Parameters.AddWithValue("Celular", clientToCreate.CellPhone);
                    sqlCommand.Parameters.AddWithValue("Situacao", (int)clientToCreate.Status);
                    sqlCommand.Parameters.AddWithValue("DataAlteracao", clientToCreate.LastChangeDateTime);
                    sqlCommand.Parameters.AddWithValue("IdUsuarioAlteracao", clientToCreate.LastChangeUserId);

                    queryResult = sqlCommand.ExecuteNonQuery();
                    if (queryResult < 1)
                    {
                        success = false;
                        return success;
                    }
                    sqlCommand.CommandText = string.Empty;
                    sqlCommand.Parameters.Clear();
                    #endregion


                    #region --== Find ClientId ==--
                    sqlCommand.CommandText = @"Select Distinct 
                                                    Id 
                                               From cliente 
                                               Where Lower(Nome)=@Name;";

                    sqlCommand.Parameters.AddWithValue("Name", clientToCreate.Name.ToLower());

                    using (MySqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            clientId = Convert.ToInt32(dataReader["Id"].ToString());
                        }
                    }
                    sqlCommand.CommandText = string.Empty;
                    sqlCommand.Parameters.Clear();
                    clientToCreate.Id = clientId;
                    #endregion


                    #region --== Addresses Insert ==--
                    foreach (Address address in clientToCreate.Addresses)
                    {
                        address.Client = clientToCreate;

                        sqlCommand.CommandText = @"Insert Into endereco
                                                        (IdCliente,
                                                         Logradouro, 
                                                         Numero, 
                                                         Complemento, 
                                                         Bairro, 
                                                         Cidade)
                                                   Values
                                                        (@IdCliente,
                                                         @Logradouro, 
                                                         @Numero, 
                                                         @Complemento, 
                                                         @Bairro, 
                                                         @Cidade);";

                        sqlCommand.Parameters.AddWithValue("IdCliente", address.Client.Id);
                        sqlCommand.Parameters.AddWithValue("Logradouro", address.Adrress);
                        sqlCommand.Parameters.AddWithValue("Numero", address.Number);
                        sqlCommand.Parameters.AddWithValue("Complemento", address.Address2nd);
                        sqlCommand.Parameters.AddWithValue("Bairro", address.District);
                        sqlCommand.Parameters.AddWithValue("Cidade", address.City);

                        queryResult = sqlCommand.ExecuteNonQuery();

                        if (queryResult < 1)
                        {
                            success = false;
                            return success;
                        }
                        sqlCommand.CommandText = string.Empty;
                        sqlCommand.Parameters.Clear();

                        if (address.DeliveryAddress)
                        {
                            sqlCommand.CommandText = "Show table status like 'endereco';";
                            //Get Last Address Inserted
                            using (MySqlDataReader dataReader = sqlCommand.ExecuteReader())
                            {
                                while (dataReader.Read())
                                {
                                    addressId = Convert.ToInt32(dataReader["Auto_increment"].ToString());

                                }
                                addressId -= 1;
                            }
                            sqlCommand.CommandText = string.Empty;
                            sqlCommand.Parameters.Clear();

                            //Insert delivery address table relation

                            sqlCommand.CommandText = @"Insert into enderecopadrao
                                                            (IdCliente, IdEndereco)
                                                       Values
                                                            (@IdCliente, @IdEndereco);";

                            sqlCommand.Parameters.AddWithValue("IdCliente", address.Client.Id);
                            sqlCommand.Parameters.AddWithValue("IdEndereco", addressId);

                            queryResult = sqlCommand.ExecuteNonQuery();
                            
                            if (queryResult < 1)
                            {
                                success = false;
                                return success;
                            }
                            sqlCommand.CommandText = string.Empty;
                            sqlCommand.Parameters.Clear();
                        }

                    }
                    #endregion

                    success = true;
                }
                catch (MySqlException ex)
                {
                    success = false;
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show(ex.InnerException.Message,
                       "MySql Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (!success)
                    {
                        clientTransact.Rollback();
                    }
                    else
                    {
                        clientTransact.Commit();
                    }
                    dbContext.Close();
                }
            }
            return success;
        }

        public int FindNextCode()
        {
            string sql = "Show table status like 'cliente';";
            return _dbFunctions.FindNextCode(sql);
        }
    }
}
