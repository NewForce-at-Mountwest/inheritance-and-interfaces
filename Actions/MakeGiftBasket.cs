using System;
using advanced_typing.Models;

namespace advanced_typing.Actions
{
    public class MakeGiftBasket
    {
        public static void PrintOptions()
        {
            Console.WriteLine("What theme do you want for your gift basket?");
            Console.WriteLine("1. Fruit");
            Console.WriteLine("2. Nut");
            Console.WriteLine("3. Candy");



            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Preparing your fruit gift basket...");

                // To do: create a gift basket class and give it a list of holiday themed items

                // To do: create some instances of each item and add them to the gift basket.


                Console.WriteLine("All done! Press any key to continue.");
                Console.ReadKey();


            }
            else if (userInput == "2")
            {
                Console.WriteLine("Preparing your nut gift basket...");

                // To do: create a birthday gift basket class and give it a list of holiday themed items

                // To do: create some instances of each item and add them to the gift basket.
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Preparing your candy gift basket...");

            }
            else
            {
                Console.WriteLine("Please enter either 1 or 2 to select an option.");

            }

        }
    }

}
