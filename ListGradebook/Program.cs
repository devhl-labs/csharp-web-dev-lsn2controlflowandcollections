using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace ListGradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            string newStudent;
            string input;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names
            do
            {
                input = Console.ReadLine();

                newStudent = input;

                if (newStudent != string.Empty)
                {
                    int id = 1;
                    
                    if (students.Count > 0)
                        id = students.Max(s => s.Key) + 1;

                    students.Add(id, new Student(id, input));
                }

            } while (newStudent != string.Empty);

            // Get student grades
            foreach (Student student in students.Values)
            {
                Console.WriteLine("Enter space separated list of grades for " + student.Name + ": ");
                
                input = Console.ReadLine();

                foreach(string str in input.Split(' '))
                {
                    if (double.TryParse(str, out double grade))
                    {
                        student.Grades.Add(grade);
                    }
                }
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");

            double sum = 0.0;

            foreach(Student student in students.Values)
            {
                Console.WriteLine(student.Name + " (" + Math.Round(student.Grades.Average(), 2) + ")");
                sum += student.Grades.Average();
            }

            double avg = sum / students.Count;

            Console.WriteLine("Average grade: " + Math.Round(avg, 2));
        }
    }

    public class Student
    {
        public int Id { get; }

        public string Name { get; }

        public List<double> Grades { get; } = new List<double>();

        public Student(int id, string name)
        {
            Id = id;

            Name = name;
        }
    }
}
