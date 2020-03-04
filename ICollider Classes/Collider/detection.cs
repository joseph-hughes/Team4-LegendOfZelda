using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    public class Detection
    {
        public static void PlayerItemDetection(IPlayer player, IRoom room, List<ITrigger> triggerList)
        {
            foreach (IItem currentItem in room.Items)
            {
                if (player.LinkRectangle.Intersects(currentItem.Rectangle))
                {
                    //triggerList.Add(new PlayerItemTrigger(Player, Item, room));
                }
            }
        }
        public static void PlayerEnemyDection(IPlayer player, IRoom room, List<ITrigger> triggerList)
        {
            foreach (IEnemy currentEnemy in room.Enemies)
            {
                if (currentEnemy.Rectangle.Intersects(player.LinkRectangle) || currentEnemy.Rectangle.Intersects(player.LinkSwordRectangle))
                {
                    triggerList.Add(new PlayerEnemyTrigger(player, currentEnemy, room));

                }
            }
        }
        public static void PlayerBlockDection(IPlayer player, IRoom room, List<ITrigger> triggerList)
        {
            foreach (IBlock currentBlock in room.Blocks)
            {
                if (player.LinkRectangle.Intersects(currentBlock.Rectangle))
                {
                    triggerList.Add(new PlayerBlockTrigger(player, currentBlock));
                }
            }
        }
        public static void EnemyProjectilePlayerDection(IPlayer player, IRoom room, List<ITrigger> triggerList)
        {
            foreach (IProjectile currentEnemyProjectile in room.EnemyProjectiles)
            {
                if (currentEnemyProjectile.Rectangle.Intersects(player.LinkRectangle))
                {
                    triggerList.Add(new EnemyProjectilePlayerTrigger(currentEnemyProjectile, player, room));
                }
            }
        }
        public static void PlayerProjectileEnemyDection(IRoom room, List<ITrigger> triggerList)
        {
            foreach (IProjectile currentPlayerProjectile in room.PlayerProjectiles)
            {
                foreach (IEnemy currentEnemy in room.Enemies)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentEnemy.Rectangle))
                    {
                        triggerList.Add(new PlayerProjectileEnemyTrigger(currentPlayerProjectile, currentEnemy, room));
                    }
                }
            }
        }
        public static void ProjectileBlock(IRoom room, List<ITrigger> triggerList)
        {
            foreach (IProjectile currentEnemyProjectile in room.EnemyProjectiles)
            {
                foreach (IBlock currentBlock in room.Blocks)
                {
                    if (currentEnemyProjectile.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        triggerList.Add(new ProjectileBlockTrigger(currentEnemyProjectile, room));
                    }
                }
            }
            foreach (IProjectile currentPlayerProjectile in room.PlayerProjectiles)
            {
                foreach (IBlock currentBlock in room.Blocks)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        triggerList.Add(new ProjectileBlockTrigger(currentPlayerProjectile, room));
                    }
                }
            }
        }

        public static void EnemyBlock(IRoom room, List<ITrigger> triggerList)
        {
            foreach (IEnemy currentEnemy in room.Enemies)
            {
                foreach (IBlock currentBlock in room.Blocks)
                {
                    if (currentEnemy.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        triggerList.Add(new EnemyBlockTrigger(currentEnemy, currentBlock));
                    }
                }
            }
        }

    }
}
