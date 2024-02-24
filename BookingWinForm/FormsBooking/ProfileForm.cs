using BookingWinForm.Data.Entities;
using BookingWinForm.Options;
using BookingWinForm.Services;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            LoadUserProfile();
            InitializeComponent();
        }

        private void LoadUserProfile()
        {
            UserManager userManager = new UserManager();
            UserEntity userEntity = new UserEntity();
            userEntity = userManager.FillProfile();
            lblName.Text = userEntity.FirstName;
            lblSurname.Text = userEntity.LastName;
            lblPhone.Text = userEntity.Phone;
            lblEmail.Text = userEntity.Email;
        }
    }
}
