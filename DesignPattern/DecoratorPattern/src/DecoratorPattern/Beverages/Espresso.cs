namespace DecoratorPattern.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concreate component
    public class Espresso : Beverage
    {
        public  string GetDescription()
        {
            return "Espresso Coffee";
        }
        public  double Cost()
        {
            return 1.99;
        }
    }
}
