namespace AbstractFactoryPattern.ConcreteFactory
{
    using System;
    using AbstractFactory;
    using AbstractProduct;
    using Product;

    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
           
        }
    }
}
