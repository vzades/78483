using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _78483
{
    class MYThreadPool
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s)=>
            {
                Console.WriteLine("wokring on the thred from the thread pool");
            });

            Console.ReadLine();
        }
    }
}
