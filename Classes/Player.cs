using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFarmerTheGame.Classes
{
    internal class Player
    {
        public int rabbitNumber = 1;
        public int cowNumber;
        public int horseNumber;
        public int pigNumber;
        public int sheepNumber;
        public int bigDogNumber;
        public int smallDogNumber;
        public string name;
        public Player(string Name)
        {
            name = Name;
        }
    }
}
