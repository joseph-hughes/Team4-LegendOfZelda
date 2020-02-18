using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class ItemObjectEmpty:Item
    {
        ItemState itemState;
        public ItemObjectEmpty()
        {
            itemState = new EmptyState();
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
