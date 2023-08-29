using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using allLeagues.Shared.DTOS;
using allLeagues.Shared.Teams;

namespace allLeagues.Shared.Services
{
    public class MatchService : IMatchService
    {
        private readonly HttpClient httpClient;

        public MatchService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            httpClient.DefaultRequestHeaders.Add("X-Auth-Token", "ec2f44858f7349da9aef87cdf3debb94");
        }

        //public async Task<MatchTimingss> GetMAtches()
        //{
        //    return await httpClient.GetFromJsonAsync<MatchTimingss>("http://api.football-data.org/v4/competitions/PL/matches?matchday=1");
        //}

        //public async Task<List<ResultResponseDto>> GetStandings()
        //{
        //  return  await httpClient.GetFromJsonAsync<List<ResultResponseDto>>("https://apiv3.apifootball.com/?action=get_standings&league_id=152&APIkey=924e72873225a840e1729b78f27249d88dc4bf301ef9bb310361083125e0cba6");
        //}

        public async Task<PremierleagueResponse> GetStandingsToPremierleague()
        {
            return await httpClient.GetFromJsonAsync<PremierleagueResponse>("https://api.football-data.org/v4/competitions/PL/standings?season=2022");
        }

        public async Task<ResultTeam> GetTeam(int id)
        {
            return await httpClient.GetFromJsonAsync<ResultTeam>($"https://api.football-data.org/v4/teams/{id}");
        }
    }
}
