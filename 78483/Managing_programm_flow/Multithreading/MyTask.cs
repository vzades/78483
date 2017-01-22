using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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

            Console.WriteLine(t2.Result);
            //Child task 

            Task<Int32[]> parent = Task.Run(()=> {
                var results = new Int32[3];

                new Task(()=> results[0]=0,TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();
                return  results;
               
            });

            var finaltask = parent.ContinueWith((s) =>
            {
                foreach (int i  in s.Result)
                {
                    Console.WriteLine(i);
                }
            });

            //taskfactory 
            Task<Int32[]> parent1 = Task.Run( ()=>
            {
                var results = new Int32[3];

                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => results[0] == 1);
                tf.StartNew(() => results[1] == 2);
                tf.StartNew(() => results[2] == 3);

                return results;
            } 
            );


            var finaltask2 = parent1.ContinueWith((s)=> {

                foreach (var item in s.Result)
                {
                    Console.WriteLine(item);
                }

            });

            finaltask2.Wait();


            //wait all 
            Task[] alltask = new Task[3];
            alltask[0] = Task.Run(() =>
             {
                 Thread.Sleep(1000);
                 Console.WriteLine("1");
                 return 1;
             });

            alltask[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });

            alltask[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 3;
            });

            Task.WaitAll(alltask);
            Console.ReadKey();

        }
    }
}
