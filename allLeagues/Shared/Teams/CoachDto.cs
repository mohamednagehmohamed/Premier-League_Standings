using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allLeagues.Shared.Teams
{
    public class CoachDto
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
        public ContractDto contract { get; set; }
    }
}
