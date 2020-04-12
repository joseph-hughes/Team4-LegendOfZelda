using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.BladeTrap_States;
using Team4_LegendOfZelda.Vector;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class BladeTrap : IEnemy
    {
        public IRoom Room { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public IVector Velocity { get; set; }
        private IController controller;
        public Rectangle DestinationRectangle { get; set; }
        private const int width = 16;
        private const int height = 16;
        public float Scale { get; set; }

        public BladeTrap(IRoom room, Vector2 position)
        {
            Room = room;
            Scale = 3f;
            Velocity = new VelocityVector(0, Orientation.South);
            Sprite = EnemySpriteFactory.Instance.CreateBladeTrapSprite();
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(Scale * width), (int)(Scale * height));

            State = new BladeTrapIdleState(this);
            controller = new BladeTrapController(this);
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
