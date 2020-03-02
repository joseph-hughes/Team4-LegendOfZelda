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
            player.UseItem();
            level.PlayerProjectileList.Add(new BoomerangProjectile(player.itemPosition, player.Direction * 90));

        }
    }
}
