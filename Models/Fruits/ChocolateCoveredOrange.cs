using System;
using advanced_typing.Interfaces;

namespace advanced_typing.Models {
    public class ChocolateCoveredOrange : IFruit, ICandy, IFood {

        public bool isItBloody {get; set;}
        public bool isRipe { get; set; }
        public bool hasSeeds { get; set; }
        public string Color { get; set; }
        public string Name { get;  set; }
        public int CaloriesPerServing { get; set; }
        public string ServingSize { get; set; }
        public string Flavor { get; set; }
        public int NumberOfPounds { get; set; }
        public bool hasChocolate { get; set; }
    }
}