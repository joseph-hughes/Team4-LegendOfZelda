using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
	public class EnemySpriteFactory
	{
		private Texture2D AquamentusLeftFacingIdleTexture;
		private Texture2D AquamentusLeftFacingAttackTexture;
		private Texture2D AquamentusRightFacingIdleTexture;
		private Texture2D AquamentusRightFacingAttackTexture;

		private static EnemySpriteFactory instance = new EnemySpriteFactory();

		public static EnemySpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private EnemySpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			AquamentusLeftFacingIdleTexture = content.Load<Texture2D>("Aquamentus Left-facing Non-fire");
			AquamentusLeftFacingAttackTexture = content.Load<Texture2D>("Aquamentus Left-facing Fire");
			AquamentusRightFacingIdleTexture = content.Load<Texture2D>("Aquamentus Right-facing Non-fire");
			AquamentusRightFacingAttackTexture = content.Load<Texture2D>("Aquamentus Right-facing Fire");
		}

		public ISprite CreateAquamentusLeftFacingIdleSprite()
		{
			return new TextureSprite(AquamentusLeftFacingIdleTexture, 1, 2, 5);
		}

		public ISprite CreateAquamentusLeftFacingAttackSprite()
		{
			return new TextureSprite(AquamentusLeftFacingAttackTexture, 1, 2, 5);
		}

		public ISprite CreateAquamentusRightFacingIdleSprite()
		{
			return new TextureSprite(AquamentusRightFacingIdleTexture, 1, 2, 5);
		}

		public ISprite CreateAquamentusRightFacingAttackSprite()
		{
			return new TextureSprite(AquamentusRightFacingAttackTexture, 1, 2, 5);
		}
	}
}
