using ClapBomb.Models.GameLog;
using ClapBomb.Models.GameLogCurrent;
using ClapBomb.Models.PlayerInfo;

namespace ClapBomb.Services;

public class PlayerService
{
    LogRoot gameLog;
    GameLogCurrentRoot gameLogCurrent;
    PlayerRoot playerInfo;
    HttpClient webApiClient = new HttpClient();
    HttpClient nhlStatsApiClient = new HttpClient();

    public PlayerService()
    {
        webApiClient.BaseAddress = new Uri("https://api-web.nhle.com/");
        nhlStatsApiClient.BaseAddress = new Uri("https://api.nhle.com/stats/rest/");
    }

    public string errorString { get; private set; }

    /// <summary>
    /// Gets information for a specific player.
    /// </summary>
    /// <param name="playerId">The id of the player.</param>
    /// <returns></returns>
    public async Task<PlayerRoot> GetPlayerInfo(string playerId)
    {
        try
        {
            playerInfo = await webApiClient.GetFromJsonAsync<PlayerRoot>($"v1/player/{playerId}/landing");
            errorString = null;
            return playerInfo;
        }
        catch (Exception ex)
        {
            errorString = $"There was an error getting the player information: {ex.Message}";
        }
        return null;
    }

    /// <summary>
    /// Gets the game log of a player.
    /// </summary>
    /// <param name="playerId">The id of the player.</param>
    /// <param name="season">The season of the game log in YYYYYYYY format, where the first four digits represent the start year of the season,
    /// and the last four digits represent the end year.</param>
    /// <param name="gameType">The game type. Regular season = 2, playoffs = 3.</param>
    /// <returns></returns>
    public async Task<LogRoot> GetGameLog(int playerId, string season, int gameType = 2)
    {
        try
        {
            gameLog = await webApiClient.GetFromJsonAsync<LogRoot>($"v1/player/{playerId}/game-log/{season}/{gameType}");
            errorString = null;
            return gameLog;
        }
        catch (Exception ex)
        {
            errorString = $"There was an error getting the game log: {ex.Message}";
        }
        return null;
    }

    /// <summary>
    /// Gets the game log of a player as of the current moment.
    /// </summary>
    /// <param name="playerId"></param>
    /// <returns></returns>
    public async Task<GameLogCurrentRoot> GetGameLogCurrent(string playerId)
    {
        try
        {
            gameLogCurrent = await webApiClient.GetFromJsonAsync<GameLogCurrentRoot>($"v1/player/{playerId}/game-log/now");
            errorString = null;
            return gameLogCurrent;
        }
        catch (Exception ex)
        {
            errorString = $"There was an error getting the current game log: {ex.Message}";
        }
        return null;
    }
}
