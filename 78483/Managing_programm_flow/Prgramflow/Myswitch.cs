using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78483.Managing_programm_flow.Prgramflow
{
    class Myswitch
    {
        public static void Main()
        {

            switchcase(1);

            Console.ReadKey();
        }

        static void switchcase(int i )
        {

            switch(i)
                {

                case 1:
                    {
                        Console.WriteLine("into the case 1 ");
                        goto case 2;
                    }
                case 2:
                    {
                        Console.WriteLine("Into the case 2");
                        break;
                    }
            }
        }
    }
}
