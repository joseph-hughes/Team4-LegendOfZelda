using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Utility_Classes;
using Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class Aquamentus : IEnemy
    {
        public IRoom Room { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        private UtilityClass utilities = new UtilityClass();
        public float Scale { get; set; }
        private IController controller;

        public Aquamentus(IRoom room, Vector2 position)
        {
            Room = room;
            Scale = utilities.Scale;
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, DestinationRectangle.Width, DestinationRectangle.Height);
            State = new AquamentusWestIdleState(this);
            controller = new AquamentusController(this);

        }

        public void North()
        {
            State.North();
        }

        public void East()
        {
            State.East();
        }

        public void South()
        {
            State.South();
        }

        public void West()
        {
            State.West();
        }

        public void Idle()
        {
            State.Idle();
        }

        public void BeDamaged()
        {
            State.BeDamaged();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void UseItem()
        {
            State.UseItem();
        }

        public void Update()
        {
            controller.Update();
            State.Update();
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
