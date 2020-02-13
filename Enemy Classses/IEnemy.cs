using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    interface IEnemy
    {
        ISprite Sprite { get; set; }
        IState State { get; set; }
        Vector2 Position { get; set; }
        void GoNorth();
        void GoEast();
        void GoSouth();
        void GoWest();
        void BeDamaged();
        void Attack();
        void UseItem();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
