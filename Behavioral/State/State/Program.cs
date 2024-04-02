using State;

var context = new Context();

// Executa ação do Estado A
context.State = new StateA();
context.Request();

// Executa ação do Estado B
context.Request();

// Executa ação do Estado A novamente
context.Request();