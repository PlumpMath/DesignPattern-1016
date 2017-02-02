namespace DecoratorPattern.Condiments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concrete decorator
    public class Whip : CondimentDecorator
    {
        public Beverage beverage;
        public override string Description {get;set;}
        public Whip(Beverage beverage) 
        {
            this.beverage = beverage;
            this.Description = this.beverage.GetDescription() + ", Whip";

        }
        public override double Cost()
        {
            return this.beverage.Cost() + 0.10;
        }

        public override string GetDescription()
        {
            string descpription = this.beverage.GetDescription() + " "+Description;
            return descpription;
        }
    }
}
