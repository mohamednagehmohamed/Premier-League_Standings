using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allLeagues.Shared.DTOS
{
    public class TeamDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string tla { get; set; }
        public string crest { get; set; }
    }
}
