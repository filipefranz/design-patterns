
using Builder;

HamburguerBuilder hamburguerBuilder = new();

var hamburguerSalad =
    hamburguerBuilder
    .SetTypeBread("white")
    .SetTypeMeat("bovine")
    .HaveSalad()
    .Build();

hamburguerBuilder = new();
var hamburguerBacon =
    hamburguerBuilder
    .SetTypeBread("white")
    .SetTypeMeat("bovine")
    .HaveBacon()
    .HaveCheese()
    .Build();

hamburguerBuilder = new();
var hamburguerAll =
    hamburguerBuilder
    .SetTypeBread("white")
    .SetTypeMeat("bovine")
    .HaveBacon()
    .HaveCheese()
    .HaveSalad()
    .HavePotatosFries()
    .Build();

Console.WriteLine(hamburguerSalad.getDescription());
Console.WriteLine("------------------------------------------");
Console.WriteLine(hamburguerBacon.getDescription());
Console.WriteLine("------------------------------------------");
Console.WriteLine(hamburguerAll.getDescription());


