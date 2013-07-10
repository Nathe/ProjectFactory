using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Builder
{
    class MobileEntity:Entity
    {
        bool direction = true;

        public MobileEntity(int imageIndex, int x, int y)
            : base(imageIndex, x, y)
        {

        }

        public void RunBehaviour()
        {
            if (direction && base.GetX() <= 500)
            {
                base.SetLocation(base.GetX() + 1, base.GetY());

                if(base.GetX() == 500)
                {
                    direction = false;
                }
            }
            else if (direction == false && base.GetX() >= 0)
            {
                base.SetLocation(base.GetX() - 1, base.GetY());

                if (base.GetX() == 0)
                {
                    direction = true;
                }
            }
        }
    }
}
