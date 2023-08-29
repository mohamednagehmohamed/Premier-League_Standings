using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allLeagues.Shared.Teams
{
    public class ResultTeam
    {
        public AreaDto area { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string tla { get; set; }
        public string crest { get; set; }
        public string address { get; set; }
        public string website { get; set; }
        public int founded { get; set; }
        public string clubColors { get; set; }
        public string venue { get; set; }
        public List<RunningcompetitionDto> runningCompetitions { get; set; }
        public CoachDto coach { get; set; }
        public List<SquadDto> squad { get; set; }
        public object[] staff { get; set; }
        public DateTime lastUpdated { get; set; }
    }
}
