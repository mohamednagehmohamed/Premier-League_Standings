using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allLeagues.Shared.DTOS
{
    public class PremierleagueResponse
    {
        public FiltersDto filters { get; set; }
        public SeasonDto season { get; set; }
        public List<StandingDto> standings { get; set; }
    }
}
