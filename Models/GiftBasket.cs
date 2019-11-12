using System;
using System.Collections.Generic;
using advanced_typing.Interfaces;

namespace advanced_typing.Models{
    public class GiftBasket {

        public double Price {get; set;}

        public string Name {get; set;}

        public List<IFood> GiftBasketInventory {get; set;} = new List<IFood>();

    }
}