namespace DecoratorPattern.Condiments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concrete decorator
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage):base(beverage)
        {
        
        }
        public override double Cost()
        {
            return base._beverage.Cost() + 0.15;
        }

        public override string GetDescription()
        {
            return base._beverage.GetDescription() + " ,Soy";
        }
    }
}
