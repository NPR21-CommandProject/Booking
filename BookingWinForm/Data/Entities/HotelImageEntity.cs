using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace BookingWinForm.Data.Entities
{
    [Table("tblHotelImage")]
    public class HotelImageEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public short Priority { get; set; }


    }
}
