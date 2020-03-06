using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseRed_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class KeeseRed : IEnemy
    {
        public IRoom Room { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        private IController controller;
        public float Scale { get; set; }
        private const int width = 16;
        private const int height = 10;
        
       

        public KeeseRed(IRoom room, Vector2 position)
        {
            Room = room;
            
            Scale = 3f;

            Sprite = EnemySpriteFactory.Instance.CreateKeeseRedSprite();
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(Scale * width), (int)(Scale * height));
            State = new KeeseRedIdleState(this);
            controller = new KeeseController(this);


           
          
            
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
