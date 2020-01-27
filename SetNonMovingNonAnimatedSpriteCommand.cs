using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint0
{
    public class SetNonMovingNonAnimatedSpriteCommand : ICommand
    {
        public SpritesGame ThisGame { get; set; }
        public SetNonMovingNonAnimatedSpriteCommand(SpritesGame thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute ()
        {
            Texture2D sprite = ThisGame.Content.Load<Texture2D>("Link");
            ThisGame.SetSprite(new NonMovingNonAnimatedSprite(sprite, new Vector2(320, 200)));
            ThisGame.SetSource("https://www.nesmaps.com/maps/Zelda/sprites/ZeldaSpriteLinkSwingSwordLeft.png");
        }
    }
}
