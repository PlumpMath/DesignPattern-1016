namespace TemplateMethodPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Football : Game
    {
        protected override void EndPlay()
        {
            Console.WriteLine("football endplay");
        }

        protected override void Initialize()
        {
            Console.WriteLine("football Initialize");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("football startPlay");
        }
    }
}
