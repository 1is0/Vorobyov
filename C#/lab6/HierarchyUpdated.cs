using System;
using System.Text;

namespace HierarchyUpdated
{
    class HierarchyUpdated
    {
        static void Main(string[] args)
        {
            /*initializing objects of hierarchy classes in common 
            object array using different variations of constructors*/
            object[] objArray = new object[5];
            DateTime date = new DateTime(1981, 12, 12);

            objArray[0] = new SpecSportsman(gold: 10, bronze: 8, silver: 5, category: "IMS");
            objArray[1] = new SpecSportsman("BJ Blaskowiz", new DateTime(1932, 01, 15), 98, 1.90,
                "Poland", "IMS", 1, 9, 4, "Football", "2nd place European championship 1941");
            objArray[2] = new SpecSportsman(gold: 2, silver: 4, bronze: 10);
            objArray[3] = new SpecSportsman("Mathew Clare", weight: 57, sportsname: "Hockey", country: "Sweeden");
            objArray[4] = new SpecSportsman(weight: 0, height: -12, country: "Netherlands",
                bday: new DateTime(1987, 07, 12), category: "First");
            
            ShowInfo(objArray);
            
            //using interfaces
            DemoDefaultInterface(objArray);
            DemoCustomInterface(objArray);            
        }

        static void ShowInfo(object[] objArray) 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"Info about arrayed objects:",70}\n");
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
        }

        static void DemoDefaultInterface(object [] objArray)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"Interface mehtods:",67}\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("a) Standart IComparable interface method, defined in SpecSportsman:\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1) Sorted objArray!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Array.Sort(objArray);
            foreach (object ob in objArray)
            {
                Console.WriteLine(((SpecSportsman)ob).ToString() + '\n');
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("2) Comparing separate items!\n");
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                SpecSportsman comp = (SpecSportsman)objArray[3];
                for (int i = 1; i < objArray.Length; i++)
                {
                    switch (comp.CompareTo(objArray[i]))
                    {
                        case 1:
                            Console.WriteLine($"objArray[3] is bigger than objArray[{i}]\n");
                            break;
                        case -1:
                            Console.WriteLine($"objArray[3] is less than objArray[{i}]\n");
                            break;
                        case 0:
                            Console.WriteLine($"objArray[3] equals objArray[{i}]\n");
                            break;
                    }
                }

                //to get exception
                comp.CompareTo(new Human("abc"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message + '\n');
            }
        }    
        static void DemoCustomInterface(object [] objArray)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("b) Custom IFamous interface methods, defined in SpecSportsman:\n");
            Console.ForegroundColor = ConsoleColor.White;
            bool agr;
            for (int i = 0; i < objArray.Length; i++)
            {
                if (i%2 == 0)
                {
                    agr = true;
                }
                else 
                {
                    agr = false;
                }
                ((SpecSportsman)objArray[i]).WellKnown();
                ((SpecSportsman)objArray[i]).Citizenship(agr);
            }
            Console.ReadKey();
        }
    }
}
