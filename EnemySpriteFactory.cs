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
		private Texture2D wallMasterUpsideDownEastTexture;
		private Texture2D wallMasterUpsideDownWestTexture;

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
			aquamentusEastIdleTexture = content.Load<Texture2D>("Bosses/Aquamentus/AquamentusEastIdle");
			aquamentusEastAttackTexture = content.Load<Texture2D>("Bosses/Aquamentus/AquamentusEastAttack");
			aquamentusWestIdleTexture = content.Load<Texture2D>("Bosses/Aquamentus/AquamentusWestIdle");
			aquamentusWestAttackTexture = content.Load<Texture2D>("Bosses/Aquamentus/AquamentusWestAttack");

			dodongoNorthWalkingTexture = content.Load<Texture2D>("Bosses/Dodongo/DodongoNorthWalking");
			dodongoNorthDamagedTexture = content.Load<Texture2D>("Bosses/Dodongo/DodongoNorthDamaged");
			dodongoEastWalkingTexture = content.Load<Texture2D>("Bosses/Dodongo/DodongoEastWalking");
			dodongoEastDamagedTexture = content.Load<Texture2D>("Bosses/Dodongo/DodongoEastDamaged");
			dodongoSouthWalkingTexture = content.Load<Texture2D>("Bosses/Dodongo/DodongoSouthWalking");
			dodongoSouthDamagedTexture = content.Load<Texture2D>("Bosses/Dodongo/DodongoSouthDamaged");
			dodongoWestWalkingTexture = content.Load<Texture2D>("Bosses/Dodongo/DodongoWestWalking");
			dodongoWestDamagedTexture = content.Load<Texture2D>("Bosses/Dodongo/DodongoWestDamaged");

			gelDarkBlueTexture = content.Load<Texture2D>("Dungeon Enemies/Gel/GelDarkBlue");

			goriyaBlueNorthTexture = content.Load<Texture2D>("Dungeon Enemies/Goriya/GoriyaBlueNorth");
			goriyaBlueEastTexture = content.Load<Texture2D>("Dungeon Enemies/Goriya/GoriyaBlueEast");
			goriyaBlueSouthTexture = content.Load<Texture2D>("Dungeon Enemies/Goriya/GoriyaBlueSouth");
			goriyaBlueWestTexture = content.Load<Texture2D>("Dungeon Enemies/Goriya/GoriyaBlueWest");

			goriyaRedNorthTexture = content.Load<Texture2D>("Dungeon Enemies/Goriya/GoriyaRedNorth");
			goriyaRedEastTexture = content.Load<Texture2D>("Dungeon Enemies/Goriya/GoriyaRedEast");
			goriyaRedSouthTexture = content.Load<Texture2D>("Dungeon Enemies/Goriya/GoriyaRedSouth");
			goriyaRedWestTexture = content.Load<Texture2D>("Dungeon Enemies/Goriya/GoriyaRedWest");

			keeseBlueTexture = content.Load<Texture2D>("Dungeon Enemies/Keese/KeeseBlue");
			keeseRedTexture = content.Load<Texture2D>("Dungeon Enemies/Keese/KeeseRed");

			ropeEastTexture = content.Load<Texture2D>("Dungeon Enemies/Rope/RopeEast");
			ropeWestTexture = content.Load<Texture2D>("Dungeon Enemies/Rope/RopeWest");

			stalfosTexture = content.Load<Texture2D>("Dungeon Enemies/Stalfos/Stalfos");

			bladeTrapTexture = content.Load<Texture2D>("Dungeon Enemies/Trap/BladeTrap");

			wallMasterEastTexture = content.Load<Texture2D>("Dungeon Enemies/Wall Master/WallMasterEast");
			wallMasterWestTexture = content.Load<Texture2D>("Dungeon Enemies/Wall Master/WallMasterWest");
			wallMasterUpsideDownEastTexture = content.Load<Texture2D>("Dungeon Enemies/Wall Master/WallMasterUpsideDownEast");
			wallMasterUpsideDownWestTexture = content.Load<Texture2D>("Dungeon Enemies/Wall Master/WallMasterUpsideDownWest");

			zolDarkGreenTexture = content.Load<Texture2D>("Dungeon Enemies/Zol/ZolDarkGreen");
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

		public ISprite CreateWallMasterUpsideDownEastSprite()
		{
			return new TextureSprite(wallMasterUpsideDownEastTexture, 1, 2, 5);
		}

		public ISprite CreateWallMasterUpsideDownWestSprite()
		{
			return new TextureSprite(wallMasterUpsideDownWestTexture, 1, 2, 5);
		}

		// Zol Sprites
		public ISprite CreateZolDarkGreenSprite()
		{
			return new TextureSprite(zolDarkGreenTexture, 1, 2, 5);
		}
	}
}
