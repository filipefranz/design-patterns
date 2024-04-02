using Strategy;

var context = new Context(new StrategyA());
context.ExecuteStrategy();

context.SetStrategy(new StrategyB());
context.ExecuteStrategy();
