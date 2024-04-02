namespace Memento
{
    public class ConcreteMemento : IMemento
    {
        private readonly string text;

        public ConcreteMemento(string text)
        {
            this.text = text;
        }

        public string GetText()
        {
            return text;
        }
    }
}
