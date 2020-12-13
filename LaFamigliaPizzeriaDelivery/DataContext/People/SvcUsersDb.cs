using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Entities.People;
using Entities.Enums;
using System;

namespace DataContext.People
{
    public class SvcUsersDb
    {
        public List<User> GetUsers()
        {
            List<User> usersList = new List<User>();
            using(MySqlConnection dbContext = DbContext.GetInstance().GetConnection())
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
                        User newUser = new User();
                        newUser.Id = Convert.ToInt32(dataReader["Id"].ToString());
                        newUser.UserType = new UserType(Convert.ToInt32(dataReader["Id_TipoUsuario"].ToString()), string.Empty);
                        newUser.Name = dataReader["Nome"].ToString();
                        newUser.Login = dataReader["Login"].ToString();
                        newUser.Password = dataReader["Senha"].ToString();
                        newUser.UserStatus = (Status)Convert.ToInt32(dataReader["Situacao"]);
                        newUser.LastChangeDate = Convert.ToDateTime(dataReader["DataAlteracao"].ToString());
                        newUser.LastChangeUserId = Convert.ToInt32(dataReader["Id_Usuario_Alteracao"].ToString());

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
