namespace ClapBomb.Models.GameLogCurrent;

public class GameLogCurrentRoot
{
    public int seasonId { get; set; }
    public int gameTypeId { get; set; }
    public Playerstatsseason[] playerStatsSeasons { get; set; }
    public Gamelog[] gameLog { get; set; }
}
