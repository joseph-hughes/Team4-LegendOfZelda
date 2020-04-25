using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Xml;
using Team4_LegendOfZelda.IEnemy_Classses.Bosses;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies;
using Team4_LegendOfZelda.Item_Classes;

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

            foreach (XmlNode roomNode in root)
            {
                IRoom room = new DungeonRoom();
                room.Player = player;

                XmlNode enemiesNode = roomNode.FirstChild;
                if (enemiesNode.Attributes["total"].Value != "0")
                {
                    foreach (XmlNode enemyNode in enemiesNode)
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
                                room.FlyingEnemies.Add(new KeeseBlue(room, position));
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
                                room.ReceivedItems.Add(new BlueCandle(position));
                                break;
                            case "BlueRing":
                                room.ReceivedItems.Add(new BlueRing(position));
                                break;
                            case "Bomb":
                                room.ReceivedItems.Add(new Bomb(position));
                                break;
                            case "BookOfMagic":
                                room.ReceivedItems.Add(new BookOfMagic(position));
                                break;
                            case "Bow":
                                room.ReceivedItems.Add(new Bow(position));
                                break;
                            case "Clock":
                                room.ObtainedItems.Add(new Clock(position));
                                break;
                            case "Compass":
                                room.ReceivedItems.Add(new Compass(position));
                                break;
                            case "EmptyItem":
                                room.ReceivedItems.Add(new EmptyItem(position));
                                break;
                            case "Fairy":
                                room.ObtainedItems.Add(new Fairy(position));
                                break;
                            case "FiveRupies":
                                room.ObtainedItems.Add(new FiveRupies(position));
                                break;
                            case "Food":
                                room.ObtainedItems.Add(new Food(position));
                                break;
                            case "Heart":
                                room.ObtainedItems.Add(new Heart(position));
                                break;
                            case "HeartContainer":
                                room.ObtainedItems.Add(new HeartContainer(position));
                                break;
                            case "Key":
                                room.ObtainedItems.Add(new Key(position));
                                break;
                            case "Letter":
                                room.ReceivedItems.Add(new Letter(position));
                                break;
                            case "LifePotion":
                                room.ReceivedItems.Add(new LifePotion(position));
                                break;
                            case "MagicalKey":
                                room.ObtainedItems.Add(new MagicalKey(position));
                                break;
                            case "MagicalRod":
                                room.ReceivedItems.Add(new MagicalRod(position));
                                break;
                            case "MagicalShield":
                                room.ReceivedItems.Add(new MagicalShield(position));
                                break;
                            case "MapItem":
                                room.ReceivedItems.Add(new MapItem(position));
                                break;
                            case "PowerBracelet":
                                room.ReceivedItems.Add(new PowerBracelet(position));
                                break;
                            case "Raft":
                                room.ReceivedItems.Add(new Raft(position));
                                break;
                            case "Recorder":
                                room.ReceivedItems.Add(new Recorder(position));
                                break;
                            case "RedCandle":
                                room.ReceivedItems.Add(new RedCandle(position));
                                break;
                            case "RedRing":
                                room.ReceivedItems.Add(new RedRing(position));
                                break;
                            case "Rupy":
                                room.ObtainedItems.Add(new Rupy(position));
                                break;
                            case "SecondPotion":
                                room.ReceivedItems.Add(new SecondPotion(position));
                                break;
                            case "SilverArrow":
                                room.ReceivedItems.Add(new SilverArrow(position));
                                break;
                            case "Stepladder":
                                room.ReceivedItems.Add(new Stepladder(position));
                                break;
                            case "Sword":
                                room.ReceivedItems.Add(new Sword(position));
                                break;
                            case "Triforce":
                                room.ReceivedItems.Add(new Triforce(position));
                                break;
                            case "WhiteSword":
                                room.ReceivedItems.Add(new WhiteSword(position));
                                break;
                        }

                    }

                    rooms.Add(room);
                }
                XmlNode blocksNode = itemsNode.NextSibling;
                if (blocksNode.Attributes["total"].Value != "0")
                {
                    foreach (XmlNode blockNode in blocksNode)
                    {
                        string BlockName = blockNode["ObjectType"].InnerText;
                        float columnNum = float.Parse(blockNode["ColumnNum"].InnerText);
                        float rowNum = float.Parse(blockNode["RowNum"].InnerText);
                        Vector2 position = new Vector2(columnNum * 48 + 33, rowNum * 48 + 33 + 168);
                        switch (BlockName)
                        {
                            case "NoneMoveableBlock":
                                room.Block.Add(new Block(false, new Rectangle((int)position.X, (int)position.Y, 48, 48), MapAndHUDSpriteFactory.Instance.CreateSignleBlock()));
                                //room.Block.Add(new Block(false, new Rectangle((int)position.X, (int)position.Y, 48, 48), null));
                                break;
                            case "MoveableBlock":
                                room.Block.Add(new Block(true, new Rectangle((int)position.X, (int)position.Y, 48, 48), MapAndHUDSpriteFactory.Instance.CreateSignleBlock()));
                                break;
                            case "River":
                                room.Block.Add(new Block(false, new Rectangle((int)position.X, (int)position.Y, 48, 48), MapAndHUDSpriteFactory.Instance.CreateRiverBlock()));
                                break;
                        }
                    }
                }
                rooms.Add(room);
            }
            int index = 0;
            foreach (XmlNode roomNode in root)
            {
                XmlNode northNode = roomNode.FirstChild.NextSibling.NextSibling.NextSibling;
                if (northNode.InnerText != "")
                {
                    rooms[index].North = rooms[int.Parse(northNode.InnerText) - 1];
                    rooms[index].HasNorth = true;
                }
                XmlNode eastNode = northNode.NextSibling;
                if (eastNode.InnerText != "")
                {
                    rooms[index].East = rooms[int.Parse(eastNode.InnerText) - 1];
                    rooms[index].HasEast = true;
                }
                XmlNode southNode = eastNode.NextSibling;
                if (southNode.InnerText != "")
                {
                    rooms[index].South = rooms[int.Parse(southNode.InnerText) - 1];
                    rooms[index].HasSouth = true;
                }
                XmlNode westNode = southNode.NextSibling;
                if (westNode.InnerText != "")
                {
                    rooms[index].West = rooms[int.Parse(westNode.InnerText) - 1];
                    rooms[index].HasWest = true;
                }
                XmlNode otherNode = westNode.NextSibling;
                if (otherNode.InnerText != "")
                {
                    rooms[index].Other = rooms[int.Parse(otherNode.InnerText) - 1];
                    rooms[index].HasOther = true;
                }
                index += 1;
            }

            return rooms;
        }


    }
}
