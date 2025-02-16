namespace ClapBomb.Models.PlayerInfo;

    public class PlayerRoot
    {
        public int playerId { get; set; }
        public bool isActive { get; set; }
        public int currentTeamId { get; set; }
        public string currentTeamAbbrev { get; set; }
        public Fullteamname fullTeamName { get; set; }
        public Teamcommonname teamCommonName { get; set; }
        public Teamplacenamewithpreposition teamPlaceNameWithPreposition { get; set; }
        public Firstname firstName { get; set; }
        public Lastname lastName { get; set; }
        public Badge[] badges { get; set; }
        public string teamLogo { get; set; }
        public int sweaterNumber { get; set; }
        public string position { get; set; }
        public string headshot { get; set; }
        public string heroImage { get; set; }
        public int heightInInches { get; set; }
        public int heightInCentimeters { get; set; }
        public int weightInPounds { get; set; }
        public int weightInKilograms { get; set; }
        public string birthDate { get; set; }
        public Birthcity birthCity { get; set; }
        public Birthstateprovince birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string shootsCatches { get; set; }
        public Draftdetails draftDetails { get; set; }
        public string playerSlug { get; set; }
        public int inTop100AllTime { get; set; }
        public int inHHOF { get; set; }
        public Featuredstats featuredStats { get; set; }
        public Careertotals careerTotals { get; set; }
        public string shopLink { get; set; }
        public string twitterLink { get; set; }
        public string watchLink { get; set; }
        public Last5games[] last5Games { get; set; }
        public Seasontotal[] seasonTotals { get; set; }
        public Award[] awards { get; set; }
        public Currentteamroster[] currentTeamRoster { get; set; }
    }
