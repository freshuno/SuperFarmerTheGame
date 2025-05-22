using SuperFarmerTheGame.Classes;

namespace SuperFarmerTheGame
{
    public partial class Form1 : Form
    {
        TheGame SuperFarmer;
        Player Player1 = new Player("Player1");
        Player Player2 = new Player("Player2");
        Player Player3 = new Player("Player3");
        Player Player4 = new Player("Player4");
        Player currentPlayer;
        public Form1()
        {
            InitializeComponent();
            SuperFarmer = new TheGame(Player1, Player2);
            currentPlayer = Player1;
            numberUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (currentPlayer == Player1)
            {
                SuperFarmer.rollTheDice(currentPlayer);
                currentPlayer = Player2;
            }
            else if (currentPlayer == Player2)
            {
                SuperFarmer.rollTheDice(currentPlayer);
                currentPlayer = Player1;

            }
            label13.Text = "Current player: " + currentPlayer;
            label5.Text = SuperFarmer.dice1.ToString();
            label6.Text = SuperFarmer.dice2.ToString();
            numberUpdate();
        }
        private void numberUpdate()
        {
            label1.Text = "Sheep: " + Player1.sheepNumber.ToString();
            label2.Text = "Pig: " + Player1.pigNumber.ToString();
            label3.Text = "Horse: " + Player1.horseNumber.ToString();
            label4.Text = "Rabbit " + Player1.rabbitNumber.ToString();
            label7.Text = "Cow: " + Player1.cowNumber.ToString();
            label12.Text = "Sheep: " + Player2.sheepNumber.ToString();
            label11.Text = "Pig: " + Player2.pigNumber.ToString();
            label10.Text = "Horse: " + Player2.horseNumber.ToString();
            label9.Text = "Rabbit " + Player2.rabbitNumber.ToString();
            label8.Text = "Cow: " + Player2.cowNumber.ToString();
            label13.Text = "Current player: " + currentPlayer.name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentPlayer.sheepNumber > 0)
            {
                currentPlayer.sheepNumber--;
                currentPlayer.rabbitNumber += 6;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle owiec";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentPlayer.rabbitNumber > 5)
            {
                currentPlayer.rabbitNumber -= 6;
                currentPlayer.sheepNumber++;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle królików";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentPlayer.pigNumber > 0)
            {
                currentPlayer.pigNumber--;
                currentPlayer.sheepNumber += 2;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle œwiñ";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentPlayer.sheepNumber > 1)
            {
                currentPlayer.sheepNumber -= 2;
                currentPlayer.pigNumber++;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle owiec";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentPlayer.cowNumber > 0)
            {
                currentPlayer.cowNumber--;
                currentPlayer.pigNumber += 3;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle krów";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentPlayer.pigNumber > 2)
            {
                currentPlayer.pigNumber -= 3;
                currentPlayer.cowNumber++;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle œwiñ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (currentPlayer.horseNumber > 0)
            {
                currentPlayer.horseNumber--;
                currentPlayer.cowNumber += 2;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle koni";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currentPlayer.cowNumber > 1)
            {
                currentPlayer.cowNumber -= 2;
                currentPlayer.horseNumber++;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle krów";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (currentPlayer.smallDogNumber > 0)
            {
                currentPlayer.smallDogNumber--;
                currentPlayer.sheepNumber++;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle ma³ych psów";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (currentPlayer.sheepNumber > 0)
            {
                currentPlayer.sheepNumber--;
                currentPlayer.smallDogNumber++;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle owiec";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (currentPlayer.bigDogNumber > 0)
            {
                currentPlayer.bigDogNumber--;
                currentPlayer.cowNumber++;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle du¿ych psów";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (currentPlayer.cowNumber > 0)
            {
                currentPlayer.cowNumber--;
                currentPlayer.bigDogNumber++;
                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;
                }
                else if (currentPlayer == Player2)
                {
                    currentPlayer = Player1;
                }
                numberUpdate();
            }
            else
            {
                label5.Text = "nie masz tyle krów";
            }
        }
    }
}
