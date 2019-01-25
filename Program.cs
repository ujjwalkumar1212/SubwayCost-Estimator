using System;

namespace CalorieCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var subType = String.Empty;
            var name = String.Empty;
            var bread = String.Empty;
            bool extra_cheese = false;
            var category = String.Empty;

            Console.WriteLine("Hello Welcome to the Subway!");

            while (name == "")
            {

                Console.WriteLine($"Enter your Name: ");
                name = Console.ReadLine();
            }

            while (subType == "")
            {

                Console.WriteLine($"Do you want Salad/Sandwich: ");
                subType = Console.ReadLine();
            }

            if (subType.ToLower() == "sandwich")
            {
                while (category == "")
                {
                    Console.Write("Please enter subType of bread italian_herbs or garlic: ");
                    category = Console.ReadLine();
                }
            }


            Console.WriteLine($"Do you want extra_cheese(Y/N): ");
           
            var extraCheese = Console.ReadLine();
            if (extraCheese.ToLower().Equals("y"))
                extra_cheese = true;

            Console.WriteLine("Hello {0} your total cost of your subType is: {1}", name, calTotalCost(category, extra_cheese));
            Console.ReadLine();
        }

        private static decimal calTotalCost(String subType, bool extra_cheese)
        {

            var totalCost = 0.0m;
            switch (subType.ToLower())
            {

                case "italian_herbs":
                    totalCost = 2.99m;
                    break;

                case "garlic":
                    totalCost = 1.99m;
                    break;
            }

            if (extra_cheese)
            {
                totalCost += 1.00m;
            }

            return totalCost;
        }
    }
}
