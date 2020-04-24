using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerObtainItemTrigger : ITrigger
    {
        private IPlayer player;
        private IRoom currentRoom;
        private IItem item;

        public PlayerObtainItemTrigger(IPlayer Player, IItem Item, IRoom room)
        {
            this.player = Player;
            this.currentRoom = room;
            this.item = Item;


        }
        public void Execute()
        {
            item.UseItem(player, currentRoom);
            SFXFactory.Instance.PlayItemObtained();
            currentRoom.ObtainedItems.Remove(item);
        }
    }
}
