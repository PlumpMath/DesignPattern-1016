using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern.Basic
{
    public interface Command
    {
        void Execute();
    }

    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Receiver performs an action");
        }
    }
    public class ConcreteCommand : Command
    {
        private Receiver receiver;
        public ConcreteCommand(Receiver r)
        {
            receiver = r;
        }
        public void Execute()
        {
            receiver.Action();
        }
    }

    public class Invoker
    {
        private Command command;

        public void SetCommand(Command c)
        {
            command = c;
        }

        public void PerformAction()
        {
            command.Execute();
        }
    }

    public class Client
    {
        public void CreateOrder()
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker i = new Invoker();
            i.SetCommand(c);
            i.PerformAction();

        }
    }
}
