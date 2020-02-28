namespace Team4_LegendOfZelda
{
    public class LinkUseBoomerangCommand : ICommand
    {
        private IPlayer player;
        private ILevel level;

        public LinkUseBoomerangCommand(IPlayer player, ILevel level)
        {
            this.player = player;
            this.level = level;
        }
        public void Execute()
        {
            player.currentUseItemID = 1;
            player.UseItem();
            level.ProjectileList.Add(player.currentProjectile);

        }
    }
}
