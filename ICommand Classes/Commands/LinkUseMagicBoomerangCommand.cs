﻿namespace Team4_LegendOfZelda
{
    public class LinkUseMagicBoomerangCommand : ICommand
    {
        private IPlayer player;
        private ILevel level;

        public LinkUseMagicBoomerangCommand(IPlayer player, ILevel level)
        {
            this.player = player;
            this.level = level;
        }
        public void Execute()
        {
            player.currentUseItemID = 3;
            player.UseItem();
            level.CurrentRoom.Projectiles.Add(player.currentProjectile);

        }
    }
}