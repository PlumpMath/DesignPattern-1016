namespace DecoratorPattern.Condiments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concrete decorator
    public class Whip : CondimentDecorator
    {
         public Whip(Beverage beverage) :base(beverage)
        {
          }
        public override double Cost()
        {
            return base._beverage.Cost() + 0.10;
        }

        public override string GetDescription()
        {
            string descpription = base._beverage.GetDescription() + ", Whip";
            return descpription;
        }
    }
}
