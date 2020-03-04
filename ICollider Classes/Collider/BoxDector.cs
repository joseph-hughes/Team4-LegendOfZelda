using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class BoxDector : IDector
    {
        public ILevel Level { get; set; }
        public IPlayer Player { get; set; }
        public List<ITrigger> TriggerList { get; set; }
        public BoxDector(IPlayer player)
        {
            Player = player;

            TriggerList = new List<ITrigger>();
        }

        public void Detact()
        {

            Detection.PlayerItemDetection(Player, Level, TriggerList);
            Detection.PlayerEnemyDection(Player, Level, TriggerList);
            Detection.EnemyProjectilePlayerDection(Player, Level, TriggerList);
            Detection.PlayerProjectileEnemyDection(Level, TriggerList);
            Detection.ProjectileBlock(Level, TriggerList);
            Detection.PlayerBlockDection(Player, Level, TriggerList);

        }

        public void Update(ILevel level)
        {
            Level = level;
            foreach (ITrigger trigger in TriggerList)
            {
                trigger.Execute();
            }
            TriggerList = new List<ITrigger>();

        }
    }
}
