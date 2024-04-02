namespace Composite
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name) { Name = name; }

        public abstract string Operation();

        public virtual void Add(Employee component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Employee component)
        {
            throw new NotImplementedException();
        }

        public virtual Employee Get(int index)
        {
            throw new NotImplementedException();
        }
    }
}
