using Entities.Enums;
using Entities.People;
using Entities.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataContext.People
{
    public class SvcUserTypeDb
    {
        public UserType GetUserType(int id)
        {
            UserType usersType = new UserType();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();
                    command.CommandText = @"select 
                                            U.Id_TipoUsuario as IdUserType,
                                            TU.Descricao as UserType
                                            From usuario as U
                                            Inner JOIN tipousuario as TU on U.Id_TipoUsuario = TU.Id
                                            where U.Id = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        usersType.Id = Convert.ToInt32(dataReader["IdUserType"].ToString());
                        usersType.Description = dataReader["UserType"].ToString();
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
            return usersType;
        }
        
        public UserType GetUserTypeById(int id)
        {
            UserType userType = new UserType();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();

                    command = dbContext.CreateCommand();
                    command.CommandText = @"select * from tipousuario where Id = @id;";
                    command.Parameters.AddWithValue("Id", id);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        userType.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        userType.Description = dataReader["Descricao"].ToString();
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
            return userType;
        }

        public List<EntityViewSearch> GetEntityViewSearch()
        {
            List<EntityViewSearch> entityList = new List<EntityViewSearch>();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    command.CommandText = @"Select Id, Descricao, '1' as situacao 
                                            From tipousuario";

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
                    throw new System.Exception(ex.Message);
                }
                finally
                {
                    dbContext.Close();
                }
            }
            return entityList;
        }
    }
}
