namespace Bridge
{
    public abstract class WindowAbstract
    {
        protected IWindowBridge window;

        public WindowAbstract(IWindowBridge w)
        {
            window = w;
        }

        public void drawWindow(string title)
        {
            Console.WriteLine("Drawing window...");
            window.drawWindow(title);
        }

        public void drawButton(string title)
        {
            window.drawButton(title);
        }

        public abstract void draw();
    }
}
