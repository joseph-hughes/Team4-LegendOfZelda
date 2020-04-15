using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Stalfos_States;
using Team4_LegendOfZelda.Vector;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class Stalfos : IEnemy
    {
        public IRoom Room { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public IVector Velocity { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
      
        private IController controller;

        public Stalfos(IRoom room, Vector2 position)
        {
            Room = room;
            Scale = UtilityClass.Instance.Scale();
            Sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(Scale * UtilityClass.Instance.Stalfos_WIDTH()), (int)(Scale * UtilityClass.Instance.Stalfos_HEIGHT()));
            Velocity = new VelocityVector(0, Orientation.South);
            State = new StalfosIdleState(this);
            controller = new StalfosController(this);
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
