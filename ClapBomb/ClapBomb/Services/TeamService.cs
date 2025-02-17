using ClapBomb.Models.Roster;
using ClapBomb.Models.Standings;

namespace ClapBomb.Services;
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

    /// <summary>
    /// Gets the standings as of the current moment.
    /// </summary>
    /// <returns>The current standings.</returns>
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
            errorString = $"There was an error getting the standings: {ex.Message}";
        }
        return null;
    }

    /// <summary>
    /// Gets the roster of a team.
    /// </summary>
    /// <param name="teamAbbreviation">The team to fetch the roster for.</param>
    /// <param name="season">The season of the roster in YYYYYYYY format, where the first four digits represent the start year of the season,
    /// and the last four digits represent the end year.</param>
    /// <returns></returns>
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
