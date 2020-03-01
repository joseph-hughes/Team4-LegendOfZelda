using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IRoom
    {
        IPlayer Player { get; set; }
        List<IEnemy> Enemies { get; set; }
        List<IItem> Items { get; set; }
        List<IProjectile> Projectiles { get; set; }
        //List<IBlock> Blocks { get; set; }
        //List<IBoundary> Boundaries { get; set; }
        IRoom North { get; set; }
        IRoom East { get; set; }
        IRoom South { get; set; }
        IRoom West { get; set; }
        IRoom Other { get; set; }

        void Update();
        void Draw();
    }
}
