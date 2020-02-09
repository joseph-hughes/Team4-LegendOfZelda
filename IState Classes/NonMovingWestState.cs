using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda.IState_Classes
{
    class NonMovingWestState : IState
    {
        public LegendOfZelda ThisGame { get; set; }
        public string GetState()
        {
            return "NonMovingWest";
        }
        public void Update()
        {
            Texture2D sprite = ThisGame.Content.Load<Texture2D>("Link");
            ThisGame.SetSprite(new NonMovingWestSprite(sprite, new Vector2(320, 200)));
        }
    }
}