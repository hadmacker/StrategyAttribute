namespace ConsoleApp1.Strategies
{
    [Strategy(Name = "CustomInput")]
    internal class CustomInputStrategy : IStrategy
    {
        public void Execute(params object[] input)
        {
            if(input == null)
            {
                Console.WriteLine($"no mathable input");
                return;
            }
            var a = (int)input.FirstOrDefault(i => i is int, 0);
            var b = (int)input.LastOrDefault(i => i is int, 0);
            Console.WriteLine($"{a}+{b}={a+b}");
        }
    }
}
