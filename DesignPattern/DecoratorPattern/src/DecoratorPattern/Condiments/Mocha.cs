
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
       public Beverage beverage;
        public override string Description { get; set; }

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description = this.beverage.GetDescription()+ ", Mocha";
        }
        public override double Cost()
        {
            return this.beverage.Cost() + 0.20;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + Description;
        }
    }
}
