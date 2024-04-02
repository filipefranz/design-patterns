using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ConcreteScreenSmartWatchCreator : ScreenCreator
    {
        public override Screen CreateScreen()
        {
            return new ScreenSmartWatch();
        }
    }
}
