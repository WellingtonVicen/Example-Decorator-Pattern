using DecoratorExample.Interfaces;

namespace DecoratorExample
{

    //Concrete Decorator
    public class CorDecorator : CarDecorator
    {
        public CorDecorator(ICar car) : base(car)
        {
        }

        public override string SearchCar()
        {
            var car = base.SearchCar();
            car += "\n da Cor Azul";
            return car;
        }
    }


}
