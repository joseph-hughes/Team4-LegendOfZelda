using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Team4_LegendOfZelda
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private Dictionary<List<Keys>, ICommand> unpressedKeysMappings;
        private List<Keys> previousPressedKeys;

        public KeyboardController()
        {
            controllerMappings = new Dictionary<Keys, ICommand>();
            unpressedKeysMappings = new Dictionary<List<Keys>, ICommand>();
            previousPressedKeys = new List<Keys>();
        }

        public void RegisterCommand(Keys key, ICommand command)
        {
            controllerMappings.Add(key, command);
        }

        public void RegisterUnpressedKeysCommand(List<Keys> keyList, ICommand command)
        {
            unpressedKeysMappings.Add(keyList, command);
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

            foreach (List<Keys> keyList in unpressedKeysMappings.Keys)
            {
                bool keysUnpressed = true;

                foreach (Keys key in keyList)
                {
                    if (pressedKeys.Contains(key))
                    {
                        keysUnpressed = false;
                    }
                }

                if (keysUnpressed)
                {
                    unpressedKeysMappings[keyList].Execute();
                }
            }

            previousPressedKeys = pressedKeys;
        }
    }
}
