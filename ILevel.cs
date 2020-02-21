using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Team4_LegendOfZelda
{
    public interface ILevel
    {
        List<IItem> ItemList { get; set; }
        List<IEnemy> EnemyList { get; set; }
        void Initialize(ContentManager content);
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
