using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.MapClasses
{
    public interface IMap
    {

        void room1();
        void room2();
        void room3();
        void Update();
        void Draw(SpriteBatch spriteBatch);
        
    }
}
