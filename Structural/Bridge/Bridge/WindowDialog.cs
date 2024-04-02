namespace Bridge
{
    public class WindowDialog : WindowAbstract
    {
        public WindowDialog(IWindowBridge window) : base(window) { }
        public override void draw()
        {
            drawWindow("Warning! Do you want to close without saving?");
            drawButton("Yes");
            drawButton("No");
        }
    }
}
