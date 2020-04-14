namespace Team4_LegendOfZelda
{
    public interface IState
    {
 
        void North();
        void East();
        void South();
        void West();
        void Idle();
        void BeDamaged();
        void Attack();
        void UseItem();
        void Update();
    }

}
