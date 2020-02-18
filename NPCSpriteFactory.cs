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

<<<<<<< HEAD
        public void LoadAllTextures(ContentManager content)
        {
            oldManTexture = content.Load<Texture2D>("NPCs/Old Man/OldMan");
        }
=======
		public void LoadAllTextures(ContentManager content)
		{
			oldManTexture = content.Load<Texture2D>("NPCs/Old Man/OldMan");
		}
>>>>>>> 5e32a5afb77c0b46721c2c077b0e6f0e1c803dab

        // Old Man Sprites
        public ISprite CreateOldManSprite()
        {
            return new TextureSprite(oldManTexture);
        }
    }
}
