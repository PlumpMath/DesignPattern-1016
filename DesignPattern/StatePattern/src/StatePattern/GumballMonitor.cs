namespace StatePattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class GumballMonitor
    {
        private readonly GumballMachine _gumballMachine;

        public GumballMonitor(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine : {0}\nCurrent Inventory : {1}\nCurrent State : {2}",
                _gumballMachine.Location,_gumballMachine.Count,_gumballMachine.State);
        }

    }
}
