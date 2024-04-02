using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ConcreteScreenSmartTvCreator : ScreenCreator
    {
        public override Screen CreateScreen()
        {
            return new ScreenSmartTv();
        }
    }
}
