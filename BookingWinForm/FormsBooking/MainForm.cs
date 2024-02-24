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

        private void ViewProfileStrip_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm();
            form.ShowDialog();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_load(object sender, EventArgs e)
        {

        }

        private void btnUserSearch_main_Click(object sender, EventArgs e)
        {
            // процедура пошуку користувача
            // Створити екземпляр форми HotelsList
            var hotelsListForm = new HotelsList();

            // Відобразити форму
            hotelsListForm.Show();
        }

        private void btnShowAllHotels_main_Click(object sender, EventArgs e)
        {
            // Створити екземпляр форми HotelsList
            var hotelsListForm = new HotelsList();

            // Відобразити форму
            hotelsListForm.Show();
        }
    }
}
