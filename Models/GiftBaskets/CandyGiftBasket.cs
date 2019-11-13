using System;
using System.Collections.Generic;
using advanced_typing.Interfaces;


namespace advanced_typing.Models
{
    public class CandyGiftBasket : IGiftBasket<ICandy>
    {


        public double Price { get; set; }
        public string Name { get; set; }
        public List<ICandy> GiftBasketInventory { get; set; }

        public void AddItem(ICandy item)
        {
            throw new NotImplementedException();
        }

        public void AddItem(List<ICandy> items)
        {
            throw new NotImplementedException();
        }

        public void ListInventory()
        {
            throw new NotImplementedException();
        }
    }
}