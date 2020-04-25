using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerEnemyTrigger : ITrigger
    {
        private IRoom currentRoom;
        private Link player;
        private IEnemy enemy;
        public PlayerEnemyTrigger(IPlayer Player, IEnemy Enemy, IRoom Room)
        {
            currentRoom = Room;
            player = (Link)Player;
            enemy = Enemy;
        }
        public void Execute()
        {
            if (!player.IsDamaged)
            {

                if (player.DestinationRectangle.Intersects(enemy.DestinationRectangle))
                {
                    float dx = player.DestinationRectangle.X - enemy.DestinationRectangle.X;
                    float dy = player.DestinationRectangle.Y - enemy.DestinationRectangle.Y;

                    //top bottom collision
                    if (System.Math.Abs(dx) < System.Math.Abs(dy))
                    {
                        if (dy > 0)
                        {
                            player.North();
                            player.BeDamaged();
                        }
                        else
                        {
                            player.South();
                            player.BeDamaged();
                        }
                    }
                    //left right collision
                    else
                    {
                        if (dx > 0)
                        {
                            player.West();
                            player.BeDamaged();
                        }
                        else
                        {
                            player.East();
                            player.BeDamaged();
                        }
                    }
                }
                else
                {
                    enemy.BeDamaged();
                }
            }

        }
    }
}
