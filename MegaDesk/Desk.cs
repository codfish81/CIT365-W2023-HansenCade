using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        int width;
        int depth;
        int drawers;
        string material;
        int MAX_WIDTH = 96;
        int MIN_WIDTH = 24;
        int MAX_DEPTH = 48;
        int MIN_DEPTH = 12;

        public Desk(int width, int depth, int drawers, string material) {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = material;
        }
        

        int Width { get => width; set => width = value; }
        int Depth { get => depth; set => depth = value; }
        int Drawers { get => drawers; set => drawers = value; }
        string Material { get => material;set => material = value; }
    }
    enum Material
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    enum Drawers
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
}
