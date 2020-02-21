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

		private Texture2D zeldaGreenIdleTexture;
		private Texture2D zeldaGreenHoldingTexture;
		private Texture2D zeldaBlueIdleTexture;
		private Texture2D zeldaBlueHoldingTexture;
		private Texture2D zeldaRedIdleTexture;
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
			oldManTexture = content.Load<Texture2D>("NPCs/Old Man/OldMan");

			oldWomanTexture = content.Load<Texture2D>("NPCs/Old Woman/OldWoman");

			merchantGreenTexture = content.Load<Texture2D>("NPCs/Merchant/MerchantGreen");
			merchantBlueTexture = content.Load<Texture2D>("NPCs/Merchant/MerchantBlue");
			merchantRedTexture = content.Load<Texture2D>("NPCs/Merchant/MerchantRed");

			zeldaGreenIdleTexture = content.Load<Texture2D>("NPCs/Zelda/ZeldaGreenIdle");
			zeldaGreenHoldingTexture = content.Load<Texture2D>("NPCs/Zelda/ZeldaGreenHolding");
			zeldaBlueIdleTexture = content.Load<Texture2D>("NPCs/Zelda/ZeldaBlueIdle");
			zeldaBlueHoldingTexture = content.Load<Texture2D>("NPCs/Zelda/ZeldaBlueHolding");
			zeldaRedIdleTexture = content.Load<Texture2D>("NPCs/Zelda/ZeldaRedIdle");
			zeldaRedHoldingTexture = content.Load<Texture2D>("NPCs/Zelda/ZeldaRedHolding");
		}

		// Old Man Sprites
		public ISprite CreateOldManSprite()
		{
			return new TextureSprite(oldManTexture, 3);
		}

		// Old Woman Sprites
		public ISprite CreateOldWomanSprite()
		{
			return new TextureSprite(oldWomanTexture, 3);
		}

		// Merchant Sprites
		public ISprite CreateMerchantGreenSprite()
		{
			return new TextureSprite(merchantGreenTexture, 3);
		}

		public ISprite CreateMerchantBlueSprite()
		{
			return new TextureSprite(merchantBlueTexture, 3);
		}

		public ISprite CreateMerchantRedSprite()
		{
			return new TextureSprite(merchantRedTexture, 3);
		}

		// Zelda Sprites
		public ISprite CreateZeldaGreenIdleSprite()
		{
			return new TextureSprite(zeldaGreenIdleTexture, 3);
		}

		public ISprite CreateZeldaGreenHoldingSprite()
		{
			return new TextureSprite(zeldaGreenHoldingTexture, 3);
		}

		public ISprite CreateZeldaBlueIdleSprite()
		{
			return new TextureSprite(zeldaBlueIdleTexture, 3);
		}

		public ISprite CreateZeldaBlueHoldingSprite()
		{
			return new TextureSprite(zeldaBlueHoldingTexture, 3);
		}

		public ISprite CreateZeldaRedIdleSprite()
		{
			return new TextureSprite(zeldaRedIdleTexture, 3);
		}

		public ISprite CreateZeldaRedHoldingSprite()
		{
			return new TextureSprite(zeldaRedHoldingTexture, 3);
		}
	}
}
