using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class RegisterPage : ContentPage
    {
        private Label registerLabel;
        private Entry emailEntry;
        private Entry nickNameEntry;
        private Entry handiCapEntry;
        private Entry passwordEntry;
        private Button registerButton;
        private bool emailFound = false;
        private int nextID = 0;
        private string addressUser = "https://golfserversws6042.herokuapp.com/user/";
        private string addressScoreCard = "https://golfserversws6042.herokuapp.com/scorecard/";


        public RegisterPage()
        {
            this.BackgroundImageSource = "SharecardBase.png";
            StackLayout stackLayout = new StackLayout();

            registerLabel = new Label();
            registerLabel.Text = "Enter Account Information:";
            registerLabel.FontAttributes = FontAttributes.Bold;
            registerLabel.Margin = new Thickness(10, 10, 10, 10);
            registerLabel.HorizontalOptions = LayoutOptions.CenterAndExpand;
            stackLayout.Children.Add(registerLabel);

            emailEntry = new Entry();
            emailEntry.Keyboard = Keyboard.Email;
            emailEntry.Placeholder = "Email";
            emailEntry.Margin = new Thickness(30, 10);
            stackLayout.Children.Add(emailEntry);

            nickNameEntry = new Entry();
            nickNameEntry.Keyboard = Keyboard.Text;
            nickNameEntry.Placeholder = "Username";
            nickNameEntry.Margin = new Thickness(30, 10);
            stackLayout.Children.Add(nickNameEntry);

            handiCapEntry = new Entry();
            handiCapEntry.Keyboard = Keyboard.Numeric;
            handiCapEntry.Placeholder = "0";
            handiCapEntry.Margin = new Thickness(30, 10);
            stackLayout.Children.Add(handiCapEntry);

            passwordEntry = new Entry();
            passwordEntry.Keyboard = Keyboard.Text;
            passwordEntry.Placeholder = "Password";
            passwordEntry.IsPassword = true;
            passwordEntry.Margin = new Thickness(30, 10);
            stackLayout.Children.Add(passwordEntry);

            registerButton = new Button();
            registerButton.Text = "Create Account";
            registerButton.Clicked += RegisterButton_ClickedAsync;
            registerButton.Margin = new Thickness(30, 10);
            stackLayout.Children.Add(registerButton);

            Content = stackLayout;
        }

        private async void RegisterButton_ClickedAsync(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            await checkEmails(email);
            if (emailFound)
            {
                emailEntry.Text = "";
                nickNameEntry.Text = "";
                handiCapEntry.Text = "";
                passwordEntry.Text = "";
                await DisplayAlert("ERROR", "Email Already In Use", "Ok");
            }
            else
            {
                string username = nickNameEntry.Text;
                string handicap = handiCapEntry.Text;
                string password = passwordEntry.Text;

                //Format the user data
                IEnumerable<KeyValuePair<string, string>> userData = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("email", email),
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("handicap", handicap),
                    new KeyValuePair<string, string>("password", password)
                };

                //Find next Empty Slot
                await findEmptyID();

                HttpClient client = new HttpClient();
                HttpContent content = new FormUrlEncodedContent(userData);
                HttpResponseMessage response = await client.PutAsync(addressUser + nextID, content);



                IEnumerable<KeyValuePair<string, string>> scoreCardData = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("uid", nextID.ToString()),
                    new KeyValuePair<string, string>("h1r", "0"),
                    new KeyValuePair<string, string>("h2r", "0"),
                    new KeyValuePair<string, string>("h3r", "0"),
                    new KeyValuePair<string, string>("h4r", "0"),
                    new KeyValuePair<string, string>("h5r", "0"),
                    new KeyValuePair<string, string>("h6r", "0"),
                    new KeyValuePair<string, string>("h7r", "0"),
                    new KeyValuePair<string, string>("h8r", "0"),
                    new KeyValuePair<string, string>("h9r", "0"),
                    new KeyValuePair<string, string>("h10r", "0"),
                    new KeyValuePair<string, string>("h11r", "0"),
                    new KeyValuePair<string, string>("h12r", "0"),
                    new KeyValuePair<string, string>("h13r", "0"),
                    new KeyValuePair<string, string>("h14r", "0"),
                    new KeyValuePair<string, string>("h15r", "0"),
                    new KeyValuePair<string, string>("h16r", "0"),
                    new KeyValuePair<string, string>("h17r", "0"),
                    new KeyValuePair<string, string>("h18r", "0"),
                    new KeyValuePair<string, string>("h1hc", "0"),
                    new KeyValuePair<string, string>("h2hc", "0"),
                    new KeyValuePair<string, string>("h3hc", "0"),
                    new KeyValuePair<string, string>("h4hc", "0"),
                    new KeyValuePair<string, string>("h5hc", "0"),
                    new KeyValuePair<string, string>("h6hc", "0"),
                    new KeyValuePair<string, string>("h7hc", "0"),
                    new KeyValuePair<string, string>("h8hc", "0"),
                    new KeyValuePair<string, string>("h9hc", "0"),
                    new KeyValuePair<string, string>("h10hc", "0"),
                    new KeyValuePair<string, string>("h11hc", "0"),
                    new KeyValuePair<string, string>("h12hc", "0"),
                    new KeyValuePair<string, string>("h13hc", "0"),
                    new KeyValuePair<string, string>("h14hc", "0"),
                    new KeyValuePair<string, string>("h15hc", "0"),
                    new KeyValuePair<string, string>("h16hc", "0"),
                    new KeyValuePair<string, string>("h17hc", "0"),
                    new KeyValuePair<string, string>("h18hc", "0"),
                    new KeyValuePair<string, string>("h1sp", "0"),
                    new KeyValuePair<string, string>("h2sp", "0"),
                    new KeyValuePair<string, string>("h3sp", "0"),
                    new KeyValuePair<string, string>("h4sp", "0"),
                    new KeyValuePair<string, string>("h5sp", "0"),
                    new KeyValuePair<string, string>("h6sp", "0"),
                    new KeyValuePair<string, string>("h7sp", "0"),
                    new KeyValuePair<string, string>("h8sp", "0"),
                    new KeyValuePair<string, string>("h9sp", "0"),
                    new KeyValuePair<string, string>("h10sp", "0"),
                    new KeyValuePair<string, string>("h11sp", "0"),
                    new KeyValuePair<string, string>("h12sp", "0"),
                    new KeyValuePair<string, string>("h13sp", "0"),
                    new KeyValuePair<string, string>("h14sp", "0"),
                    new KeyValuePair<string, string>("h15sp", "0"),
                    new KeyValuePair<string, string>("h16sp", "0"),
                    new KeyValuePair<string, string>("h17sp", "0"),
                    new KeyValuePair<string, string>("h18sp", "0")
                };

                HttpClient client2 = new HttpClient();
                HttpContent content2 = new FormUrlEncodedContent(scoreCardData);
                response = await client2.PutAsync(addressScoreCard + nextID, content2);

                emailEntry.Text = "";
                nickNameEntry.Text = "";
                handiCapEntry.Text = "";
                passwordEntry.Text = "";
                                    
                
                await DisplayAlert("Account Created", "Your Account Was Created Successfully", "Ok");
                await Navigation.PushAsync(new DashboardPage(nextID));
                var pages = Navigation.NavigationStack.ToList();
                foreach (var page in pages)
                {
                    if (page.GetType() != typeof(DashboardPage))
                    {
                        Navigation.RemovePage(page);
                    }
                }
            }
        }

        private async Task findEmptyID()
        {
            nextID = 0;
            bool finishedChecking = false;
            string msg;

            while (!finishedChecking) {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(addressUser + nextID);
                msg = await response.Content.ReadAsStringAsync();
                //await DisplayAlert("Checking ID", "Checking " + nextID +"\n" + msg, "Ok");

                if (msg.Contains("message") && msg.Contains("Could Not Find That User"))
                {
                    finishedChecking = true;
                }
                else {
                    nextID++;
                }
            }
            await DisplayAlert("ID FOUND", nextID.ToString(), "OK");
        }

        private async Task checkEmails(string email) {
            emailFound = false;
            int userID = 0;
            bool finishedChecking = false;
            string msg;
            while (!finishedChecking)
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(addressUser + userID);
                msg = await response.Content.ReadAsStringAsync();
                //await DisplayAlert("Checking ID", "Checking " + nextID + "\n" + msg, "Ok");
                if (msg.Contains("\"email\": \"" + email + "\""))
                {
                    emailFound = true;
                    finishedChecking = true;
                }
                else
                {
                    if (msg.Contains("message") && msg.Contains("Could Not Find That User"))
                    {
                        finishedChecking = true;
                    }
                    else
                    {
                        userID++;
                    }
                }
            }
        }
    }
}