using System;
using System.Collections.Generic;


namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> orderPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> orderQuantiti = new Dictionary<string, int>();
            AddProdukt(orderPrice, orderQuantiti);
            PrintOutput(orderPrice, orderQuantiti);
      
        }



        static void AddProdukt(Dictionary<string, decimal> orderPrice, Dictionary<string, int> orderQuantiti)
        {
            string comand = Console.ReadLine();
            while (comand != "buy")
            {
                string[] infoProdukt = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string nameProdukt = infoProdukt[0];
                decimal priceProdukt = decimal.Parse(infoProdukt[1]);
                int quantitiProdukt = int.Parse(infoProdukt[2]);

                if (!orderPrice.ContainsKey(nameProdukt))
                {
                    orderPrice.Add(nameProdukt, priceProdukt);
                    orderQuantiti.Add(nameProdukt, quantitiProdukt);
                }
                else
                {
                    orderPrice[nameProdukt] = priceProdukt;
                    orderQuantiti[nameProdukt] += quantitiProdukt;
                }

                comand = Console.ReadLine();
            }
        }

        static void PrintOutput(Dictionary<string, decimal> orderPrice, Dictionary<string, int> orderQuantiti)
        {
            foreach (var namPrice in orderPrice)
            {
                foreach (var namQuantiti in orderQuantiti)
                {
                    if (namPrice.Key == namQuantiti.Key)
                    {
                        //"{productName} -> {totalPrice}"
                        Console.WriteLine($"{namQuantiti.Key} -> {namPrice.Value * namQuantiti.Value:f2}");

                    }
                }
            }
        }
    }
}
