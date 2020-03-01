using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{
    public interface ILevel
    {
        List<IBlock> BlockList { get; set; }
        List<IEnemy> EnemyList { get; set; }
        List<IItem> ItemList { get; set; }
        List<IProjectile> PlayerProjectileList { get; set; }
        List<IProjectile> EnemyProjectileList { get; set; }
        void Initialize(ContentManager content);
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
