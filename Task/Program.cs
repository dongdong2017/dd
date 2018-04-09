using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tasktest
{
    class Program
    {
      
        public async Task ImportAccId(string accName)
        {
            await Task.Delay(10000);
            int _int = await add(accName); 
        }

        private Task<int> add(string accName)
        {
           if(accName == "aa")
            {
             
                return 1231;
            }
            else
            {
                return 222;
            }
        }

        static void Main(string[] args)
        {
            string accName = "aa";
            var accountid = Task.Run(async () =>
            {
                return await ImportAccId(accName);
            });

            Console.ReadLine( accountid.Result);

        }
    }
}
