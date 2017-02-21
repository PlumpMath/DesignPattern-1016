namespace StatePattern.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
   public interface State
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
