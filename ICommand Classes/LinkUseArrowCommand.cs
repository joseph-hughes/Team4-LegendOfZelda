namespace Team4_LegendOfZelda
{
    public class LinkUseArrowCommand : ICommand
    {
        private IPlayer player;
        private ILevel level;

        public LinkUseArrowCommand(IPlayer player, ILevel level)
        {
            this.player = player;
            this.level = level; 
        }
        public void Execute()
        {
            player.currentUseItemID = 0;
            player.UseItem();
            level.ProjectileList.Add(player.currentProjectile);

        }
    }
}
