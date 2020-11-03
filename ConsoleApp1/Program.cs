using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{

    public class Program
    {
        public static void Main(string[] args)
        {
           // Result.maximumContainers();
        }
    }


    public class Order
    {
        public Order(string input)
        {
            var values = input.Split(' ');

            Budget = int.Parse(values[0]);

            Cost = int.Parse(values[1]);

            ReturnContainers = int.Parse(values[2]);

            TotalContainers = GetTotalContainer(Budget, Cost, ReturnContainers);
        }

        public int Budget { get; set; }

        public int Cost { get; set; }

        public int ReturnContainers { get; set; }

        public int TotalContainers { get; private set; }

        private int GetTotalContainer(int budget, int cost, int returnContainer)
        {
            var totalContainers = budget / cost;
            var emptyContainers = totalContainers;

            //calculate number of empty containers
            while (emptyContainers >= returnContainer)
            {
                //add returnable containers to total number of containers budget allows
                totalContainers += emptyContainers / returnContainer;

                //decrease amount of containers avaiable to return-- compare against number of containers budget allows
                emptyContainers = emptyContainers / returnContainer + emptyContainers % returnContainer;
            }

            return totalContainers;
        }  
    }

    public class Result 
    {
        public static void maximumContainers(List<string> scenarios)
        {
            var orderItems = scenarios
                .Select(x => x)
                .ToList();

            //split each input
            foreach (var orderItem in orderItems)
            {
                var order = new Order(orderItem);

                Console.WriteLine(order.TotalContainers);
            }
        }
    }
}
