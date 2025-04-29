using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dealInitialCards();

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            game.dealCardPlayer();
            updateImages();

            int sum = game.calculateTotal(game.player_hand);

            if (!(sum > 21))
            {
                lblPlayerScore.Text = sum.ToString();
            }
            else
            {
                lblPlayerScore.Text = "YOU BUSTED! DEALER WINS";
                btnHit.Enabled = false;
                btnStand.Enabled = false;
            }



        }

        private void updateImages()
        {
            for (int i = 0; i < Math.Min(PlayerPanel.Controls.Count, game.player_hand.hand_cards.Count); i++)
            {
                if (PlayerPanel.Controls[i] is PictureBox pb)
                {
                    Card currentCard = game.player_hand.hand_cards[i];

                    pb.Image = Image.FromFile($"C:\\Users\\gabri\\source\\repos\\BlackJackGame\\BlackJackGame\\Cards Images\\{currentCard.Card_name}_of_{currentCard.Suit}.png");
                }
            }

            for (int i = 0; i < Math.Min(dealerPanel.Controls.Count, game.dealer_hand.hand_cards.Count); i++)
            {
                if (dealerPanel.Controls[i] is PictureBox pb)
                {
                    Card currentCard = game.dealer_hand.hand_cards[i];

                    string path = currentCard.hidden ? "C:\\Users\\gabri\\source\\repos\\BlackJackGame\\BlackJackGame\\Cards Images\\black_joker.png" :
                        $"C:\\Users\\gabri\\source\\repos\\BlackJackGame\\BlackJackGame\\Cards Images\\{currentCard.Card_name}_of_{currentCard.Suit}.png";

                    pb.Image = Image.FromFile(path);
                }
            }
        }

        private async void btnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            foreach (Card card in game.dealer_hand.hand_cards)
            {
                if (card.hidden)
                {
                    card.hidden = false;
                }
            }

            updateImages();

            int sum = game.calculateTotal(game.dealer_hand);

            while (sum < 17)
            {
                await Task.Delay(1000); // 1 second delay (non-blocking)
                game.dealDealer(false);
                sum = game.calculateTotal(game.dealer_hand);
                updateImages();
                lblDealerScore.Text = sum.ToString();
            }

            if (sum > 21)
            {
                lblDealerScore.Text = "DEALER BUSTED! YOU WIN";
            }
            else if (sum > game.calculateTotal(game.player_hand))
            {
                lblDealerScore.Text = "YOU LOSE!";
                lblPlayerScore.Text = "YOU LOSE!";
            }
            else
            {
                lblDealerScore.Text = "YOU WIN!";
                lblPlayerScore.Text = "YOU WIN!";
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            // Clear the player's and dealer's hands
            game.player_hand.hand_cards.Clear();
            game.dealer_hand.hand_cards.Clear();

            // Enable buttons
            btnHit.Enabled = true;
            btnStand.Enabled = true;

            // Clear score labels
            lblPlayerScore.Text = "";
            lblDealerScore.Text = "";

            // Clear card images from UI
            foreach (Control control in dealerPanel.Controls)
            {
                if (control is PictureBox pb)
                    pb.Image = null;
            }

            foreach (Control control in PlayerPanel.Controls)
            {
                if (control is PictureBox pb)
                    pb.Image = null;
            }

            
            game.deck = new Deck();

            // Deal initial cards
            dealInitialCards(); 
            updateImages(); 

            
        }

        private void dealInitialCards()
        {
            game = new Game();

            game.dealCardPlayer();
            game.dealCardPlayer();
            game.dealDealer(false);
            game.dealDealer(true);

            updateImages();

            int sum = game.calculateTotal(game.player_hand);

            if (sum == 21)
            {
                lblPlayerScore.Text = "THAT'S A BLACKJACK! YOU WIN";
                btnStand.Enabled = false;
                btnHit.Enabled = false;
            }
            else
            {
                lblPlayerScore.Text = sum.ToString();
            }
        }

    }
}
