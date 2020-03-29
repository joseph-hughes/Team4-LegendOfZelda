using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class BoxDector : IDector
    {
        public IRoom room { get; set; }
        public IPlayer player { get; set; }
        public List<ITrigger> triggerList { get; set; }
        public BoxDector(IPlayer Player)
        {
            player = Player;
            triggerList = new List<ITrigger>();
        }

        public void Detact()
        {
            Detection.PlayerEnemyDection(player, room, triggerList);
            Detection.PlayerItemDetection(player, room, triggerList);
            Detection.EnemyProjectilePlayerDection(player, room, triggerList);
            Detection.PlayerProjectileEnemyDection(room, triggerList);
            Detection.ProjectileBlock(room, triggerList);
            Detection.PlayerNonemoveableBlockDection(player, room, triggerList);
            Detection.EnemyBlock(room, triggerList);
        }

        public void Update(ILevel level)
        {
            room = level.CurrentRoom;
            foreach (ITrigger trigger in triggerList)
            {
                trigger.Execute();
            }
            triggerList = new List<ITrigger>();

        }
    }
}
