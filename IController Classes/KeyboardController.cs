using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Team4_LegendOfZelda
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private List<Keys> previousPressedKeys;

        public KeyboardController()
        {
            controllerMappings = new Dictionary<Keys, ICommand>();
            previousPressedKeys = new List<Keys>();
        }

        public void RegisterCommand(Keys key, ICommand command)
        {
            controllerMappings.Add(key, command);
        }

        public void Update()
        {
            List<Keys> pressedKeys = new List<Keys>(Keyboard.GetState().GetPressedKeys());

            foreach (Keys key in pressedKeys)
            {
                if (controllerMappings.ContainsKey(key) && !previousPressedKeys.Contains(key))
                {
                    controllerMappings[key].Execute();
                }
            }

            previousPressedKeys = pressedKeys;
        }
    }
}
