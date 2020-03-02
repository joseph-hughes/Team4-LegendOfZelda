namespace Team4_LegendOfZelda
{
    public class LinkUseFireballCommand : ICommand
    {
        private IPlayer player;
        private ILevel level;

        public LinkUseFireballCommand(IPlayer player, ILevel level)
        {
            this.player = player;
            this.level = level;
        }
        public void Execute()
        {
            player.UseItem();
            level.PlayerProjectileList.Add(new FireballProjectile(player.itemPosition, player.Direction * 90));

        }
    }
}
