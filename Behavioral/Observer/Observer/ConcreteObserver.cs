﻿namespace Observer
{
    internal class ConcreteObserver : IObserver
    {
        private string _observerName;

        public ConcreteObserver(string name)
        {
            _observerName = name;
        }

        public void Update(int value)
        {
            Console.WriteLine($"Observer {_observerName} received update: {value}");
        }
    }
}
