using DecoratorExample.Interfaces;

namespace DecoratorExample.Entities
{
    public class Car : ICar
    {
        public string SearchCar()
        {
            var car = "Este é um carro Popular";
            return car;
        }
    }
}
