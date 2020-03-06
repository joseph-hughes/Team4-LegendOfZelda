using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Team4_LegendOfZelda
{
    public class MouseController : IController
    {
        private Dictionary<MouseClickArea, ICommand> controllerMappings;

        public MouseController()
        {
            controllerMappings = new Dictionary<MouseClickArea, ICommand>();
        }
        public void RegisterCommand(MouseState mouseState, Rectangle activationArea, ICommand command)
        {
            controllerMappings.Add(new MouseClickArea(mouseState, activationArea), command);
        }

        public void Update()
        {
            MouseState mouseState = Mouse.GetState();

            foreach (MouseClickArea mouseClickArea in controllerMappings.Keys)
            {
                if (mouseClickArea.Contains(mouseState))
                {
                    controllerMappings[mouseClickArea].Execute();
                }
            }
        }
    }
}