using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class EnemyBlockTrigger : ITrigger
    {
        private IEnemy enemy;
        private IBlock block;

        public EnemyBlockTrigger(IEnemy Enemy, IBlock Block)
        {
            enemy = Enemy;
            block = Block;
        }
        public void Execute()
        {
            Vector.Orientation Directon; 

            float dx = enemy.DestinationRectangle.X - block.DestinationRectangle.X;
            float dy = enemy.DestinationRectangle.Y - block.DestinationRectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
            {
                if (dy > 0)
                {
                    Directon = Vector.Orientation.West;
                }
                else
                {
                    Directon = Vector.Orientation.East;
                }
            }
            //left right collision
            else
            {
                if (dx > 0)
                {
                    Directon = Vector.Orientation.North;
                }
                else
                {
                    Directon = Vector.Orientation.South;
                }
            }

           if (enemy.Velocity.Directon == Directon)
            {
                enemy.Idle() ;
            }

        }
    }
}
