using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78483.Managing_programm_flow.Prgramflow
{
    class MyForeach
    {
        public static void Main()
        {

            var people = new List<person>
            {

                new person()
                {
                    FirstName ="test",
                    LastName = "test2"
                },
                new person()
                {
                    FirstName="test",
                    LastName = "test2",
                }
            };

            foreach (var item in people)
            {

                item.LastName = "chagnes";
                //item = new person(); //This will be compiler error 
            }
        

                        
        }
    }

    class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
