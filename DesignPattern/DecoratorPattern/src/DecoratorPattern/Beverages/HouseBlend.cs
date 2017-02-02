namespace DecoratorPattern.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concreate component
    public class HouseBlend : Beverage
    {
        public override string Description { get; set; }

        public HouseBlend()
        {
            Description = "this is house blend";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
