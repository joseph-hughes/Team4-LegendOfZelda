using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class EnemyWallTrigger : ITrigger
    {
        private IEnemy enemy;
        private IBlock block;

        public EnemyWallTrigger(IEnemy Enemy, IBlock Block)
        {
            enemy = Enemy;
            block = Block;
        }
        public void Execute()
        {
            Vector.Orientation Direction;

            float dx = enemy.DestinationRectangle.X - block.DestinationRectangle.X;
            float dy = enemy.DestinationRectangle.Y - block.DestinationRectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
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
            else
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

            if (enemy.Velocity.Direction == Direction)
            {
                switch (enemy.Velocity.Direction)
                {
                    case Vector.Orientation.North:
                        enemy.South();
                        break;
                    case Vector.Orientation.East:
                        enemy.West();
                        break;
                    case Vector.Orientation.South:
                        enemy.North();
                        break;
                    case Vector.Orientation.West:
                        enemy.East();
                        break;
                    default:
                        break;

                }
            }

        }
    }
}
