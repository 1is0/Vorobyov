using System;
using System.Text;

namespace Hierarchy
{
    class SpecSportsman : Sportsman
    {
        public string SportsName { get; set; }
        public string GreatestAchievement { get; set; }

        public SpecSportsman(string fullName = "UNKNOWN HUMAN", DateTime bday = new DateTime(),
            double? weight = null, double? height = null, string country = "UNKNOWN LOCATION",
            string category = "UNDEFINED", uint gold = 0, uint silver = 0, uint bronze = 0,
            string sportsname = "UNKNOWN SPORT", string achievement = "NO MAJOR ACHIEVEMENTS")
            : base(fullName, bday, weight, height, country, category, gold, silver, bronze)
        {
            SportsName = sportsname;
            GreatestAchievement = achievement;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.Append("\n--This is a specialised sportsman!--\n");
            result.Append($"This sportsman is {SportsName} player\n");
            result.Append($"And the greatest achievement of his/her is {GreatestAchievement}");
            return result.ToString();
        }

        public override string this[string field]
        {
            get
            {
                switch (field)
                {
                    case "sports": return $"Sports name: {SportsName}";
                    case "achievement": return $"Greatest achievement: {GreatestAchievement}";
                    default:
                        return "Wrong field name, for SPECIALISEDSPORTSMAN " +
                       "should be either \"sports\" or \"achievement\"";
                }
            }
        }
    }
}
