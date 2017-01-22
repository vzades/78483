using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace _78483
{
    class MyParaller
    {
         public static void Main()
        {
            var numbers = Enumerable.Range(0,10);
            var parallelResults = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();
            foreach (var item in parallelResults)
            {

                Console.WriteLine(item);
            }




            //asordered 
            var numbers1 = Enumerable.Range(0, 10);
            var parallelResults1 = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();
            foreach (var item in parallelResults1)
            {

                Console.WriteLine(item);
            }

            //aggrigation exception 

            var numbers2 = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel().Where(i => IsEven(i));

                parallelResult.ForAll(e => Console.WriteLine("e"));
            }
            catch (AggregateException ex)
            {

                Console.WriteLine("tehre were {0} exception", ex.InnerExceptions.Count);
            }
            Console.ReadKey();
        }
        
        public static bool IsEven(int i )
        {
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        } 
        
    }
}
