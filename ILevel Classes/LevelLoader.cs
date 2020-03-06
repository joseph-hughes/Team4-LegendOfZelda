using System.Collections.Generic;
using System.Xml;

namespace Team4_LegendOfZelda.ILevel_Classes
{

    class LevelLoader : IFileLoader
    {
        private XmlReader xmlReader;
        private List<IRoom> rooms;

        public LevelLoader(int levelNum)
        {
            switch (levelNum)
            {
                case 0:
                    // Overworld
                    break;
                case 1:
                    xmlReader = XmlReader.Create("XML/Level1.xml"); // Fix the file name so that it's correct
                    break;
                default:
                    xmlReader = XmlReader.Create("XML/BlankLevel.xml"); // Fix the file name so that it's correct
                    break;
            }

            rooms = new List<IRoom>();
        }

        public IRoom LoadRoom()
        {
            IRoom room = new DungeonRoom();
            return room;
        }


    }
}
