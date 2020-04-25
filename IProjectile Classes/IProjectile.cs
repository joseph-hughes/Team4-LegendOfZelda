using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Vector;

namespace Team4_LegendOfZelda
{
    public interface IProjectile
    {
        ISprite Sprite { get; set; }
        Vector2 Position { get; set; }
        Rectangle DestinationRectangle { get; set; }
        Orientation Direction { get; set; }
        float Scale { get; set; }
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
