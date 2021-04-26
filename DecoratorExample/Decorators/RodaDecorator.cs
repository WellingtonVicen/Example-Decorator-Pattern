using DecoratorExample.Interfaces;

namespace DecoratorExample
{
     //Concrete Decorator
    public class RodaDecorator : CarDecorator
    {
        public RodaDecorator(ICar car) : base(car)
        {
        }

        public override string SearchCar()
        {
            var car = base.SearchCar();
            car += "\n com roda Aro 16";
            return car;
        }
    }
}
