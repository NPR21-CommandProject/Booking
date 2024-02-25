using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BookingWinForm.Options;
using BookingWinForm.Data.Entities;
using BookingWinForm.Services;


namespace BookingWinForm.Services
{
    public class UsersDataAccess
    {
        public UsersDataAccess() { }

        //public static List<User> FindUsers(string name, string email, string phone)
        //{
        //    // Підключитися до сервера
        //    using (var connection = new SqlConnection("server=localhost;database=booking;integrated security=True;"))
        //    {
        //        connection.Open();

        //        // Створити SqlCommand
        //        //var cmd = new SqlCommand("SELECT * FROM tblUsers WHERE Name LIKE @name AND Email LIKE @email AND Phone LIKE @phone", connection);
        //        var cmd = new SqlCommand("SELECT * FROM tblUsers WHERE Name LIKE @name", connection);

        //        // Додати параметри
        //        cmd.Parameters.AddWithValue("@name", $"%{name}%");
        //        //cmd.Parameters.AddWithValue("@email", $"%{email}%");
        //        //cmd.Parameters.AddWithValue("@phone", $"%{phone}%");

        //        // Виконати запит
        //        var reader = cmd.ExecuteReader();

        //        // Зчитати результати
        //        var users = new List<User>();
        //        while (reader.Read())
        //        {
        //            users.Add(new User
        //            {
        //                Id = (int)reader["Id"],
        //                Name = (string)reader["Name"],
        //                //Email = (string)reader["Email"],
        //                //Phone = (string)reader["Phone"]
        //            });
        //        }

        //        return users;
        //    }
        //}

        public static UserEntity FindUserByLogin(string login)
        {
            //using (var connection = new SqlConnection(connectionString))
            using (var connection = new SqlConnection("server=localhost;database=booking;integrated security=True;"))
            {
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM tblUsers WHERE Login = @login", connection);
                cmd.Parameters.AddWithValue("@login", login);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new UserEntity
                    {
                        Id = (int)reader["Id"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        Email = (string)reader["Email"],
                        Phone = (string)reader["Phone"]
                    };
                }

                return null;
            }
        }
    }
}
