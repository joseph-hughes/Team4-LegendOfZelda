using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda.IState_Classes
{
    public interface IPlayerState : IState
    {
        void South();
        void North();
        void East();
        void West();
        void BeDamaged();
        void UseItem();
        void UseSword();
    }
}
