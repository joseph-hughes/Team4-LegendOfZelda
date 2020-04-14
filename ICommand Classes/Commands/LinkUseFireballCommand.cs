using Team4_LegendOfZelda.ILevel_Classes;

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
            if (!player.IsDamaged)
            {

                player.UseItem();
                if (player.Velocity.Direction == Vector.Orientation.North)
                {
                    level.CurrentRoom.PlayerProjectiles.Add(new FireballProjectile(player.ItemPosition, 0));
                }
                else if (player.Velocity.Direction == Vector.Orientation.East)
                {
                    level.CurrentRoom.PlayerProjectiles.Add(new FireballProjectile(player.ItemPosition, 90));
                }
                else if (player.Velocity.Direction == Vector.Orientation.South)
                {
                    level.CurrentRoom.PlayerProjectiles.Add(new FireballProjectile(player.ItemPosition, 180));
                }
                else
                {
                    level.CurrentRoom.PlayerProjectiles.Add(new FireballProjectile(player.ItemPosition, 270));
                }
            }
        }
    }
}
