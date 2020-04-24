using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{
    public class LinkUseBoomerangCommand : ICommand
    {
        private IPlayer player;
        private IRoom room;

        public LinkUseBoomerangCommand(IPlayer player, IRoom room)
        {
            this.player = player;
            this.room = room;
        }
        public void Execute()
        {
            if (!player.IsDamaged)
            {

                player.UseItem();
                if (player.Velocity.Direction == Vector.Orientation.North)
                {
                    room.PlayerProjectiles.Add(new BoomerangProjectile(player.ItemPosition, 0));
                }
                else if (player.Velocity.Direction == Vector.Orientation.East)
                {
                    room.PlayerProjectiles.Add(new BoomerangProjectile(player.ItemPosition, 90));
                }
                else if (player.Velocity.Direction == Vector.Orientation.South)
                {
                    room.PlayerProjectiles.Add(new BoomerangProjectile(player.ItemPosition, 180));
                }
                else
                {
                    room.PlayerProjectiles.Add(new BoomerangProjectile(player.ItemPosition, 270));
                }
            }


        }
    }
}
