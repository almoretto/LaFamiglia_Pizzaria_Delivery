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

                    if (status != Status.Todos) { query += " WHERE Situacao = @status"; }

                    if (!term.Trim().Equals(string.Empty))
                    {
                        if (status == Status.Todos)
                        {
                            query += " WHERE ";
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

                    if (status != Status.Todos) 
                    { 
                        command.Parameters.AddWithValue("status", (int)status); 
                    }

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        EntityViewClient newEntity = new EntityViewClient();
                        newEntity.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        newEntity.Name = dataReader["Nome"].ToString();
                          
                        if (dataReader["Telefone"] != null
                           &&
                           dataReader["Telefone"].ToString() != string.Empty)
                        {
                            newEntity.Phone = Convert
                                .ToInt64(dataReader["Telefone"])
                                .ToString("(##) ####-####");
                        }

                        if (dataReader["Celular"] != null
                            &&
                            dataReader["Celular"].ToString() != string.Empty)
                        {
                            newEntity.CellPhone = Convert
                                .ToInt64(dataReader["Celular"])
                                .ToString("(##) # ####-####");
                        }
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

        public Client FindClientFullEntity(int id)
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
        
        public Client FindClientByContact(long contact)
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
                    command.CommandText = @"select * from cliente 
                                                     where 
                                                        Telefone LIKE @NumeroContato
                                                     OR
                                                        Celular LIKE @NumeroContato
                                                     LIMIT 1;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("NumeroContato", contact);

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

        public bool EditClient(Client clientToEdit)
        {
            bool success = false;
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                MySqlTransaction clientTransact = null;
                int queryResult = 0;

                try
                {
                    dbContext.Open();

                    #region --== creation of a trasaction on db ==--
                    clientTransact = dbContext.BeginTransaction();
                    MySqlCommand sqlCommand = new MySqlCommand();
                    sqlCommand.Connection = dbContext;
                    sqlCommand.Transaction = clientTransact;
                    #endregion


                    #region --== Client Edit ==--
                    sqlCommand.CommandText = @"Update cliente
                                                    SET     
                                                         Nome = @Nome, 
                                                         Telefone = @Telefone,
                                                         Celular = @Celular, 
                                                         Situacao = @Situacao, 
                                                         DataAlteracao = @DataAlteracao,
                                                         IdUsuarioAlteracao =  @IdUsuarioAlteracao
                                                    Where 
                                                         Id = @Id;";

                    sqlCommand.Parameters.AddWithValue("Id", clientToEdit.Id);
                    sqlCommand.Parameters.AddWithValue("Nome", clientToEdit.Name);
                    sqlCommand.Parameters.AddWithValue("Telefone", clientToEdit.Phone);
                    sqlCommand.Parameters.AddWithValue("Celular", clientToEdit.CellPhone);
                    sqlCommand.Parameters.AddWithValue("Situacao", (int)clientToEdit.Status);
                    sqlCommand.Parameters.AddWithValue("DataAlteracao", clientToEdit.LastChangeDateTime);
                    sqlCommand.Parameters.AddWithValue("IdUsuarioAlteracao", clientToEdit.LastChangeUserId);

                    queryResult = sqlCommand.ExecuteNonQuery();
                    if (queryResult < 1)
                    {
                        success = false;
                        return success;
                    }
                    sqlCommand.CommandText = string.Empty;
                    sqlCommand.Parameters.Clear();
                    #endregion


                    #region --== Addresses Edit ==--
                    foreach (Address address in clientToEdit.Addresses)
                    {
                        address.Client = clientToEdit;

                        sqlCommand.CommandText = @"Update endereco
                                                    SET                                                        
                                                       IdCliente = @IdCliente,
                                                       Logradouro = @Logradouro, 
                                                       Numero = @Numero, 
                                                       Complemento = @Complemento, 
                                                       Bairro = @Bairro, 
                                                       Cidade =  @Cidade
                                                    Where Id = @Id 
                                                      And IdCliente = @IdCliente";

                        sqlCommand.Parameters.AddWithValue("Id", address.Id);
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


                            sqlCommand.CommandText = @"Update enderecopadrao
                                                       SET IdEndereco = @IdEndereco
                                                       Where IdCliente = @IdCliente;";

                            sqlCommand.Parameters.AddWithValue("IdEndereco", address.Id);
                            sqlCommand.Parameters.AddWithValue("IdCliente", address.Client.Id);


                            queryResult = sqlCommand.ExecuteNonQuery();
                        }

                        if (queryResult < 1)
                        {
                            success = false;
                            return success;
                        }
                        sqlCommand.CommandText = string.Empty;
                        sqlCommand.Parameters.Clear();
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
                    if (success)
                    {
                        clientTransact.Commit();
                    }
                    else
                    {
                        clientTransact.Rollback();
                    }
                    dbContext.Close();
                }
            }
            return success;
        }

        public bool DeleteClient(Client clientToDelete)
        {
            bool success = false;
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                MySqlTransaction clientTransact = null;
                int queryResult = 0;

                try
                {
                    dbContext.Open();

                    #region --== creation of a trasaction on db ==--
                    clientTransact = dbContext.BeginTransaction();
                    MySqlCommand sqlCommand = new MySqlCommand();
                    sqlCommand.Connection = dbContext;
                    sqlCommand.Transaction = clientTransact;
                    #endregion
                    
                    
                    #region --== Addresses Delete ==--
                    foreach (Address address in clientToDelete.Addresses)
                    {
                        if (address.DeliveryAddress)
                        {
                            sqlCommand.CommandText = @"Delete from enderecopadrao
                                                       Where IdCliente = @IdCliente;";

                            sqlCommand.Parameters.AddWithValue("IdCliente", clientToDelete.Id);

                            queryResult = sqlCommand.ExecuteNonQuery();
                        }
                        sqlCommand.CommandText = string.Empty;
                        sqlCommand.Parameters.Clear();

                        if (queryResult < 1)
                        {
                            success = false;
                            return success;
                        }
                        
                        sqlCommand.CommandText = @"Delete from endereco
                                                    Where IdCliente = @IdCliente";

                        sqlCommand.Parameters.AddWithValue("IdCliente", clientToDelete.Id);

                        queryResult = sqlCommand.ExecuteNonQuery();

                        if (queryResult < 1)
                        {
                            success = false;
                            return success;
                        }
                        sqlCommand.CommandText = string.Empty;
                        sqlCommand.Parameters.Clear();
                    }

                    #endregion


                    #region --== Client Delete ==--
                    sqlCommand.CommandText = @"Delete from cliente
                                                   Where Id = @Id;";

                    sqlCommand.Parameters.AddWithValue("Id", clientToDelete.Id);

                    queryResult = sqlCommand.ExecuteNonQuery();
                    
                    if (queryResult < 1)
                    {
                        success = false;
                        return success;
                    }

                    sqlCommand.CommandText = string.Empty;
                    sqlCommand.Parameters.Clear();
                    
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
                    if (success)
                    {
                        clientTransact.Commit();
                    }
                    else
                    {
                        clientTransact.Rollback();
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
