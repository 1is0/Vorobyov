﻿using System;
using System.Text;

namespace HierarchyFinal
{
    class SpecSportsman : Sportsman, IFamous, IComparable
    {
        public string SportsName { get; set; }
        public string GreatestAchievement { get; set; }

        //another event
        private event Action<bool> CitizenshipChange;

        public SpecSportsman(string fullName = "UNKNOWN HUMAN", DateTime bday = new DateTime(),
            double? weight = null, double? height = null, string country = "UNKNOWN LOCATION",
            string category = "UNDEFINED", uint gold = 0, uint silver = 0, uint bronze = 0,
            string sportsname = "UNKNOWN SPORT", string achievement = "NO MAJOR ACHIEVEMENTS")
            : base(fullName, bday, weight, height, country, category, gold, silver, bronze)
        {
            SportsName = sportsname;
            GreatestAchievement = achievement;
            CitizenshipChange += Citizenship;
        }

        public override void EarnedMedals(uint gold = 0, uint silver = 0, uint bronze = 0)
        {
            base.EarnedMedals(gold, silver, bronze);
            CitizenshipChange.Invoke(Convert.ToBoolean(Country.Length % 2));
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

        public void WellKnown()
        {
            if (MedalStack.Gold + MedalStack.Bronze + MedalStack.Silver >= 20 &&
                Category >= Categories.First && MedalStack.Gold >= 3)
            {
                Console.WriteLine($"{FullName} is a LEGENDARY sportsman, and " +
                    $"the country is trully porud of him!\n");
            }

            else if (MedalStack.Gold + MedalStack.Bronze + MedalStack.Silver >= 15)
            {
                Console.WriteLine($"{FullName} is a true sport-star in his country!\n");
            }

            else if (MedalStack.Gold + MedalStack.Bronze + MedalStack.Silver >= 10) 
            {
                Console.WriteLine($"{FullName} is a well-known sportsman in his country!\n");
            }
            
            else
            {
                Console.WriteLine($"{FullName} is just an ordinary sportsman in his country!\n");
            }
        }

        //another handler 
        public void Citizenship(bool agreement)
        {
            if (MedalStack.Gold + MedalStack.Bronze + MedalStack.Silver >= 10)
            {
                string country = "Belarus";                
                if (MedalStack.Silver >= 5)
                {
                    country = "Russia";   
                }
                if (MedalStack.Silver >= 9)
                {
                    country = "Belgium";
                }
                if (MedalStack.Gold >= 3)
                {
                    country = "Germany";
                }
                if (MedalStack.Gold >= 6)
                {
                    country = "USA";
                }

                Console.WriteLine($"{FullName} was proposed to compete for " +
                    $"{country}{(agreement? " and agreed": ", but declined the proposal")}.");
                if (agreement)
                {
                    Country = country;
                    Console.WriteLine($"Now {FullName} stands for a new country: {Country}");
                }
                Console.WriteLine();
            }
        }

        public int CompareTo(object obj)
        {
            SpecSportsman sp = obj as SpecSportsman;
            if (sp != null)
            {
                uint m1 = MedalStack.Gold + MedalStack.Bronze + MedalStack.Silver;
                uint m2 = sp.MedalStack.Gold + sp.MedalStack.Bronze + sp.MedalStack.Silver;
                if (m1 > m2)
                {
                    return 1;
                }
                if (m2 > m1)
                {
                    return -1;
                }
                else 
                {
                    return 0;
                }
            }
            else throw new ArgumentException("Error! Incompetible type");
        }
    }
}
