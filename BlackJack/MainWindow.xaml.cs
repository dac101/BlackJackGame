using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using BlackJack.Logic;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Deck deck = new Deck();
        PlayerLogic _dealer = new PlayerLogic();
        PlayerLogic player = new PlayerLogic();
        Random rnd = new Random();

        public MainWindow()
        {
            deck.DeckValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 } ;
            InitializeComponent(); HitBtn.Visibility = System.Windows.Visibility.Hidden;
            StandBtn.Visibility = System.Windows.Visibility.Hidden;
        }

        private void UICharacter_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Player_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Dealbtn_Click(object sender, RoutedEventArgs e)
        {


            Player.lblOutcome.Text = "";
            CardDealer.lblOutcome.Text = "";
            PlayGame();
            HitBtn.Visibility = System.Windows.Visibility.Visible;
            StandBtn.Visibility = System.Windows.Visibility.Visible;
        }

        private void PlayGame()
        {
            Player.lblCardCount.Visibility = System.Windows.Visibility.Visible;
            int value = rnd.Next(0, 13);

            PlayerTurn(value);
            value = rnd.Next(0, 13);
            CardDealerTurn(value);

            Dealbtn.Visibility = System.Windows.Visibility.Hidden;
        }

        private void CardDealerTurn(int value)
        {
            value = deck.DeckValues[value];
            ImageSource imageSourc = new BitmapImage(new Uri(deck.ChangeCardUi(value)));
            CardDealer.CardImage.Source = imageSourc;

            if (value == 1)
            {
                _dealer.Total = 11 + _dealer.Total;
            }
            else if (value >= 10)
            {
                _dealer.Total = 10 + _dealer.Total;
            }
            else
            {
                _dealer.Total = deck.DeckValues[value] + _dealer.Total;
            }

            CardDealer.lblCardCount.Text = _dealer.Total.ToString();
        }

        private void PlayerTurn(int value)
        {
            value = deck.DeckValues[value];
            ImageSource imageSource = new BitmapImage(new Uri(deck.ChangeCardUi(value)));
            Player.CardImage.Source = imageSource;

            if (value == 1)
            {
                CustomDialog custom = new CustomDialog();
                custom.ShowDialog();
                player.Total = player.Total + custom.Value;
            }
            else if (value >= 10)
            {
                player.Total = 10 + player.Total;
            }
            else
            {
                player.Total = value + player.Total;
            }

            Player.lblCardCount.Text = player.Total.ToString();
        }

        private void hitBtn_Click(object sender, RoutedEventArgs e)
        {
            PlayGame();
            CheckWinnerOrLoster();
        }

        private void CheckWinnerOrLoster()
        {
            if (player.Total > 21 && _dealer.Total > 21)
            {
                HideBtnbust();
                SetBustWinTxt("Bust", "Bust");
            }
            else if (player.Total == 21 || _dealer.Total > 21)
            {
                HideBtnbust();
                SetBustWinTxt("Win", "Bust");
            }
            else if (player.Total > 21 || _dealer.Total == 21)
            {
                HideBtnbust();

                SetBustWinTxt("Bust", "Win");
            }
        }

        private void SetBustWinTxt(string playerResult, string cardDealResult)
        {
            Player.lblOutcome.Text = playerResult;
            CardDealer.lblOutcome.Text = cardDealResult;
            player.Total = 0;
            _dealer.Total = 0;
        }

        private void HideBtnbust()
        {
            Dealbtn.Visibility = Visibility.Visible;
            HitBtn.Visibility = Visibility.Hidden;
            StandBtn.Visibility = Visibility.Hidden;
        }

        private void StandBtn_Click(object sender, RoutedEventArgs e)
        {
            CardDealerTurn(rnd.Next(0, 13));
            CheckWinnerOrLoster();
        }
    }
}
