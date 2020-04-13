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
        private IGameState gameState { get; set; }
        private ILevel level { get; set; }
        private IRoom nextRoom { get; set; }

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
            level.CurrentRoom = nextRoom;
        }
    }
}
