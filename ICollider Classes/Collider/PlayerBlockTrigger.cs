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
            int direction;

            float dx = player.DestinationRectangle.X - block.DestinationRectangle.X;
            float dy = player.DestinationRectangle.Y - block.DestinationRectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
            {
                if (dx > 0)
                {
                    if (player.isKnocked)
                    {
                        direction = 1;  //East
                    }
                    else
                    {
                        direction = 3;  //West
                    }
                }
                else
                    if (player.isKnocked)
                {
                    direction = 3;  //West
                }
                else
                {
                    direction = 1;  //East
                }

            }
            else
            {
                if (dy > 0)
                {
                    if (player.isKnocked)
                    {
                        direction = 2;  //South
                    }
                    else
                    {
                        direction = 0;  //North
                    }
                }
                else
                {
                    if (player.isKnocked)
                    {
                        direction = 0;  //North
                    }
                    else
                    {
                        direction = 2;  //South
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
