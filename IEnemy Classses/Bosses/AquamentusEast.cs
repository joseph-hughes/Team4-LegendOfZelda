using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class AquamentusEast : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle Rectangle { get; set; }
        public float Scale { get; set; }
        private IController controller;

        public AquamentusEast(ILevel level, Vector2 position)
        {
            Level = level;
            Scale = 3f;
            Position = position;

            State = new AquamentusEastIdleState(this);
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
            Sprite.Draw(spriteBatch, Rectangle);
        }
    }
}
