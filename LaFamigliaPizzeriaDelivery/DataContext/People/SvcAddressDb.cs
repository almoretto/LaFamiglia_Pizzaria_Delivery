using DataContext.Modules;
using Entities.Enums;
using Entities.People;
using Entities.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataContext.People
{
    public class SvcAddressDb
    {
        private readonly DbFunctions _dbFunctions = new DbFunctions();

        public List<Address> FindByClientId(int clientId)
        {
            List<Address> listAddress = new List<Address>();

            Client client = new SvcClientDb().FindClientById(clientId);
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = "select * from endereco where IdCliente = @IdCliente;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("IdCliente", clientId);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Address addressFound = new Address();
                        addressFound.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        addressFound.Client = client;
                        addressFound.Adrress = dataReader["Logradouro"].ToString();
                        addressFound.Number = dataReader["Numero"].ToString();

                        if (dataReader["Complemento"] != null)
                        {
                            addressFound.Address2nd = dataReader["Complemento"].ToString();
                        }
                        addressFound.District = dataReader["Bairro"].ToString();
                        addressFound.City = dataReader["Cidade"].ToString();

                        if (addressFound.Id == FindDeliveryAddress(clientId))
                        {//Get the relation of delivery address if equals to actual address id then sets to true.
                            addressFound.DeliveryAddress = true;
                        }
                        else
                        {
                            addressFound.DeliveryAddress = false;
                        }
                        listAddress.Add(addressFound);

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
            return listAddress;
        }

        public Address FindAddressById(int addressId)
        {
            Address addressFound = null;
            Client client = null;

            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = "SELECT * FROM endereco WHERE Id = @Id;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("Id", addressId);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        addressFound = new Address();
                        addressFound.Id = Convert.ToInt32(dataReader["Id"].ToString());

                        client = new SvcClientDb().FindClientById(Convert.ToInt32(dataReader["IdCliente"].ToString()));

                        if (client != null)
                        { addressFound.Client = client; }
                        else
                        { throw new ApplicationException("Cliente não encontrado"); }

                        addressFound.Adrress = dataReader["Logradouro"].ToString();
                        addressFound.Number = dataReader["Numero"].ToString();
                        
                        if (dataReader["Complemento"] != null)//DBNull.Value
                        { addressFound.Address2nd = dataReader["Complemento"].ToString(); }

                        addressFound.District = dataReader["Bairro"].ToString();
                        addressFound.City = dataReader["Cidade"].ToString();

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
            return addressFound;
        }
        public List<EntityViewSearch> GetEntityViewSearch(int idClient)
        {
            List<EntityViewSearch> entityList = new List<EntityViewSearch>();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    string query = @"SELECT Id, 
                                            CONCAT(
                                                    Logradouro,
                                                    ', Nº: ',NUmero,
                                                        IF(Complemento LIKE '' Or NULL,
                                                            CONCAT(''),
                                                            CONCAT(', ',Complemento)),
                                                    ', ',Bairro,
                                                    ', ',Cidade
                                                    ) AS Descricao,
                                            '1' AS Status
                                     FROM endereco 
                                     WHERE IdCliente=@IdCliente;";


                    command.CommandText = query;

                    command.Parameters.AddWithValue("IdCliente", idClient);


                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        EntityViewSearch newEntity = new EntityViewSearch
                        {
                            Id = Convert.ToInt32(dataReader["Id"].ToString()),
                            Description = dataReader["Descricao"].ToString(),
                            Status = (Status)Convert.ToInt32(dataReader["Status"])
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

        public int FindNextCode()
        {
            string sql = "Show table status like 'endereco';";
            return _dbFunctions.FindNextCode(sql);
        }

        public int FindDeliveryAddress(int clientId)
        {
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = @"select IdEndereco from enderecopadrao 
                                            where IdCliente = @IdCliente;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("IdCliente", clientId);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        return Convert.ToInt32(dataReader["IdEndereco"].ToString());
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
            return -1;
        }

    }
}
