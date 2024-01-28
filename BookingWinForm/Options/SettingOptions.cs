using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingWinForm.Options
{
    public class ConnectionStrings
    {
        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }

    public class SettingOptions
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }
}
