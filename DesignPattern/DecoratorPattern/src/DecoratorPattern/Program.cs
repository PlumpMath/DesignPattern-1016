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

            Beverage c1 = new DarkRoast();
             c1 = new Mocha(c1);
            c1 = new Mocha(c1);
            c1 = new Whip(c1);
            Console.WriteLine(c1.GetDescription() + " $ " + c1.Cost());

            Beverage b3 = new HouseBlend();
            b3 = new Soy(b3);
            b3 = new Mocha(b3);
            b3 = new Whip(b3);
            Console.WriteLine(b3.GetDescription() + " $ " + b3.Cost());

        }
    }
}
