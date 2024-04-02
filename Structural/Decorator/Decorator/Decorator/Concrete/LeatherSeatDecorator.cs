using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete
{
    public class LeatherSeatDecorator : CarDecorator
    {
        public LeatherSeatDecorator(ICar car) : base(car)
        {
        }
        public override string ReturnCar()
        {
            return base.ReturnCar() + " with leather seat";
        }

    }
}
