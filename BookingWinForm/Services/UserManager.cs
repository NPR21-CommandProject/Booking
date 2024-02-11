using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingWinForm.Services
{
    internal class UserManager
    {
        private readonly SqlConnection _con;
        public UserManager()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());

            string conStr = $"Data Source=20.65.144.204;User ID=kaban;Password=9[nV`e7VN`0%;Initial Catalog=Booking;MultipleActiveResultSets=true;";
            try
            {
                _con = new SqlConnection(conStr);
                _con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення!!! " + ex.Message);
            }
        }

        public void RegisterUser(string e, string pass, string phone, string lastN, string firstN, DateTime date)
        {
            try
            {
                string sql = "INSERT INTO tblUsers (Email, Phone, FirstName, LastName, Password, DateCreated) " +
                             "VALUES (@Email, @Phone, @FirstName, @LastName, @Password, @DateCreated);";

                SqlCommand sqlCommand = new SqlCommand(sql, _con);
                sqlCommand.Parameters.AddWithValue("@Email", e);
                sqlCommand.Parameters.AddWithValue("@Phone", phone);
                sqlCommand.Parameters.AddWithValue("@FirstName", firstN);
                sqlCommand.Parameters.AddWithValue("@LastName", lastN);
                sqlCommand.Parameters.AddWithValue("@Password", pass);
                sqlCommand.Parameters.AddWithValue("@DateCreated", date);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка додавання користувача!!! " + ex.Message);
            }
        }
    }
}
