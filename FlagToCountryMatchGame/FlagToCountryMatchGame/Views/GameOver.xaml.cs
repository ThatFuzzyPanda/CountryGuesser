using FlagToCountryMatchGame.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FlagToCountryMatchGame.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class GameOver : Page
    {
         static GameParams gameParams = new GameParams();
        public GameOver()
        {
            this.InitializeComponent();
            
        }
        private void SetGuesses()
        {
            CorrectGuess.Text = $"Total Correct Guesses {gameParams.CorrectGuess}" ;
            IncorrectGuess.Text = $"Total Incorrect Guesses {gameParams.IncorrectGuess}";
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            gameParams = (GameParams)e.Parameter;
            SetGuesses();
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GameScreen), gameParams.Gamemode);
        }
    }
}
