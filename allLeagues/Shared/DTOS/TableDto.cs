﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MudBlazor.Colors;

namespace allLeagues.Shared.DTOS
{
    public class TableDto
    {
        public int position { get; set; }
        public TeamDto team { get; set; }
        public int playedGames { get; set; }
        public string form { get; set; }
        public int won { get; set; }
        public int draw { get; set; }
        public int lost { get; set; }
        public int points { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifference { get; set; }
    }
}
