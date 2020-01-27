using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Team4_LegendOfZelda
{
    public class SetNonMovingAnimatedSpriteCommand : ICommand
    {
        public LegendOfZelda ThisGame { get; set; }
        public SetNonMovingAnimatedSpriteCommand(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute ()
        {
            Texture2D sprite = ThisGame.Content.Load<Texture2D>("Simon");
            ThisGame.SetSprite(new NonMovingAnimatedSprite(sprite, new Vector2(260, 150), 1, 5, 5));
            ThisGame.SetSource("https://www.spriters-resource.com/submitter/MisterMike/");
        }
    }
}
