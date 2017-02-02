namespace DecoratorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //this is component
   public interface  Beverage
    {

          string GetDescription();
           double Cost();
        
    }
}
