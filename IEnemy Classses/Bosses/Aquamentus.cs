using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.IEnemy_Classses.Bosses.Aquamentus_States;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.Vector;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{

    class Aquamentus : IEnemy
    {
        public IRoom Room { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public IVector Velocity { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        private IController controller;
        

        public Aquamentus(IRoom room, Vector2 position)
        {
            Room = room;
            Scale = 3f;
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(Scale * UtilityClass.Instance.Aquamentus_WIDTH()), (int)(Scale * UtilityClass.Instance.Aquamentus_Height()));
            Velocity = new VelocityVector(0, Orientation.West);
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
            Velocity.Magnitude = 0;
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

            if (Velocity.Direction == Orientation.East)
            {
                DestinationRectangle = new Rectangle(DestinationRectangle.X + Velocity.Magnitude, DestinationRectangle.Y, DestinationRectangle.Width, DestinationRectangle.Height);
            }
            else
            {
                DestinationRectangle = new Rectangle(DestinationRectangle.X - Velocity.Magnitude, DestinationRectangle.Y, DestinationRectangle.Width, DestinationRectangle.Height);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
