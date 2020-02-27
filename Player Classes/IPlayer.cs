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
        IProjectile currentProjectile { get; set; }
        IItem currentItem { get; set; }
        int currentUseItemID { get; set; }
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