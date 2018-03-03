using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate int calculator(int a, int b);//委托类型
        //static void Main(string[] args)
        //{
        //    calculator Num = new calculator(add);
            
        //    Console.WriteLine(Num(1, 2));
        //}

        private static int add(int a, int b)
        {
            return a + b;
        }
    }
}
