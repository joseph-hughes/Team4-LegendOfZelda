namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IRoom
    {
        IPlayer Player { get; set; }
        System.Collections.Generic.List<IEnemy> Enemies { get; set; }
        System.Collections.Generic.List<IItem> Items { get; set; }
        System.Collections.Generic.List<IProjectile> Projectiles { get; set; }
        //List<IBlock> Blocks { get; set; }
        //List<IBoundary> Boundaries { get; set; }
        IRoom North { get; set; }
        IRoom East { get; set; }
        IRoom South { get; set; }
        IRoom West { get; set; }
        IRoom Other { get; set; }

        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}
