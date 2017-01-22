using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _78483.Managing_programm_flow.ManagingMultithreaidng
{
    class MYLock
    {
        public static void Main()
        {
            int n = 0;

            object _lock = new object();
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                     lock (_lock) 
                    n++;
                }
            });

            for (int i = 0; i < 1000000; i++)
            {

                lock (_lock) 
                n--;
            }
            up.Wait();
            Console.WriteLine(n);


            //interlocked classes 

            int x = 0;
            var up2 = Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Interlocked.Increment(ref x);
                }
            });

            for (int i = 0; i < 10000; i++)
            {
                Interlocked.Decrement(ref x);

            }

            Console.WriteLine(x);
            Console.ReadKey();
        }


    }
}
