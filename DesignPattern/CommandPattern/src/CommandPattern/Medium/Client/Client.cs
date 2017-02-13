namespace CommandPattern.Medium.Client
{
    using Invoker;
    using Receiver;
    using Command;
    using ConcreteCommand;
    public class Client
    {
        public void Start()
        {
            StockTrade st = new StockTrade();
            Command buyStock = new BuyStockOrder(st);
            Command sellStock = new SellStockOrder(st);
            Agent agent = new Agent();
            agent.SetCommand(buyStock);
            agent.SetCommand(sellStock);
           
            agent.DoAction();
            agent.Undo();
        }
    }
}
