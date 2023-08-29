using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using allLeagues.Shared.DTOS;
using allLeagues.Shared.Teams;

namespace allLeagues.Shared.Services
{
    public interface IMatchService
    {
        //Task<List<ResultResponseDto>> GetStandings();
        Task<PremierleagueResponse> GetStandingsToPremierleague();
        Task<ResultTeam> GetTeam(int id);
        //Task<MatchTimingss> GetMAtches();
    }
}
