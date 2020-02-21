using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
	public class ProjectileSpriteFactory : ISpriteFactory
	{
		private Texture2D arrowUp;
		private Texture2D arrowDown;
		private Texture2D arrowLeft;
		private Texture2D arrowRight;
		private Texture2D fireball;
		private Texture2D boomerang;
		private Texture2D magicBoomerang;


		private static ProjectileSpriteFactory instance = new ProjectileSpriteFactory();

		public static ProjectileSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private ProjectileSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			arrowUp = content.Load<Texture2D>("Projectiles/ArrowUp");
			arrowDown = content.Load<Texture2D>("Projectiles/ArrowDown");
			arrowLeft = content.Load<Texture2D>("Projectiles/ArrowLeft");
			arrowRight = content.Load<Texture2D>("Projectiles/ArrowRight");
			fireball = content.Load<Texture2D>("Projectiles/Fireball");
			boomerang = content.Load<Texture2D>("Projectile Sprites/FlyingBoomerang");
			magicBoomerang = content.Load<Texture2D>("Projectile Sprites/FlyingMagicalBoomerang");
		}

		public ISprite CreateArrowUpSprite()
		{
			return new TextureSprite(arrowUp);
		}
		public ISprite CreateArrowDownSprite()
		{
			return new TextureSprite(arrowDown);
		}
		public ISprite CreateArrowLeftSprite()
		{
			return new TextureSprite(arrowLeft);
		}
		public ISprite CreateArrowRightSprite()
		{
			return new TextureSprite(arrowRight);
		}
		public ISprite CreateFireballSprite()
		{
			return new TextureSprite(fireball, 1, 4, 5);
		}

		public ISprite CreateBoomerangSprite()
		{
			return new TextureSprite(boomerang, 1, 8, 5);
		}

		public ISprite CreateMagicBoomerangSprite()
		{
			return new TextureSprite(magicBoomerang, 1, 8, 5);
		}
	}
}
