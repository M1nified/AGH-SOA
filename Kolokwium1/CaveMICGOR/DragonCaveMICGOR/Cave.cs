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
    public class Cave : ICave
    {
        private List<Gamer> _players = new List<Gamer>();
        private Map _mapObject;

        public Location Init(string playerName)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
            var player = _players.Where(x => x.Name == playerName).FirstOrDefault();
            if (player == null)
                throw new ArgumentOutOfRangeException();

        }

        public int UserKey(int kierunek, string secretKey)
        {
            throw new NotImplementedException();
        }
    }
}
