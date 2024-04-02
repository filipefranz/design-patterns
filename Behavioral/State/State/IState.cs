namespace State
{
    internal interface IState
    {
        void Handle(Context context);
    }
}
