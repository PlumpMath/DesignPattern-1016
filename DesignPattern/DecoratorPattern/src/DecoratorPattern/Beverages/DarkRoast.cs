namespace DecoratorPattern.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concreate component
    public class DarkRoast : Beverage
    {
        public override string Description { get; set; }
        public DarkRoast()
        {
            Description = "Dark Roast coffee";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}
