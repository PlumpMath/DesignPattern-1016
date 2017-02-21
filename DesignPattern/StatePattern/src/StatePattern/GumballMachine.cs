namespace StatePattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Interface;
    using States;
    public class GumballMachine
    {

        private State NoQuarterState { get; set; }
        private State HasQuarterState { get; set; }
        private State SoldOutState { get; set; }
        private State SoldState { get; set; }
        private State WinnerState { get; set; }

        private State State { get; set; }

        private int Count { get; set; } 

        public GumballMachine(int count)
        {
            State = SoldOutState;
            Count = count;
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldOutState = new SoldOutState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            if (count>0)
            {
                State = NoQuarterState;
            }
        }
        
        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void SetState(State state)
        {
            State = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot .....");
            if(Count>0)
            {
                Count = Count - 1;
            }
        }

        public int GetCount()
        {
            return Count;
        }

        public State GetNoQuarterState()
        {
            return NoQuarterState;
        }

        public State GetHasQuarterState()
        {
            return HasQuarterState;
        }
        public State GetSoldOutState()
        {
            return SoldOutState; 
        }
        public State GetSoldState()
        {
            return SoldState;
        }

        public State GetWinnerState()
        {
            return WinnerState;
        }
        public State GetState()
        {
            return State;
        }

    }
}
