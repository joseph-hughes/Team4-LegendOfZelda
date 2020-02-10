using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Team4_LegendOfZelda
{
    public class SetNonMovingNonAnimatedSpriteCommand : ICommand
    {
        public LegendOfZelda ThisGame { get; set; }
        public SetNonMovingNonAnimatedSpriteCommand(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {
            Texture2D sprite = ThisGame.Content.Load<Texture2D>("Link");
            ThisGame.SetSprite(new NonMovingNonAnimatedSprite(sprite, new Vector2(320, 200)));
            ThisGame.SetSource("https://www.nesmaps.com/maps/Zelda/sprites/ZeldaSpriteLinkSwingSwordLeft.png");
        }
    }
}
