namespace CommandPattern.Medium.Invoker
{
    using System.Collections.Generic;
    using Command;
    public class Agent
    {
         private List<Command> commands = new List<Command>();

        public void SetCommand(Command c)
        {
            commands.Add(c);
        }

        public void DoAction()
        {
            foreach(Command c in commands)
            {
                c.Execute();
            }
        }

        public void Undo()
        {
           int noOfItems= commands.Count;
            commands[noOfItems - 1].Undo();
        }
    }
}
