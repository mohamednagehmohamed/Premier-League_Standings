using allLeagues.Shared.DTOS;
using allLeagues.Shared.Services;
using Microsoft.AspNetCore.Components;
using System.Globalization;

namespace allLeagues.Client.Pages
{
    public partial class Index
    {
        #region Injects
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IMatchService matchService { get; set; }

        #endregion

        #region Properties
        public PremierleagueResponse premierleague { get; set; } = new();
        public List<StandingDto> Standings { get; set; } = new();
        public List<TableDto> tableDtos { get; set; } = new();
        public TableDto tableDto { get; set; } = new();
        private string Searchteam = "";
        private int numberofGoals = 0;
        private int points = 0;
        private int PalyedGames = 0;
        #endregion
        #region overrides

        protected override async Task OnInitializedAsync()
        {
            premierleague = await matchService.GetStandingsToPremierleague();
            for (int i = 0; i < premierleague.standings.Count; i++)
            {
                tableDtos = premierleague.standings[i].table;
                for (int j = 0; j < tableDtos.Count; j++)
                {
                    tableDto = tableDtos[j];
                }
            }
            numberofGoals = tableDtos.Sum(x => x.goalsFor);
            points = tableDtos.Sum(x => x.points);
            PalyedGames = tableDtos.Sum(x => x.playedGames);

            await base.OnInitializedAsync();
        }
        #endregion
        #region Actions
        private void GototoTeam() 
        {
            navigationManager.NavigateTo("Team");
        }
        #endregion
    }
}
