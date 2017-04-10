using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ObjectManager.Models;
using ObjectManager.LiteDB;

namespace Cave
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public partial class Cave : ICave
    {
        private List<Gamer> _players = new List<Gamer>();
        private Map _mapObject;

        public Location Init(string playerName)
        {
            var gamer = new Gamer()
            {
                CurrentPosition = 24
            };
            _players.Add(gamer);
            var mapRepo = new MapRepository();
            _mapObject = mapRepo.FindAll().FirstOrDefault();
            if (_mapObject == null)
            {
                InitMap();
                mapRepo.Add(_mapObject);
            }
            return MakeLocation(_mapObject, gamer.CurrentPosition);
        }
        private Location MakeLocation(Map map, int position)
        {
            return new Location()
            {
                Left = map.Positions.ElementAt(position - 1),
                Right = map.Positions.ElementAt(position + 1),
                Up = map.Positions.ElementAt(position - 7),
                Down = map.Positions.ElementAt(position + 7),
                Center = map.Positions.ElementAt(position),
                Message = "",
                SecretKey = "",
                PlayerName = ""
            };
        }
        private void InitMap()
        {
            List<string> map = new List<string>();
            for (int i = 0; i < 7; i++)
                map.Add("*");
            map.Add("*"); map.Add("_"); map.Add("_"); map.Add("_"); map.Add("_"); map.Add("_"); map.Add("*");
            map.Add("*"); map.Add("_"); map.Add("_"); map.Add("_"); map.Add("_"); map.Add("_"); map.Add("d");
            map.Add("*"); map.Add("z"); map.Add("_"); map.Add("_"); map.Add("_"); map.Add("_"); map.Add("*");
            map.Add("*"); map.Add("_"); map.Add("_"); map.Add("z"); map.Add("_"); map.Add("z"); map.Add("*");
            for (int i = 0; i < 7; i++)
                map.Add("*");            _mapObject = new Map()
            {
                Positions = map,
                SecretKey = @"LeGoLaSlOvE"
            };
        }

        public Location Move(int kierunek, string playerName)
        {
            var player = _players.Where(x => x.Name == playerName).FirstOrDefault();
            if (player == null)
                throw new ArgumentOutOfRangeException();
            var position = player.CurrentPosition;
            string message = null;
            try
            {
                switch (kierunek)
                {
                    case 0:
                        position = MoveUp(position);
                        break;
                    case 1:
                        position = MoveRight(position);
                        break;
                    case 2:
                        position = MoveDown(position);
                        break;
                    case 3:
                        position = MoveLeft(position);
                        break;
                }
            }
            catch (LocationBusyException ex)
            {
                message = ex.PlayerName;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            var location = MakeLocation(_mapObject, position);
            if (_mapObject.Positions.ElementAt(position).Equals("z"))
            {
                _mapObject.Positions[position] = "_";
            }
            else if (_mapObject.Positions.ElementAt(position).Equals("k"))
            {
                location.SecretKey = _mapObject.SecretKey;
                location.Center = "klucz";
            }
            location.PlayerName = playerName;
            location.Message = message;
            return location;

        }

        private int MoveLeft(int position) //3
        {
            if ((position - 1) % 7 != 0)
            {
                var otherPlayer = _players.Find(x => x.CurrentPosition == position - 1);
                if (otherPlayer != null)
                    throw new LocationBusyException()
                    {
                        PlayerName = otherPlayer.Name
                    };
                return position - 1;
            }
            throw new Exception("Nie umiesz w ducha");
        }

        private int MoveDown(int position) //2
        {
            if (position >= 35 && position <= 41)
                throw new Exception("Nie umiesz w ducha");
            var otherPlayer = _players.Find(x => x.CurrentPosition == position + 7);
            if (otherPlayer != null)
                throw new LocationBusyException()
                {
                    PlayerName = otherPlayer.Name
                };
            return position + 7;
        }

        private int MoveRight(int position) //1
        {
            if (position == 26)
                throw new Exception("Sprobuj uzyc Einsteinie!");
            if ((position - 5) % 7 != 0)
            {
                var otherPlayer = _players.Find(x => x.CurrentPosition == position + 1);
                if (otherPlayer != null)
                    throw new LocationBusyException()
                    {
                        PlayerName = otherPlayer.Name
                    };
                return position + 1;
            }
            throw new Exception("Nie umiesz w ducha");
        }

        private int MoveUp(int position) //0
        {
            if (position >= 7 && position <= 13)
                throw new Exception("Nie umiesz w ducha");
            var otherPlayer = _players.Find(x => x.CurrentPosition == position - 7);
            if (otherPlayer != null)
                throw new LocationBusyException()
                {
                    PlayerName = otherPlayer.Name
                };
            return position - 7;
        }

        public int UserKey(int kierunek, string secretKey)
        {
            throw new NotImplementedException();
        }
    }
}
