using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread theader = new Thread(new ThreadStart(new Action(() =>
            {

                Thread.Sleep(2000);
                Console.WriteLine("我是新建的子线程.....");


            })));
            Thread theader1 = new Thread(new ThreadStart(new Action(() =>
            {

                Thread.Sleep(1000);
                Console.WriteLine("我是新建的子线程a.....");


            })));
            theader.Start();
            theader1.Start();

            Console.WriteLine("我是主线程......");

            Console.ReadKey();
        }
    }
}
