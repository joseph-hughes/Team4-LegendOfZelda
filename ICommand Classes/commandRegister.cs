using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{
    class commandRegister
    {
        public List<ICommand> getCommandList(LegendOfZelda game)
        {
            List<ICommand> commandList = new List<ICommand>
            {
                new QuitCommand(game),
                new resetGame(game),
                new moveLinkDown(game),
                new moveLinkLeft(game),
                new moveLinkRight(game),
                new moveLinkUp(game),
                new cycleItem(game),
                new cycleItemPrevious(game),
                new linkAttack(game),
                new linkChangeItem(game),
                new takeDamage(game),

            };

            return commandList;

        }
    }
}