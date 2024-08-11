using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    interface IFeedingBehavior
    {
        void Feed();
    }

    class Absorbs : IFeedingBehavior
    {
        public void Feed()
        {
            Console.WriteLine("Squeezing and Absorbing");
        }
    }

  class Envelopes : IFeedingBehavior
    {
        public void Feed()
        {
            Console.WriteLine("Enveloping and Overwhelming");
        }
    }
}
