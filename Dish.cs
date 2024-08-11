using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    class Dish
    {
        //public const int width = 50;
        //public const int height = 50;
        public List<Morg> morgs;

        public Dish()
        {
            morgs = new List<Morg>();
        }


        public void AddMorg(Morg m)
        {
            morgs.Add(m);

        }

        public List<Morg> GetMorgs()
        {
            return morgs;
        }

        public IEnumerable<Morg> Morgs
        {
            get { return morgs; }
        }
    }
}
