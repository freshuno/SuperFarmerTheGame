using SuperFarmerTheGame.Classes;

namespace SuperFarmerTheGame
{
    public partial class Form1 : Form
    {
        TheGame SuperFarmer;
        Player Player1 = new Player();
        Player Player2 = new Player();
        Player Player3 = new Player();
        Player Player4 = new Player();
        public Form1()
        {
            InitializeComponent();
            SuperFarmer = new TheGame(Player1, Player2);
            label1.Text = "Sheep: " + Player1.sheepNumber.ToString();
            label2.Text = "Pig: " + Player1.pigNumber.ToString();
            label3.Text = "Horse: " + Player1.horseNumber.ToString();
            label4.Text = "Rabbit " + Player1.rabbitNumber.ToString();
            label7.Text = "Cow: " + Player1.cowNumber.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuperFarmer.rollTheDice(Player1);
            label5.Text = SuperFarmer.dice1.ToString();
            label6.Text = SuperFarmer.dice2.ToString();
            label1.Text = "Sheep: " + Player1.sheepNumber.ToString();
            label2.Text = "Pig: " + Player1.pigNumber.ToString();
            label3.Text = "Horse: " + Player1.horseNumber.ToString();
            label4.Text = "Rabbit " + Player1.rabbitNumber.ToString();
            label7.Text = "Cow: " + Player1.cowNumber.ToString();
        }
    }
}
