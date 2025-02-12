using ClapBomb.Models.Rankings;

namespace ClapBomb.Components.Pages;

public partial class Standings
{
    StandingsRoot standing;
    string errorString;

    protected override async Task OnInitializedAsync()
    {
        // Longer way of sending requests
        // var request = new HttpRequestMessage(HttpMethod.Get, "https://api-web.nhle.com/v1/standings/now");

        // var client = _clientFactory.CreateClient();

        // HttpResponseMessage response = await client.SendAsync(request);

        // if (response.IsSuccessStatusCode)
        // {
        //     standing = await response.Content.ReadFromJsonAsync<StandingsRoot>();
        //     errorString = null;
        // }
        // else
        // {
        //     errorString = $"There was an error getting our standings: {response.ReasonPhrase}";
        // }

        standing = await teamService.GetStandings();
        errorString = teamService.errorString;

        // Shorter way of sending requests
        // var client = _clientFactory.CreateClient("NHLWebAPI");

        // try
        // {
        //     standing = await client.GetFromJsonAsync<StandingsRoot>("v1/standings/now");
        //     errorString = null;
        // }
        // catch (Exception ex)
        // {
        //     errorString = $"There was an error getting our standings: { ex.Message }";
        // }
    }

}