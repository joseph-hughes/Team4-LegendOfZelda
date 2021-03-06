﻿using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.Vector;

namespace Team4_LegendOfZelda
{
    public class LinkUseArrowCommand : ICommand
    {
        private IPlayer player;
        private IRoom room;
        private IVector vector;

        public LinkUseArrowCommand(IPlayer player, IRoom room)
        {
            this.player = player;
            this.room = room;
            vector = player.Velocity;
        }
        public void Execute()
        {
            if (!player.IsDamaged)
            {
                player.UseItem();
                room.PlayerProjectiles.Add(new ArrowProjectile(player.ItemPosition, vector));
            }


        }
    }
}
