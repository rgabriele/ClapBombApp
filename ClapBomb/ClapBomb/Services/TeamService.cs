using ClapBomb.Models.Rankings;
using ClapBomb.Models.Roster;

namespace ClapBomb.Services
{
    public class TeamService
    {
        StandingsRoot standing;
        RosterRoot roster;
        HttpClient webApiClient = new HttpClient();
        HttpClient nhlStatsApiClient = new HttpClient();
        public string errorString { get; private set; }
        public TeamService()
        {
            webApiClient.BaseAddress = new Uri("https://api-web.nhle.com/");
            nhlStatsApiClient.BaseAddress = new Uri("https://api.nhle.com/stats/rest/");
        }
        public async Task<StandingsRoot> GetStandings()
        {
            try
            {
                standing = await webApiClient.GetFromJsonAsync<StandingsRoot>("v1/standings/now");
                errorString = null;
                return standing;
            }
            catch (Exception ex)
            {
                errorString = $"There was an error getting our standings: {ex.Message}";
            }
            return null;
        }

        public async Task<RosterRoot> GetRoster(string teamAbbreviation, string season)
        {
            try
            {
                roster = await webApiClient.GetFromJsonAsync<RosterRoot>($"v1/roster/{teamAbbreviation}/{season}");
                errorString = null;
                return roster;
            }
            catch (Exception ex)
            {
                errorString = $"There was an error getting the roster: {ex.Message}";
            }
            return null;
        }
    }
}
