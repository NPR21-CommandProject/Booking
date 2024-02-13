using BookingWinForm.FormsBooking;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BookingWinForm.Services
{
    internal class UserManager
    {
        private readonly SqlConnection _con;
        public UserManager()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());

            string conStr = $"Data Source=20.65.144.204;User ID=kaban;Password=9[nV`e7VN`0%;Initial Catalog=Booking;MultipleActiveResultSets=true;trustServerCertificate=true";
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

        private bool IsExistUser(string email, string pass)
        {

            string query = $"SELECT COUNT(*) FROM tblUsers WHERE Email = '{email}' AND Password = '{pass}'";
            SqlCommand command = new SqlCommand(query, _con);
            int tableCount = (int)command.ExecuteScalar();
            if (tableCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoginUser(string email, string pass)
        {
            var isExist = IsExistUser(email, pass);
            if (isExist) 
            {
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else if (!isExist)
            {
                MessageBox.Show("Користувача з такою поштою та паролем не знайдено");
            }
            else
            {
                MessageBox.Show("Script Error!!!");
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
