﻿using BookingWinForm.Data.Entities;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserEntity user = new UserEntity();
            user.Email = txtUserEmail.Text;
            user.Password = txtPassword.Text;
            
            UserManager manager = new UserManager();
            manager.LoginUser(user.Email, user.Password);
        }
    }
}
