using System;
using advanced_typing.Interfaces;

namespace advanced_typing.Models{
    public class Taffy : ICandy, IFood {

        public bool isSaltWater {get; set;}
        public string Flavor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfPounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool hasChocolate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IFood.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IFood.CaloriesPerServing { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IFood.ServingSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}