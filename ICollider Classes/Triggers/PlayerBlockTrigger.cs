using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerBlockTrigger : ITrigger
    {
        private IPlayer player;
        private IBlock block;

        public PlayerBlockTrigger(IPlayer Player, IBlock Block)
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
                if (dy > 0)
                {
                    Direction = Vector.Orientation.North;
                }
                else 
                { 
                    Direction = Vector.Orientation.South;
                }

            }
            else
            {
                if (dx > 0)
                {
                    Direction = Vector.Orientation.West;
                }
                else
                {
                    Direction = Vector.Orientation.East;
                }
            }


            if(player.Velocity.Direction == Direction)
            {
                if (block.CanBeMoved&&block.OptionalDirection.Contains(Direction)&&!player.IsKnocked)
                {
                    switch (Direction)
                    {
                        default:
                            break;
                        case Vector.Orientation.North:
                            block.DestinationRectangle = new Rectangle(block.DestinationRectangle.X, block.DestinationRectangle.Y - 2, block.DestinationRectangle.Width, block.DestinationRectangle.Height);
                            break;
                        case Vector.Orientation.East:
                            block.DestinationRectangle = new Rectangle(block.DestinationRectangle.X + 2, block.DestinationRectangle.Y, block.DestinationRectangle.Width, block.DestinationRectangle.Height);
                            break;
                        case Vector.Orientation.South:
                            block.DestinationRectangle = new Rectangle(block.DestinationRectangle.X, block.DestinationRectangle.Y + 2, block.DestinationRectangle.Width, block.DestinationRectangle.Height);
                            break;
                        case Vector.Orientation.West:
                            block.DestinationRectangle = new Rectangle(block.DestinationRectangle.X - 2, block.DestinationRectangle.Y, block.DestinationRectangle.Width, block.DestinationRectangle.Height);
                            break;
                    }
                }
                else
                {
                    player.Velocity.Magnitude = 0;
                }
            }

        }
    }
}
