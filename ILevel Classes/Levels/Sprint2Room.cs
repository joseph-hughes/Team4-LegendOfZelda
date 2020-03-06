using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    public class Sprint2Room : IRoom
    {
        public IPlayer Player { get; set; }
        public List<IEnemy> Enemies { get; set; }
        public List<IItem> Items { get; set; }
        public List<IProjectile> PlayerProjectiles { get; set; }
        public List<IProjectile> EnemyProjectiles { get; set; }
        public List<IBlock> Blocks { get; set; }
        public IRoom North { get; set; }
        public bool HasNorth { get; set; }
        public IRoom East { get; set; }
        public bool HasEast { get; set; }
        public IRoom South { get; set; }
        public bool HasSouth { get; set; }
        public IRoom West { get; set; }
        public bool HasWest { get; set; }
        public IRoom Other { get; set; }
        public bool HasOther { get; set; }
        private IItem currentItem;
        private IEnemy currentEnemy;
        int itemIndex;
        int enemyIndex;

        public Sprint2Room()
        {
            itemIndex = 0;
            enemyIndex = 0;

            Enemies = new List<IEnemy>();
            Items = new List<IItem>();
            PlayerProjectiles = new List<IProjectile>();
            EnemyProjectiles = new List<IProjectile>();
            Blocks = new List<IBlock>();

            HasNorth = false;
            HasEast = false;
            HasSouth = false;
            HasWest = false;
            HasOther = false;
        }

        public void Initialize(IPlayer player, List<IEnemy> enemies, List<IItem> items, List<IBlock> blocks)
        {
            Player = player;
            Enemies.AddRange(enemies);
            Items.AddRange(items);
            Blocks.AddRange(blocks);

            currentItem = Items[itemIndex];
            currentEnemy = Enemies[enemyIndex];
        }

        public void NextItem()
        {
            itemIndex = (itemIndex + 1) % Items.Count;
            currentItem = Items[itemIndex];
        }

        public void PreviousItem()
        {
            itemIndex = (itemIndex - 1) % Items.Count;
            if (itemIndex == -1)
            {
                itemIndex = Items.Count - 1;
            }
            currentItem = Items[itemIndex];
        }

        public void NextEnemy()
        {
            enemyIndex = (enemyIndex + 1) % Enemies.Count;
            currentEnemy = Enemies[enemyIndex];
        }

        public void PreviousEnemy()
        {
            enemyIndex = (enemyIndex - 1) % Enemies.Count;
            if (enemyIndex == -1)
            {
                enemyIndex = Enemies.Count - 1;
            }
            currentEnemy = Enemies[enemyIndex];
        }

        public void Update()
        {
            currentEnemy.Update();
            currentItem.Update();
            foreach (IProjectile projectile in PlayerProjectiles)
            {
                projectile.Update();
            }

            foreach (IProjectile projectile in EnemyProjectiles)
            {
                projectile.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentEnemy.Draw(spriteBatch);
            currentItem.Draw(spriteBatch);
            foreach (IProjectile projectile in PlayerProjectiles)
            {
                projectile.Draw(spriteBatch);
            }

            foreach (IProjectile projectile in EnemyProjectiles)
            {
                projectile.Draw(spriteBatch);
            }
        }
    }
}
