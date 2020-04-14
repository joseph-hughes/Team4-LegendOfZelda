namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IRoom
    {
        IPlayer Player { get; set; }
        System.Collections.Generic.List<IEnemy> Enemies { get; set; }
        System.Collections.Generic.List<IItem> Items { get; set; }
        System.Collections.Generic.List<IProjectile> PlayerProjectiles { get; set; }
        System.Collections.Generic.List<IProjectile> EnemyProjectiles { get; set; }
        System.Collections.Generic.List<IBlock> Block { get; set; }
        System.Collections.Generic.List<IBlock> Wall { get; set; }
        System.Collections.Generic.List<IBlock> Boundary { get; set; }
        IRoom North { get; set; }
        bool HasNorth { get; set; }
        IRoom East { get; set; }
        bool HasEast { get; set; }
        IRoom South { get; set; }
        bool HasSouth { get; set; }
        IRoom West { get; set; }
        bool HasWest { get; set; }
        IRoom Other { get; set; }
        bool HasOther { get; set; }

        void Initialize(IPlayer player, System.Collections.Generic.List<IEnemy> enemies, System.Collections.Generic.List<IItem> items, System.Collections.Generic.List<IBlock> blocks);
        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}
