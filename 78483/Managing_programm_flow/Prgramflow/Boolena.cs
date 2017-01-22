using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78483.Managing_programm_flow.Prgramflow
{
    class Boolena
    {
        public static void Main()
        {
            bool x = true;
            bool y = false;

            bool result = x || y;

            bool result2 = x || GetY();
            Console.WriteLine(result);
            Console.WriteLine(result2);


            //dealing with null 
            string test = null;
            bool result3 = test != null && test.StartsWith("v");
            Console.WriteLine(result3);

            
            Console.ReadLine();
        }


        private static  bool GetY()
        {
            Console.WriteLine("This method is never called because of the shortcircut nature");
            return true;
        }
    }
}
