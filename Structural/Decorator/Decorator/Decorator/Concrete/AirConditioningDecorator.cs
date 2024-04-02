using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete
{
    internal class AirConditioningDecorator : CarDecorator
    {
        public AirConditioningDecorator(ICar car) : base(car)
        {
        }

        public override string ReturnCar()
        {
            return base.ReturnCar() + " with Air Conditioning";
        }
    }
}
