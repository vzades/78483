using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78483
{
    class baseclass
    {
        public virtual void print()
        {
            Console.WriteLine("This if from base  class ");
        }
    }

    class derivedclass : baseclass
    {

        public new void print()
        {
            Console.WriteLine("this is form derived class");

        }
    }

    public class progrma
    {
        public static void Main()
        {
            baseclass b = new baseclass();
            b.print();

            baseclass b1 = new derivedclass();
            b1.print();


            derivedclass d = new derivedclass();
            d.print();

           
            Console.ReadKey();
            }
    }
}
