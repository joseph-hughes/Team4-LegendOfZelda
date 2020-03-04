using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class DungeonRoom : IRoom
    {
        public IPlayer Player { get; set; }
        System.Collections.Generic.List<IEnemy> Enemies { get; set; }
        System.Collections.Generic.List<IItem> Items { get; set; }
        System.Collections.Generic.List<IProjectile> Projectiles { get; set; }
        //List<IBlock> Blocks { get; set; }
        //List<IBoundary> Boundaries { get; set; }
        public IRoom North { get; set; }
        public IRoom East { get; set; }
        public IRoom South { get; set; }
        public IRoom West { get; set; }
        public IRoom Other { get; set; }

        public DungeonRoom()
        { }
        public void Update()
        { }
        public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        { }
    }
}
