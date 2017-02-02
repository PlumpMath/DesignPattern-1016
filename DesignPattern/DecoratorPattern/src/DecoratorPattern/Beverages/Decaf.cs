namespace DecoratorPattern.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //concreate component
    public class Decaf : Beverage
    {
        public  string GetDescription()
        {
            return "decaf  Coffee";
        }
        public  double Cost()
        {
            return 1.05;
        }
    }
}
