namespace AbstractFactoryPattern.Client
{
    using AbstractFactory;
    using AbstractProduct;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //this is client class 
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continent)
        {
            _herbivore = continent.CreateHerbivore();
            _carnivore = continent.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }

}
