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
            Vector.Orientation Direction;

            float dx = player.DestinationRectangle.X - block.DestinationRectangle.X;
            float dy = player.DestinationRectangle.Y - block.DestinationRectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
            {
                if (dx > 0)
                {
                    if (player.IsKnocked)
                    {
                        Direction = Vector.Orientation.East;
                    }
                    else
                    {
                        Direction = Vector.Orientation.West;
                    }
                }
                else
                    if (player.IsKnocked)
                {
                    Direction = Vector.Orientation.West;
                }
                else
                {
                    Direction = Vector.Orientation.East;
                }

            }
            else
            {
                if (dy > 0)
                {
                    if (player.IsKnocked)
                    {
                        Direction = Vector.Orientation.South;
                    }
                    else
                    {
                        Direction = Vector.Orientation.North;
                    }
                }
                else
                {
                    if (player.IsKnocked)
                    {
                        Direction = Vector.Orientation.North;
                    }
                    else
                    {
                        Direction = Vector.Orientation.South;
                    }
                }
            }


            if(player.Velocity.Direction == Direction)
            {
                    player.Velocity.Magnitude = 0;
            }

        }
    }
}
