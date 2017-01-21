using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _78483
{
    class MyTask
    { 

        public static void Main()
        {
            int i5 = new Int32();

            Console.WriteLine(i5);

            Console.WriteLine("c:\\winenti\\syst332");
            
            int i1 = 1;
            int j1 = 1;
            System.Console.WriteLine((object)i1 == (object)j1);
            //notmal taks 
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {

                    Console.WriteLine(i);
                }
            });

            t.Wait();

            //task with return value 
            Task<int> t1 = Task<int>.Run(()=> {

                return 42;
            });

            Console.WriteLine(t1.Result);


            //continus task
            Task<int> t2 = Task<int>.Run(() =>
            {
                return 42; 
            }).ContinueWith((i)=> {

                return i.Result * 2;
            });


            //Child task 

            Task<Int32[]> parent = Task.Run(()=> {
                var results = new Int32[3];

                new Task(()=> results[0]=0,TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[0] = 1, TaskCreationOptions.AttachedToParent).Start(); ;
                new Task(() => results[0] = 2, TaskCreationOptions.AttachedToParent).Start();

                return results;
               
            });

            Console.WriteLine(t2.Result);

            Console.ReadKey();

        }
    }
}
