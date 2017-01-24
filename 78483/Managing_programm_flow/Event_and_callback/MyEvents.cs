using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78483.Managing_programm_flow.Event_and_callback
{
    class MyEvents
    {
   
         public static void Main()
        {
            pub p = new pub();
            //p.Onchange += () => Console.WriteLine("event is reaise to method 1");
            //p.Onchange += () => Console.WriteLine("event is reaised to method 2 ");

            p.Onchange += (sender, e) => Console.WriteLine("event is raised : {0}", e.Value);

            p.Raie();

            Console.ReadLine();
        }     
    }

 
    public class Myargs:EventArgs
    {
        public Myargs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
    public  class pub
    {
        //   public Action Onchange { get; set; }


        //following needs to be added for the event 

        public event EventHandler<Myargs> Onchange = delegate { };
        public void Raie()
        {

            //if(Onchange !=null)
            //{
            //    Onchange();
            //}

            //follwong needts to added for the event 

            Onchange(this, new Myargs(42));
        }
    }
}
