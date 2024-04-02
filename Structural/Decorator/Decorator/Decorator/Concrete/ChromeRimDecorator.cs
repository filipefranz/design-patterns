using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete
{
    public class ChromeRimDecorator : CarDecorator
    {
        public ChromeRimDecorator(ICar car) : base(car)
        {
        }

        public override string ReturnCar()
        {
            return base.ReturnCar() + " with chorme rim";
        }
    }
}
