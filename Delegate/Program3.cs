using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate int calculator(int x, int y); //委托类型
    class Program3
    {
        static void Main()
        {
            calculator sum = (x, y) => x + y;//Lambda表达式
            Console.WriteLine(sum(1,2));
            Console.ReadLine();
        }
    }
}
