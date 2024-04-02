namespace State
{
    internal class StateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Executing State A action");
            context.State = new StateB();
        }
    }
}
