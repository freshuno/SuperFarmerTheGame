using SuperFarmerTheGame.Classes;

namespace SuperFarmerTheGame
{
    public partial class MainGame : Form
    {
        TheDice SuperFarmer;
        Player Player1 = new Player("Gracz1");
        Player Player2 = new Player("Gracz2");
        Player Player3 = new Player("Gracz3");
        Player Player4 = new Player("Gracz4");
        Player currentPlayer;
        int playerNumber;
        public MainGame(int PlayerNumber)
        {
            InitializeComponent();
            SuperFarmer = new TheDice(Player1, Player2, Player3, Player4);
            if(PlayerNumber == 2)
            {
                Player3Panel.Visible = false;
                Player4Panel.Visible = false;
            }
            if(PlayerNumber == 3)
            {
                Player4Panel.Visible = false;
            }
            playerNumber = PlayerNumber;
            currentPlayer = Player1;
            NumberUpdate();
        }

        private void ClickRoll(object sender, EventArgs e)
        {
            SuperFarmer.RollTheDice(currentPlayer);
            CheckWin(currentPlayer);
            PlayerChange();
            CurrentPlayerLabel.Text = "Current player: " + currentPlayer;
            Dice1Label.Text = SuperFarmer.dice1.ToString();
            Dice2Label.Text = SuperFarmer.dice2.ToString();
            NumberUpdate();
        }
        private void NumberUpdate()
        {
            Player1SheepLabel.Text = "Owca: " + Player1.sheepNumber.ToString();
            Player1PigLabel.Text = "Œwinia: " + Player1.pigNumber.ToString();
            Player1HorseLabel.Text = "Koñ: " + Player1.horseNumber.ToString();
            Player1RabbitLabel.Text = "Królik: " + Player1.rabbitNumber.ToString();
            Player1CowLabel.Text = "Krowa: " + Player1.cowNumber.ToString();
            Player1SmallDogLabel.Text = "Ma³y pies: " + Player1.smallDogNumber.ToString();
            Player1BigDogLabel.Text = "Du¿y pies: " + Player1.bigDogNumber.ToString();

            Player2SheepLabel.Text = "Owca: " + Player2.sheepNumber.ToString();
            Player2PigLabel.Text = "Œwinia: " + Player2.pigNumber.ToString();
            Player2HorseLabel.Text = "Koñ: " + Player2.horseNumber.ToString();
            Player2RabbitLabel.Text = "Królik: " + Player2.rabbitNumber.ToString();
            Player2CowLabel.Text = "Krowa: " + Player2.cowNumber.ToString();
            Player2SmallDogLabel.Text = "Ma³y pies: " + Player2.smallDogNumber.ToString();
            Player2BigDogLabel.Text = "Du¿y pies: " + Player2.bigDogNumber.ToString();

            Player3SheepLabel.Text = "Owca: " + Player3.sheepNumber.ToString();
            Player3PigLabel.Text = "Œwinia: " + Player3.pigNumber.ToString();
            Player3HorseLabel.Text = "Koñ: " + Player3.horseNumber.ToString();
            Player3RabbitLabel.Text = "Królik: " + Player3.rabbitNumber.ToString();
            Player3CowLabel.Text = "Krowa: " + Player3.cowNumber.ToString();
            Player3SmallDogLabel.Text = "Ma³y pies: " + Player3.smallDogNumber.ToString();
            Player3BigDogLabel.Text = "Du¿y pies: " + Player3.bigDogNumber.ToString();

            Player4SheepLabel.Text = "Owca: " + Player4.sheepNumber.ToString();
            Player4PigLabel.Text = "Œwinia: " + Player4.pigNumber.ToString();
            Player4HorseLabel.Text = "Koñ: " + Player4.horseNumber.ToString();
            Player4RabbitLabel.Text = "Królik: " + Player4.rabbitNumber.ToString();
            Player4CowLabel.Text = "Krowa: " + Player4.cowNumber.ToString();
            Player4SmallDogLabel.Text = "Ma³y pies: " + Player4.smallDogNumber.ToString();
            Player4BigDogLabel.Text = "Du¿y pies: " + Player4.bigDogNumber.ToString();

            CurrentPlayerLabel.Text = "Tura gracza: " + currentPlayer.name;
        }
        private void CheckWin(Player CurrentPlayer)
        {
            if(CurrentPlayer.horseNumber >= 1 && CurrentPlayer.cowNumber >=1 && CurrentPlayer.sheepNumber >=1 && CurrentPlayer.rabbitNumber >= 1)
            {
                MessageBox.Show("Wygral: " + currentPlayer.name);
            }
        }

