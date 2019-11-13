using System;

namespace advanced_typing.Interfaces
{

    public interface IFruit
    {

        string Name { get; set; }
        bool isRipe { get; set; }

        bool hasSeeds { get; set; }

        string Color { get; set; }

    }

}