using DecoratorExample.Entities;
using DecoratorExample.Interfaces;
using System;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Car();
            ICar palioDecorator = new PalioDecorator(car);
            ICar corDecorator = new CorDecorator(palioDecorator);
            ICar RodaDecorator = new RodaDecorator(corDecorator);

            Console.WriteLine(RodaDecorator.SearchCar());
            Console.WriteLine();
        }
    }
}
