using System;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.MapClasses
{
    public class Room_Link:IMap
    {
        public IRoomState room { get; set; }
        public Room_Link()
        {
            room = room1();
        }



        public void room1()
        {
            room.room2();
        }

        public void room2()
        {
            room.room2();
        }

        public void room3()
        {
            room.room3();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
