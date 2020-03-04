using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    public class Detection
    {
        public static void PlayerItemDetection(IPlayer player, ILevel level, List<ITrigger> TriggerList)
        {
            foreach (IItem currentItem in level.ItemList)
            {
                if (player.LinkRectangle.Intersects(currentItem.Rectangle))
                {
                    //triggerList.Add(new PlayerItemTrigger(Player, Item, level));
                }
            }
        }
        public static void PlayerEnemyDection(IPlayer player, ILevel level, List<ITrigger> TriggerList)
        {
            foreach (IEnemy currentEnemy in level.EnemyList)
            {
                if (currentEnemy.Rectangle.Intersects(player.LinkRectangle) || currentEnemy.Rectangle.Intersects(player.LinkSwordRectangle))
                {
                    TriggerList.Add(new PlayerEnemyTrigger(player, currentEnemy, level));

                }
            }
        }
        public static void PlayerBlockDection(IPlayer player, ILevel level, List<ITrigger> TriggerList)
        {
            foreach (IBlock currentBlock in level.BlockList)
            {
                if (player.LinkRectangle.Intersects(currentBlock.Rectangle))
                {
                    TriggerList.Add(new PlayerBlockTrigger(player, currentBlock));
                }
            }
        }
        public static void EnemyProjectilePlayerDection(IPlayer player, ILevel level, List<ITrigger> TriggerList)
        {
            foreach (IProjectile currentEnemyProjectile in level.EnemyProjectileList)
            {
                if (currentEnemyProjectile.Rectangle.Intersects(player.LinkRectangle))
                {
                    TriggerList.Add(new EnemyProjectilePlayerTrigger(currentEnemyProjectile, player, level));
                }
            }
        }
        public static void PlayerProjectileEnemyDection(ILevel level, List<ITrigger> TriggerList)
        {
            foreach (IProjectile currentPlayerProjectile in level.PlayerProjectileList)
            {
                foreach (IEnemy currentEnemy in level.EnemyList)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentEnemy.Rectangle))
                    {
                        TriggerList.Add(new PlayerProjectileEnemyTrigger(currentPlayerProjectile, currentEnemy, level));
                    }
                }
            }
        }
        public static void ProjectileBlock(ILevel level, List<ITrigger> TriggerList)
        {
            foreach (IProjectile currentEnemyProjectile in level.EnemyProjectileList)
            {
                foreach (IBlock currentBlock in level.BlockList)
                {
                    if (currentEnemyProjectile.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        TriggerList.Add(new ProjectileBlockTrigger(currentEnemyProjectile, level));
                    }
                }
            }
            foreach (IProjectile currentPlayerProjectile in level.PlayerProjectileList)
            {
                foreach (IBlock currentBlock in level.BlockList)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        TriggerList.Add(new ProjectileBlockTrigger(currentPlayerProjectile, level));
                    }
                }
            }
        }

        public static void EnemyBlock(ILevel level, List<ITrigger> TriggerList)
        {
            foreach (IEnemy currentEnemy in level.EnemyList)
            {
                foreach (IBlock currentBlock in level.BlockList)
                {
                    if (currentEnemy.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        TriggerList.Add(new EnemyBlockTrigger(currentEnemy, currentBlock));
                    }
                }
            }
        }

    }
}
