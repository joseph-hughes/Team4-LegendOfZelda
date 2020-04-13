namespace Team4_LegendOfZelda
{
    public interface IGameState
    {
        void ItemSelect();
        void Over();
        void Pause();
        void Win();
        void RoomChange();
        void Update();
    }
}