using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda
{
    public class Link
    {
        public IPlayerState state;
        public Link()
        {
            state = new NonMovingSouthLinkState(this);
        }
        public void South()
        {
            state.South();
        }
        public void North()
        {
            state.North();
        }
        public void East()
        {
            state.East();
        }
        public void West()
        {
            state.West();
        }
        public void BeDamaged()
        {
            state.BeDamaged();
        }
        public void Move()
        {
            state.Move();
        }
        public void UseItem()
        {
            state.UseItem();
        }
        public void UseSword()
        {
            state.UseSword();
        }
    }
}
