using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Team4_LegendOfZelda
{
    public class SetMovingAnimatedSpriteCommand : ICommand
    {
        public LegendOfZelda ThisGame { get; set; }
        public SetMovingAnimatedSpriteCommand(LegendOfZelda thisGame)
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
