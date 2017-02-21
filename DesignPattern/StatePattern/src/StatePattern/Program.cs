using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine.GetState().GetType().Name);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine.GetState().GetType().Name);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine.GetState().GetType().Name);


        }
    }
    }
