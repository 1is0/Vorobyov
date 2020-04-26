using System;
using System.Text;

namespace HierarchyUpdated
{
    class Human
    {
        //fields
        protected double? height;
        protected double? weight;

        //overall of created Human objects
        private static int Amount { get; set; }

        //properties
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public double? Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    height = null;
                }
            }
        }
        public double? Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    weight = null;
                }
            }
        }

        //constructor -- one but for any purpose)        
        public Human(string fullName = "UNKNOWN HUMAN", DateTime bday = new DateTime(),
            double? weight = null, double? height = null, string country = "UNKNOWN LOCATION")
        {
            FullName = fullName;
            if (bday > DateTime.Now || bday == DateTime.MinValue)
            {
                bday = DateTime.Now;
            }
            BirthDate = bday;
            Weight = weight;
            Height = height;
            Country = country;
            Amount++;
        }

        //indexator shows fields newly defined in each class, using their fieldnames as index
        virtual public string this[string field]
        {
            get
            {
                switch (field)
                {
                    case "name":
                        return "Full name: " + FullName;
                    case "birthday":
                        System.Globalization.CultureInfo cl = new System.Globalization.CultureInfo("en-US");
                        return "B-Day: " + BirthDate.ToString("dddd, dd MMMM yyyy", cl);
                    case "weight":
                        return "Weight: " + (Weight == null ? "NO DATA" : Weight.ToString());
                    case "height":
                        return "Height: " + (Height == null ? "NO DATA" : Height.ToString());
                    case "country":
                        return "Country: " + Country;
                    default:
                        return "Wrong field name, for HUMAN should be either " +
                            "\"name\" or \"birthday\" or \"weight\" or \"height\" or \"country\"";
                }
            }
        }

        //methods
        protected int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (BirthDate > today.AddYears(-age))
            {
                age--;
            }
            if (age < 0)
            {
                age = 0;
            }
            return age;
        }
        public override string ToString()
        {
            System.Globalization.CultureInfo cl = new System.Globalization.CultureInfo("en-US");
            StringBuilder result = new StringBuilder("This is " + FullName + " born on " +
                BirthDate.ToString("dddd, dd MMMM yyyy", cl) + " in " + Country +
                " and is currently " + GetAge() + " Y.O. ");
            if (Height != null)
            {
                result.Append(Height.ToString());
            }
            else
            {
                result.Append("UNKNOWN HEIGHT");
            }
            result.Append(" meters tall weighing ");
            if (Weight != null)
            {
                result.Append(Weight.ToString());
            }
            else
            {
                result.Append("UNKNOWN WEIGHT");
            }
            result.Append(" kilo(s).");
            return result.ToString();
        }
        public static void ShowAmount()
        {
            Console.WriteLine($" Overall amount of people: {Amount}");
        }
    }
}
