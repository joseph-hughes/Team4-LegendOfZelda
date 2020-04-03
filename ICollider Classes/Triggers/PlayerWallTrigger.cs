using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerWallTrigger : ITrigger
    {
        private IPlayer player;
        private IBlock block;

        public PlayerWallTrigger(IPlayer Player, IBlock Block)
        {
            player = Player;
            block = Block;
        }
        public void Execute()
        {
            Vector.Orientation direction;

            float dx = player.DestinationRectangle.X - block.DestinationRectangle.X;
            float dy = player.DestinationRectangle.Y - block.DestinationRectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
            {
                if (dx > 0)
                {
                    if (player.isKnocked)
                    {
                        direction = Vector.Orientation.East;
                    }
                    else
                    {
                        direction = Vector.Orientation.West;
                    }
                }
                else
                    if (player.isKnocked)
                {
                    direction = Vector.Orientation.West;
                }
                else
                {
                    direction = Vector.Orientation.East;
                }

            }
            else
            {
                if (dy > 0)
                {
                    if (player.isKnocked)
                    {
                        direction = Vector.Orientation.South;
                    }
                    else
                    {
                        direction = Vector.Orientation.North;
                    }
                }
                else
                {
                    if (player.isKnocked)
                    {
                        direction = Vector.Orientation.North;
                    }
                    else
                    {
                        direction = Vector.Orientation.South;
                    }
                }
            }


            if(player.Velocity.Directon == direction)
            {
                    player.Velocity.Magnitude = 0;
            }

        }
    }
}
