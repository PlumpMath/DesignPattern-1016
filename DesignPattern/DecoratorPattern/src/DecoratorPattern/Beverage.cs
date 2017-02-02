namespace DecoratorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //this is component
    public abstract class Beverage
    {
        public abstract string Description { get; set; }
       
        public string GetDescription()
        {
            return Description;
        }
        public abstract double Cost();
        
    }
}
