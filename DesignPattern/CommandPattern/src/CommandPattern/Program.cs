using CommandPattern.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Basic1().Start();
            new Client().CreateOrder();

            //medium level
            new Medium.Client.Client().Start();
          
        }
    }
}
