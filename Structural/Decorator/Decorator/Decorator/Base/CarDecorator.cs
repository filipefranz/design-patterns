namespace Decorator.Decorator.Base
{
    //Decorator (Base)
    public class CarDecorator : ICar
    {
        private readonly ICar Car;

        public CarDecorator(ICar car)
        {
            Car = car;
        }

        public virtual string ReturnCar()
        {
            return Car.ReturnCar();
        }
    }
}
