using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1
            /*
            Console.Write("Please enter any few numbers sebarated by hyphin (eg 1-2-3-4-5): ");
            var userInput = Console.ReadLine();

            var numbers = new List<int>();

            foreach (var number in userInput.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Numbers are Consecutive" : "Numbers are not Consecutive";
            Console.WriteLine(message);
            */






            //EX2
            
            /*
            Console.Write("Please enter any few numbers sebarated by hyphin (eg 1-2-3-4-5): ");
            var UserInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(UserInput))
                return;

            var numbers = new List<int>();
            foreach (var number in UserInput.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniquesInputs = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniquesInputs.Contains(number))
                    uniquesInputs.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
                Console.WriteLine("This set of numbers have Duplicates");
            else
                Console.WriteLine("Numbers on this set are unique");
            */



            //EX3
            Console.Write("Please enter any time in 24hrs format(ex 19:00): ");
            var UserInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(UserInput))
            {
                Console.WriteLine("This is an Invalid Time");
                return;
            }

            var components = UserInput.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("This is an Invalid Time Format");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
