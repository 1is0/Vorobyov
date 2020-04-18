using System;

namespace Lab3
{
    class Human
    {
        //fields
        protected double? height;
        protected double? weight;        

        //overall of created objects
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

        //constructor        
        public Human(string fullName = "Unknown Human", DateTime bday = new DateTime(), double? weight = null, double? height = null, string country = "Unknown Location")
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

        //indexator
        public string this [string field]
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
                        return "Weight: " + (Weight == null? "No data" : Weight.ToString());
                    case "height":
                        return "Height: " + (Height == null ? "No data" : Height.ToString());
                    case "country":
                        return "Country: " + Country;
                    default:
                        return "Wrong field name, should be either \"name\" or \"birthday\" or \"weight\" or \"height\" or \"country\"";
                }
            }
        }

        //methods
        public int GetAge()
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
            string result = "This is " + FullName + " born on " + BirthDate.ToString("dddd, dd MMMM yyyy", cl) + 
                " in " + Country + " and is currently " + GetAge() + " Y.O. ";
            if (Height != null)
            {
                result += Height.ToString();
            }
            else
            {
                result += "Unknown";
            }
            result += " meters tall weighing ";
            if (Weight != null)
            {
                result += Weight.ToString();
            }
            else
            {
                result += "unknown";
            }
            result += " kilo(s).";
            return result;
        }
        public static void ShowAmount() 
        {
            Console.WriteLine($" Overall amount of people: {Amount}");
        }
    }
}
