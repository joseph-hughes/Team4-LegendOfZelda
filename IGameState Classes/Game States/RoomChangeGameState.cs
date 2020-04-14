using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.IGameState_Classes
{
    class RoomChangeGameState : IGameState
    {
        private IGameState gameState;
        private ILevel level;
        private IRoom nextRoom;
        private int transitionTimer = 100;

        public RoomChangeGameState(IGameState gameState, ILevel level, IRoom nextRoom)
        {
            this.gameState = gameState;
            this.level = level;
            this.nextRoom = nextRoom;
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
            // TODO: trigger room transition
            if (transitionTimer > 0)
            {
                transitionTimer -= 1;
            } else {
                level.CurrentRoom = nextRoom;
                this.gameState = new RoomGameState(gameState, level);
            }
        }
    }
}
