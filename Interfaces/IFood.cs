using System;

namespace advanced_typing.Interfaces
{

    public interface IFood
    {
        string Name { get; set; }

        int CaloriesPerServing { get; set; }

        string ServingSize { get; set; }

    }

}