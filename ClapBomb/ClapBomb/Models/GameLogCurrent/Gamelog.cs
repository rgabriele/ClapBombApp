namespace ClapBomb.Models.GameLogCurrent;

public class Gamelog
{
    public int gameId { get; set; }
    public string teamAbbrev { get; set; }
    public string homeRoadFlag { get; set; }
    public string gameDate { get; set; }
    public int goals { get; set; }
    public int assists { get; set; }
    public Commonname commonName { get; set; }
    public Opponentcommonname opponentCommonName { get; set; }
    public int points { get; set; }
    public int plusMinus { get; set; }
    public int powerPlayGoals { get; set; }
    public int powerPlayPoints { get; set; }
    public int gameWinningGoals { get; set; }
    public int otGoals { get; set; }
    public int shots { get; set; }
    public int shifts { get; set; }
    public int shorthandedGoals { get; set; }
    public int shorthandedPoints { get; set; }
    public string opponentAbbrev { get; set; }
    public int pim { get; set; }
    public string toi { get; set; }
}
