using ClapBomb.Models.Roster;
using Microsoft.AspNetCore.Components;

namespace ClapBomb.Components.Pages;

public partial class Team
{
    [Parameter] public String? teamAbbreviation { get; set; }
    RosterRoot roster;
    string errorString;

    protected override async Task OnInitializedAsync()
    {
        string season = GetSeason();

        roster = await teamService.GetRoster(teamAbbreviation, season);
        errorString = teamService.errorString;
        // var client = _clientFactory.CreateClient("NHLWebAPI");

        // try
        // {
        //     roster = await client.GetFromJsonAsync<RosterRoot>($"v1/roster/{teamAbbreviation}/{season}");
        //     errorString = null;
        // }
        // catch (Exception ex)
        // {
        //     errorString = $"There was an error getting the roster: {ex.Message}";
        // }
    }

    /// <summary>
    /// Gets the current season.
    /// </summary>
    /// <returns>A string of the current season in XXXXYYYY format.</returns>
    private string GetSeason()
    {
        int currentMonth = DateTime.Now.Month;
        int currentYear = DateTime.Now.Year;
        var season = "";

        if (currentMonth >= 10 && currentMonth <= 12)
        {
            season = currentYear.ToString() + (currentYear + 1).ToString();
        }
        else if (currentMonth >= 1 && currentMonth <= 6)
        {
            season = (currentYear - 1).ToString() + (currentYear);
        }

        return season;
    }

    /// <summary>
    /// Gets the position of forwards.
    /// </summary>
    /// <param name="positionCode">The unformatted position of the forward.</param>
    /// <returns>The position of the forward. Formats wingers accordingly - L => LW and R => RW.</returns>
    private string GetForwardPosition(string positionCode)
    {
        if (positionCode == "C")
        {
            return "C";
        }
        else if (positionCode == "L")
        {
            return "LW";
        }
        else
        {
            return "RW";
        }
    }

    /// <summary>
    /// Gets the position of defenseman according to handedness.
    /// </summary>
    /// <param name="handedness"> The handedness of the player - Left or right shot.</param>
    /// <returns>The position of the defenseman.</returns>
    private string GetDmanPosition(string handedness)
    {
        if (handedness == "L")
        {
            return "LD";
        }
        else
        {
            return "RD";
        }
    }
}