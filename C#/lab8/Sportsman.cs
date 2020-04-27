using System;
using System.Text;

namespace HierarchyFinal
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

        //serving class for delegate
        protected class MedalsArg: EventArgs 
        {
            public readonly Medals meds;
            public MedalsArg(uint gold, uint silver, uint bronze) 
            {
                meds = new Medals(gold, silver, bronze);
            }
        }
 
        //event
        protected event EventHandler<MedalsArg> MedalsEarned;

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

            //anonymous method-handler
            MedalsEarned += delegate(object sender, MedalsArg m)
            {
                Sportsman s = (Sportsman)sender;
                Console.WriteLine($"Congratulations, {s.FullName} from {s.Country}!");
                Console.WriteLine($"He/She has just earned {(m.meds.Gold > 0 ? m.meds.Gold + " golden," : "\b")} " +
                    $"{(m.meds.Silver > 0 ? m.meds.Silver + " silver," : "\b")} " +
                    $"{(m.meds.Bronze > 0 ? m.meds.Bronze + " bronze," : "\b")}\b medals!\n");                
            };
        }

        public virtual void EarnedMedals(uint gold = 0, uint silver = 0, uint bronze = 0) 
        {
            if (gold + silver + bronze > 0)
            {
                Medals renewed = MedalStack;
                renewed.Gold += gold;
                renewed.Silver += silver;
                renewed.Bronze += bronze;
                MedalStack = renewed;
                MedalsEarned.Invoke(this, new MedalsArg(gold, silver, bronze));
            }
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
