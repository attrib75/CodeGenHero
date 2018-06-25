using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.GameState.Models
{
    public class Company
    {

        public string CompanyId { get; set; }
        public string Name { get; set; }

        public List<User> CompanyDirectory { get; set; }

    }
}
