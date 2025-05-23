using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFarmerTheGame.Classes
{
    internal class TheGame
    {
        Player player1;
        Player player2;
        Player player3;
        Player player4;
        public int dice1;
        public int dice2;
        public TheGame(Player Player1, Player Player2, Player Player3, Player Player4)
        {
            player1 = Player1;
            player2 = Player2;
            player3 = Player3;
            player4 = Player4;
        }
        public void rollTheDice(Player CurrentPlayer)
        {
            Random rnd = new Random();
            dice1 = rnd.Next(1, 13);
            dice2 = rnd.Next(1, 13);
            if(dice1 == 10 && dice2 > 8 && dice2 < 11)
            {
                CurrentPlayer.pigNumber += 1;
                return;
            }
            if (dice1 > 6 && dice1 < 10 && dice2 < 7)
            {
                CurrentPlayer.sheepNumber += 1;
                return;
            }
            if (dice1 < 7)
            {
                float fullPairsFloat = (CurrentPlayer.rabbitNumber + 1)/2;
                int fullPairs = (int)fullPairsFloat;
                CurrentPlayer.rabbitNumber += fullPairs;
            }
            if (dice1 > 6 && dice1 < 10)
            {
                float fullPairsFloat = (CurrentPlayer.sheepNumber + 1) / 2;
                int fullPairs = (int)fullPairsFloat;
                CurrentPlayer.sheepNumber += fullPairs;
            }
            if (dice1==10)
            {
                float fullPairsFloat = (CurrentPlayer.pigNumber + 1) / 2;
                int fullPairs = (int)fullPairsFloat;
                CurrentPlayer.pigNumber += fullPairs;
            }
            if (dice1 == 11)
            {
                float fullPairsFloat = (CurrentPlayer.cowNumber + 1) / 2;
                int fullPairs = (int)fullPairsFloat;
                CurrentPlayer.cowNumber += fullPairs;
            }
            if (dice2 < 9)
            {
                float fullPairsFloat = (CurrentPlayer.sheepNumber + 1) / 2;
                int fullPairs = (int)fullPairsFloat;
                CurrentPlayer.sheepNumber += fullPairs;
            }
            if (dice2 > 8 && dice2 < 11)
            {
                float fullPairsFloat = (CurrentPlayer.pigNumber + 1) / 2;
                int fullPairs = (int)fullPairsFloat;
                CurrentPlayer.pigNumber += fullPairs;
            }
            if (dice2 == 11)
            {
                float fullPairsFloat = (CurrentPlayer.horseNumber + 1) / 2;
                int fullPairs = (int)fullPairsFloat;
                CurrentPlayer.horseNumber += fullPairs;
            }
            //wolf and fox
            if(dice1 == 12)
            {
                if(CurrentPlayer.bigDogNumber == 0)
                {
                    CurrentPlayer.cowNumber = 0;
                    CurrentPlayer.pigNumber = 0;
                    CurrentPlayer.sheepNumber = 0;
                }
                else
                {
                    CurrentPlayer.bigDogNumber--;
                }
            }
            if (dice2 == 12)
            {
                if (CurrentPlayer.smallDogNumber == 0)
                {
                    CurrentPlayer.rabbitNumber = 1;
                }
                else
                {
                    CurrentPlayer.smallDogNumber--;
                }
            }

        }
    }
}
