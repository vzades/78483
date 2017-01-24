using System;
using System.IO;
namespace _78483.Managing_programm_flow.Event_and_callback
{
    class Mydelegates
    {

        public delegate int Calculae(int x, int y);
        public delegate TextWriter CovarinaceDel();

        public delegate void ContraValriance(StreamWriter rw);
        public static StreamWriter MethodStream() { return null; }
        public static StringWriter MethodString() { return null; }
        public static void  dosomething(TextWriter tw ) { }
        public static int Add(int x, int y) { return x + y; }
        
        public static int Multiply(int x, int y) { return x * y; }

        public static void Main()
        {
            Calculae calc = Add;
            Console.WriteLine(calc(3, 4));

            calc = Multiply;
            Console.WriteLine(calc(3, 4));


            //covariance and contravairance 
            CovarinaceDel del;
            del = MethodStream;
            del += MethodString;

            del();

            ContraValriance del2;
            del2 = dosomething;


            Console.ReadLine();

        }

        
    }
}
