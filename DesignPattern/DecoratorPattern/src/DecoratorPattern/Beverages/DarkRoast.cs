namespace DecoratorPattern.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concreate component
    public class DarkRoast : Beverage
    {
    
        public  double Cost()
        {
            return .99;
        }

        public  string GetDescription()
        {
            return "Dark Roast Coffee";
        }
    }
}
