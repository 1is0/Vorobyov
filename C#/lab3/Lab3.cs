using System;

namespace Lab3
{
    class Lab3
    {
        static void Main()
        {
            System.Globalization.CultureInfo cl = new System.Globalization.CultureInfo("en-US");
            DateTime myBday = new DateTime(2002, 07, 22);
            Human[] humanArray = new Human[4];
            humanArray[0] = new Human("Andrew", myBday, 70, 1.82, "Belarus");
            humanArray[1] = new Human(height: 2, country: "Lithuania");
            humanArray[2] = new Human();
            humanArray[3] = new Human("Tom", country: "USA", height: 1.50, weight: 100);
            
            //static method functionality
            Human.ShowAmount();
            Human tod = new Human("Tod", myBday.AddDays(123), -12, 2.20);
            
            //properties functionalities
            Console.WriteLine("After adding new Human named {0} born on {1} in {4} weighing {2} his height is {3}", 
                tod.FullName, tod.BirthDate.ToString("dddd, dd MMMM yyyy", cl), (tod.Weight == null? 0 : tod.Weight),
                (tod.Height == null ? 0 : tod.Height), tod.Country);
            tod.Country = "Brazil";
            Console.WriteLine("... we change his country for {0}", tod.Country);
            Human.ShowAmount();
            Console.WriteLine();
            
            //override ToString() functionality:
            for (int i = 0; i < humanArray.Length; i++)
            {
                Console.WriteLine(humanArray[i].ToString());
            }
            Console.WriteLine();
            
            //indexators functionality:
            Console.WriteLine(" I'll show you Tod's new info using indexators:\n{0}\n{1}\n{2}\n{3}\n{4}\n", tod["name"],
                tod["birthday"], tod["height"], tod["weight"], tod["country"]);
            Console.WriteLine(" ... and the mistake which appears after incorrect input:\n{0}", tod["whatever"]);
            Console.WriteLine("\nPress any button to proceed...");
            Console.ReadKey();
        }
    }
}
