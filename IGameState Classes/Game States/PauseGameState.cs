using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.IGameState_Classes
{
    class PauseGameState : IGameState
    {
        private IGameState gameState;
        private ILevel level;

        public PauseGameState(IGameState gameState, ILevel level)
        {
            this.gameState = gameState;
            this.level = level;
        }
        public void ItemSelect()
        {
            this.gameState = new ItemSelectGameState(gameState, level);
        }
        public void Over()
        {
            // no action
        }
        public void Pause()
        {
            this.gameState = new RoomGameState(gameState, level);
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
            // trigger pause screen
        }
    }
}
