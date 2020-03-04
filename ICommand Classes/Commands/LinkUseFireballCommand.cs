using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{
    public class LinkUseFireballCommand : ICommand
    {
        private IPlayer player;
        private IRoom room;

        public LinkUseFireballCommand(IPlayer player, IRoom room)
        {
            this.player = player;
            this.room = room;
        }
        public void Execute()
        {
            if (!player.isDamaged)
            {
                player.UseItem();
                room.PlayerProjectiles.Add(new FireballProjectile(player.itemPosition, player.Direction * 90));
            }
        }
    }
}
