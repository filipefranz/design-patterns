namespace Memento
{
    internal class CaretakerMemento
    {
        private List<ConcreteMemento> savesStates = new();

        public void AddMemento(ConcreteMemento memento)
        {
            savesStates.Add(memento);
        }

        public ConcreteMemento GetMemento(int indice)
        {
            return savesStates[indice];
        }
    }
}
