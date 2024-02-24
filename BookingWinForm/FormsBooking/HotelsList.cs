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
            dgvHotelsList.Rows.Add(" "); ///  тест -змінити
        }
    }
}
