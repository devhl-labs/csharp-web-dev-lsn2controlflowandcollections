using System;
using System.Linq;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach(int myInt in myArray.Where(x => x % 2 == 0))
                Console.WriteLine(myInt);

        }
    }
}
