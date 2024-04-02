

using FactoryMethod.Creator;
using FactoryMethod.Product;

Screen screen1 = new ConcreteScreenWebCreator().CreateScreen();
Screen screen2 = new ConcreteScreenSmartPhoneCreator().CreateScreen();
Screen screen3 = new ConcreteScreenSmartWatchCreator().CreateScreen();
Screen screen4 = new ConcreteScreenSmartTvCreator().CreateScreen();

Console.WriteLine("Screen web => " + screen1.GetMessageText());
Console.WriteLine("Screen smart phone => " + screen2.GetMessageText());
Console.WriteLine("Screen smart watch => " + screen3.GetMessageText());
Console.WriteLine("Screen smart tv => " + screen4.GetMessageText());
