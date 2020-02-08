using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Team4_LegendOfZelda
{
    public class SetMovingNonAnimatedSpriteCommand : ICommand
    {
        public LegendOfZelda ThisGame { get; set; }
        public SetMovingNonAnimatedSpriteCommand(LegendOfZelda thisGame)
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
