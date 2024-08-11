using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    class Morg
    {
        public IMovementBehavior movement;
        public IFeedingBehavior feeding;
        public string name;
        public string morgType;

        public Morg(string morgType, string name, int x, int y, int vx, int vy, double eatingDistance, IMovementBehavior mb, IFeedingBehavior fb)
        {
            this.morgType = morgType;
            this.name = name;
            movement = mb;
            feeding = fb;
        }

        public IMovementBehavior Movement
        {
            get { return movement; }
            set
            {
                movement = value;
            }
        }

        public IFeedingBehavior Feeding
        {
            get { return feeding; }
            set { feeding = value; }
        }

        public string Name
        {
            get { return name; }
        }

        public string MorgType
        {
            get { return morgType; }
        }

        public void Move()
        {
            movement.Move();
        }

       public void Feed()
        {
            feeding.Feed();
        }
     
    }
}
