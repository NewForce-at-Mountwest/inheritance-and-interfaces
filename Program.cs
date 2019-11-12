using System;
using advanced_typing.Actions;

namespace advanced_typing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lucas and Spencer Gift Basket Company");
            Console.WriteLine("---------");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Make Gift Basket");





            // Problems with our current system:
            // 1. We're duplicating code! We write the same properties on a bunch of food items
            // 2. Our gift basket need to store a list of multiple types --> not JUST pears, for example, but assorted fruits

            // Inheritance --> let's create some types (candy, fruit, nut) where we can store some of the properties these things have in common

            // What about chocolate orange? Is it a candy or a fruit? Chocolate covered almond?

            // Iterfaces --> you can inherit from multiple interfaces

            // Let's make interfaces for ICandy, IFruit, INut, etc.




            string userInput = Console.ReadLine();

            if (userInput == "1")
            {

                MakeGiftBasket.PrintOptions();
            }
            else
            {
                Console.WriteLine("Please enter a number to select your next step.");
            }


        }
    }
}
