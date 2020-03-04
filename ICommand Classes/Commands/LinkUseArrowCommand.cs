using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{
    public class LinkUseArrowCommand : ICommand
    {
        private IPlayer player;
        private IRoom room;

        public LinkUseArrowCommand(IPlayer player, IRoom room)
        {
            this.player = player;
            this.room = room;
        }
        public void Execute()
        {
            player.UseItem();
            room.PlayerProjectiles.Add(new ArrowProjectile(player.itemPosition, player.Direction * 90));

        }
    }
}
