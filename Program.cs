namespace ass1oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Enum called "WeekDays" with the days of the week (Monday to Sunday)
            //as its members. Then, write a
            //C# program that prints out all the days of the week using this Enum.
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
        }
    }
}
