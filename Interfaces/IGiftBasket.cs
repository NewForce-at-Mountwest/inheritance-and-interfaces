using System;
using System.Collections.Generic;


namespace advanced_typing.Interfaces
{
    public interface IGiftBasket<T>
    {

        double Price { get; set; }

        string Name { get; set; }

        List<T> GiftBasketInventory {get; set;}
        void AddItem(T item);
        void AddItem(List<T> items);

        void ListInventory();
    }
}