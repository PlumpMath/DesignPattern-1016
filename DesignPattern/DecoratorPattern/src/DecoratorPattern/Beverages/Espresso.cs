namespace DecoratorPattern.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concreate component
    public class Espresso : Beverage
    {
        public override string Description { get; set; }

        public Espresso()
        {
            Description = "this is espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
