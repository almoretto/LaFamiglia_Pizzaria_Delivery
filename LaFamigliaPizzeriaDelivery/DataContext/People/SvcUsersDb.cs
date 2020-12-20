﻿using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Entities.People;
using Entities.Enums;
using System;
using Entities.Views;

namespace DataContext.People
{
    public class SvcUsersDb
    {
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
    }
}