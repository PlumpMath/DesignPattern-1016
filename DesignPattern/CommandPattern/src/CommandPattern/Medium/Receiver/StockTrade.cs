namespace CommandPattern.Medium.Receiver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class StockTrade
    {
        private int stocks = 0;
        public void Buy()
        {
            Console.WriteLine("stocks : "+(++stocks));
        }

        public void Sell()
        {

            Console.WriteLine("stocks : " + (--stocks));
        }
    }
}
