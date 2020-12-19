using Entities.People;
using MySql.Data.MySqlClient;
using System;

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
    }
}
