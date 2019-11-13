using System;
using System.Collections.Generic;
using advanced_typing.Interfaces;

namespace advanced_typing.Models{
    public class FruitGiftBasket {

        public List<IFruit> GiftBasketInventory {get; set;} = new List<IFruit>();

    }
}