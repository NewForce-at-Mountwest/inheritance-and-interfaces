using System;
using System.Collections.Generic;
using advanced_typing.Interfaces;

namespace advanced_typing.Models{
    public class NutGiftBasket : IGiftBasket<INut>
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public List<INut> GiftBasketInventory { get; set; }

        public void AddItem(INut item)
        {
            throw new NotImplementedException();
        }

        public void AddItem(List<INut> items)
        {
            throw new NotImplementedException();
        }

        public void ListInventory()
        {
            throw new NotImplementedException();
        }
    }
}