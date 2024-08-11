using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    interface IBehaviorFactory
    {
        IMovementBehavior CreateMovement(string name);
        IFeedingBehavior CreateFeeding(string name);

    }
}
