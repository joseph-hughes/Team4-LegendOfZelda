using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.IGameState_Classes
{
    class OverGameState : IGameState
    {
        private IGameState gameState;
        private ILevel level;

        public OverGameState(IGameState gameState, ILevel level)
        {
            this.gameState = gameState;
            this.level = level;
        }
        public void ItemSelect()
        {
            // no action
        }
        public void Over()
        {
            // no action
        }
        public void Pause()
        {
            // no action
        }
        public void RoomChange(IRoom nextRoom)
        {
            // no action
        }
        public void Win()
        {
            // no action
        }
        public void Update()
        {
            // TODO: trigger game over screen
        }

    }
}
