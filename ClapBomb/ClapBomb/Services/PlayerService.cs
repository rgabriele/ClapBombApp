﻿using ClapBomb.Models.GameLog;

namespace ClapBomb.Services;

public class PlayerService
{
    LogRoot gameLog;
    HttpClient webApiClient = new HttpClient();
    HttpClient nhlStatsApiClient = new HttpClient();

    public string errorString { get; private set; }

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
}
