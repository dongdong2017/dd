using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyThread
{
    class Program
    {
        private static int newTask(int ms)
        {
            Console.WriteLine("任务开始");
            Thread.Sleep(ms);
            Random random = new Random();
            int n = random.Next(10000);//返回一个小于10000的随机数
            Console.WriteLine("任务完成");
            return n;
         
        }

        private delegate int NewTaskDelegate(int ms);
        static void Main(string[] args)
        {
            
            NewTaskDelegate task = newTask;
            IAsyncResult asyncResult = task.BeginInvoke(2000,null,null);
            // EndInvoke方法将被阻塞2秒
            int result = task.EndInvoke(asyncResult);
            Console.WriteLine(result);
            
        }
    }
}
