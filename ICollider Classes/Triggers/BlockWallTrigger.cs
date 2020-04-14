using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class BlockWallTrigger : ITrigger
    {
        private IBlock currentBlock;
        private IBlock targetBlock;

        public BlockWallTrigger(IBlock CurrentBlock, IBlock TargetWall)
        {
            currentBlock = CurrentBlock;
            targetBlock = TargetWall;
        }
        public void Execute()
        {
            currentBlock.OptionalDirecton = new List<Vector.Orientation> { Vector.Orientation.North, Vector.Orientation.East, Vector.Orientation.South, Vector.Orientation.West };
            float dx = currentBlock.DestinationRectangle.X - targetBlock.DestinationRectangle.X;
            float dy = currentBlock.DestinationRectangle.Y - targetBlock.DestinationRectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
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
            else
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
        }
    }
}
