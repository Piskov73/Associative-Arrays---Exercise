using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            RemuvAddUser(n, parking);
            PrintOutput(parking);

        }



        static void RemuvAddUser(int n, Dictionary<string, string> parking)
        {
            for (int i = 0; i < n; i++)
            {
                string[] manipulator = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string comand = manipulator[0];
                string username = manipulator[1];
                string licensePlateNumber = "";
                if (comand == "register")
                {
                    licensePlateNumber = manipulator[2];
                    AddUser(parking, username, licensePlateNumber);
                }
                else if (comand == "unregister")
                {
                    Unregistrer(parking, username);
                }

            }
        }

        static void AddUser(Dictionary<string, string> parking, string username, string licensePlateNumber)
        {
            if (parking.ContainsKey(username))
            {
                //"ERROR: already registered with plate number {licensePlateNumber}"
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                return;
            }
            parking.Add(username, licensePlateNumber);
            // "{username} registered {licensePlateNumber} successfully"
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }

        static void Unregistrer(Dictionary<string, string> parking, string username)
        {
            if (!parking.ContainsKey(username))
            {
                //"ERROR: user {username} not found"
                Console.WriteLine($"ERROR: user {username} not found");
                return;
            }
            //"{username} unregistered successfully"
            parking.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }

        static void PrintOutput(Dictionary<string, string> parking)
        {
            //•	"{username} => {licensePlateNumber}"
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
