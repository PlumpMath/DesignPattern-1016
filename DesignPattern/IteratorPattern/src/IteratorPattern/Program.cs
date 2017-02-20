namespace IteratorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Basic;
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate(5);
            a[0] = new ConcreteAggregate();
            a[1] = new ConcreteAggregate();
           Iterator i =  a.CreateIterator();
           while(i.HasNext())
            {
                Console.WriteLine(i.Next().GetType().ToString());
            }
        }
    }
}
