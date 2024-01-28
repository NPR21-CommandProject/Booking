using BookingWinForm.Data;
using BookingWinForm.Data.Entities;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserEntity entity = new UserEntity()
            {
                FirstName = "Котик",
                LastName = "Рижик",
                Email = "kotyk@gmail.com",
                Password = "123456",
                DateCreated = DateTime.Now,
                Phone = "+380 97 123 45 67"
            };

            BookingContext context = new BookingContext();  
            context.Users.Add(entity);
            context.SaveChanges();

        }
    }
}
