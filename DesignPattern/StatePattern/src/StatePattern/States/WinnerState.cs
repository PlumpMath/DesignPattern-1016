namespace StatePattern.States
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Interface;
    public class WinnerState : State
    {
        private GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
            public void Dispense()
        {
            Console.WriteLine("You are a winnner you get 2 gumballs ");
            _gumballMachine.ReleaseBall();
            if(_gumballMachine.Count==0)
            {
                _gumballMachine.State=_gumballMachine.SoldOutState;
            }
            else
            {
                _gumballMachine.ReleaseBall();
                if(_gumballMachine.Count>0)
                {
                    _gumballMachine.State=_gumballMachine.NoQuarterState;
                }
                else
                {
                    Console.WriteLine("You are running out of gumballs");
                    _gumballMachine.State=_gumballMachine.SoldOutState;
                }
            }
        
        }

        public void EjectQuarter()
        {
            throw new InvalidOperationException();
        }

        public void InsertQuarter()
        {
            throw new InvalidOperationException();
        }

        public void TurnCrank()
        {
            throw new InvalidOperationException();
        }
    }
}
