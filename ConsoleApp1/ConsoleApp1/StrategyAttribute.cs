namespace ConsoleApp1
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    internal class StrategyAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
