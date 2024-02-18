using BookingWinForm.Data.Entities;
using BookingWinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingWinForm.FormsBooking
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserEntity user = new UserEntity();
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.Phone = txtPhone.Text;
            user.FirstName = txtFirstN.Text;
            user.LastName = txtLastN.Text;
            user.DateCreated = DateTime.Now;
            UserManager userManager = new UserManager();
            userManager.RegisterUser(user.Email, user.Password, user.Phone, user.FirstName, user.LastName, user.DateCreated);
            MessageBox.Show("Аккаунт успішно створено!");
        }
    }
}
