﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{
    public interface IEnemy
    {
        IRoom Room { get; set; }
        ISprite Sprite { get; set; }
        IState State { get; set; }
        Rectangle DestinationRectangle { get; set; }
        float Scale { get; set; }

        void North();
        void East();
        void South();
        void West();
        void Idle();
        void BeDamaged();
        void UseItem();
        void Attack();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
