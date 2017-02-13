using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Basic1
    {
        public void Start()
        {
            Light light = new Light();
            Command l = new LightOnCommand(light);
            SimpleRemoteControl s = new SimpleRemoteControl();
            s.SetOnCommand(l);
            s.ButtonPressed();
        }
    }

    public class Light
    {

    }

    public interface Command
    {
        void Execute();
    }

    public class LightOnCommand : Command
    {
       private Light light;

      public  LightOnCommand(Light l)
        {
            light = l;
        }
        public void Execute()
        {
            Console.WriteLine("Light is on");
        }
    }

    public class SimpleRemoteControl
    {
        Command slot;

        public void SetOnCommand(Command c)
        {
            slot = c;
        }
        public void ButtonPressed()
        {
            slot.Execute();
        }
    }
}
