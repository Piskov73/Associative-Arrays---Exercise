using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> minerResurs = new Dictionary<string, int>();
            MinerResours(minerResurs);

            Print(minerResurs); 
        }

       

        static void MinerResours(Dictionary<string, int> minerResurs)
        {
            string resoursce = Console.ReadLine();
            int quantitiy = int.Parse(Console.ReadLine());
            while (resoursce != "stop")
            {
                if (!minerResurs.ContainsKey(resoursce))
                {
                    // minerResurs.Add(resoursce, quantitiy);
                    minerResurs[resoursce] = 0;
                }
                minerResurs[resoursce] += quantitiy;
                resoursce = Console.ReadLine();
                if (resoursce == "stop") break;
                quantitiy = int.Parse(Console.ReadLine());
            }
        }

        
        static void Print(Dictionary<string, int> minerResurs)
        {
            foreach (var resours in minerResurs)
            {
                //"{resource} –> {quantity}"
                Console.WriteLine($"{resours.Key} -> {resours.Value}");

            }
        }
    }
}
