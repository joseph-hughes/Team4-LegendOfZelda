using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.IEnemy_Classses.Bosses.Dodongo_States;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.Vector;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class Dodongo : IEnemy
    {
        public IRoom Room { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public IVector Velocity { get; set; }
        private IController controller;
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }

        public Dodongo(IRoom room, Vector2 position)
        {
            Room = room;
            Scale = 3f;
            controller = new DodongoController(this);
            Velocity = new VelocityVector(0, Orientation.West);
            State = new DodongoWestWalkingState(this);
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(Scale * Sprite.SourceRectangle.Width), (int)(Scale * Sprite.SourceRectangle.Height));
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
        public void Freeze()
        {
            State.Freeze();
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
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
