using System;

namespace advanced_typing.Interfaces
{

    public interface IFood
    {
        public string Name { get; set; }

        public int CaloriesPerServing { get; set; }

        public string ServingSize { get; set; }

    }

}