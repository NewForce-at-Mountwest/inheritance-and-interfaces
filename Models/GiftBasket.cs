using System;
using System.Collections.Generic;

namespace advanced_typing.Models{
    public class GiftBasket {

        public double Price {get; set;}

        public string Name {get; set;}

        public List<Food> GiftBasketInventory {get; set;} = new List<Food>();

    }
}