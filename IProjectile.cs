using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    interface IProjectile
    {
        ISprite Sprite { get; set; }
        Vector2 Position { get; set; }
        int Angle { get; set; }

        void Update();
        void Draw(SpriteBatch spriteBatch, Vector2 position);
    }
}
