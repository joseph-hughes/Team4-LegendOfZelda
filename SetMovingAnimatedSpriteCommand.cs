using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint0
{
    public class SetMovingAnimatedSpriteCommand : ICommand
    {
        public SpritesGame ThisGame { get; set; }
        public SetMovingAnimatedSpriteCommand(SpritesGame thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute ()
        {
            Texture2D sprite = ThisGame.Content.Load<Texture2D>("Spiderman");
            ThisGame.SetSprite(new MovingAnimatedSprite(sprite, new Vector2(360, 150), 1, 10, -8, 4));
            ThisGame.SetSource("http://alvin-earthworm.deviantart.com");
        }
    }
}
