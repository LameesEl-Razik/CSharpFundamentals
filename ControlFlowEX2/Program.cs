using System;



namespace CSharpFundamentalsCourse
{
    class Program
    {
        static void Main(string[] args)


        {
            //ex1
            /*
            for (var i= 1; i<= 10; i++)
            {
                if (i%2== 0)
                {
                    Console.WriteLine(i);
                }

            }
            */



            //ex2
            /*
             var name = "John Smith";
        
             for (var i= 0; i<name.Length; i++)
             {
                 Console.WriteLine(name[i]);
             }
              */


            //ex3
            /*
            var name = "John Smith";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            */


            //ex4
            /*
            var numbers = new int[] { 1, 2, 3, 4};

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            */



            //ex4
            /*
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                Console.WriteLine("@Echo:" + input);

            }
            */

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo:" + input);
                    continue;
                }


                break;
            }
        }
    }
}
