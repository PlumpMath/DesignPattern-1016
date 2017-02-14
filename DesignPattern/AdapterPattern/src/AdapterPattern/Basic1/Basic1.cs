namespace AdapterPattern.Basic1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Basic1
    {
        
        public void Start()
        {
            Duck d = new MallardDuck();
            Turkey t = new WildTurkey();
            Console.WriteLine("turkey");
            t.Gobble();
            t.Fly();
            Console.WriteLine("duck");
            Basic1.TestDuck(d);
            Console.WriteLine("turkey");
            TurkeyAdapter ta = new TurkeyAdapter(t);
            TestDuck(ta);
        }

        static void TestDuck(Duck d)
        {
            d.Quack();
            d.Fly();
        }
    }

    public interface Duck
    {
        void Quack();
        void Fly();
    }

    public interface Turkey
    {
        void Gobble();
        void Fly();
    }

    public class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("fly");
        }

        public void Quack()
        {
            Console.WriteLine("quack");
        }
    }

    public class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("fly");
        }

        public void Gobble()
        {
            Console.WriteLine("gobble");
        }
    }

    public class TurkeyAdapter : Duck
    {
       private Turkey turkey;

        public TurkeyAdapter(Turkey t)
        {
            turkey = t;
        }
        public void Fly()
        {
            for(int i=0;i<5;i++)
            {
                turkey.Fly();
            }
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
