using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace _78483
{
    class Program
    {

        public static ThreadLocal<int> _field = new ThreadLocal<int>(()=>
        {
            return Thread.CurrentThread.ManagedThreadId;
        });
       
        
        static void Main(string[] args)
        {

            new Thread(()=> {
                for (int i = 0; i < _field.Value; i++)
                {
                   
                    Console.WriteLine("thread A:{0}", i);

                }

            }

                ).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    
                    Console.WriteLine("thread b:{0}", i);

                }

            }

                            ).Start();
            Console.ReadKey();






        }

        public static void ThreadMethod(object o )
        {
            for(int i = 0; i<(int)o;i++)
            {
                Console.WriteLine("Thredproc :{0}", i);
                Thread.Sleep(1000);
                
            }

            
        }
    }
}

