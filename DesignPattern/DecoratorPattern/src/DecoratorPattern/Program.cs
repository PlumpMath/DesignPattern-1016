namespace DecoratorPattern
{
    using Beverages;
    using Condiments;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

            Beverage b2 = new DarkRoast();
            b2 = new Mocha(b2);
            b2 = new Mocha(b2);
            b2 = new Whip(b2);
            Console.WriteLine(b2.GetDescription() + " $ " + b2.Cost());

            Beverage b3 = new HouseBlend();
            b3 = new Soy(b3);
            b3 = new Mocha(b3);
            b3 = new Whip(b3);
            Console.WriteLine(b3.GetDescription() + " $ " + b3.Cost());

        }
    }
}
