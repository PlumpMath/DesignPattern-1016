namespace CommandPattern.Medium.ConcreteCommand
{
    using System;
    using Command;
    using Receiver;
    public class BuyStockOrder : Command
    {
        private StockTrade stock;

        public BuyStockOrder(StockTrade st)
        {
            stock = st;
        }
        public void Execute()
        {
            stock.Buy();
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
            stock.Sell();
        }
    }
}
