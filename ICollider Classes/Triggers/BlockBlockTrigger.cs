using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class BlockBlockTrigger : ITrigger
    {
        private IBlock currentBlock;
        private IBlock targetBlock;

        public BlockBlockTrigger(IBlock CurrentBlock, IBlock TargetBlock)
        {
            currentBlock = CurrentBlock;
            targetBlock = TargetBlock;
        }
        public void Execute()
        {
            float dx = currentBlock.DestinationRectangle.X - targetBlock.DestinationRectangle.X;
            float dy = currentBlock.DestinationRectangle.Y - targetBlock.DestinationRectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
            {
                if (dy > 0)
                {
                    currentBlock.OptionalDirecton.Remove(Vector.Orientation.North);
                }
                else
                {
                    currentBlock.OptionalDirecton.Remove(Vector.Orientation.South);
                }

            }
            else
            {
                if (dx > 0)
                {
                    currentBlock.OptionalDirecton.Remove(Vector.Orientation.West);
                }
                else
                {
                    currentBlock.OptionalDirecton.Remove(Vector.Orientation.East);
                }
            }
        }
    }
}
