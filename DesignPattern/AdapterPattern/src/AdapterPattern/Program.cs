namespace AdapterPattern
{
    using Basic1;
    using Basic;
    using RealWorld.Client;
    public class Program
    {
        public static void Main(string[] args)
        {
            //new Basic1.Basic1().Start();
            //new Basic.Basic().Start();
            new Client().Start();
            
        }
    }
}
