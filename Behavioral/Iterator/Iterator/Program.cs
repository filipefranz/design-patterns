
using Iterator;

ConcreteAggregate aggregate = new ConcreteAggregate();
aggregate.AddItem("Item 1");
aggregate.AddItem("Item 2");
aggregate.AddItem("Item 3");

IIterator iterator = aggregate.CreateIterator();
Console.WriteLine("Iterating over collection:");

//should show only the first two items
for (object item = iterator.First(); !iterator.IsDone; item = iterator.Next())
{
    Console.WriteLine(item);
}

Console.WriteLine("End Iteration");
