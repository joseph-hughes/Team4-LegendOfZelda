namespace Team4_LegendOfZelda
{
    public interface IState
    {
        void South();
        void North();
        void East();
        void West();
        void BeDamaged();
        void Attack();
        void UseItem();
        void Update();
    }

}
