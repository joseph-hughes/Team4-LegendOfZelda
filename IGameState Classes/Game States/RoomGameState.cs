﻿using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.IGameState_Classes
{
    class RoomGameState : IGameState
    {
        private IGameState gameState;
        private ILevel level;

        public RoomGameState(IGameState gameState, ILevel level)
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
            this.gameState = new OverGameState(gameState, level);
        }
        public void Pause()
        {
            this.gameState = new PauseGameState(gameState, level);
        }
        public void RoomChange(IRoom nextRoom)
        {
            this.gameState = new RoomChangeGameState(gameState, level, nextRoom);
        }
        public void Win()
        {
            this.gameState = new WinGameState(gameState, level);
        }
        public void Update()
        {
            // no action
        }

    }
}
