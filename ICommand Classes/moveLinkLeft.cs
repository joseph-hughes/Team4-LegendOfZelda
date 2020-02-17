﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{

    public class moveLinkLeft : ICommand
    {
        private PlayerSpriteFactory spriteFactory = PlayerSpriteFactory.Instance;

        public LegendOfZelda ThisGame { get; set; }
        public moveLinkLeft(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {
            spriteFactory.CreateLinkMovingWestSprite().Update();
        }
    }
}
