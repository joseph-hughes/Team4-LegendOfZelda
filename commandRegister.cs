using System.Collections.Generic;

namespace Team4_LegendOfZelda
{
    class commandRegister
    {
        public List<ICommand> getCommandList(LegendOfZelda game)
        {
            List<ICommand> commandList = new List<ICommand>
            {
                new QuitCommand(game), //0
                new resetGame(game), //1
                new moveLinkDown(game), //2
                new moveLinkLeft(game), //3
                new moveLinkRight(game), //4
                new moveLinkUp(game), //5
                new nextItem(game), //6
                new previousItem(game), //7
                new nextEnemy(game), //8
                new previousEnemy(game), //9
                new linkAttack(game), //10
                new linkChangeItem(game), //11
                new takeDamage(game), //12

            };

            return commandList;

        }
    }
}