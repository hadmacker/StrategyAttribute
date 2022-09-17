using System.Reflection;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class StrategyFinder
    {
        private static List<Tuple<StrategyAttribute?, Type>> Strategies { get; } = new();

        static StrategyFinder()
        {
            var types =
                AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(a => a.GetTypes()
                    .Where(t => t.IsDefined(typeof(StrategyAttribute), false) && !t.IsAbstract))
                    .Select(t => new Tuple<StrategyAttribute?, Type>(t.GetCustomAttribute<StrategyAttribute>(), t));
            Strategies.AddRange(types);
        }

        public static IStrategy? For(string name)
        {
            var preferredStrategy = Strategies
                .FirstOrDefault(
                    s => s.Item1?.Name.Equals(name, StringComparison.OrdinalIgnoreCase) ?? false);

            if (preferredStrategy != null)
                return Activator.CreateInstance(preferredStrategy.Item2) as IStrategy;

            var defaultStrategy = Strategies
               .FirstOrDefault(
                   s => s.Item1?.Name.Equals("Default", StringComparison.OrdinalIgnoreCase) ?? false);

            if (defaultStrategy != null)
                return Activator.CreateInstance(defaultStrategy.Item2) as IStrategy;

            return null;
        }
    }
}
