using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_pinvoke_swig
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpp = new cpp();
            Console.WriteLine("Five times two = " + cpp.times2(5));
        }
    }
}
