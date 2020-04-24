using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{
    public interface IItem
    {
        Vector2 itemLocation { get; set; }
        Rectangle DestinationRectangle { get; set; }
        float Scale { get; set; }
        void Draw(SpriteBatch spriteBatch);
        void Update();
        void UseItem(IPlayer player, IRoom room);
    }
}
