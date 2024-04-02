namespace Visitor
{
    internal class PersonVisitor : IVisitor
    {
        public void Visit(Person person)
        {
            if (person.Age >= 18)
            {
                Console.WriteLine($"{person.Name} is over 18.");
            }
            else
            {
                Console.WriteLine($"{person.Name} is under 18.");
            }
        }
    }
}
