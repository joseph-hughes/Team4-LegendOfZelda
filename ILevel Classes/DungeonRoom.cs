using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class DungeonRoom : IRoom
    {
        public IPlayer Player { get; set; }
        public List<IEnemy> Enemies { get; set; }
        public List<IItem> Items { get; set; }
        public List<IProjectile> PlayerProjectiles { get; set; }
        public List<IProjectile> EnemyProjectiles { get; set; }
        public List<IBlock> NonmoveableBlock { get; set; }
        public List<IBlock> MoveableBlock { get; set; }
        public List<IBlock> Boundary { get; set; }
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


        public DungeonRoom()
        {
            Enemies = new List<IEnemy>();
            Items = new List<IItem>();
            PlayerProjectiles = new List<IProjectile>();
            EnemyProjectiles = new List<IProjectile>();
            NonmoveableBlock = new List<IBlock>();
            MoveableBlock = new List<IBlock>();
            Boundary = new List<IBlock>();

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
            NonmoveableBlock.AddRange(blocks);
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

            foreach (IProjectile projectile in PlayerProjectiles)
            {
                projectile.Update();
            }

            foreach (IProjectile projectile in EnemyProjectiles)
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
