namespace DecoratorPattern.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concreate component
    public class Decaf : Beverage
    {
        public override string Description { get; set; }

        public Decaf()
        {
            Description = "Decaf coffee";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
