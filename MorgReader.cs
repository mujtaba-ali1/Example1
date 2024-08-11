using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    class MorgReader : ReaderDecorator
    {
        IBehaviorFactory factory;
        List<string> morgNames = new List<string>();
        Random rnd = new Random();

        public MorgReader(Reader wrapped, IBehaviorFactory factory) : base(wrapped)
        {
            this.factory = factory;
        }
        public Morg ReadMorg()
        {
            morgNames.Add("Alice");
            morgNames.Add("Clarice");
            morgNames.Add("Wade");

            int value = rnd.Next(0, 3);

            string morgType = wrapped.Read();

            if (morgType == null)
            {
                return null;
            }

            //get the morg's location (x,y)
            int x = System.Convert.ToInt32(wrapped.Read());
            int y = System.Convert.ToInt32(wrapped.Read());

            //TODO: validate that (x,y) is in the dish boundary
            // get the morg's movement behavior

            string movementString = wrapped.Read();
            IMovementBehavior movementBehavior = factory.CreateMovement(movementString);
         

            string feedingString = wrapped.Read();
            string[] feedingParts = feedingString.Split(' ');
            IFeedingBehavior feedingBehavior = factory.CreateFeeding(feedingParts[0]);

            Morg m = new Morg(morgType, morgNames[value], x, y, 0,0, 1.0, movementBehavior, feedingBehavior);

            return m;
        }

        public override string Read()
        {
            //Note: MorgReader does not really do anything with the string by themselves
            //so it is a 'pass-through' and should just return the result
            //from the wrapped Reader
            return wrapped.Read();
        }

        public override void Close()
        {
            wrapped.Close();
        }
    }
}
