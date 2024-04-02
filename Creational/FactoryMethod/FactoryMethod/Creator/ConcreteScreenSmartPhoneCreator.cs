using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ConcreteScreenSmartPhoneCreator : ScreenCreator
    {
        public override Screen CreateScreen()
        {
            return new ScreenSmartPhone();
        }
    }
}
