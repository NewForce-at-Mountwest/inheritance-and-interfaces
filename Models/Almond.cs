using advanced_typing.Interfaces;

namespace advanced_typing.Models{
    public class Almond : INut, IFood

     {
         public bool isOrganic {get; set;}
        public bool Salted { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool Shelled { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool DryRoasted { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool TreeNut { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int CaloriesPerServing { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string ServingSize { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}