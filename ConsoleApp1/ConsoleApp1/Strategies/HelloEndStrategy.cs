namespace ConsoleApp1.Strategies
{
    [Strategy(Name = "Hello_End")]
    internal class HelloEndStrategy : IStrategy
    {
        public void Execute(params object[] input)
        {
            if (input == null) return;
            var name = input.FirstOrDefault(i => i as string != null) ?? "<unset>";
            Console.WriteLine($"Hello {name} End");
        }
    }
}
