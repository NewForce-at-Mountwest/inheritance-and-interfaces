using advanced_typing.Interfaces;

namespace advanced_typing.Models{
    public class Fudge : ICandy, IFood {
        public string Flavor { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int NumberOfPounds { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool hasChocolate { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        bool hasNuts {get; set;}
        string IFood.Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        int IFood.CaloriesPerServing { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        string IFood.ServingSize { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}