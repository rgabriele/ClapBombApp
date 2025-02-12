namespace ClapBomb.Models.Roster
{
    public class Forward
        {
            public int id { get; set; }
            public string headshot { get; set; }
            public Firstname firstName { get; set; }
            public Lastname lastName { get; set; }
            public int sweaterNumber { get; set; }
            public string positionCode { get; set; }
            public string shootsCatches { get; set; }
            public int heightInInches { get; set; }
            public int weightInPounds { get; set; }
            public int heightInCentimeters { get; set; }
            public int weightInKilograms { get; set; }
            public string birthDate { get; set; }
            public Birthcity birthCity { get; set; }
            public string birthCountry { get; set; }
            public Birthstateprovince birthStateProvince { get; set; }
        }

    }
