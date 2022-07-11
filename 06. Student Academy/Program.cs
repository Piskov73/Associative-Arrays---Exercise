using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double MinGrade = 4.50;
            Dictionary<string, List<double>> studentAcademy = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            AddStudent(n, studentAcademy);
            PrintStdent(studentAcademy, MinGrade);

        }



        static void AddStudent(int n, Dictionary<string, List<double>> studentAcademy)
        {
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentAcademy.ContainsKey(name))
                {
                    studentAcademy.Add(name, new List<double>());
                }
                studentAcademy[name].Add(grade);
            }
        }

        static void PrintStdent(Dictionary<string, List<double>> studentAcademy, double minGrade)
        {
            var filterStudent = studentAcademy.Where(x => x.Value.Sum() / x.Value.Count() >= minGrade).ToList();
            foreach (var student in filterStudent)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Sum() / student.Value.Count:f2}");
            }
        }
    }
}

