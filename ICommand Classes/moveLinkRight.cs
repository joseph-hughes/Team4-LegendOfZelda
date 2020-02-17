using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{
    public class moveLinkRight : ICommand
    {
        private PlayerSpriteFactory spriteFactory = PlayerSpriteFactory.Instance;
        public LegendOfZelda ThisGame { get; set; }
        public moveLinkRight(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {
            spriteFactory.CreateLinkMovingEastSprite().Update();
        }
    }
}
