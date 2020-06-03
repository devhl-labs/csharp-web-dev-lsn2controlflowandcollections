using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumbers = new List<int>
            {
                -2,
                -1,
                0,
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9                
            };

            Console.WriteLine(SumOfEvenNumbers(myNumbers));

            List<string> myWords = new List<string>
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten"
            };

            int length;

            do
            {
                Console.WriteLine("Enter the desired word length.");

                if (int.TryParse(Console.ReadLine(), out length) == false)
                    Console.WriteLine("Not an integer.");

            } while (length == 0);

            PrintEachWordWithLength(length, myWords);
        }

        static int SumOfEvenNumbers(List<int> numbers) => numbers.Where(n => n % 2 == 0).Sum();

        static void PrintEachWordWithLength(int length, List<string> words)
        {
            foreach(string word in words.Where(w => w.Length == length))
                Console.WriteLine(word);
        }
    }


}
