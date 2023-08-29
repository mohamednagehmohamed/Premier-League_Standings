using allLeagues.Shared.DTOS;
using allLeagues.Shared.Services;
using allLeagues.Shared.Teams;
using Microsoft.AspNetCore.Components;

namespace allLeagues.Client.Pages
{
    public partial class TeamPage
    {
        #region Injects
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IMatchService matchService { get; set; }

        #endregion

        #region Properties
        public ResultTeam resultTeam { get; set; } = new();

        #endregion
        #region overrides

        protected override async Task OnInitializedAsync()
        {

            resultTeam = await matchService.GetTeam(65);
            await base.OnInitializedAsync();
        }
        #endregion
        #region Actions
        private void GotoStandings() 
        {
            navigationManager.NavigateTo("/");
        }
        #endregion
    }
}
