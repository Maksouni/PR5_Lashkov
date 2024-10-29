using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_Lashkov.Model
{
    internal class DbConnector
    {
        private readonly string connectionString = "Persist Security Info=False;" +
            "User ID=makson;" +
            "Password=Passw0rd;" +
            "Initial Catalog=DrinkFactory;" +
            "Server=WIN-N0KOTU5A8JF";


        public User GetUserById(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = $"select u.id, u.login, u.password, u.role_id from Users u " +
                        $"where u.id = {id};";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetInt32(3)
                                );
                            }
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            return null;
        }

        public void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"insert into Users(login, password, role_id) values" +
                    $"('{user.Login}', '{user.Password}', {user.RoleId})";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    } catch (Exception ex) { Console.WriteLine(ex.Message); }
                }
            }
        }
    }
}
