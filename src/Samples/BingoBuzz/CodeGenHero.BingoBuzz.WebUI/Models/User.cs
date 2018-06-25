using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.WebUI.Models
{
    public class User
    {

        public string UserId { get; set; }
        public string Fullname { get; set; }

        public int? Stats_Games { get; set; }

        public int? Stats_Bingos { get; set; }

        public int? Stats_Clicks { get; set; }

        public Company Company { get; set; }

    }
}
