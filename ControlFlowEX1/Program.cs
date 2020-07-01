using System;


namespace CSharpFundamentalsCourse
{
    class Program
    {
        static void Main(string[] args)
        {

            //1st exercise

            /*
            
                Console.WriteLine("Please Enter a number between 1 amd 10:"); 
                var userInput = Console.ReadLine();
                var number = Convert.ToInt32(userInput);
                if (number >= 1 && number <= 10)
                    Console.WriteLine("Valid Input");
                else
                    Console.WriteLine("Invalid Input");
            */




            //2nd Exercise
            /*

            Console.WriteLine("Please enter first value :");
            var value1 = Console.ReadLine();
            var firstNumber = Convert.ToInt32(value1);

            Console.WriteLine("Please enter second value :");
            var value2 = Console.ReadLine();
            var secondNumber = Convert.ToInt32(value2);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The Bigger value is the first value:" + firstNumber);
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("The Bigger value is the second value: " + secondNumber);
            }
            else
            {
                Console.WriteLine("Those might be invalid values or the 2 values are equal");
            }

            */




            //3 rd Exercise

            /*
            Console.WriteLine("Please enter the width of the image:");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height of the image:");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width> height)
            {
                Console.WriteLine("This is a landscape image");
            }

            else if (width < height)
            {
                Console.WriteLine("This is a portrait image");
            }

            else
            {
                Console.WriteLine("image might be square or you entered invalid values");
            }
            */




            // 4th Exercise

            Console.WriteLine("Please enter Car speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}
