using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    interface IMovementBehavior
    {
        void Move();
    }

    class Ooze: IMovementBehavior
    {
        public void Move()
        {
            Console.WriteLine("...Oozing away...");
        }
    }

    class Paddle: IMovementBehavior
    {
        public void Move()
        {
            Console.WriteLine("...paddling to the future...");
        }
    }

    class Shuffle: IMovementBehavior
    {
        public void Move()
        {
            Console.WriteLine("...shuffling away..") ;
        }
    }

}
