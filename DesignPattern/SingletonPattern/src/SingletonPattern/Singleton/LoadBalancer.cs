
namespace SingletonPattern.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class LoadBalancer
    {
        private static readonly LoadBalancer _instance = new LoadBalancer();

        public List<Server> _servers;
        private Random _random = new Random();
        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server {Name="Server1" , Ip="120.14.228.10" },
                new Server {Name="Server2" , Ip="120.14.228.11" },
                new Server { Name="Server3",Ip="120.14.228.12" },
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return _instance;
        }

        public Server NextServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
