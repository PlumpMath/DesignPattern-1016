
namespace AbstractFactoryPattern.ConcreteFactory
{
    using AbstractFactory;
    using AbstractProduct;
    using Product;

    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
        public override Herbivore CreateHerbivore()
        {

            return new WildBeast();
        }
    }
}
