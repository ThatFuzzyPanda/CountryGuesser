using FlagToCountryMatchGame.Model;
using FlagToCountryMatchGame.Views;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;




namespace FlagToCountryMatchGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
	///
    public sealed partial class MainPage : Page
    {
		private List<Players> highscore = new List<Players>();
        public MainPage()
        {
            this.InitializeComponent();

			highscore.Add(new Players { Name = "john", Score = 10 });
            highscore.Add(new Players { Name = "sofie", Score = 20 });
            highscore.Add(new Players { Name = "Julie-Anna", Score = 6 });
            HighScoresList.ItemsSource = highscore;
        }

		private void GuessByCapClicked(object sender, RoutedEventArgs e)
		{
             Frame.Navigate(typeof(GameScreen), GAMEMODES.PracticeCaptial);
		}

		private void GuessByFlagClicked(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(GameScreen),GAMEMODES.PracticeFlag);
		}

		private void GuessByFlagTimeClicked(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(GameScreen), GAMEMODES.TAFlag);
		}
	}
}
