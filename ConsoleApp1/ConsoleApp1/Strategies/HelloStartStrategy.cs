using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategies
{
    [Strategy(Name = "Hello_Start")]
    internal class HelloStartStrategy : IStrategy
    {
        public void Execute(params object[] input)
        {
            if (input == null) return;
            var name = input.FirstOrDefault(i => i as string != null) ?? "<unset>";
            Console.WriteLine($"Hello {name} Start");
        }
    }
}
