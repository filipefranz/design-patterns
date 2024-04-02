using System.Collections;

namespace Iterator
{
    public class ConcreteAggregate
    {
        private ArrayList _items = new ArrayList();

        public void AddItem(object item)
        {
            _items.Add(item);
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
