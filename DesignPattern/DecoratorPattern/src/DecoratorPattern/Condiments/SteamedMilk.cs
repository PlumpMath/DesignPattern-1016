namespace DecoratorPattern.Condiments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concrete decorator
    public class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;
        public SteamedMilk(Beverage beverage)
        {
            beverage = beverage;
            this.Description = this.beverage.GetDescription() + ", Steamed Milk";
        }

        public override string Description { get; set; }
        
          

        public override double Cost()
        {
            return this.beverage.Cost() + 0.10;

        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + " ,Steamed Milk";
        }
    }
}
