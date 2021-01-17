using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Entities.People;
using Entities.Enums;
using System;
using Entities.Views;
using DataContext.Modules;

namespace DataContext.People
{
    public class SvcUsersDb
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

                    string query = @"Select Id, Nome, Situacao From usuario";

                    if (status != Status.Todos) { query += " Where situacao = @status;"; }
                    else { query += ";"; }

                    command.CommandText = query;

                    if (status != Status.Todos) { command.Parameters.AddWithValue("situacao", (int)status); }


                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        EntityViewSearch newEntity = new EntityViewSearch
                        {
                            Id = Convert.ToInt32(dataReader["Id"].ToString()),
                            Description = dataReader["Nome"].ToString(),
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

        public List<User> GetActiveUsers()
        {
            List<User> usersList = new List<User>();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();
                    command.CommandText = "select * from usuario where Situacao=1;";

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        User newUser = new User
                        {
                            Id = Convert.ToInt32(dataReader["Id"].ToString()),
                            UserType = new UserType(Convert.ToInt32(dataReader["Id_TipoUsuario"].ToString()), string.Empty),
                            Name = dataReader["Nome"].ToString(),
                            Login = dataReader["Login"].ToString(),
                            Password = dataReader["Senha"].ToString(),
                            UserStatus = (Status)Convert.ToInt32(dataReader["Situacao"]),
                            LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString()),
                            LastChangeUserId = Convert.ToInt32(dataReader["Id_Usuario_Alteracao"].ToString())
                        };

                        usersList.Add(newUser);
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
            return usersList;
        }

        public User FindById(int id)
        {
            User userFounded = new User();
            using (MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
            {
                try
                {
                    dbContext.Open();
                    MySqlCommand command = new MySqlCommand();
                    command = dbContext.CreateCommand();

                    //Sql command
                    command.CommandText = "select * from usuario where id = @Id;";
                    //Sql Parameter
                    command.Parameters.AddWithValue("Id", id);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        userFounded.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        userFounded.UserType = new UserType(Convert.ToInt32(dataReader["Id_TipoUsuario"].ToString()), string.Empty);
                        userFounded.Name = dataReader["Nome"].ToString();
                        userFounded.Login = dataReader["Login"].ToString();
                        userFounded.Password = dataReader["Senha"].ToString();
                        userFounded.UserStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        userFounded.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        userFounded.LastChangeUserId = Convert.ToInt32(dataReader["Id_Usuario_Alteracao"].ToString());
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
            return userFounded;
        }
        
        public bool CreateUser(User newUser)
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
                                            usuario(Id_TipoUsuario, 
                                                    Nome, 
                                                    Login, 
                                                    Senha, 
                                                    Situacao, 
                                                    DataAlteracao, 
                                                    Id_Usuario_Alteracao)
                                            values (@Id_TipoUsuario,
                                                    @Nome, 
                                                    @Login, 
                                                    @Senha,     
                                                    @Situacao, 
                                                    Now(),  
                                                    @Id_Usuario_Alteracao);";
                    //Insert parameters
                    command.Parameters.AddWithValue("Id_TipoUsuario", newUser.UserType.Id);
                    command.Parameters.AddWithValue("Nome", newUser.Name);
                    command.Parameters.AddWithValue("Login", newUser.Login);
                    command.Parameters.AddWithValue("Senha", newUser.Password);
                    command.Parameters.AddWithValue("Situacao", (int)newUser.UserStatus);
                    command.Parameters.AddWithValue("Id_Usuario_Alteracao", newUser.LastChangeUserId);

                    //Execute Insert
                    int insertResult = command.ExecuteNonQuery();

                    if (insertResult < 1) { returnValue = false; }
                    else { returnValue = true; }
                }
                catch (MySqlException ex)
                {
                    throw new System.Exception(ex.Message);
                }
                finally
                {
                    dbContext.Close();
                }
                return returnValue;
            }
        }

        public bool UpdateUser(User userToUpdate)
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
                    command.CommandText = @"UPDATE usuario SET 
                                            Id_TipoUsuario = @Id_TipoUsuario,
                                            Nome = @Nome, 
                                            Login = @Login, 
                                            Senha = @Senha,
                                            Situacao = @Situacao,
                                            DataAlteracao = Now(),
                                            Id_Usuario_Alteracao = @Id_Usuario_Alteracao
                                            WHERE Id = @id";
                    //Insert parameters
                    command.Parameters.AddWithValue("Id", userToUpdate.Id);
                    command.Parameters.AddWithValue("Id_TipoUsuario", userToUpdate.UserType.Id);
                    command.Parameters.AddWithValue("Nome", userToUpdate.Name);
                    command.Parameters.AddWithValue("Login", userToUpdate.Login);
                    command.Parameters.AddWithValue("Senha", userToUpdate.Password);
                    command.Parameters.AddWithValue("Situacao", (int)userToUpdate.UserStatus);
                    command.Parameters.AddWithValue("Id_Usuario_Alteracao", userToUpdate.LastChangeUserId);

                    //Execute Insert
                    int insertResult = command.ExecuteNonQuery();

                    if (insertResult < 1) { returnValue = false; }
                    else { returnValue = true; }
                }
                catch (MySqlException ex)
                {
                    throw new System.Exception(ex.Message);
                }
                finally
                {
                    dbContext.Close();
                }
                return returnValue;
            }
        }

        public bool DeleteUser(User userToDelete)
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
                    command.CommandText = @"DELETE from usuario 
                                            WHERE Id = @id";
                    //Insert parameters
                    command.Parameters.AddWithValue("Id", userToDelete.Id);

                    //Execute Insert
                    int insertResult = command.ExecuteNonQuery();

                    if (insertResult < 1) { returnValue = false; }
                    else { returnValue = true; }
                }
                catch (MySqlException ex)
                {
                    throw new System.Exception(ex.Message);
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
            string sql = "Show table status like 'usuario';";
            return _dbFunctions.FindNextCode(sql, "usuario");
        }
    }
}

