namespace TemplateMethodPattern
{
    using System;
    public abstract class Game
    {
       protected abstract void Initialize();
        protected abstract void StartPlay();
        protected abstract void EndPlay();

        //this is the algorithm
        public  void Play()
        {
            GameStarted();
            Initialize();
            StartPlay();
            EndPlay();
        }
        public void GameStarted()
        {
            Console.WriteLine("game Started");
        }
    }
}
