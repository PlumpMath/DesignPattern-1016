namespace StatePattern.States
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Interface;
    public class SoldOutState : State
    {
        private GumballMachine _gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can’t insert a quarter, the machine is sold out");
        }
        public void TurnCrank()
        {
            Console.WriteLine("No gumball to dispense");
        }
    }
}
