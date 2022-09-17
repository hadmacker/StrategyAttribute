namespace ConsoleApp1.Strategies
{
    [Strategy(Name = "Default")]
    internal class DefaultStrategy : IStrategy
    {
        public void Execute(params object[] input)
        {
            var name = input?.FirstOrDefault(i => i as string != null) ?? "<unset>";
            Console.WriteLine($"foo {name} bar {name} baz");
        }
    }
}
