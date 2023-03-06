using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usings
{
    internal class SomeClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing someclass");
        }

        internal void Say(string input)
        {
            Console.WriteLine(input);
        }
    }
}
