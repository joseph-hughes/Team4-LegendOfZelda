using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class BoxDector : IDector
    {
        public ILevel Level { get; set; }
        public IPlayer player { get; set; }
        public List<ITrigger> TriggerList { get; set; }
        public BoxDector(IPlayer Player)
        {
            player = Player;
            TriggerList = new List<ITrigger>();
        }

        public void Detact()
        {
            //direction clockwise, 0 for north
            foreach (IItem currentItem in Level.CurrentRoom.Items)
            {
                if (player.LinkRectangle.Intersects(currentItem.Rectangle))
                {
                    //triggerList.Add(new PlayerItemTrigger(Player, Item, level));
                }
            }
            foreach (IEnemy currentEnemy in Level.CurrentRoom.Enemies)
            {
                if (currentEnemy.Rectangle.Intersects(player.LinkRectangle) || currentEnemy.Rectangle.Intersects(player.LinkSwordRectangle))
                {
                    TriggerList.Add(new PlayerEnemyTrigger(player, currentEnemy, Level));

                }

            }
            foreach (IBlock currentBlock in Level.CurrentRoom.Blocks)
            {
                if (player.LinkRectangle.Intersects(currentBlock.Rectangle))
                {
                    TriggerList.Add(new PlayerBlockTrigger(player, currentBlock));
                }
            }

            foreach (IProjectile currentEnemyProjectile in Level.CurrentRoom.EnemyProjectiles)
            {
                if (currentEnemyProjectile.Rectangle.Intersects(player.LinkRectangle))
                {
                    TriggerList.Add(new EnemyProjectilePlayerTrigger(currentEnemyProjectile, player, Level.CurrentRoom));
                }
                foreach (IBlock currentBlock in Level.CurrentRoom.Blocks)
                {
                    if (currentEnemyProjectile.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        TriggerList.Add(new ProjectileBlockTrigger(currentEnemyProjectile, Level.CurrentRoom));
                    }
                }
            }
            foreach (IProjectile currentPlayerProjectile in Level.CurrentRoom.PlayerProjectiles)
            {
                foreach (IEnemy currentEnemy in Level.CurrentRoom.Enemies)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentEnemy.Rectangle))
                    {
                        TriggerList.Add(new PlayerProjectileEnemyTrigger(currentPlayerProjectile, currentEnemy, Level.CurrentRoom));
                    }
                }
                foreach (IBlock currentBlock in Level.CurrentRoom.Blocks)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        TriggerList.Add(new ProjectileBlockTrigger(currentPlayerProjectile, Level.CurrentRoom));
                    }
                }
            }
        }

        public void Update(ILevel level)
        {
            Level = level;
            foreach (ITrigger trigger in TriggerList)
            {
                trigger.Execute();
            }
            TriggerList = new List<ITrigger>();

        }
    }
}
