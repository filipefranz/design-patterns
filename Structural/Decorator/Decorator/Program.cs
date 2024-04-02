using Decorator;
using Decorator.Decorator.Concrete;

ICar car = new Car();
ICar rimDecorator = new ChromeRimDecorator(car);
ICar airDecorator = new AirConditioningDecorator(rimDecorator);
ICar seatDecorator = new LeatherSeatDecorator(airDecorator);
ICar multimediaDecorator = new MultimediaDecorator(seatDecorator);

var result = multimediaDecorator.ReturnCar();

Console.WriteLine(result);