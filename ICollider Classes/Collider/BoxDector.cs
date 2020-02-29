using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class BoxDector : IDector
    {
        public ILevel level { get; set; }
        public IPlayer player { get; set; }
        private Dictionary<object, Rectangle> rectanglesMap;
        public BoxDector(ILevel level, IPlayer player)
        {
            this.level = level;
            this.player = player;

            foreach (IEnemy enemy in level.EnemyList)
            {
                rectanglesMap.Add(enemy, enemy.Rectangle);
            }
            foreach (IItem item in level.ItemList)
            {
                rectanglesMap.Add(item, item.Rectangle);
            }
            foreach (IProjectile projectile in level.ItemList)
            {
                rectanglesMap.Add(projectile, projectile.Rectangle);
            }
            rectanglesMap.Add(player, player.Rectangle);
        }

        public void Detact()
        {

        }

        public void Update()
        {

        }
    }
}
