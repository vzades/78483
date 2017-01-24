using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;

namespace _78483.Managing_programm_flow
{
    class MYExceptionHandling
    {

       

       public static void Main()
        {
            ExceptionDispatchInfo possibleexception = null;
            try
            {

                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleexception = ExceptionDispatchInfo.Capture(ex);
               
            }


            if(possibleexception!= null)
            {
                possibleexception.Throw();
            }
        }
    }
}
