﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.WallMaster_States;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class WallMasterUpsideDown : IEnemy
    {
        public IRoom Room { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        enum Direction { NORTH, EAST, SOUTH, WEST };
        Direction direction;
        private IController controller;


        public WallMasterUpsideDown(IRoom room, Vector2 position)
        {
            Room = room;
            Scale = 3f;
            State = new WallMasterUpsideDownWestState(this);
            controller = new WallMasterUpsideDownController(this);
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, DestinationRectangle.Width, DestinationRectangle.Height);

            direction = Direction.NORTH;

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
