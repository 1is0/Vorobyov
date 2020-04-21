using System;
using System.Text;

namespace Hierarchy
{
    class Hierarchy
    {
        static void Main(string[] args)
        {
            /*colors used to make sections of different class members
            demonstration more vivid in console data output*/
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Stats in the beginning:",70}");
            Console.ForegroundColor = ConsoleColor.White;
            Human.ShowAmount();

            /*initializing objects of hierarchy classes in common 
            object array using different variations of constructors*/
            object[] objArray = new object[10];
            DateTime date = new DateTime(1981, 12, 12);

            objArray[0] = new Human("Nikolay Sergeevich Vasilev", date, 86, 1.80, "Belarus");
            objArray[1] = new Human();
            date.AddTicks(12345);
            objArray[2] = new Sportsman("Gordon Freeman", date, 78, 1.60, "USA", "MS", 2, 3, 4);            
            objArray[3] = new Sportsman(bday: date, country: "UK", silver: 1);
            objArray[4] = new Sportsman();
            objArray[5] = new SpecSportsman();
            objArray[6] = new SpecSportsman("BJ Blaskowiz", new DateTime(1932, 01, 15), 98, 1.90,
                "Poland", "IMS", 1, 9, 4, "Football", "2nd place European championship 1941");
            objArray[7] = new SpecSportsman();
            objArray[8] = new SpecSportsman("Mathew Clare", weight: 57, sportsname: "Hockey", country: "Sweeden");
            objArray[9] = new Human(weight: 0, height: -12, country: "Netherlands");

            //demonstration of static method in Base class
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Stats after adding array:", 71}");
            Console.ForegroundColor = ConsoleColor.White;
            Human.ShowAmount();

            //demonstration of overridden methods ToString() in each class
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"Info about arrayed the people:", 74}\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < objArray.Length; i++)
            {
                Console.WriteLine(objArray[i].ToString() + "\n");
            }

            //demonstration of field indexators in each class
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"Getting unique fields with indexators:",70}\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < objArray.Length; i++)
            {
                Console.Write($"--This is {objArray[i].GetType()}--\n");
                if (objArray[i] is SpecSportsman ss)
                {
                    Console.WriteLine(ss["sports"] + "\n" + ss["achievement"] + "\n" +
                            ss["ID"] + "\n");
                }                
                else if (objArray[i] is Sportsman s)
                {
                    Console.WriteLine(s["medals"] + "\n" + s["category"] + "\n" +
                            s["id"] + "\n" + s["name"] + "\n");
                }
                else
                {
                    Human h = (Human)objArray[i];
                    Console.WriteLine(h["name"] + "\n" + h["birthday"] + "\n" + h["weight"] + "\n" +
                        h["height"] + "\n" + h["country"] + "\n" + h["somestring"] + "\n");
                }
            }

            //demonstration of properties working in different classes
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"Finally, let's edit some empty fields of various objects using properties:", 90}\n");
            Console.ForegroundColor = ConsoleColor.White;
            SpecSportsman np = (SpecSportsman)objArray[5];
            np.Category = Sportsman.Categories.SecondTeens;
            np.BirthDate = new DateTime(2002, 02, 06);
            np.Country = "Italy";
            np.MedalStack = new Sportsman.Medals(2, 4);
            np.SportsName = "Rugby";
            Console.WriteLine(np.ToString());
            Human nl = (Human)objArray[1];
            Console.WriteLine("\n{0}: {1}", nl.GetType(), nl.FullName = "Kate"); 
            Console.ReadKey();
        }
    }
}
