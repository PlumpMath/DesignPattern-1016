namespace DecoratorPattern.Condiments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concrete decorator
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage):base(beverage)
        {
        }
        public override double Cost()
        {
            return base._beverage.Cost() + 0.10;
}

        public override string GetDescription()
        {
            return base._beverage.GetDescription() + " ,Steamed Milk";
        }
    }
}
