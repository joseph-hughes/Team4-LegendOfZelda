using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseRed_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class KeeseRed : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        private IController controller;

        public KeeseRed(ILevel level, Vector2 position)
        {
            Level = level;
            Sprite = EnemySpriteFactory.Instance.CreateKeeseRedSprite();
            State = new KeeseRedIdleState(this);
            Position = position;
            controller = new KeeseController(this);
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            // Do nothing
        }
        
        public void BeDamaged()
        {
            // Do nothing
        }

        public void Attack()
        {
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            controller.Update();
            State.Update();
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Position);
        }
    }
}
