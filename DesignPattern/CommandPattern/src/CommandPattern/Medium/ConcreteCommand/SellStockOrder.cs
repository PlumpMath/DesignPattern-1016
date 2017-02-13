namespace CommandPattern.Medium.ConcreteCommand
{
    using System;
    using Command;
    using Receiver;
    public class SellStockOrder : Command
    {
        private StockTrade stock;

        public SellStockOrder(StockTrade st)
        {
            stock = st;
        }
        public void Execute()
        {
            stock.Sell();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Store()
        {
            throw new NotImplementedException();
        }
        public void Undo()
        {
            stock.Buy();
        }
    }
}