        private void Trade1aClick(object sender, EventArgs e)
        {
            if (currentPlayer.sheepNumber > 0)
            {
                currentPlayer.sheepNumber--;
                currentPlayer.rabbitNumber += 6;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle owiec";
            }
        }

        private void Trade1bClick(object sender, EventArgs e)
        {
            if (currentPlayer.rabbitNumber > 5)
            {
                currentPlayer.rabbitNumber -= 6;
                currentPlayer.sheepNumber++;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle królików";
            }

        }

        private void Trade2aClick(object sender, EventArgs e)
        {
            if (currentPlayer.pigNumber > 0)
            {
                currentPlayer.pigNumber--;
                currentPlayer.sheepNumber += 2;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle œwiñ";
            }

        }

        private void Trade2bClick(object sender, EventArgs e)
        {
            if (currentPlayer.sheepNumber > 1)
            {
                currentPlayer.sheepNumber -= 2;
                currentPlayer.pigNumber++;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle owiec";
            }

        }

        private void Trade3aClick(object sender, EventArgs e)
        {
            if (currentPlayer.cowNumber > 0)
            {
                currentPlayer.cowNumber--;
                currentPlayer.pigNumber += 3;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle krów";
            }

        }

        private void Trade3bClick(object sender, EventArgs e)
        {
            if (currentPlayer.pigNumber > 2)
            {
                currentPlayer.pigNumber -= 3;
                currentPlayer.cowNumber++;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle œwiñ";
            }
        }

        private void Trade4aClick(object sender, EventArgs e)
        {
            if (currentPlayer.horseNumber > 0)
            {
                currentPlayer.horseNumber--;
                currentPlayer.cowNumber += 2;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle koni";
            }
        }

        private void Trade4bClick(object sender, EventArgs e)
        {
            if (currentPlayer.cowNumber > 1)
            {
                currentPlayer.cowNumber -= 2;
                currentPlayer.horseNumber++;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle krów";
            }
        }

        private void Trade5aClick(object sender, EventArgs e)
        {
            if (currentPlayer.smallDogNumber > 0)
            {
                currentPlayer.smallDogNumber--;
                currentPlayer.sheepNumber++;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle ma³ych psów";
            }
        }

        private void Trade5bClick(object sender, EventArgs e)
        {
            if (currentPlayer.sheepNumber > 0)
            {
                currentPlayer.sheepNumber--;
                currentPlayer.smallDogNumber++;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle owiec";
            }
        }

        private void Trade6aClick(object sender, EventArgs e)
        {
            if (currentPlayer.bigDogNumber > 0)
            {
                currentPlayer.bigDogNumber--;
                currentPlayer.cowNumber++;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle du¿ych psów";
            }
        }

        private void Trade6bClick(object sender, EventArgs e)
        {
            if (currentPlayer.cowNumber > 0)
            {
                currentPlayer.cowNumber--;
                currentPlayer.bigDogNumber++;
                CheckWin(currentPlayer);
                PlayerChange();
                NumberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle krów";
            }
        }
        private void PlayerChange()
        {
            label39.Text = "";
            if (currentPlayer == Player1)
            {
                currentPlayer = Player2;
            }
            else if (currentPlayer == Player2 && playerNumber == 2)
            {
                currentPlayer = Player1;
            }
            else if (currentPlayer == Player2 && playerNumber > 2)
            {
                currentPlayer = Player3;
            }
            else if (currentPlayer == Player3 && playerNumber == 3)
            {
                currentPlayer = Player1;
            }
            else if (currentPlayer == Player3 && playerNumber == 4)
            {
                currentPlayer = Player4;
            }
            else if (currentPlayer == Player4)
            {
                currentPlayer = Player1;
            }

        }
    }
}
