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
            player.UseItem();
            level.PlayerProjectileList.Add(new ArrowProjectile(player.itemPosition, player.Direction * 90));

        }
    }
}
