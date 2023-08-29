using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allLeagues.Shared.Teams
{
    public class SquadDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
    }
}
