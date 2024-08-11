using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dish dish = new Dish();
            Morg m;

            MorgReader mr = new MorgReader(new CSVReader(new FileReader("myMorgs.txt")), new MorgFactory());

            while((m = mr.ReadMorg()) != null)
            {
                dish.AddMorg(m);
            }

            Simulator sim = new Simulator(dish);
            sim.Run();

            /*Simulator s = new Simulator();
            s.Initialize();
            s.Run();
            */
        }
    }
}
