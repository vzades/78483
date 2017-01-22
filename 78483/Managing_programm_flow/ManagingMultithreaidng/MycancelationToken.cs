using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _78483.Managing_programm_flow.ManagingMultithreaidng
{
    class MycancelationToken
    {
        public static void Main()
        {

            CancellationTokenSource cancllatinoToken = new CancellationTokenSource();
            CancellationToken calclationtoken = cancllatinoToken.Token;

            Task task = Task.Run(() =>
            {
                while(!cancllatinoToken.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(100);
                }
            },calclationtoken);

            Console.WriteLine("presss enter to cancel the Thread");
            Console.ReadLine();
            cancllatinoToken.Cancel();

            Console.WriteLine("Press enther to end the appliation ");
            Console.ReadLine();

          
            
        }
    }
}
