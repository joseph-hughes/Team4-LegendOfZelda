using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
    public class NPCSpriteFactory : ISpriteFactory
    {
        private Texture2D oldManTexture;

        private static NPCSpriteFactory instance = new NPCSpriteFactory();

        public static NPCSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private NPCSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            oldManTexture = content.Load<Texture2D>("OldMan");
        }

        // Old Man Sprites
        public ISprite CreateOldManSprite()
        {
            return new TextureSprite(oldManTexture);
        }
    }
}
