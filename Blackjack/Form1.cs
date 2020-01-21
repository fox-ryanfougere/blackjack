using Blackjack.Library;
using System;
using System.Media;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        Deck mydeck = new Deck();
        Player Dealer = new Player();
        Player Me = new Player();

        public int PlayerValue = 0;
        public int DealerValue = 0;
        public int Break = 0;
        public int Decision = 0;
        public int Position = 2;
        public double Bankroll = 50;
        public int Wager = 0;
        public int fliptime = Int32.Parse(ConfigurationManager.AppSettings["fliptime"]);


        //Methods



        public static class Prompt
        {
            public static int ShowDialog(string text, string caption, double Bankroll)
            {
                int wager = -1;
                
                int max = Convert.ToInt32(Bankroll);

                
                while (wager < 1 || wager > max) 
                { 
                Form prompt = new Form();
                prompt.Width = 200;
                prompt.Height = 150;
                prompt.Text = caption;
                prompt.MinimizeBox = false;
                prompt.MaximizeBox = false;
                prompt.FormBorderStyle = FormBorderStyle.FixedSingle;
                Label textLabel = new Label() { Left = 20, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 150 };
                Button confirmation = new Button() { Text = "Okay", Left = 20, Width = 50, Top = 82 };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.ShowDialog();

                string input = textBox.Text;

                    if (Int32.TryParse(input, out int number))
                    {
                        wager = Int32.Parse(input);

                        /* Yes input could be parsed and we can now use number in this code block 
                           scope */
                    }
                    else
                    {
                        /* No, input could not be parsed to an integer */
                    }

                   

                }

                return wager;
            }
        }

        public void Reset()
        {
            Me.hand.AllCards.RemoveRange(0, Me.hand.AllCards.Count);
            Dealer.hand.AllCards.RemoveRange(0, Dealer.hand.AllCards.Count);
            btnShuffleAndDeal.Enabled = true;
            btnShuffleAndDeal.Visible = true;
            btnHitMe.Visible = false;
            btnHitMe.Enabled = false;
            btnStay.Visible = false;
            btnStay.Enabled = false;
            mydeck.AllCards.RemoveRange(0, mydeck.AllCards.Count);
            label8.Text = Bankroll.ToString();


        }



        public async Task FirstDealAsync()
        {
            label8.Text = Bankroll.ToString();

            Me.hand.AddCard(mydeck.NextCard());
            Dealer.hand.AddCard(mydeck.NextCard());
            Me.hand.AddCard(mydeck.NextCard());
            Dealer.hand.AddCard(mydeck.NextCard());

            string suitp01 = Me.hand.AllCards[0].suit;
            string facep01 = Me.hand.AllCards[0].face;

            string suitd01 = Dealer.hand.AllCards[0].suit;
            string faced01 = Dealer.hand.AllCards[0].face;

            string suitp02 = Me.hand.AllCards[1].suit;
            string facep02 = Me.hand.AllCards[1].face;

            string suitd02 = Dealer.hand.AllCards[1].suit;
            string faced02 = Dealer.hand.AllCards[1].face;

            PlayerValue = Me.hand.AllCards[0].value + Me.hand.AllCards[1].value;
            DealerValue = Dealer.hand.AllCards[0].value + Dealer.hand.AllCards[1].value;

            picboxDealer1.BackgroundImage = null;
            picboxDealer2.BackgroundImage = null;
            picboxDealer3.BackgroundImage = null;
            picboxDealer4.BackgroundImage = null;
            picboxDealer5.BackgroundImage = null;
            picboxDealer6.BackgroundImage = null;
            picboxPlayer1.BackgroundImage = null;
            picboxPlayer2.BackgroundImage = null;
            picboxPlayer3.BackgroundImage = null;
            picboxPlayer4.BackgroundImage = null;
            picboxPlayer5.BackgroundImage = null;
            picboxPlayer6.BackgroundImage = null;

            await Task.Delay(fliptime);

            picboxPlayer1.BackgroundImage = Image.FromFile(BuildCardString(suitp01, facep01));

            await Task.Delay(fliptime);

            picboxDealer1.BackgroundImage = Image.FromFile(BuildCardString(suitd01, faced01));

            await Task.Delay(fliptime);

            picboxPlayer2.BackgroundImage = Image.FromFile(BuildCardString(suitp02, facep02));

            await Task.Delay(fliptime);

            picboxDealer2.BackgroundImage = Image.FromFile(BuildCardString("D", "F"));

            await Task.Delay(fliptime);


        }

        public void PlayerFinishes(int currentvalue)
        {

            PlayerValue = 0;
            for (int f = 0; f < Me.hand.AllCards.Count; f++)
            {
                PlayerValue = PlayerValue + Me.hand.AllCards[f].value;

            }

            PlayerValue = CheckForAceP(PlayerValue);

            if (CheckValue(PlayerValue) == 0)
            {
                btnHitMe.Visible = true;
                btnHitMe.Enabled = true;
                btnStay.Visible = true;
                btnStay.Enabled = true;

            }

            if (CheckValue(PlayerValue) > 0)
            {

                btnHitMe.Visible = false;
                btnHitMe.Enabled = false;
                btnStay.Visible = false;
                btnStay.Enabled = false;

            }


        }

        public async void EndGame()
        {
            await Task.Delay(1000);
            btnShuffleAndDeal.Enabled = false;
            btnShuffleAndDeal.Visible = false;
            btnHitMe.Visible = false;
            btnHitMe.Enabled = false;
            btnStay.Visible = false;
            btnStay.Enabled = false;
            label3.Text = "You lost it all. Game Over.";
            await Task.Delay(4000);
            Close();

        }

        public async void DealerFinishes()
        {


            await Task.Delay(fliptime);

            picboxDealer2.BackgroundImage = Image.FromFile(BuildCardString(Dealer.hand.AllCards[1].suit, Dealer.hand.AllCards[1].face));

            DealerValue = 0;

            for (int f = 0; f < Dealer.hand.AllCards.Count; f++)
            {
                DealerValue = DealerValue + Dealer.hand.AllCards[f].value;
            }

            DealerValue = CheckForAceD(DealerValue);

            while (DealerValue < 17)
            {
                Dealer.hand.AddCard(mydeck.NextCard());

                await Task.Delay(fliptime);

                switch (Dealer.hand.AllCards.Count)
                {

                    case 3:
                        picboxDealer3.BackgroundImage = Image.FromFile(BuildCardString(Dealer.hand.AllCards[2].suit, Dealer.hand.AllCards[2].face));
                        break;

                    case 4:
                        picboxDealer4.BackgroundImage = Image.FromFile(BuildCardString(Dealer.hand.AllCards[3].suit, Dealer.hand.AllCards[3].face));
                        break;

                    case 5:
                        picboxDealer5.BackgroundImage = Image.FromFile(BuildCardString(Dealer.hand.AllCards[4].suit, Dealer.hand.AllCards[4].face));
                        break;

                    case 6:
                        picboxDealer6.BackgroundImage = Image.FromFile(BuildCardString(Dealer.hand.AllCards[5].suit, Dealer.hand.AllCards[5].face));
                        break;

                }

                DealerValue = 0;

                for (int f = 0; f < Dealer.hand.AllCards.Count; f++)
                {
                    DealerValue = DealerValue + Dealer.hand.AllCards[f].value;
                }
                DealerValue = CheckForAceD(DealerValue);

            }

            int a = 0;

            if (DealerValue < PlayerValue)
            {
                a = 0;
            }

            if (DealerValue == PlayerValue)
            {
                a = 1;
            }

            if (DealerValue > PlayerValue && DealerValue < 22)
            {
                a = 2;
            }

            if (DealerValue > 21)
            {
                a = 3;
            }

            switch (a)
            {
                case 0:
                    label3.Text = "You win!";
                    Bankroll = Bankroll + Wager;
                    break;
                case 1:
                    string x = "You both have ";
                    string value = PlayerValue.ToString();
                    string y = " pot is shared.";
                    string finalvalue = x + value + y;
                    label3.Text = finalvalue;
                    break;
                case 2:
                    string q = "Dealer wins with ";
                    string w = DealerValue.ToString();
                    string e = q + w;
                    label3.Text = e;
                    Bankroll = Bankroll - Wager;
                    if (Bankroll == 0)
                    {
                        EndGame();
                        
                    }
                    //Reset();
                    break;
                case 3:
                    label3.Text = "Dealer busted, you win!";
                    Bankroll = Bankroll + Wager;
                    //Reset();
                    break;


            }

            Reset();






        }

        public int CheckValue(int currentvalue)
        {
            int a = currentvalue;

            currentvalue = CheckForAceP(a);

            if (currentvalue < 21)
            {
                a = 0;
            }

            if (currentvalue == 21)
            {
                a = 1;
            }

            if (currentvalue > 21)
            {
                a = 2;
            }

            switch (a)
            {
                case 0:
                    label3.Text = "Would you like another card?";
                    break;
                case 1:
                    label3.Text = "You have 21!";
                    DealerFinishes();
                    //Reset();
                    break;
                case 2:
                    label3.Text = "Sorry you busted";
                    Bankroll = Bankroll - Wager;
                    if (Bankroll == 0)
                    {
                        EndGame();
                        break;
                    }
                    Reset();
                    //btnShuffleAndDeal.Enabled = true;
                    //btnShuffleAndDeal.Visible = true;
                    break;


            }

            return (a);
        }

        public int CheckForAceP(int current)

        {
            for (int i = 0; i < Me.hand.AllCards.Count; i++)
            {
                if (Me.hand.AllCards[i].value == 11 && PlayerValue > 21)
                {
                    Me.hand.AllCards[i].value = 1;

                    PlayerValue = 0;

                    for (int f = 0; f < Me.hand.AllCards.Count; f++)
                    {
                        PlayerValue = PlayerValue + Me.hand.AllCards[f].value;

                    }

                    return PlayerValue;
                }
            }

            return current;
        }

        public int CheckForAceD(int current)

        {
            for (int i = 0; i < Dealer.hand.AllCards.Count; i++)
            {
                if (Dealer.hand.AllCards[i].value == 11 && DealerValue > 21)
                {
                    Dealer.hand.AllCards[i].value = 1;

                    DealerValue = 0;

                    for (int f = 0; f < Dealer.hand.AllCards.Count; f++)
                    {
                        DealerValue = DealerValue + Dealer.hand.AllCards[f].value;

                    }

                    return DealerValue;
                }
            }

            return current;
        }



        public string BuildCardString(string suit, string face)
        {
            string a = "../PNGCARDS/";
            string b = face;
            string c = suit;
            string d = ".png";

            string piclocation = a + b + c + d;

            SoundPlayer flipwav = new SoundPlayer("../PNGCARDS/FLIP.wav");
            flipwav.PlaySync();

            return piclocation;

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = Bankroll.ToString();
        }

        public int GetWager()
        {
            

           return 10;
        }


        private async void btnShuffleAndDeal_ClickAsync(object sender, EventArgs e)
        {
            btnShuffleAndDeal.Enabled = false;
            btnShuffleAndDeal.Visible = false;

            



            // label1.Text = "";
            label2.Text = "";
            //label4.Text = "";
            //label5.Text = "";


            Wager = Prompt.ShowDialog("Wager?", "Wager", Bankroll);

            //label6.Text = "How much would you like to wager?";

            //Wager = GetWager();

            
            label7.Text = Wager.ToString();



            label8.Text = Bankroll.ToString();

            SoundPlayer shufflewav = new SoundPlayer("../PNGCARDS/SHUFFLE.wav");
            shufflewav.PlaySync();

            await Task.Delay(1000);

            label6.Text = "";

            label3.Text = "";

            mydeck.FillDeck();

            mydeck.FillDeck();

            mydeck.FillDeck();

            mydeck.ShuffleDeck();

            

            await this.FirstDealAsync();

            PlayerValue = 0;
            for (int f = 0; f < Me.hand.AllCards.Count; f++)
            {
                PlayerValue = PlayerValue + Me.hand.AllCards[f].value;

            }

            if (PlayerValue == 21)
            {
                label3.Text = "BLACKJACK! You win!";
                Bankroll = Bankroll + (1.5 * Wager);
                Reset();
            }
            else
            {
                PlayerFinishes(PlayerValue);
            }
            
        }

        

        private void btnHitMe_Click(object sender, EventArgs e)
        {
            Me.hand.AddCard(mydeck.NextCard());

            btnHitMe.Visible = false;
            btnHitMe.Enabled = false;
            btnStay.Visible = false;
            btnStay.Enabled = false;

            switch (Me.hand.AllCards.Count)
            {

                case 3:
                    picboxPlayer3.BackgroundImage = Image.FromFile(BuildCardString(Me.hand.AllCards[2].suit, Me.hand.AllCards[2].face));
                    break;

                case 4:
                    picboxPlayer4.BackgroundImage = Image.FromFile(BuildCardString(Me.hand.AllCards[3].suit, Me.hand.AllCards[3].face));
                    break;

                case 5:
                    picboxPlayer5.BackgroundImage = Image.FromFile(BuildCardString(Me.hand.AllCards[4].suit, Me.hand.AllCards[4].face));
                    break;

                case 6:
                    picboxPlayer6.BackgroundImage = Image.FromFile(BuildCardString(Me.hand.AllCards[5].suit, Me.hand.AllCards[5].face));
                    break;

            }

            PlayerValue = 0;

            for (int i = 0; i < Me.hand.AllCards.Count; i++)
            {
                PlayerValue = PlayerValue + Me.hand.AllCards[i].value;
                

            }

            PlayerValue = CheckForAceP(PlayerValue);

            if (PlayerValue < 21)
            {
                PlayerFinishes(PlayerValue);
            }
            else
            {
                CheckValue(PlayerValue);
            }

        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            string value;

            btnHitMe.Visible = false;
            btnHitMe.Enabled = false;
            btnStay.Visible = false;
            btnStay.Enabled = false;

            PlayerValue = 0;

            for (int i = 0; i < Me.hand.AllCards.Count; i++)
            {
                PlayerValue = PlayerValue + Me.hand.AllCards[i].value;
                
            }

            string a = "You have ";
            value = PlayerValue.ToString();
            string b = value;
           

            string finalvalue = a + b;
            
            label3.Text = finalvalue;
            DealerFinishes();
            //Reset();
        }
    }

    
}
