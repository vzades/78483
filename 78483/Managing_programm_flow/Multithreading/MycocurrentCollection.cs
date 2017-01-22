using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;

namespace _78483
{
    class MycocurrentCollection
    {

        public static void Main()
        {
        //    BlockingCollection<string> col = new BlockingCollection<string>();



        //    //using for ech for the task 

        //    Task read2 = Task.Run(() =>
        //    {

        //        foreach (var item in col.GetConsumingEnumerable())
        //        {

        //            Console.WriteLine(item);
        //        }
        //    });
        //    Task read = Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine(col.Take());
        //        }
        //    });

        //    Task write = Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            string s = Console.ReadLine();
        //            if (string.IsNullOrWhiteSpace(s)) break;
        //            col.Add(s);
                    
        //        }
        //    });




        //    write.Wait();


            //cocurrent bag 


            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(42);
            bag.Add(32);

            int result;
            if (bag.TryPeek(out result))
                Console.WriteLine("Threre is the next item{0} ", result);


            //concurrent bag Ienumrable 

            ConcurrentBag<int> bag2 = new ConcurrentBag<int>();
            Task.Run(() =>
            {
    
                bag2.Add(32);
                Thread.Sleep(10000);
                bag2.Add(21);
                
            });

            Task.Run(() =>
            {

                foreach (var item in bag2)
                {

                    Console.WriteLine(item);
                }
            }).Wait();


            //cocurrent dictiornary 
            var dict = new ConcurrentDictionary<string, int>();
            if(dict.TryAdd("k1",42))
            {
                Console.WriteLine("added");
            }
            if(dict.TryUpdate("k1",21,42))
            {
                Console.WriteLine("42 is updated to 21");
            }

            dict["k1"] = 42; //override unconditionlay 


            Console.ReadLine();

        }
    }
}
