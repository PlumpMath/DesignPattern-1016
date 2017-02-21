namespace StatePattern.States
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Interface;
    public class SoldState : State
    {
        private GumballMachine _gumballMachine;


        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if(_gumballMachine.GetCount()>0)
            {
                _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldState());
            }
          
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry , you already turned the crank");
        }


        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine(" Turning twice doesn't get you another gumball");
        }
    }
}
