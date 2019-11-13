using System;
using System.Collections.Generic;


namespace advanced_typing.Interfaces
{
    public interface IGiftBasket<T>
    {

        public double Price { get; set; }

        public string Name { get; set; }

        public List<T> GiftBasketInventory {get; set;}
        public void AddItem(T item);
        public void AddItem(List<T> items);

        public void ListInventory();
    }
}