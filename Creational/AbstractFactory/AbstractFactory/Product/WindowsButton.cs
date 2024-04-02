﻿namespace AbstractFactory.Product
{
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Drawing Butotn in Windows OS");
        }
    }
}
