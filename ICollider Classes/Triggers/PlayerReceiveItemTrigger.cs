using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerReceiveItemTrigger : ITrigger
    {
        private IPlayer player;
        private IRoom currentRoom;
        private IItem item;

        public PlayerReceiveItemTrigger(IPlayer Player, IItem Item, IRoom room)
        {
            this.player = Player;
            this.currentRoom = room;
            this.item = Item;


        }
        public void Execute()
        {
            player.State = new LinkPickUpItemState((Link)player, 100, item, currentRoom);
        }
    }
}
