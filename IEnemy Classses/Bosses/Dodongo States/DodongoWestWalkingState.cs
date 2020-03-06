using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoWestWalkingState : IState
    {
        IEnemy enemy;

        public DodongoWestWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoWestWalkingSprite();
        }

        public void North()
        {
            enemy.State = new DodongoNorthWalkingState(enemy);
        }

        public void East()
        {
            enemy.State = new DodongoEastWalkingState(enemy);
        }

        public void South()
        {
            enemy.State = new DodongoSouthWalkingState(enemy);
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            // TODO
        }

        public void BeDamaged()
        {
            enemy.State = new DodongoWestDamagedState(enemy);
        }

        public void Attack()
        {
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            if (enemy.Position.X > 1)
            {
                enemy.Position = new Rectangle(((int)enemy.Position.X - 1) % 768, enemy.Position.Y, enemy.Position.Width, enemy.Position.Height);
            }
            else
            {
                enemy.Position = new Rectangle(768 - (int)enemy.Position.X, enemy.Position.Y, enemy.Position.Width, enemy.Position.Height);
            }
        }
    }
}
