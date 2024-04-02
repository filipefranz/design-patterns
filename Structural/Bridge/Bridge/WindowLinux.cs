namespace Bridge
{
    public class WindowLinux : IWindowBridge
    {
        public void drawButton(string title)
        {
            Console.WriteLine(title + " + Button Linux");
        }

        public void drawWindow(string title)
        {
            Console.WriteLine(title + " + Window Linux");
        }
    }
}
