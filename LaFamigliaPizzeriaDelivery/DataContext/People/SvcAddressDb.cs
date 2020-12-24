using DataContext.Modules;
using Entities.People;
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
            Address addressFound = new Address();
            Client client;
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
                        addressFound.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        client = new SvcClientDb()
                            .FindById(Convert.ToInt32(dataReader["IdCliente"].ToString()));
                        addressFound.Client = client;
                        addressFound.Adrress = dataReader["Logradouro"].ToString();
                        addressFound.Number = Convert.ToInt32(dataReader["Numero"].ToString());

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
                        return Convert.ToInt32(dataReader["Id"].ToString());
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
