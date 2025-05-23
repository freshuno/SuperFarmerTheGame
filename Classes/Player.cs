using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFarmerTheGame.Classes
{
    internal class Player
    {
        public string name { get; set; }
        public int rabbitNumber { get; set; } = 1;
        public int cowNumber { get; set; }
        public int horseNumber { get; set; }
        public int pigNumber { get; set; }
        public int sheepNumber { get; set; }
        public int bigDogNumber { get; set; }
        public int smallDogNumber { get; set; }

        public Player(string Name)
        {
            name = Name;
        }
    }
}
