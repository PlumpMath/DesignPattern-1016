namespace DecoratorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //this is decorator
    public abstract class CondimentDecorator : Beverage
    {

        protected Beverage _beverage;
        public CondimentDecorator(Beverage b)
        {
            _beverage = b;
        }

        public virtual string GetDescription()
        {
            return this._beverage.GetDescription();
        }

        public virtual double Cost()
        {
            return this._beverage.Cost();
        }

        }
}
