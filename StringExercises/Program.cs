using System;
using System.Linq;

namespace StringExercises
{
    class Program
    {
        private const string Rhymes = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

        static void Main(string[] args)
        {
            string[] myArray = Rhymes.Split(' ').ToArray();

            Console.WriteLine(string.Join(" ", myArray));

            myArray = Rhymes.Split('.').ToArray();

            Console.WriteLine(string.Join(".", myArray));
        }
    }
}
