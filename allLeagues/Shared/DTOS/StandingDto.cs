using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MudBlazor.CategoryTypes;

namespace allLeagues.Shared.DTOS
{
    public class StandingDto
    {
        public string stage { get; set; }
        public string type { get; set; }
        public object group { get; set; }
        public List<TableDto> table { get; set; }
    }
}
