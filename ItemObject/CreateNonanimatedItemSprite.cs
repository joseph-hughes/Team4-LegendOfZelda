using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda.ItemObject
{
    class CreateNonanimatedItemSprite : MyItem
    {
        Texture2D image;
        Vector2 position; 

        public CreateNonanimatedItemSprite(Texture2D texture, Vector2 location)
        {
            image = texture;
            position = location; 
        }
        public void Update()
        {
            //Nothing to update
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(image, new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height), new Rectangle(0,0,image.Width, image.Height), Color.White);
            spriteBatch.End();
        }


    }
}
