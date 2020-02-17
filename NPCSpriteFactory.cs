using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
	public class NPCSpriteFactory : ISpriteFactory
	{
		private Texture2D oldManTexture;
		private Texture2D oldWomanTexture;

		private Texture2D merchantGreenTexture;
		private Texture2D merchantBlueTexture;
		private Texture2D merchantRedTexture;

		private Texture2D zeldaGreenTexture;
		private Texture2D zeldaGreenHoldingTexture;
		private Texture2D zeldaBlueTexture;
		private Texture2D zeldaBlueHoldingTexture;
		private Texture2D zeldaRedTexture;
		private Texture2D zeldaRedHoldingTexture;

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

			oldWomanTexture = content.Load<Texture2D>("OldWoman");

			merchantGreenTexture = content.Load<Texture2D>("MerchantGreen");
			merchantBlueTexture = content.Load<Texture2D>("MerchantBlue");
			merchantRedTexture = content.Load<Texture2D>("MerchantRed");

			zeldaGreenTexture = content.Load<Texture2D>("ZeldaGreenIdle");
			zeldaGreenHoldingTexture = content.Load<Texture2D>("ZeldaGreenHolding");
			zeldaBlueTexture = content.Load<Texture2D>("ZeldaBlueIdle");
			zeldaBlueHoldingTexture = content.Load<Texture2D>("ZeldaBlueHolding");
			zeldaRedTexture = content.Load<Texture2D>("ZeldaRedIdle");
			zeldaRedHoldingTexture = content.Load<Texture2D>("ZeldaRedHolding");
		}

		// Old Man Sprites
		public ISprite CreateOldManSprite()
		{
			return new TextureSprite(oldManTexture);
		}

		// Old Woman Sprites
		public ISprite CreateOldWomanSprite()
		{
			return new TextureSprite(oldWomanTexture);
		}

		// Merchant Sprites
		public ISprite CreateMerchantGreenSprite()
		{
			return new TextureSprite(merchantGreenTexture);
		}

		public ISprite CreateMerchantBlueSprite()
		{
			return new TextureSprite(merchantBlueTexture);
		}

		public ISprite CreateMerchantRedSprite()
		{
			return new TextureSprite(merchantRedTexture);
		}

		// Zelda Sprites
		public ISprite CreateZeldaGreenSprite()
		{
			return new TextureSprite(zeldaGreenTexture);
		}

		public ISprite CreateZeldaGreenHoldingSprite()
		{
			return new TextureSprite(zeldaGreenHoldingTexture);
		}

		public ISprite CreateZeldaBlueSprite()
		{
			return new TextureSprite(zeldaBlueTexture);
		}

		public ISprite CreateZeldaBlueHoldingSprite()
		{
			return new TextureSprite(zeldaBlueHoldingTexture);
		}

		public ISprite CreateZeldaRedSprite()
		{
			return new TextureSprite(zeldaRedTexture);
		}

		public ISprite CreateZeldaRedHoldingSprite()
		{
			return new TextureSprite(zeldaRedHoldingTexture);
		}
	}
}
