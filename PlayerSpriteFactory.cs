using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
	public class PlayerSpriteFactory
	{
		private Texture2D LinkDamagedMovingSouthTexture;
        private Texture2D LinkDamagedMovingNorthTexture;
        private Texture2D LinkDamagedMovingEastTexture;
        private Texture2D LinkDamagedMovingWestTexture;
        private Texture2D LinkDamagedNonMovingSouthTexture;
        private Texture2D LinkDamagedNonMovingNorthTexture;
        private Texture2D LinkDamagedNonMovingEastTexture;
        private Texture2D LinkDamagedNonMovingWestTexture;
        private Texture2D LinkMovingSouthTexture;
        private Texture2D LinkMovingNorthTexture;
        private Texture2D LinkMovingEastTexture;
        private Texture2D LinkMovingWestTexture;
        private Texture2D LinkNonMovingSouthTexture;
        private Texture2D LinkNonMovingNorthTexture;
        private Texture2D LinkNonMovingEastTexture;
        private Texture2D LinkNonMovingWestTexture;
        private Texture2D LinkSwordSouthTexture;
        private Texture2D LinkSwordNorthTexture;
        private Texture2D LinkSwordEastTexture;
        private Texture2D LinkSwordWestTexture;
        private Texture2D LinkUseItemSouthTexture;
        private Texture2D LinkUseItemNorthTexture;
        private Texture2D LinkUseItemEastTexture;
        private Texture2D LinkUseItemWestTexture;

        private static PlayerSpriteFactory instance = new PlayerSpriteFactory();

		public static PlayerSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private PlayerSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
            LinkDamagedMovingSouthTexture = content.Load<Texture2D>("Link Damaged Moving South");
            LinkDamagedMovingNorthTexture = content.Load<Texture2D>("Link Damaged Moving North");
            LinkDamagedMovingEastTexture = content.Load<Texture2D>("Link Damaged Moving East");
            LinkDamagedMovingWestTexture = content.Load<Texture2D>("Link Damaged Moving West");
            LinkDamagedNonMovingSouthTexture = content.Load<Texture2D>("Link Damaged NonMoving South");
            LinkDamagedNonMovingNorthTexture = content.Load<Texture2D>("Link Damaged NonMoving North");
            LinkDamagedNonMovingEastTexture = content.Load<Texture2D>("Link Damaged NonMoving East");
            LinkDamagedNonMovingWestTexture = content.Load<Texture2D>("Link Damaged NonMoving West");
            LinkMovingSouthTexture = content.Load<Texture2D>("Link Moving South");
            LinkMovingNorthTexture = content.Load<Texture2D>("Link Moving North");
            LinkMovingEastTexture = content.Load<Texture2D>("Link Moving East");
            LinkMovingWestTexture = content.Load<Texture2D>("Link Moving West");
            LinkNonMovingSouthTexture = content.Load<Texture2D>("Link NonMoving South");
            LinkNonMovingNorthTexture = content.Load<Texture2D>("Link NonMoving North");
            LinkNonMovingEastTexture = content.Load<Texture2D>("Link NonMoving East");
            LinkNonMovingWestTexture = content.Load<Texture2D>("Link NonMoving West");
            LinkSwordSouthTexture = content.Load<Texture2D>("Link Sword South");
            LinkSwordNorthTexture = content.Load<Texture2D>("Link Sword North");
            LinkSwordEastTexture = content.Load<Texture2D>("Link Sword East");
            LinkSwordWestTexture = content.Load<Texture2D>("Link Sword West");
            LinkUseItemSouthTexture = content.Load<Texture2D>("Link UseItem South");
            LinkUseItemNorthTexture = content.Load<Texture2D>("Link UseItem North");
            LinkUseItemEastTexture = content.Load<Texture2D>("Link UseItem East");
            LinkUseItemWestTexture = content.Load<Texture2D>("Link UseItem West");
        }

		public ISprite CreateLinkDamagedMovingSouthSprite()
		{
			return new TextureSprite(LinkDamagedMovingSouthTexture, 1, 2, 5);
		}
        public ISprite CreateLinkDamagedMovingNorthSprite()
        {
            return new TextureSprite(LinkDamagedMovingNorthTexture, 1, 2, 5);
        }
        public ISprite CreateLinkDamagedMovingEastSprite()
        {
            return new TextureSprite(LinkDamagedMovingEastTexture, 1, 2, 5);
        }
        public ISprite CreateLinkDamagedMovingWestSprite()
        {
            return new TextureSprite(LinkDamagedMovingWestTexture, 1, 2, 5);
        }

        public ISprite CreateLinkDamagedNonMovingSouthSprite()
        {
            return new TextureSprite(LinkDamagedNonMovingSouthTexture, 1, 1, 5);
        }
        public ISprite CreateLinkDamagedNonMovingNorthSprite()
        {
            return new TextureSprite(LinkDamagedNonMovingNorthTexture, 1, 1, 5);
        }
        public ISprite CreateLinkDamagedNonMovingEastSprite()
        {
            return new TextureSprite(LinkDamagedNonMovingEastTexture, 1, 1, 5);
        }
        public ISprite CreateLinkDamagedNonMovingWestSprite()
        {
            return new TextureSprite(LinkDamagedNonMovingWestTexture, 1, 1, 5);
        }

        public ISprite CreateLinkMovingSouthSprite()
        {
            return new TextureSprite(LinkMovingSouthTexture, 1, 2, 5);
        }
        public ISprite CreateLinkMovingNorthSprite()
        {
            return new TextureSprite(LinkMovingNorthTexture, 1, 2, 5);
        }
        public ISprite CreateLinkMovingEastSprite()
        {
            return new TextureSprite(LinkMovingEastTexture, 1, 2, 5);
        }
        public ISprite CreateLinkMovingWestSprite()
        {
            return new TextureSprite(LinkMovingWestTexture, 1, 2, 5);
        }

        public ISprite CreateLinkNonMovingSouthSprite()
        {
            return new TextureSprite(LinkNonMovingSouthTexture, 1, 1, 5);
        }
        public ISprite CreateLinkNonMovingNorthSprite()
        {
            return new TextureSprite(LinkNonMovingNorthTexture, 1, 1, 5);
        }
        public ISprite CreateLinkNonMovingEastSprite()
        {
            return new TextureSprite(LinkNonMovingEastTexture, 1, 1, 5);
        }
        public ISprite CreateLinkNonMovingWestSprite()
        {
            return new TextureSprite(LinkNonMovingWestTexture, 1, 1, 5);
        }

        public ISprite CreateLinkSwordSouthSprite()
        {
            return new TextureSprite(LinkSwordSouthTexture, 1, 2, 5);
        }
        public ISprite CreateLinkSwordNorthSprite()
        {
            return new TextureSprite(LinkSwordNorthTexture, 1, 2, 5);
        }
        public ISprite CreateLinkSwordEastSprite()
        {
            return new TextureSprite(LinkSwordEastTexture, 1, 2, 5);
        }
        public ISprite CreateLinkSwordWestSprite()
        {
            return new TextureSprite(LinkSwordWestTexture, 1, 2, 5);
        }

        public ISprite CreateLinkUseItemSouthSprite()
        {
            return new TextureSprite(LinkUseItemSouthTexture, 1, 2, 5);
        }
        public ISprite CreateLinkUseItemNorthSprite()
        {
            return new TextureSprite(LinkUseItemNorthTexture, 1, 2, 5);
        }
        public ISprite CreateLinkUseItemEastSprite()
        {
            return new TextureSprite(LinkUseItemEastTexture, 1, 2, 5);
        }
        public ISprite CreateLinkUseItemWestSprite()
        {
            return new TextureSprite(LinkUseItemWestTexture, 1, 2, 5);
        }
    }
}
