namespace DecoratorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //this is decorator
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();
    }
}
