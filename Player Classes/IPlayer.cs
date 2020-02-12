using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda
{
    public interface IPlayer
    {
        ISprite Sprite { get; set; }
        IState State { get; set; }
        Vector2 Position { get; set; }
        void South();
        void North();
        void East();
        void West();
        void BeDamaged();
        void UseItem();
        void Attack();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}