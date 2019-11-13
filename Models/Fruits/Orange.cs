using System;
using advanced_typing.Interfaces;

namespace advanced_typing.Models {
    public class ChocolateCoveredOrange : IFruit, IFood {

        public bool isItBloody {get; set;}
        public bool isRipe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool hasSeeds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CaloriesPerServing { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ServingSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}