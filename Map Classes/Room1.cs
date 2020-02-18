using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Team4_LegendOfZelda.MapClasses
{
    public class Room1: IMap
    {
        private ISprite RoomSprite;
        private Room_Link link;

        private Texture2D background;
        public List<Rectangle> non_movable_blocks;
        public List<Rectangle> movable_blocks;
        public List<Rectangle> boundaries;
        public List<Rectangle> doors;

        

        public Room1()
        {
            non_movable_blocks = new List<Rectangle>
            {
                new Rectangle()
            };
            movable_blocks = new List<Rectangle>
            {
                new Rectangle()
            };
            doors = new List<Rectangle>
            {
                new Rectangle()
            };
        }

        public void room1()
        {

        }

        public void room2()
        {
            link.room2();
        }


        public void room3()
        {
            link.room3();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //draw room 1 stuff
        }

        public void Update()
        {
            
        }
    }
}
