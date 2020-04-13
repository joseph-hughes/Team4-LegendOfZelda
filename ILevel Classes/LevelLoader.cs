using System.Xml;
using System.Collections.Generic;
using Team4_LegendOfZelda.Item_Classes;
using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.IEnemy_Classses.Bosses;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class LevelLoader : IFileLoader
    {
        private XmlDocument LevelXml;
        

        public LevelLoader(int levelNum)
        {
            LevelXml = new XmlDocument();
            switch (levelNum)
            {
                case 0:
                    // Overworld
                    break;
                case 1:
                    LevelXml.Load("../../../../XML/Level1.xml"); // Fix the file name so that it's correct
                    break;
                default:
                    LevelXml.Load("../../../../XML/BlankLevel.xml"); // Fix the file name so that it's correct
                    break;
            }

            
        }

        public List<IRoom> LoadRooms(IPlayer player)
        {
            List<IRoom> rooms = new List<IRoom>();
            XmlNode root = LevelXml.FirstChild.NextSibling;

            foreach(XmlNode roomNode in root)
            {
                IRoom room = new DungeonRoom();
                room.Player = player;

                XmlNode enemiesNode = roomNode.FirstChild;
                if (enemiesNode.Attributes["total"].Value != "0")
                {
                    foreach(XmlNode enemyNode in enemiesNode)
                    {
                        string enemyName = enemyNode["ObjectType"].InnerText;
                        float columnNum = float.Parse(enemyNode["ColumnNum"].InnerText);
                        float rowNum = float.Parse(enemyNode["RowNum"].InnerText);
                        Vector2 position = new Vector2(columnNum * 48 + 33, rowNum * 48 + 33 + 168);
                        switch (enemyName)
                        {
                            case "Aquamentus":
                                room.Enemies.Add(new Aquamentus(room, position));
                                break;
                            case "Dodongo":
                                room.Enemies.Add(new Dodongo(room, position));
                                break;
                            case "BladeTrap":
                                room.Enemies.Add(new BladeTrap(room, position));
                                break;
                            case "GelDarkBlue":
                                room.Enemies.Add(new GelDarkBlue(room, position));
                                break;
                            case "GoriyaRed":
                                room.Enemies.Add(new GoriyaRed(room, position));
                                break;
                            case "KeeseBlue":
                                room.Enemies.Add(new KeeseBlue(room, position));
                                break;
                            case "Rope":
                                room.Enemies.Add(new Rope(room, position));
                                break;
                            case "Stalfos":
                                room.Enemies.Add(new Stalfos(room, position));
                                break;
                            case "WallMaster":
                                room.Enemies.Add(new WallMaster(room, position));
                                break;
                            case "WallMasterUpsideDown":
                                room.Enemies.Add(new WallMasterUpsideDown(room, position));
                                break;
                            case "ZolDarkGreen":
                                room.Enemies.Add(new ZolDarkGreen(room, position));
                                break;


                        }
                    }
                }
                XmlNode itemsNode = enemiesNode.NextSibling;
                if (itemsNode.Attributes["total"].Value != "0")
                {
                    foreach (XmlNode itemNode in itemsNode)
                    {
                        string itemName = itemNode["ObjectType"].InnerText;
                        float columnNum = float.Parse(itemNode["ColumnNum"].InnerText);
                        float rowNum = float.Parse(itemNode["RowNum"].InnerText);
                        Vector2 position = new Vector2(columnNum * 48 + 33, rowNum * 48 + 33 + 168);
                        switch (itemName)
                        {
                            case "BlueCandle":
                                room.Items.Add(new BlueCandle(position));
                                break;
                            case "BlueRing":
                                room.Items.Add(new BlueRing(position));
                                break;
                            case "Bomb":
                                room.Items.Add(new Bomb(position));
                                break;
                            case "BookOfMagic":
                                room.Items.Add(new BookOfMagic(position));
                                break;
                            case "Bow":
                                room.Items.Add(new Bow(position));
                                break;
                            case "Clock":
                                room.Items.Add(new Clock(position));
                                break;
                            case "Compass":
                                room.Items.Add(new Compass(position));
                                break;
                            case "EmptyItem":
                                room.Items.Add(new EmptyItem(position));
                                break;
                            case "Fairy":
                                room.Items.Add(new Fairy(position));
                                break;
                            case "FiveRupies":
                                room.Items.Add(new FiveRupies(position));
                                break;
                            case "Food":
                                room.Items.Add(new Food(position));
                                break;
                            case "Heart":
                                room.Items.Add(new Heart(position));
                                break;
                            case "HeartContainer":
                                room.Items.Add(new HeartContainer(position));
                                break;
                            case "Key":
                                room.Items.Add(new Key(position));
                                break;
                            case "Letter":
                                room.Items.Add(new Letter(position));
                                break;
                            case "LifePotion":
                                room.Items.Add(new LifePotion(position));
                                break;
                            case "MagicalKey":
                                room.Items.Add(new MagicalKey(position));
                                break;
                            case "MagicalRod":
                                room.Items.Add(new MagicalRod(position));
                                break;
                            case "MagicalShield":
                                room.Items.Add(new MagicalShield(position));
                                break;
                            case "MapItem":
                                room.Items.Add(new MapItem(position));
                                break;
                            case "PowerBracelet":
                                room.Items.Add(new PowerBracelet(position));
                                break;
                            case "Raft":
                                room.Items.Add(new Raft(position));
                                break;
                            case "Recorder":
                                room.Items.Add(new Recorder(position));
                                break;
                            case "RedCandle":
                                room.Items.Add(new RedCandle(position));
                                break;
                            case "RedRing":
                                room.Items.Add(new RedRing(position));
                                break;
                            case "Rupy":
                                room.Items.Add(new Rupy(position));
                                break;
                            case "SecondPotion":
                                room.Items.Add(new SecondPotion(position));
                                break;
                            case "SilverArrow":
                                room.Items.Add(new SilverArrow(position));
                                break;
                            case "Stepladder":
                                room.Items.Add(new Stepladder(position));
                                break;
                            case "Sword":
                                room.Items.Add(new Sword(position));
                                break;
                            case "Triforce":
                                room.Items.Add(new Triforce(position));
                                break;
                            case "WhiteSword":
                                room.Items.Add(new WhiteSword(position));
                                break;
                        }

                     }
                }
                rooms.Add(room);
            }

            int index = 0;
            foreach (XmlNode roomNode in root)
            {
                XmlNode northNode = roomNode.FirstChild.NextSibling.NextSibling;
                if (northNode.InnerText != "")
                {
                    rooms[index].North = rooms[int.Parse(northNode.InnerText) - 1];
                }
                XmlNode eastNode = northNode.NextSibling;
                if (eastNode.InnerText != "")
                {
                    rooms[index].East = rooms[int.Parse(eastNode.InnerText) - 1];
                }
                XmlNode southNode = eastNode.NextSibling;
                if (southNode.InnerText != "")
                {
                    rooms[index].South = rooms[int.Parse(southNode.InnerText) - 1];
                }
                XmlNode westNode = southNode.NextSibling;
                if (westNode.InnerText!="")
                {
                    rooms[index].West = rooms[int.Parse(westNode.InnerText) - 1];
                }
                XmlNode otherNode = westNode.NextSibling;
                if (otherNode.InnerText != "")
                {
                    rooms[index].West = rooms[int.Parse(otherNode.InnerText) - 1];
                }
                index += 1;
            }

                return rooms;
        }


    }
}
