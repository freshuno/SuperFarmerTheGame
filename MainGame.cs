using SuperFarmerTheGame.Classes;

namespace SuperFarmerTheGame
{
    public partial class MainGame : Form
    {
        TheGame SuperFarmer;
        Player Player1 = new Player("Gracz1");
        Player Player2 = new Player("Gracz2");
        Player Player3 = new Player("Gracz3");
        Player Player4 = new Player("Gracz4");
        Player currentPlayer;
        int playerNumber;
        public MainGame(int PlayerNumber)
        {
            InitializeComponent();
            SuperFarmer = new TheGame(Player1, Player2, Player3, Player4);
            if(PlayerNumber == 2)
            {
                panel1.Visible = false;
                panel2.Visible = false;
            }
            if(PlayerNumber == 3)
            {
                panel2.Visible = false;
            }
            playerNumber = PlayerNumber;
            currentPlayer = Player1;
            numberUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuperFarmer.rollTheDice(currentPlayer);
            checkWin(currentPlayer);
            PlayerChange();
            label13.Text = "Current player: " + currentPlayer;
            label5.Text = SuperFarmer.dice1.ToString();
            label6.Text = SuperFarmer.dice2.ToString();
            numberUpdate();
        }
        private void numberUpdate()
        {
            label1.Text = "Owca: " + Player1.sheepNumber.ToString();
            label2.Text = "Œwinia: " + Player1.pigNumber.ToString();
            label3.Text = "Koñ: " + Player1.horseNumber.ToString();
            label4.Text = "Królik: " + Player1.rabbitNumber.ToString();
            label7.Text = "Krowa: " + Player1.cowNumber.ToString();
            label29.Text = "Ma³y pies: " + Player1.smallDogNumber.ToString();
            label30.Text = "Du¿y pies: " + Player1.bigDogNumber.ToString();

            label12.Text = "Owca: " + Player2.sheepNumber.ToString();
            label11.Text = "Œwinia: " + Player2.pigNumber.ToString();
            label10.Text = "Koñ: " + Player2.horseNumber.ToString();
            label9.Text = "Królik: " + Player2.rabbitNumber.ToString();
            label8.Text = "Krowa: " + Player2.cowNumber.ToString();
            label31.Text = "Ma³y pies: " + Player2.smallDogNumber.ToString();
            label32.Text = "Du¿y pies: " + Player2.bigDogNumber.ToString();

            label22.Text = "Owca: " + Player3.sheepNumber.ToString();
            label21.Text = "Œwinia: " + Player3.pigNumber.ToString();
            label20.Text = "Koñ: " + Player3.horseNumber.ToString();
            label19.Text = "Królik: " + Player3.rabbitNumber.ToString();
            label18.Text = "Krowa: " + Player3.cowNumber.ToString();
            label33.Text = "Ma³y pies: " + Player3.smallDogNumber.ToString();
            label34.Text = "Du¿y pies: " + Player3.bigDogNumber.ToString();

            label28.Text = "Owca: " + Player4.sheepNumber.ToString();
            label27.Text = "Œwinia: " + Player4.pigNumber.ToString();
            label26.Text = "Koñ: " + Player4.horseNumber.ToString();
            label25.Text = "Królik: " + Player4.rabbitNumber.ToString();
            label24.Text = "Krowa: " + Player4.cowNumber.ToString();
            label35.Text = "Ma³y pies: " + Player4.smallDogNumber.ToString();
            label36.Text = "Du¿y pies: " + Player4.bigDogNumber.ToString();

            label13.Text = "Tura gracza: " + currentPlayer.name;
        }
        private void checkWin(Player CurrentPlayer)
        {
            if(CurrentPlayer.horseNumber >= 1 && CurrentPlayer.cowNumber >=1 && CurrentPlayer.sheepNumber >=1 && CurrentPlayer.rabbitNumber >= 1)
            {
                MessageBox.Show("Wygral: " + currentPlayer.name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentPlayer.sheepNumber > 0)
            {
                currentPlayer.sheepNumber--;
                currentPlayer.rabbitNumber += 6;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle owiec";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentPlayer.rabbitNumber > 5)
            {
                currentPlayer.rabbitNumber -= 6;
                currentPlayer.sheepNumber++;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle królików";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentPlayer.pigNumber > 0)
            {
                currentPlayer.pigNumber--;
                currentPlayer.sheepNumber += 2;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle œwiñ";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentPlayer.sheepNumber > 1)
            {
                currentPlayer.sheepNumber -= 2;
                currentPlayer.pigNumber++;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle owiec";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentPlayer.cowNumber > 0)
            {
                currentPlayer.cowNumber--;
                currentPlayer.pigNumber += 3;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle krów";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentPlayer.pigNumber > 2)
            {
                currentPlayer.pigNumber -= 3;
                currentPlayer.cowNumber++;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle œwiñ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (currentPlayer.horseNumber > 0)
            {
                currentPlayer.horseNumber--;
                currentPlayer.cowNumber += 2;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle koni";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currentPlayer.cowNumber > 1)
            {
                currentPlayer.cowNumber -= 2;
                currentPlayer.horseNumber++;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle krów";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (currentPlayer.smallDogNumber > 0)
            {
                currentPlayer.smallDogNumber--;
                currentPlayer.sheepNumber++;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle ma³ych psów";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (currentPlayer.sheepNumber > 0)
            {
                currentPlayer.sheepNumber--;
                currentPlayer.smallDogNumber++;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle owiec";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (currentPlayer.bigDogNumber > 0)
            {
                currentPlayer.bigDogNumber--;
                currentPlayer.cowNumber++;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
            }
            else
            {
                label39.Text = "nie masz tyle du¿ych psów";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (currentPlayer.cowNumber > 0)
            {
                currentPlayer.cowNumber--;
                currentPlayer.bigDogNumber++;
                checkWin(currentPlayer);
                PlayerChange();
                numberUpdate();
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
