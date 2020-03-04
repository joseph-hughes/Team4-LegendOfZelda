using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    
    class LevelLoader : IFileLoader

    {
        private XmlReader xmlReader;

        public LevelLoader(string fileName)
        {
            xmlReader = XmlReader.Create(fileName);
        }

        public void LoadRoom()
        {
            IRoom room = new DungeonRoom();
        }


    }
}
