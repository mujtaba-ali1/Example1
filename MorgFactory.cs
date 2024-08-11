using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    class MorgFactory : IBehaviorFactory
    {
        public IMovementBehavior CreateMovement(string name)
        {
            IMovementBehavior movementBehavior = null;

            if(name == "Paddles")
            {
                movementBehavior = new Paddle();
            }
            else if (name == "Oozes")
            {
                movementBehavior = new Ooze();
            }
            else if(name == "Shuffles")
            {
                movementBehavior = new Shuffle();
            }
            else
            {
                throw new Exception("Unrecognized movment behavior" + name);
            }

            return movementBehavior;
        }
    
        public IFeedingBehavior CreateFeeding(string name)
        {
            IFeedingBehavior feedingBehavior = null;

            if(name == "Envelopes")
            {
                feedingBehavior = new Envelopes();
            }

            else if(name == "Absorbs")
            {
                feedingBehavior = new Absorbs();
            }

            else
            {
                throw new Exception("Unrecognized feeding behavior" + name);
            }

            return feedingBehavior;
        }
    
    }
}
