using System;
using System.Collections.Generic;
using advanced_typing.Interfaces;

namespace advanced_typing.Models{
    public class FruitGiftBasket : IGiftBasket<IFruit>
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public List<IFruit> GiftBasketInventory { get; set; } = new List<IFruit>();

        public void AddItem(IFruit item)
        {
            GiftBasketInventory.Add(item);
        }

        public void AddItem(List<IFruit> items)
        {
          GiftBasketInventory.AddRange(items);
        }

        public void ListInventory()
        {
           GiftBasketInventory.ForEach(fruit => Console.WriteLine(fruit.Name));
        }
    }
}