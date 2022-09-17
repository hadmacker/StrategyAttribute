// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

StrategyFinder.For("Hello_Start")?.Execute("hadmacker");
StrategyFinder.For("Hello_End")?.Execute("hadmacker");
StrategyFinder.For("CustomInput")?.Execute(new Object[] {1, 2} );
StrategyFinder.For("CustomInput")?.Execute(new Object[] { 2 });
StrategyFinder.For("CustomInput")?.Execute(new Object[] { });
StrategyFinder.For("CustomInput")?.Execute(null);
StrategyFinder.For("foobarbaz")?.Execute(null);