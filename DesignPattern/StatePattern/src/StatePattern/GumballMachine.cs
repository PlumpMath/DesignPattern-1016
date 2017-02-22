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

        public State NoQuarterState { get; set; }
        public State HasQuarterState { get; set; }
        public State SoldOutState { get; set; }
        public State SoldState { get; set; }
        public State WinnerState { get; set; }

        public State State { get; set; }

        public int Count { get; set; }
        
        public String Location { get; set; }

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

     

    }
}
