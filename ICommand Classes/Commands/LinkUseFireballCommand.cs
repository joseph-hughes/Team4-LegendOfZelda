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
            if (!player.isDamaged)
            {

                player.UseItem();
                if (player.Velocity.Directon == Vector.Orientation.North)
                {
                    level.CurrentRoom.PlayerProjectiles.Add(new FireballProjectile(player.itemPosition, 0));
                }
                else if (player.Velocity.Directon == Vector.Orientation.East)
                {
                    level.CurrentRoom.PlayerProjectiles.Add(new FireballProjectile(player.itemPosition, 90));
                }
                else if (player.Velocity.Directon == Vector.Orientation.South)
                {
                    level.CurrentRoom.PlayerProjectiles.Add(new FireballProjectile(player.itemPosition, 180));
                }
                else
                {
                    level.CurrentRoom.PlayerProjectiles.Add(new FireballProjectile(player.itemPosition, 270));
                }
            }
        }
    }
}
