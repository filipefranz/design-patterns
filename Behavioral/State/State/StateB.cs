namespace State
{
    internal class StateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Executing State B action");
            context.State = new StateA();
        }
    }
}
