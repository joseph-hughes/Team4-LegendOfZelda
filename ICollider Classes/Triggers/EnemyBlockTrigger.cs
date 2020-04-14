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
            Vector.Orientation direction; ;

            float dx = enemy.DestinationRectangle.X - block.DestinationRectangle.X;
            float dy = enemy.DestinationRectangle.Y - block.DestinationRectangle.Y;

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
            //left right collision
            else
            {
                if (dx > 0)
                {
                    direction = Vector.Orientation.East;
                }
                else
                {
                    direction = Vector.Orientation.West;
                }
            }

           if (enemy.Direction == direction)
            {
               enemy.Velocity = 0;
            }

        }
    }
}
