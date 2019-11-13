using System;
using advanced_typing.Models;
using System.Collections.Generic;
using advanced_typing.Interfaces;

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

                ChocolateCoveredOrange chocoOrange = new ChocolateCoveredOrange(){
                    Name = "Chocolate Covered Orange",
                    hasChocolate = true
                };

                Pear bartlettPear = new Pear(){
                    Name = "Bartlett Pear"
                };

                Apple galaApple = new Apple(){
                    Name = "Gala Apple"
                };

                FruitGiftBasket fruityBasket = new FruitGiftBasket();

                fruityBasket.AddItem(chocoOrange);

                fruityBasket.AddItem(new List<IFruit>(){bartlettPear, galaApple});

                fruityBasket.ListInventory();

                Console.WriteLine("All done! Press any key to exit.");
                Console.ReadKey();


            }
            else if (userInput == "2")
            {
                Console.WriteLine("Preparing your nut gift basket...");
                Almond newAlmond = new Almond()
                {
                    Salted = true,
                    Name = "Salted Almond",
                    DryRoasted = false,
                    Shelled = true,
                    TreeNut = true,
                    CaloriesPerServing = 100,
                    ServingSize = "100g",
                    isOrganic = true
                };

                Cashew newCashew = new Cashew()
                {
                    Salted = false,
                    Name = "Whole Cashew",
                    DryRoasted = false,
                    Shelled = true,
                    TreeNut = true,
                    CaloriesPerServing = 150,
                    ServingSize = "100g",
                    isWhole = true
                };

                ChocolateCoveredPeanut chocoNut = new ChocolateCoveredPeanut(){
                    Name = "Delicious chocolate covered peanuts"
                };

                // GiftBasket nutGiftBasket = new GiftBasket()
                // {
                //     Name = "Lots o' Nuts",
                //     Price = 10.99,
                //     GiftBasketInventory = new List<IFood>(){
                //         newAlmond, newCashew, chocoNut
                //     }
                // };

                // nutGiftBasket.GiftBasketInventory.ForEach(singleNut => Console.WriteLine(singleNut.Name));

                Console.WriteLine("All done! Press any key to continue.");
                Console.ReadKey();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Preparing your candy gift basket...");

                Console.WriteLine("All done! Press any key to exit.");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Please enter either 1 or 2 to select an option."); Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

            }

        }
    }

}
