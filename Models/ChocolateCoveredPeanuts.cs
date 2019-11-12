using System;
using advanced_typing.Interfaces;

namespace advanced_typing.Models {
    public class ChocolateCoveredPeanut : INut, ICandy, IFood
    {
        public bool Salted { get; set; }
        public bool Shelled { get; set; }
        public bool DryRoasted { get; set; }
        public bool TreeNut { get; set; }
        public string Flavor { get; set; }
        public int NumberOfPounds { get; set; }
        public bool hasChocolate { get; set; }
        public string Name { get; set; }
        public int CaloriesPerServing { get; set; }
        public string ServingSize { get; set; }
    }
}