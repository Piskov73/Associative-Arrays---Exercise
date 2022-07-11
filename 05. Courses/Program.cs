using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            AddCourses(courses);
            PrintInfoCourses(courses);

        }



        static void AddCourses(Dictionary<string, List<string>> courses)
        {
            string[] infoCourses = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            while (infoCourses[0] != "end")
            {
                string nameCourses = infoCourses[0];
                string nameStudent = infoCourses[1];
                if (!courses.ContainsKey(nameCourses))
                {
                    courses.Add(nameCourses, new List<string>());
                }
                courses[nameCourses].Add(nameStudent);
                infoCourses = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }
        }

        static void PrintInfoCourses(Dictionary<string, List<string>> courses)
        {
            //"{courseName}: {registeredStudents}"
            //"-- {studentName}"
            foreach (var cours in courses)
            {
                Console.WriteLine($"{cours.Key}: {cours.Value.Count}");
                foreach (var student in cours.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
