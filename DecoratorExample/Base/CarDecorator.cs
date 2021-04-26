using DecoratorExample.Interfaces;

namespace DecoratorExample
{

    //Base Decorator
    public class CarDecorator : ICar
    {
        private readonly ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string SearchCar()
        {
            var car = _car.SearchCar();
            return car;
        }
    }
}
