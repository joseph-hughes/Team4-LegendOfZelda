using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.WallMaster_States;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.Vector;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class WallMaster : IEnemy
    {
        public IRoom Room { get; set; }
        private UtilityClass utilities = new UtilityClass();

        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public IVector Velocity { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        private IController controller;
        private const int WIDTH = 16, HEIGHT = 16;

        public WallMaster(IRoom room, Vector2 position)
        {
            Room = room;
            Scale = utilities.Scale;
            Velocity = new VelocityVector(0, Orientation.South);
            State = new WallMasterIdleState(this);
            State = new WallMasterWestState(this);
            controller = new WallMasterController(this);
            Sprite = ItemSpriteFactory.Instance.CreateEmptyItem();
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, WIDTH, HEIGHT);
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
