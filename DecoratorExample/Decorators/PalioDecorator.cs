using DecoratorExample.Interfaces;

namespace DecoratorExample
{

    //Concrete Decorator
    public class PalioDecorator : CarDecorator
    {
        public PalioDecorator(ICar car) : base(car)
        {
        }


        public override string SearchCar()
        {
            var car = base.SearchCar();
            car += "\n modelo Palio";
            return car;
        }
    }
}
