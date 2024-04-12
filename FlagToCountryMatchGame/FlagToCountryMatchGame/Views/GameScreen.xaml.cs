using FlagToCountryMatchGame.Model;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;




// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FlagToCountryMatchGame.Views
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class GameScreen : Page
	{
		
		int guessCount = 0;
		int incorrectGuessCount = 0;
		public static Countries[] countries { get; private set; }
		public static string GameType;
		GameParams gameParams = new GameParams();
		DispatcherTimer timer;
        int timesTicked = 60;
        int timesToTick = 0;
        public GameScreen()
		{
			this.InitializeComponent();

			TimerSetup();
            GetData();
		}
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			gameParams.Gamemode = e.Parameter.ToString();
		}

		void SetText(string Name)
		{
			CountryName.Text = Name;
		}
		void SetImage(string Path)
		{
			string imagePath = Path;

			// Create a new BitmapImage and set its URI source
			BitmapImage bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.Absolute));

			// Set the Source property of the Image control to the BitmapImage
			Flag.Source = bitmapImage;
		}
		int SetRandomNum()
		{
			Random random = new Random();
			return random.Next(0,countries.Length);
		}
		void SetCaptial(string Name)
		{
			Captial.Text = Name;
			Captial.Visibility = Visibility.Visible;
		}
		void SetHint(string Name)
		{
			Hint.Text = $"Hint: The Capital City: {Name}" ;
		}
		
		void InitGame()
		{
            CountryName.Visibility = Visibility.Collapsed;
            CorrectIncorrect.Visibility = Visibility.Collapsed;
            Hint.Visibility = Visibility.Collapsed;
			TimerText.Visibility = Visibility.Collapsed;
            NextBtn.IsEnabled = false;
            Guess.IsEnabled = true;
            HintBtn.IsEnabled = true;
        }
		void TimerSetup()
		{

            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0,0,1);
			
		} 
        void Timer_Tick(object sender, object e)
        {
            
            TimerText.Text = $" Time Remaining: {timesTicked}";
            if (timesTicked < timesToTick)
            {
                gameParams.CorrectGuess = guessCount;
                gameParams.IncorrectGuess = incorrectGuessCount;
                timer.Stop();
                Frame.Navigate(typeof(GameOver), gameParams);
            }


            timesTicked--;
        }
        void GameLoop()
		{
			int ran = SetRandomNum();
		
			InitGame();

            CorrectGuesses.Text = $"Correct Guesses: {guessCount}";
			incorrectGuesses.Text = $"Incorrect Guesses: {incorrectGuessCount}";
			if(gameParams.Gamemode == GAMEMODES.PracticeFlag.ToString())
			{
                EndBtn.Visibility = Visibility.Visible;
                SetText(countries[ran].name.common);
				SetImage(countries[ran].flags.png);
				if(countries[ran].capital.Length < 1)
				{
					SetHint("Doesnt Have One");
				}
				else
				{
					SetHint(countries[ran].capital[0]);
				}
				
			}
			else if (gameParams.Gamemode == GAMEMODES.TAFlag.ToString())
			{

				if (!timer.IsEnabled)
				{
                    timer.Start();

                }
					EndBtn.Visibility = Visibility.Collapsed;
                    SetText(countries[ran].name.common);
                    SetImage(countries[ran].flags.png);
                    TimerText.Visibility = Visibility.Visible;
                    if (countries[ran].capital.Length < 1)
                    {
                        SetHint("Doesnt Have One");
                    }
                    else
                    {
                        SetHint(countries[ran].capital[0]);
                    }
            }
			else
			{
				if (countries[ran].capital.Length < 1)
				{
					GameLoop();
				}
				else
				{
					SetText(countries[ran].name.common);
					SetCaptial(countries[ran].capital[0]);
				}
			}
		}
		private async void GetData()
		{
			
			string url = "https://restcountries.com/v3.1/all?fields=name,flags,capital";

			HttpClient client = new HttpClient();

			string responce = await client.GetStringAsync(url);
			
			countries = JsonConvert.DeserializeObject<Countries[]>(responce);
			GameLoop();
		}

		
		private void NextBtnClicked(object sender, RoutedEventArgs e)
		{
			GameLoop();
			Guess.Text = "";
		}

		private void GuesBtnClicked(object sender, RoutedEventArgs e)
		{
			CountryName.Visibility = Visibility.Visible;
			NextBtn.IsEnabled = true;
			HintBtn.IsEnabled = false;
			CheckGuess();

        }
		private void CheckGuess()
		{
            if (Guess.Text.ToLower() == CountryName.Text.ToLower())
            {
                guessCount++;

                CorrectGuesses.Text = $"Correct Guesses: {guessCount}";
                incorrectGuesses.Text = $"Incorrect Guesses: {incorrectGuessCount}";
                CorrectIncorrect.Text = "Correct!";
                CorrectIncorrect.Visibility = Visibility.Visible;
            }
            else
            {
                CorrectIncorrect.Text = "Incorrect!";
                incorrectGuessCount++;
                CorrectIncorrect.Visibility = Visibility.Visible;
                Guess.IsEnabled = false;
            }
        }

		private void BackBtn_Click(object sender, RoutedEventArgs e)
		{
            timer.Stop();
            Frame.Navigate(typeof(MainPage), null);
		}
		private void HintBtnClicked(object sender, RoutedEventArgs e)
		{
			Hint.Visibility = Visibility.Visible;
		}

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            gameParams.CorrectGuess = guessCount;
            gameParams.IncorrectGuess = incorrectGuessCount;
            timer.Stop();
            Frame.Navigate(typeof(GameOver), gameParams);
        }
    }
}
