using System.Xml;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    
    class LevelLoader : IFileLoader
    {
        private XmlReader xmlReader;

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
                    xmlReader = XmlReader.Create("blanklevel.xml"); // Fix the file name so that it's correct
                    break;
            }
            
        }

        public IRoom LoadRoom()
        {
            IRoom room = new DungeonRoom();
            return room;
        }


    }
}
