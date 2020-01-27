using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Sprint0
{
    internal class MouseClickArea : object
    {
        private MouseState MouseState { get; set; }
        private Rectangle ActivationArea { get; set; }

        public MouseClickArea(MouseState mouseState, Rectangle activationArea)
        {
            MouseState = mouseState;

            ActivationArea = activationArea;
        }

        public bool Contains(MouseState mouseState)
        {
            bool checkArea = ActivationArea.Contains(new Point(mouseState.X, mouseState.Y));
            bool checkButtons = mouseState.LeftButton == MouseState.LeftButton && mouseState.RightButton == MouseState.RightButton;

            return checkArea && checkButtons;
        }
    }
}