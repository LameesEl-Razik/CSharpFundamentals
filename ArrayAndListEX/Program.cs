﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1
            /*
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or press 'ENTER' to exit): ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();

            */


            //ex2
            /*
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversedName = new string(array);
            Console.WriteLine("Your Reversed name: " + reversedName);
            */


            //ex3
            
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Please Enter a number:  'you should eter 5 uniqe numbers' ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
            


            //ex4

            /*

            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or type 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers are:");
            foreach (var number in uniques)
                Console.WriteLine(number);

    */


        }
    }
}
