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
            Vector.Orientation direction;

            float dx = player.DestinationRectangle.X - block.DestinationRectangle.X;
            float dy = player.DestinationRectangle.Y - block.DestinationRectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
            {
                if (dy > 0)
                {
                    direction = Vector.Orientation.North;
                }
                else 
                { 
                    direction = Vector.Orientation.South;
                }

            }
            else
            {
                if (dx > 0)
                {
                    direction = Vector.Orientation.West;
                }
                else
                {
                    direction = Vector.Orientation.East;
                }
            }


            if(player.Velocity.Direction == direction)
            {
                if (block.CanBeMoved&&block.OptionalDirection.Contains(direction)&&!player.IsKnocked)
                {
                    switch (direction)
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
