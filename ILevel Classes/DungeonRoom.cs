﻿using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class DungeonRoom : IRoom
    {
        public IPlayer Player { get; set; }
        public List<IEnemy> Enemies { get; set; }
        public List<IItem> Items { get; set; }
        public List<IProjectile> Projectiles { get; set; }
        //List<IBlock> Blocks { get; set; }
        //List<IBoundary> Boundaries { get; set; }
        public IRoom North { get; set; }
        public IRoom East { get; set; }
        public IRoom South { get; set; }
        public IRoom West { get; set; }
        public IRoom Other { get; set; }

        public DungeonRoom()
        {
            Enemies = new List<IEnemy>();
            Items = new List<IItem>();
            Projectiles = new List<IProjectile>();
        }

        public void Initialize(IPlayer player, List<IEnemy> enemies, List<IItem> items)
        {
            Player = player;
            Enemies.AddRange(enemies);
            Items.AddRange(items);
        }

        public void Update()
        {
            foreach (IEnemy enemy in Enemies)
            {
                enemy.Update();
            }

            foreach (IItem item in Items)
            {
                item.Update();
            }

            foreach (IProjectile projectile in Projectiles)
            {
                projectile.Update();
            }
        }

        public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            foreach (IEnemy enemy in Enemies)
            {
                enemy.Draw(spriteBatch);
            }

            foreach (IItem item in Items)
            {
                item.Draw(spriteBatch);
            }

            foreach (IProjectile projectile in Projectiles)
            {
                projectile.Draw(spriteBatch);
            }
        }
    }
}