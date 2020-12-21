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
        private string address = "https://golfserversws6042.herokuapp.com/user/";

        public RegisterPage()
        {
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
                HttpResponseMessage response = await client.PutAsync(address + nextID, content);

                emailEntry.Text = "";
                nickNameEntry.Text = "";
                handiCapEntry.Text = "";
                passwordEntry.Text = "";
                await DisplayAlert("Account Created", "Your Account Was Created Successfully, User ID = " + nextID, "Ok");
                await Navigation.PushAsync(new DashboardPage());
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
                HttpResponseMessage response = await client.GetAsync(address + nextID);
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
        }

        private async Task checkEmails(string email) {
            emailFound = false;
            int userID = 0;
            bool finishedChecking = false;
            string msg;
            while (!finishedChecking)
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(address + userID);
                msg = await response.Content.ReadAsStringAsync();
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