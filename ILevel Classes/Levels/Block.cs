using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class Block:IBlock
    {
        public Rectangle Rectangle { get; set; }
        public Block(Rectangle Rectangle)
        {
            this.Rectangle = Rectangle;
        }
    }
}
