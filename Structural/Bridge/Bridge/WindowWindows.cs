namespace Bridge
{
    public class WindowWindows : IWindowBridge
    {
        public void drawButton(string title)
        {
            Console.WriteLine(title + " + Button Windows");
        }

        public void drawWindow(string title)
        {
            Console.WriteLine(title + " + Window Windows");
        }
    }
}
