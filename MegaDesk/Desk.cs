using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    internal class Desk
    {
        int width;
        int height;

        enum Drawers : int
        {
            zero = 0, 
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7
        }
        enum Material
        {
            laminate,
            oak,
            rosewood,
            veneer,
            pine
        }
    }
}
