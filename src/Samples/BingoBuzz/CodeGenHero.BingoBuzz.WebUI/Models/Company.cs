using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.WebUI.Models
{
    public class Company
    {

        public string CompanyId { get; set; }
        public string Name { get; set; }

        public List<User> CompanyDirectory { get; set; }

    }
}
