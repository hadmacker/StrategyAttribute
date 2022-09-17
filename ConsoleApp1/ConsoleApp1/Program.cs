// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Collections.Generic;

StrategyFinder.For("Hello_Start")?.Execute();                     // "Hello <unset> Start"
StrategyFinder.For("Hello_End")?.Execute("hadmacker");            // "Hello hadmacker End"

// Handling different input parameters from above
StrategyFinder.For("CustomInput")?.Execute(new Object[] {1, 2} ); // "1+2=3"
StrategyFinder.For("CustomInput")?.Execute(new Object[] { 2 });   // "2+2=4"
StrategyFinder.For("CustomInput")?.Execute(new Object[] { });     // "0+0=0"
StrategyFinder.For("CustomInput")?.Execute(null);                 // "No mathable input"

// No strategy named "foobarbaz" is defined.
// This falls back to a "Default" strategy if found.
StrategyFinder.For("foobarbaz")?.Execute(null);                   // "foo <unset> bar <unset> baz"
