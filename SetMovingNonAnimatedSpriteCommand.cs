using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint0
{
    public class SetMovingNonAnimatedSpriteCommand : ICommand
    {
        public SpritesGame ThisGame { get; set; }
        public SetMovingNonAnimatedSpriteCommand(SpritesGame thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute ()
        {
            Texture2D sprite = ThisGame.Content.Load<Texture2D>("Arrow");
            ThisGame.SetSprite(new MovingNonAnimatedSprite(sprite, new Vector2(380, 200), 5));
            ThisGame.SetSource("https://www.nesmaps.com/maps/Zelda/sprites/ZeldaSpriteArrow.png");
        }
    }
}
