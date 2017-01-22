using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78483.Managing_programm_flow.Prgramflow
{
    class MyFor
    {
        public static void Main()

        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int x = 0, y=values.Length-1;((x<values.Length) && (y>=0));x++,y--)
            {
                Console.WriteLine(values[x]);
                Console.WriteLine(values[y]);

            }

            Console.ReadLine();
        }
    }
}
