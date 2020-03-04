﻿using System;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class ZolDarkGreenController : IController
    {
        private IEnemy enemy;
        private static int MAX_DIRECTION_COUNTS = 60;
        private int directionCount;
        private Random rand;

        public ZolDarkGreenController(IEnemy enemy)
        {
            this.enemy = enemy;
            rand = new Random();
            directionCount = MAX_DIRECTION_COUNTS;
        }

        public void Update()
        {
            directionCount--;
            if (directionCount <= 0)
            {
                switch (rand.Next(0, 4))
                {
                    case 0:
                        enemy.North();
                        break;
                    case 1:
                        enemy.East();
                        break;
                    case 2:
                        enemy.South();
                        break;
                    case 3:
                        enemy.West();
                        break;
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                directionCount = MAX_DIRECTION_COUNTS;
            }
        }
    }
}