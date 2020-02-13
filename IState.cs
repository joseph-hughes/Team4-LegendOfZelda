namespace Team4_LegendOfZelda
{
    public interface IState
    {
        void GoNorth();
        void GoEast();
        void GoSouth();
        void GoWest();
        void BeDamaged();
        void Attack();
        void UseItem();
        void Update();
    }

}
