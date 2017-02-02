namespace DecoratorPattern.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concreate component
    public class HouseBlend : Beverage
    {
        public  string GetDescription()
        {
            return "House Blend Coffee";
        }
        public  double Cost()
        {
            return 0.89;
        }
    }
}
