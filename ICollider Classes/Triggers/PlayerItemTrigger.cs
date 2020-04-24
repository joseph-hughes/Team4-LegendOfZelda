using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerItemTrigger : ITrigger
    {
        private IPlayer player;
        private IRoom currentRoom;
        private IItem item;

        public PlayerItemTrigger(IPlayer Player, IItem Item, IRoom room)
        {
            this.player = Player;
            this.currentRoom = room;
            this.item = Item;


        }
        public void Execute()
        {
            item.UseItem(player, currentRoom);
            currentRoom.Items.Remove(item);
        }
    }
}
