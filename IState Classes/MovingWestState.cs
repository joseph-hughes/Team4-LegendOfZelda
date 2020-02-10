using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class MovingWestState : IState
    {
        public LegendOfZelda ThisGame { get; set; }
        public string GetState()
        {
            return "MovingWest";
        }
        public void Update()
        {
            Texture2D sprite = ThisGame.Content.Load<Texture2D>("Link");
            ThisGame.SetSprite(new MovingWestSprite(sprite, new Vector2(320, 200)));
        }
    }
}