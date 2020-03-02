using Microsoft.Xna.Framework;
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
            foreach (IItem currentItem in Level.ItemList)
            {
                if (player.Rectangle.Intersects(currentItem.Rectangle))
                {
                    //triggerList.Add(new PlayerItemTrigger(Player, Item, level));
                }
            }
            foreach (IEnemy currentEnemy in Level.EnemyList)
            {
                if (currentEnemy.Rectangle.Intersects(player.Rectangle))
                {
                    TriggerList.Add(new PlayerEnemyTrigger(player, currentEnemy, Level));

                }

            }
            foreach (IBlock currentBlock in Level.BlockList)
            {
                if (player.Rectangle.Intersects(currentBlock.Rectangle))
                {
                    TriggerList.Add(new PlayerBlockTrigger(player, currentBlock));
                }
            }

            foreach (IProjectile currentEnemyProjectile in Level.EnemyProjectileList)
            {
                if (currentEnemyProjectile.Rectangle.Intersects(player.Rectangle))
                {
                    TriggerList.Add(new EnemyProjectilePlayerTrigger(currentEnemyProjectile, player, Level));
                }
                foreach (IBlock currentBlock in Level.BlockList)
                {
                    if (currentEnemyProjectile.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        TriggerList.Add(new ProjectileBlockTrigger(currentEnemyProjectile, Level));
                    }
                }
            }
            foreach (IProjectile currentPlayerProjectile in Level.PlayerProjectileList)
            {
                foreach (IEnemy currentEnemy in Level.EnemyList)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentEnemy.Rectangle))
                    {
                        TriggerList.Add(new PlayerProjectileEnemyTrigger(currentPlayerProjectile, currentEnemy, Level));
                    }
                }
                foreach (IBlock currentBlock in Level.BlockList)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        TriggerList.Add(new ProjectileBlockTrigger(currentPlayerProjectile, Level));
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
