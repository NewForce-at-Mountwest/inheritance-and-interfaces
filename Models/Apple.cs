using advanced_typing.Interfaces;

namespace advanced_typing.Models{
    public class Apple : IFruit, IFood {

        public bool isTart {get; set;}
        public bool isRipe { get; set; }
        public bool hasSeeds { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public int CaloriesPerServing { get; set; }
        public string ServingSize { get; set; }
    }
}