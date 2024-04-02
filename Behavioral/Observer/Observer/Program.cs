using Observer;

ConcreteSubject subject = new ConcreteSubject();
ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

subject.RegisterObserver(observer1);
subject.RegisterObserver(observer2);

subject.NotifyObservers(42);

subject.RemoveObserver(observer2);

subject.NotifyObservers(84);
