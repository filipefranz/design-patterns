using Composite;

EmployeeComposite tree = new("Bill Gates");
EmployeeLeaf leader1 = new("Jonh");
EmployeeLeaf leader2 = new("Paul");
EmployeeComposite leader3 = new("Steve");

EmployeeLeaf leader4 = new("Elon");
EmployeeLeaf leader5 = new("Gabriel");

tree.Add(leader1);
tree.Add(leader2);
tree.Add(leader3);

leader3.Add(leader4);
leader3.Add(leader5);

Console.WriteLine(tree.Operation());

Console.WriteLine(leader3.Operation());