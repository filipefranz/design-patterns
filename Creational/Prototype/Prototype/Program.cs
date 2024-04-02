
using Prototype;

EnemyA enemy1 = new();
enemy1.Name = "Enemy 1";
enemy1.Color = "Blue";
enemy1.Gun = new Gun("Pistol");

Enemy enemy2 = new EnemyA();
enemy2 = enemy1.DeepCopy();

enemy1.Gun.Name = "Sword";

Console.WriteLine("End");
