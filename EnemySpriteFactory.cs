using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
	public class EnemySpriteFactory : ISpriteFactory
	{
		private Texture2D AquamentusEastIdleTexture;
		private Texture2D AquamentusEastAttackTexture;
		private Texture2D AquamentusWestIdleTexture;
		private Texture2D AquamentusWestAttackTexture;

		private Texture2D DodongoWestWalkingTexture;
		private Texture2D DodongoWestDamagedTexture;
		private Texture2D DodongoEastWalkingTexture;
		private Texture2D DodongoEastDamagedTexture;
		private Texture2D DodongoNorthWalkingTexture;
		private Texture2D DodongoNorthDamagedTexture;
		private Texture2D DodongoSouthWalkingTexture;
		private Texture2D DodongoSouthDamagedTexture;

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
			AquamentusEastIdleTexture = content.Load<Texture2D>("AquamentusEastIdle");
			AquamentusEastAttackTexture = content.Load<Texture2D>("AquamentusEastAttack");
			AquamentusWestIdleTexture = content.Load<Texture2D>("AquamentusWestIdle");
			AquamentusWestAttackTexture = content.Load<Texture2D>("AquamentusWestAttack");

			DodongoWestWalkingTexture = content.Load<Texture2D>("DodongoWestWalking");
			DodongoWestDamagedTexture = content.Load<Texture2D>("DodongoWestDamaged");
			DodongoEastWalkingTexture = content.Load<Texture2D>("DodongoEastWalking");
			DodongoEastDamagedTexture = content.Load<Texture2D>("DodongoEastDamaged");
			DodongoNorthWalkingTexture = content.Load<Texture2D>("DodongoNorthWalking");
			DodongoNorthDamagedTexture = content.Load<Texture2D>("DodongoNorthDamaged");
			DodongoSouthWalkingTexture = content.Load<Texture2D>("DodongoSouthWalking");
			DodongoSouthDamagedTexture = content.Load<Texture2D>("DodongoSouthDamaged");
		}

		// Aquamentus Sprites
		public ISprite CreateAquamentusEastIdleSprite()
		{
			return new TextureSprite(AquamentusEastIdleTexture, 1, 2, 5);
		}

		public ISprite CreateAquamentusEastAttackSprite()
		{
			return new TextureSprite(AquamentusEastAttackTexture, 1, 2, 5);
		}

		public ISprite CreateAquamentusWestIdleSprite()
		{
			return new TextureSprite(AquamentusWestIdleTexture, 1, 2, 5);
		}

		public ISprite CreateAquamentusWestAttackSprite()
		{
			return new TextureSprite(AquamentusWestAttackTexture, 1, 2, 5);
		}

		// Dondongo Sprites
		public ISprite CreateDodongoWestWalkingSprite()
		{
			return new TextureSprite(DodongoWestWalkingTexture, 1, 2, 5);
		}

		public ISprite CreateDodongoWestDamagedSprite()
		{
			return new TextureSprite(DodongoWestDamagedTexture);
		}

		public ISprite CreateDodongoEastWalkingSprite()
		{
			return new TextureSprite(DodongoEastWalkingTexture, 1, 2, 5);
		}

		public ISprite CreateDodongoEastDamagedSprite()
		{
			return new TextureSprite(DodongoEastDamagedTexture);
		}

		public ISprite CreateDodongoNorthWalkingSprite()
		{
			return new TextureSprite(DodongoNorthWalkingTexture, 1, 2, 5);
		}

		public ISprite CreateDodongoNorthDamagedSprite()
		{
			return new TextureSprite(DodongoNorthDamagedTexture);
		}

		public ISprite CreateDodongoSouthWalkingSprite()
		{
			return new TextureSprite(DodongoSouthWalkingTexture, 1, 2, 5);
		}

		public ISprite CreateDodongoSouthDamagedSprite()
		{
			return new TextureSprite(DodongoSouthDamagedTexture);
		}
	}
}
