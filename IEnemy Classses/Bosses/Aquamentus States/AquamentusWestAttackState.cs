using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusWestAttackState : IState
    {
        private IEnemy enemy;
        private int attackCounter;
        private const int FIREBALL_GAP = 75;
        public const int MAX_ATTACK_COUNTER = 60;

        public AquamentusWestAttackState(IEnemy enemy, int attackCounter)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusWestAttackSprite();
            this.enemy.Velocity.Magnitude = 2;
            this.enemy.Velocity.Direction = Vector.Orientation.West;

            if (attackCounter > 0)
            {
                this.attackCounter = attackCounter;
            }
            else
            {
                this.attackCounter = MAX_ATTACK_COUNTER;
            }
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new AquamentusEastAttackState(enemy, attackCounter);
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }
        public void Freeze()
        {
            // Do nothing
        }
        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // TODO
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
            attackCounter--;
            if (attackCounter <= 0)
            {
                enemy.Room.EnemyProjectiles.Add(new FireballProjectile(new Vector2(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y), enemy.Velocity));
                enemy.Room.EnemyProjectiles.Add(new FireballProjectile(new Vector2(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y + FIREBALL_GAP), enemy.Velocity));
                enemy.Room.EnemyProjectiles.Add(new FireballProjectile(new Vector2(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y - FIREBALL_GAP), enemy.Velocity));
                enemy.State = new AquamentusWestIdleState(enemy);
            }
        }
    }
}
