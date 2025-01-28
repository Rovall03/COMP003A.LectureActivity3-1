//Author: Rosa Ovalle
//Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose:COMP003A.LectureActivity3-1

namespace COMP003A.LectureActivity3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Selection Statments Demo!");

            //prompt for the current hour
            Console.Write("Enter the current hour (0-23): ");
            int hour = int.Parse(Console.ReadLine());



            //determine time of day
            //condition 1: from 5 to 11
            //condition 2: 12 to 17
            //condition 3: from 18 to 29
            //condition 4: from 21 to 4
            if (hour >= 5 && hour <= 11)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (hour >= 12 && hour <= 17)
            {
                Console.WriteLine("Good Afternoon!");

            }
            else if (hour >= 18 && hour <= 20)
            {
                Console.WriteLine("Good Evening!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }


            //Poromt for the day of the week
            Console.Write("Enter the day of the week: ");
            string day = Console.ReadLine();


            // determoine the meddage for the day
            //condition 1: Monday
            //condition 2: Friday
            //condition 3: Sunday
            //default: just another day

            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("Start of the work week. ");
                    break;
                case "friday":
                    Console.WriteLine("Almost the weekend!");
                    break;
                case "sunday":
                    Console.WriteLine("Relax, it's Sunday");
                    break;
                default:
                    Console.WriteLine("Just another day.");
                    break;
            }






        }
    }
}

