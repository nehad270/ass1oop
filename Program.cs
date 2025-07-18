using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ass1oop
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 1
            //Create an Enum called "WeekDays" with the days of the week (Monday to Sunday)
            //as its members. Then, write a
            //C# program that prints out all the days of the week using this Enum.
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

            #region 2
            // Create an Enum called "Seas on" with the four
            // seasons(Spring, Summer, Autumn, Winter) as its members.Write
            // a C# program that takes a season name as input from the user
            // and displays the corresponding month range for that season.
            // Note range for seasons ( spring march to may , summer june to august ,
            // autumn September to November , winter December to February)




            //bool isparsed;
            //object? Season_Name;
            //do
            //{
            //    Console.WriteLine("please enter the season name");
            //    isparsed = Enum.TryParse(typeof(Seas), Console.ReadLine(), out Season_Name);

            //} while (!isparsed);

            //Seas? season = (Seas)Season_Name;

            //switch (Season_Name)
            //{
            //    case Seas.Spring:
            //        Console.WriteLine("march to may ");
            //        break;
            //    case Seas.Autumn:
            //        Console.WriteLine("September to November ");
            //        break;
            //    case Seas.Summer:
            //        Console.WriteLine("june to august");
            //        break;
            //    case Seas.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //    default:
            //        Console.WriteLine("please enter the season again ");
            //        break;
            //} 
            #endregion


            #region 3
            //Peop peop1 = new Peop();

            ////  3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum           .
            ////Create Variable from previous Enum to Add and Remove Permission from variable,
            ////    check if specific Permission existed inside variable


            ////to add permissoins
            //peop1.Permission |= Permissions.write;
            //peop1.Permission |= Permissions.Read;

            //if ((peop1.Permission & Permissions.write) == Permissions.write)
            //{
            //    Console.WriteLine("execited");
            //    Console.WriteLine(peop1.Permission);
            //}
            ////to delete permission
            //peop1.Permission &= ~Permissions.Read;
            //Console.WriteLine(peop1.Permission);





            #endregion


            #region 4


            /// 4.Create an Enum called "Colors" with the basic colors
            /// (Red, Green, Blue) as its members.Write a C# program that takes
            /// a color name as input from the user and displays a message indicating 
            /// whether the input color is a primary color or not.




            bool isparsed;
            object? Colors_Name;
            do
            {
                Console.WriteLine("please enter the color");
                isparsed = Enum.TryParse(typeof(Colors), Console.ReadLine(), out Colors_Name);

            } while (!isparsed);

            Colors? color = (Colors)Colors_Name;
            if (isparsed)
            {
                Console.WriteLine($"{color} is a primary color");
            }
            else
            {
                Console.WriteLine("not primary");


            } 
            #endregion



        }

    }
}
