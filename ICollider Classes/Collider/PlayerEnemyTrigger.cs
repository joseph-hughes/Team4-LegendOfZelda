﻿using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerEnemyTrigger : ITrigger
    {
        private IRoom room;
        private Link player;
        private IEnemy enemy;
        public PlayerEnemyTrigger(IPlayer Player, IEnemy Enemy, IRoom Room)
        {
            room = Room;
            player = (Link)Player;
            enemy = Enemy;
        }
        public void Execute()
        {
            if (!player.isDamaged)
            {

                if (player.DestinationRectangle.Intersects(enemy.DestinationRectangle))
                {
                    float dx = player.DestinationRectangle.X - enemy.DestinationRectangle.X;
                    float dy = player.DestinationRectangle.Y - enemy.DestinationRectangle.Y;

                    //top bottom collision
                    if (System.Math.Abs(dx) < System.Math.Abs(dy))
                    {
                        if (dy > 0)
                        {
                            player.State = new LinkKnockbackNorthState(player, Link.knockback_timer);
                        }
                        else
                        {
                            player.State = new LinkKnockbackSouthState(player, Link.knockback_timer);
                        }
                    }
                    //left right collision
                    else
                    {
                        if (dx > 0)
                        {
                            player.State = new LinkKnockbackWestState(player, Link.knockback_timer);
                        }
                        else
                        {
                            player.State = new LinkKnockbackEastState(player, Link.knockback_timer);
                        }
                    }
                }
                else
                {
                    enemy.State.BeDamaged();
                }
            }

        }
    }
}
