using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
	public class EnemySpriteFactory : ISpriteFactory
	{
		private Texture2D AquamentusLeftFacingIdleTexture;
		private Texture2D AquamentusLeftFacingAttackTexture;
		private Texture2D AquamentusRightFacingIdleTexture;
		private Texture2D AquamentusRightFacingAttackTexture;

		private Texture2D DodongoLeftFacingWalkingTexture;
		private Texture2D DodongoLeftFacingHitTexture;
		private Texture2D DodongoRightFacingWalkingTexture;
		private Texture2D DodongoRightFacingHitTexture;
		private Texture2D DodongoUpWalkingTexture;
		private Texture2D DodongoUpHitTexture;
		private Texture2D DodongoDownWalkingTexture;
		private Texture2D DodongoDownHitTexture;

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

			DodongoLeftFacingWalkingTexture = content.Load<Texture2D>("");
			DodongoLeftFacingHitTexture = content.Load<Texture2D>("");
			DodongoRightFacingWalkingTexture = content.Load<Texture2D>("");
			DodongoRightFacingHitTexture = content.Load<Texture2D>("");
			DodongoUpWalkingTexture = content.Load<Texture2D>("");
			DodongoUpHitTexture = content.Load<Texture2D>("");
			DodongoDownWalkingTexture = content.Load<Texture2D>("");
			DodongoDownHitTexture = content.Load<Texture2D>("");
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
