using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.Basic
{
    public class Basic
    {
        public void Start()
        {
            Target t = new Adapter();
            t.Request();
        }
    }

    public interface Target
    {
        void Request();
    }

    public class Adapter : Target
    {
        private Adaptee a = new Adaptee();
        public void Request()
        {
            a.Specifications();
        }
    }

    public class Adaptee
    {
        public void Specifications()
        {
            Console.WriteLine("called adapteee");
        }
    }
}
