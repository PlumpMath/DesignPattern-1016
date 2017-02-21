namespace StatePattern.States
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Interface;
    public class HasQuarterState : State
    {
        private GumballMachine _gumballMachine;
        Random random = new Random();
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter Returned");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can’t insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned....");
            int winner = random.Next(3);
            if ((winner == 0) && (_gumballMachine.GetCount() > 1))
            {
                _gumballMachine.SetState(_gumballMachine.GetWinnerState());
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldState());
            }
            }
    }
}
