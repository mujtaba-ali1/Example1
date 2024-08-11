using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    class Simulator
    {
        int RUN_TIME = 100;
        Dish dish;
     
       
        public Simulator(Dish dish)
        {
            this.dish = dish;
        }

        public void Run()
        {
            for(int t=0; t < RUN_TIME; t++)
            {
                foreach(Morg m in dish.Morgs)
                {
                    Console.Write(m.Name + " is...");
                    m.Move();

                   Console.Write(m.Name + "....");
                   m.Feed();

                    Console.WriteLine("---------------------");
                }
            }

        }

    }
}
