namespace FactoryMethodPattern
{
    using ConcreateCreators;
    using Creator;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Document[] documents = new Document[2];
            documents[0] = new Report();
            documents[1] = new Resume();

            foreach(var document in documents)
            {
                Console.WriteLine("\nCreator : " + document.GetType().Name + "\n Product : ");
                foreach(var page in document.Pages)
                {
                    Console.WriteLine(page.GetType().Name + "\t");
                }
            }
        }
    }
}
