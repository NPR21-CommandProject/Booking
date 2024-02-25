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
    public partial class HotelsList : Form
    {
        public HotelsList()
        {
            InitializeComponent();
        }

        private void HotelsList_Load(object sender, EventArgs e)
        {
            dgvHotelsList.Rows.Clear();
            dgvHotelsList.Rows.Add(" bbb "); ///  тест -змінити
        }

        private void btnShowHotel_Click(object sender, EventArgs e)
        {
            var showHotelForm = new ShowHotel();
            showHotelForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addNewHotelForm = new AddNewHotel();
            addNewHotelForm.ShowDialog();
        }
    }
}
