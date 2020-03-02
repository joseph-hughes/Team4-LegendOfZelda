using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerBlockTrigger : ITrigger
    {
        private IPlayer player;
        private IBlock block;
        private int direction; 
        public PlayerBlockTrigger(IPlayer Player, IBlock Block)
        {
            player = Player;
            block = Block;
        }
        public void Execute()
        {

            float dx = player.Rectangle.X - block.Rectangle.X;
            float dy = player.Rectangle.Y - block.Rectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
            {
                if (dx > 0)
                {
                    if (player.isKnocked)
                    {
                        direction = 1;
                    }
                    else
                    {
                        direction = 3;
                    }
                }
                else
                    if (player.isKnocked)
                    {
                      direction = 3;
                    }
                    else
                    {
                      direction = 1;
                    }

            }
            else
            {
                if (dy > 0)
                {
                    if (player.isKnocked)
                    {
                        direction = 2;
                    }
                    else
                    {
                        direction = 0;
                    }
                }
                else
                {
                    if (player.isKnocked)
                    {
                        direction = 0;
                    }
                    else
                    {
                        direction = 2;
                    }
                }
            }

            if (player.Direction == direction)
            {
                player.Velocity = 0;
            }

        }
    }
}
