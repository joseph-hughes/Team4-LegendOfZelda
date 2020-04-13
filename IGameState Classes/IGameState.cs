using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{
    public interface IGameState
    {
        void ItemSelect();
        void Over();
        void Pause();
        void Win();
        void RoomChange(IRoom nextRoom);
        void Update();
    }
}