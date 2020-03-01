using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class BoxDector : IDector
    {
        public ILevel level { get; set; }
        public IPlayer player { get; set; }
        public List<ITrigger> triggerList { get; set; }
        public BoxDector(IPlayer Player)
        {
            player = Player;
            triggerList = new List<ITrigger>();
        }

        public void Detact()
        {
            //direction clockwise, 0 for north
            foreach (IItem currentItem in level.ItemList)
            {
                if (player.Rectangle.Intersects(currentItem.Rectangle))
                {
                    //triggerList.Add(new PlayerItemTrigger(Player, Item, level));
                }
            }
            foreach (IEnemy currentEnemy in level.EnemyList)
            {
                if (currentEnemy.Rectangle.Intersects(player.Rectangle))
                {
                    float dx = player.Rectangle.X - currentEnemy.Rectangle.X;
                    float dy = player.Rectangle.Y - currentEnemy.Rectangle.Y;

                    //top bottom collision
                    if (System.Math.Abs(dx) < System.Math.Abs(dy))
                    {
                        if (dy > 0)
                        {
                            triggerList.Add(new PlayerEnemyTrigger(player, currentEnemy, level, 0));
                        }
                        else
                        {
                            triggerList.Add(new PlayerEnemyTrigger(player, currentEnemy, level, 2));
                        }
                    }
                    //left right collision
                    else
                    {
                        if (dx > 0)
                        {
                            triggerList.Add(new PlayerEnemyTrigger(player, currentEnemy, level, 3));
                        }
                        else
                        {
                            triggerList.Add(new PlayerEnemyTrigger(player, currentEnemy, level, 1));
                        }
                    }

                }

            }
            foreach (IProjectile currentEnemyProjectile in level.EnemyProjectileList)
            {
                if (currentEnemyProjectile.Rectangle.Intersects(player.Rectangle))
                {
                    float dx = currentEnemyProjectile.Rectangle.X - player.Rectangle.X;
                    float dy = currentEnemyProjectile.Rectangle.Y - player.Rectangle.Y;

                    //top bottom collision
                    if (System.Math.Abs(dx) < System.Math.Abs(dy))
                    {
                        if (dy > 0)
                        {
                            //top collision (player bottem collision)
                            //triggerList.Add(new EnemyProjectilePlayerTrigger(EnemyProjectile, Player, level, Top));
                        }
                        else
                        {
                            //bottom collision (player top collision)
                            //triggerList.Add(new EnemyProjectilePlayerTrigger(EnemyProjectile, Player, level, Bottom));
                        }
                    }
                    //left right collision
                    else
                    {
                        if (dx > 0)
                        {
                            //left collision (player right collision)
                            //triggerList.Add(new EnemyProjectilePlayerTrigger(EnemyProjectile, Player, level, Left));
                        }
                        else
                        {
                            //right collision (player left collision)
                            //triggerList.Add(new EnemyProjectilePlayerTrigger(EnemyProjectile, Player, level, Right));
                        }
                    }

                }
            }
            foreach (IProjectile currentPlayerProjectile in level.PlayerProjectileList)
            {
                foreach (IEnemy currentEnemy in level.EnemyList)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentEnemy.Rectangle))
                    {
                        float dx = currentPlayerProjectile.Rectangle.X - currentEnemy.Rectangle.X;
                        float dy = currentPlayerProjectile.Rectangle.Y - currentEnemy.Rectangle.Y;

                        //up down collision
                        if (System.Math.Abs(dx) < System.Math.Abs(dy))
                        {
                            if (dy > 0)
                            {
                                //top collision (Enemy bottem collision)
                                //triggerList.Add(new EnemyProjectilePlayerTrigger(PlayerProjectile, Enemy, level, Top));
                            }
                            else
                            {
                                //bottom collision (Enemy top collision)
                                //triggerList.Add(new EnemyProjectilePlayerTrigger(PlayerProjectile, Enemy, level, Bottom));
                            }
                        }
                        //left right collision
                        else
                        {
                            if (dx > 0)
                            {
                                //left collision (Enemy right collision)
                                //triggerList.Add(new EnemyProjectilePlayerTrigger(PlayerProjectile, Enemy, level, Left));
                            }
                            else
                            {
                                //right collision (Enemy left collision)
                                //triggerList.Add(new EnemyProjectilePlayerTrigger(PlayerProjectile, Enemy, level, Right));
                            }
                        }

                    }
                }
                foreach (IBlock currentBlock in level.BlockList)
                {
                    if (currentPlayerProjectile.Rectangle.Intersects(currentBlock.Rectangle))
                    {
                        triggerList.Add(new PlayerProjectileBlockTrigger(currentPlayerProjectile, level));
                    }
                }
            }

        }

        public void Update(ILevel Level)
        {
            level = Level;
            foreach (ITrigger trigger in triggerList)
            {
                trigger.Execute();
            }
            triggerList = new List<ITrigger>();

        }
    }
}
