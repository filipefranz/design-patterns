namespace Decorator
{
    //Concrete Component
    public sealed class Car : ICar
    {
        public string ReturnCar()
        {
            var carro = "This is a basic car:";
            return carro;
        }
    }
}
