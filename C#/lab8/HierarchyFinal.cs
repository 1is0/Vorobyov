using System;

namespace HierarchyFinal
{
    class HierarchyFinal
    {
        public delegate void ConsoleColorHandler(ConsoleColor clr, string msg);
        static void Main(string[] args)
        {
            //having fun with multioperational lambdas for proper output
            ConsoleColorHandler cch = (clr, msg) =>
            {
                Console.ForegroundColor = clr;
                Console.WriteLine(msg);
                Console.ForegroundColor = ConsoleColor.White;
            };

            object[] objArray = new object[5];
            DateTime date = new DateTime(1985, 10, 26);
            cch(ConsoleColor.DarkGreen, $"{"Events, delegates, anonymous methods and lamda-expressions\n",90}");
            
            //must invoke amountHandler 5 times
            objArray[0] = new Sportsman(gold: 10, bronze: 8, silver: 5, category: "IMS");
            objArray[1] = new SpecSportsman("BJ Blaskowiz", new DateTime(1932, 01, 15), 98, 1.90,
                "Poland", "IMS", 1, 9, 4, "Football", "2nd place European championship 1941");
            objArray[2] = new SpecSportsman(gold: 2, silver: 4, bronze: 10);
            objArray[3] = new SpecSportsman("Mathew Clare", weight: 57, sportsname: "Hockey", country: "Sweeden");
            objArray[4] = new Sportsman(weight: 0, height: -12, country: "Netherlands",
                bday: new DateTime(1987, 07, 12), category: "First");

            //triggering "Sportsman earning medals" events
            ((Sportsman)objArray[4]).EarnedMedals(1, 3, 0);

            //this one will not trigger
            ((Sportsman)objArray[0]).EarnedMedals(0, 0, 0);

            ((Sportsman)objArray[0]).EarnedMedals(0, 0, 3);

            //invoking "SpecSportsman is offered a citizenship" event
            ((SpecSportsman)objArray[1]).EarnedMedals(0, 1, 1);
            ((SpecSportsman)objArray[3]).EarnedMedals(1, 2, 8);

            //catching exception with mehod CompareTo
            try
            {
                ((SpecSportsman)objArray[3]).CompareTo("I am a string");
                ((SpecSportsman)objArray[3]).CompareTo(objArray[1]);                                
            }
            catch (ArgumentException e) 
            {
                cch(ConsoleColor.Red, $"{e.Message}\nMehtod collapsed: {e.TargetSite}\n" +
                    $"In programm: {e.Source}");
            }            
            Console.ReadKey();
        }        
    }
}
