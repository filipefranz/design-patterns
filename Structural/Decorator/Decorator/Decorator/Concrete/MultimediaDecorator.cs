using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete
{
    public class MultimediaDecorator : CarDecorator
    {
        public MultimediaDecorator(ICar car) : base(car)
        {
        }

        public override string ReturnCar()
        {
            return base.ReturnCar() + " with multimedia";
        }
    }
}
