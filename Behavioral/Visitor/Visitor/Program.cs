using Visitor;

var person1 = new Person { Name = "Jonh", Age = 20 };
var person2 = new Person { Name = "Maria", Age = 16 };

var visitor = new PersonVisitor();

person1.Accept(visitor);
person2.Accept(visitor);