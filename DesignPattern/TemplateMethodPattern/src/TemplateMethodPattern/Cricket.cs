namespace TemplateMethodPattern
{
    using System;
    public class Cricket : Game
    {
        protected override void EndPlay()
        {
            Console.WriteLine("Cricket End Play");
        }

        protected override void Initialize()
        {
            Console.WriteLine("Cricket initialize");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Cricket Start Play");
        }

        
    }
}
