namespace Visitor
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
