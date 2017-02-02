namespace DecoratorPattern.Condiments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concrete decorator
    public class Soy : CondimentDecorator
    {
       public Beverage beverage;
        public override string Description { get; set; }
       
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description = this.beverage.GetDescription() + ", Soy";
        }
        public override double Cost()
        {
            return this.beverage.Cost() + 0.15;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + " ,Soy";
        }
    }
}
