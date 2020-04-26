using System;
using System.Text;

namespace HierarchyUpdated
{
    class Sportsman : Human
    {
        public enum Categories : byte
        {
            ThirdTeens = 1,
            SecondTeens,
            FirstTeens,
            Third,
            Second,
            First,
            KMS,
            MS,
            IMS,
            UNDEFINED = 0
        }

        public struct Medals
        {
            public uint Gold { get; set; }
            public uint Silver { get; set; }
            public uint Bronze { get; set; }

            public Medals(uint gold = 0, uint silver = 0, uint bronze = 0)
            {
                Gold = gold;
                Silver = silver;
                Bronze = bronze;
            }
        }

        public Categories Category { get; set; }

        public Medals MedalStack { get; set; }

        public string SportsID { get; protected set; }

        public Sportsman(string fullName = "UNKNOWN HUMAN", DateTime bday = new DateTime(),
            double? weight = null, double? height = null, string country = "UNKNOWN LOCATION",
            string category = "UNDEFINED", uint gold = 0, uint silver = 0, uint bronze = 0) :
            base(fullName, bday, weight, height, country)
        {
            if (Enum.TryParse<Categories>(category, true, out Categories temp))
            {
                Category = temp;
            }
            else
                Category = Categories.UNDEFINED;
            MedalStack = new Medals(gold, silver, bronze);
            SportsID = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.Append("\n--This fellow is a sportsman!--\n");
            result.Append($"Honorable {Category} category with {MedalStack.Gold} gold, " +
                $"{MedalStack.Silver} silver and {MedalStack.Bronze} bronze medals");
            result.Append($"\nUnique SportsID is {SportsID} (for more details on [allspotsman.com] website)");
            return result.ToString();
        }

        public override string this[string field]
        {
            get
            {
                switch (field)
                {
                    case "medals":
                        return $"Medals: {MedalStack.Gold} golden," +
                        $" {MedalStack.Silver} silver and {MedalStack.Bronze} bronze";
                    case "category": return $"Category: {Category}";
                    case "ID":
                    case "id": return $"ID: {SportsID}";
                    default:
                        return "Wrong field name, for SPORTSMAN should be either " +
                       "\"medals\" or \"category\" or \"ID\"(\"id\") ";
                }
            }

        }
    }
}
