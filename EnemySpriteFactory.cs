using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
	public class EnemySpriteFactory : ISpriteFactory
	{
		private Texture2D aquamentusEastIdleTexture;
		private Texture2D aquamentusEastAttackTexture;
		private Texture2D aquamentusWestIdleTexture;
		private Texture2D aquamentusWestAttackTexture;

		private Texture2D dodongoNorthWalkingTexture;
		private Texture2D dodongoNorthDamagedTexture;
		private Texture2D dodongoEastWalkingTexture;
		private Texture2D dodongoEastDamagedTexture;
		private Texture2D dodongoSouthWalkingTexture;
		private Texture2D dodongoSouthDamagedTexture;
		private Texture2D dodongoWestWalkingTexture;
		private Texture2D dodongoWestDamagedTexture;

		private Texture2D gelDarkBlueTexture;

		private Texture2D goriyaBlueNorthTexture;
		private Texture2D goriyaBlueEastTexture;
		private Texture2D goriyaBlueSouthTexture;
		private Texture2D goriyaBlueWestTexture;

		private Texture2D goriyaRedNorthTexture;
		private Texture2D goriyaRedEastTexture;
		private Texture2D goriyaRedSouthTexture;
		private Texture2D goriyaRedWestTexture;

		private Texture2D keeseBlueTexture;
		private Texture2D keeseRedTexture;

		private Texture2D ropeEastTexture;
		private Texture2D ropeWestTexture;

		private Texture2D stalfosTexture;

		private Texture2D bladeTrapTexture;

		private Texture2D wallMasterEastTexture;
		private Texture2D wallMasterWestTexture;

		private Texture2D zolDarkGreenTexture;

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
			aquamentusEastIdleTexture = content.Load<Texture2D>("AquamentusEastIdle");
			aquamentusEastAttackTexture = content.Load<Texture2D>("AquamentusEastAttack");
			aquamentusWestIdleTexture = content.Load<Texture2D>("AquamentusWestIdle");
			aquamentusWestAttackTexture = content.Load<Texture2D>("AquamentusWestAttack");

			dodongoNorthWalkingTexture = content.Load<Texture2D>("DodongoNorthWalking");
			dodongoNorthDamagedTexture = content.Load<Texture2D>("DodongoNorthDamaged");
			dodongoEastWalkingTexture = content.Load<Texture2D>("DodongoEastWalking");
			dodongoEastDamagedTexture = content.Load<Texture2D>("DodongoEastDamaged");
			dodongoSouthWalkingTexture = content.Load<Texture2D>("DodongoSouthWalking");
			dodongoSouthDamagedTexture = content.Load<Texture2D>("DodongoSouthDamaged");
			dodongoWestWalkingTexture = content.Load<Texture2D>("DodongoWestWalking");
			dodongoWestDamagedTexture = content.Load<Texture2D>("DodongoWestDamaged");

			gelDarkBlueTexture = content.Load<Texture2D>("GelDarkBlue");

			goriyaBlueNorthTexture = content.Load<Texture2D>("GoriyaBlueNorth");
			goriyaBlueEastTexture = content.Load<Texture2D>("GoriyaBlueEast");
			goriyaBlueSouthTexture = content.Load<Texture2D>("GoriyaBlueSouth");
			goriyaBlueWestTexture = content.Load<Texture2D>("GoriyaBlueWest");

			goriyaRedNorthTexture = content.Load<Texture2D>("GoriyaRedNorth");
			goriyaRedEastTexture = content.Load<Texture2D>("GoriyaRedEast");
			goriyaRedSouthTexture = content.Load<Texture2D>("GoriyaRedSouth");
			goriyaRedWestTexture = content.Load<Texture2D>("GoriyaRedWest");

			keeseBlueTexture = content.Load<Texture2D>("KeeseBlue");
			keeseRedTexture = content.Load<Texture2D>("KeeseRed");

			ropeEastTexture = content.Load<Texture2D>("RopeEast");
			ropeWestTexture = content.Load<Texture2D>("RopeWest");

			stalfosTexture = content.Load<Texture2D>("Stalfos");

			bladeTrapTexture = content.Load<Texture2D>("BladeTrap");

			wallMasterEastTexture = content.Load<Texture2D>("WallMasterEast");
			wallMasterWestTexture = content.Load<Texture2D>("WallMasterWest");

			zolDarkGreenTexture = content.Load<Texture2D>("ZolDarkGreen");
		}

		// Aquamentus Sprites
		public ISprite CreateAquamentusEastIdleSprite()
		{
			return new TextureSprite(aquamentusEastIdleTexture, 1, 2, 5);
		}

		public ISprite CreateAquamentusEastAttackSprite()
		{
			return new TextureSprite(aquamentusEastAttackTexture, 1, 2, 5);
		}

		public ISprite CreateAquamentusWestIdleSprite()
		{
			return new TextureSprite(aquamentusWestIdleTexture, 1, 2, 5);
		}

		public ISprite CreateAquamentusWestAttackSprite()
		{
			return new TextureSprite(aquamentusWestAttackTexture, 1, 2, 5);
		}

		// Dondongo Sprites
		public ISprite CreateDodongoNorthWalkingSprite()
		{
			return new TextureSprite(dodongoNorthWalkingTexture, 1, 2, 5);
		}

		public ISprite CreateDodongoNorthDamagedSprite()
		{
			return new TextureSprite(dodongoNorthDamagedTexture);
		}

		public ISprite CreateDodongoEastWalkingSprite()
		{
			return new TextureSprite(dodongoEastWalkingTexture, 1, 2, 5);
		}

		public ISprite CreateDodongoEastDamagedSprite()
		{
			return new TextureSprite(dodongoEastDamagedTexture);
		}

		public ISprite CreateDodongoSouthWalkingSprite()
		{
			return new TextureSprite(dodongoSouthWalkingTexture, 1, 2, 5);
		}

		public ISprite CreateDodongoSouthDamagedSprite()
		{
			return new TextureSprite(dodongoSouthDamagedTexture);
		}

		public ISprite CreateDodongoWestWalkingSprite()
		{
			return new TextureSprite(dodongoWestWalkingTexture, 1, 2, 5);
		}

		public ISprite CreateDodongoWestDamagedSprite()
		{
			return new TextureSprite(dodongoWestDamagedTexture);
		}

		// Gel Sprites
		public ISprite CreateGelDarkBlueSprite()
		{
			return new TextureSprite(gelDarkBlueTexture, 1, 2, 5);
		}

		// Goriya Blue Sprites
		public ISprite CreateGoriyaBlueNorthSprite()
		{
			return new TextureSprite(goriyaBlueNorthTexture, 1, 2, 5);
		}

		public ISprite CreateGoriyaBlueEastSprite()
		{
			return new TextureSprite(goriyaBlueEastTexture, 1, 2, 5);
		}

		public ISprite CreateGoriyaBlueSouthSprite()
		{
			return new TextureSprite(goriyaBlueSouthTexture, 1, 2, 5);
		}

		public ISprite CreateGoriyaBlueWestSprite()
		{
			return new TextureSprite(goriyaBlueWestTexture, 1, 2, 5);
		}

		// Goriya Red Sprites
		public ISprite CreateGoriyaRedNorthSprite()
		{
			return new TextureSprite(goriyaRedNorthTexture, 1, 2, 5);
		}

		public ISprite CreateGoriyaRedEastSprite()
		{
			return new TextureSprite(goriyaRedEastTexture, 1, 2, 5);
		}

		public ISprite CreateGoriyaRedSouthSprite()
		{
			return new TextureSprite(goriyaRedSouthTexture, 1, 2, 5);
		}

		public ISprite CreateGoriyaRedWestSprite()
		{
			return new TextureSprite(goriyaRedWestTexture, 1, 2, 5);
		}

		// Keese Sprites
		public ISprite CreateKeeseBlueSprite()
		{
			return new TextureSprite(keeseBlueTexture, 1, 2, 5);
		}

		public ISprite CreateKeeseRedSprite()
		{
			return new TextureSprite(keeseRedTexture, 1, 2, 5);
		}

		// Rope Sprites
		public ISprite CreateRopeEastSprite()
		{
			return new TextureSprite(ropeEastTexture, 1, 2, 5);
		}

		public ISprite CreateRopeWestSprite()
		{
			return new TextureSprite(ropeWestTexture, 1, 2, 5);
		}

		// Stalfos Sprites
		public ISprite CreateStalfosSprite()
		{
			return new TextureSprite(stalfosTexture, 1, 2, 5);
		}

		// Blade Trap Sprites
		public ISprite CreateBladeTrapSprite()
		{
			return new TextureSprite(bladeTrapTexture, 1, 2, 5);
		}

		// Wall Master Sprites
		public ISprite CreateWallMasterEastSprite()
		{
			return new TextureSprite(wallMasterEastTexture, 1, 2, 5);
		}

		public ISprite CreateWallMasterWestSprite()
		{
			return new TextureSprite(wallMasterWestTexture, 1, 2, 5);
		}

		// Zol Sprites
		public ISprite CreateZolDarkGreenSprite()
		{
			return new TextureSprite(zolDarkGreenTexture, 1, 2, 5);
		}
	}
}
