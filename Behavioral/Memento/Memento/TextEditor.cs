namespace Memento
{
    public class TextEditor : IOriginator
    {
        private string text;

        public TextEditor(string text)
        {
            this.text = text;
        }

        public void Write(string newText)
        {
            Console.WriteLine("Writing: " + newText);
            text += " " + newText;
        }

        public ConcreteMemento Save()
        {
            Console.WriteLine("Saving state. Current text: " + text);
            return new ConcreteMemento(text);
        }

        public void Restore(ConcreteMemento memento)
        {
            text = memento.GetText();
            Console.WriteLine("state restored. Current text: " + text);
        }

        public void ShowText()
        {
            Console.WriteLine("Current text: " + text);
        }
    }
}
