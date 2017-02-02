
namespace DecoratorPattern.Condiments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concrete decorator
    public class Mocha : CondimentDecorator
    {
        //this is composition 
        //an instance variable to hold the beverage we are wrapping 
       public Mocha(Beverage beverage):base(beverage)
        {
        }
        public override double Cost()
        {
            return base._beverage.Cost() + 0.20;
        }

        public override string GetDescription()
        {
            return base._beverage.GetDescription() + ", Mocha";
        }
    }
}
