using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Team4_LegendOfZelda
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private Dictionary<Keys, ICommand> unpressedKeysMappings;
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

        public void RegisterUnpressedKeysCommand(Keys key, ICommand command)
        {
            unpressedKeysMappings.Add(key, command);
        }

        public void Update()
        {
            List<Keys> pressedKeys = new List<Keys>(Keyboard.GetState().GetPressedKeys());
            bool keysPressed = false;

            foreach (Keys key in pressedKeys)
            {
                if (controllerMappings.ContainsKey(key) && !previousPressedKeys.Contains(key))
                {
                    controllerMappings[key].Execute();
                }
            }

            foreach (Keys key in unpressedKeysMappings.Keys)
            {
                if (!pressedKeys.Contains(key))
                {
                    unpressedKeysMappings[key].Execute();
                }
            }

            previousPressedKeys = pressedKeys;
        }
    }
}
