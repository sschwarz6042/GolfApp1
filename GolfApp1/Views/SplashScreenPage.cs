using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class SplashScreenPage : ContentPage
    {
        private Label spacer;
        private Entry emailEntry;
        private Entry passwordEntry;
        private Button loginButton;
        private Label regLabel;
        private Button registerButton;
        private string address = "https://golfserversws6042.herokuapp.com/user/";

        public SplashScreenPage()
        {
            this.BackgroundImageSource = "SharecardTitle.png"; 
            
            StackLayout stackLayout = new StackLayout();

            spacer = new Label();
            spacer.Text = "";
            spacer.Margin = new Thickness(0, 50);
            stackLayout.Children.Add(spacer);

            emailEntry = new Entry();
            emailEntry.Keyboard = Keyboard.Email;
            emailEntry.Placeholder = "Email";
            emailEntry.Margin = new Thickness(30, 10);
            stackLayout.Children.Add(emailEntry);

            passwordEntry = new Entry();
            passwordEntry.Keyboard = Keyboard.Text;
            passwordEntry.Placeholder = "Password";
            passwordEntry.IsPassword = true;
            passwordEntry.Margin = new Thickness(30, 10);
            stackLayout.Children.Add(passwordEntry);

            loginButton = new Button();
            loginButton.Text = "Log In";
            loginButton.Clicked += LoginButton_ClickedAsync;
            loginButton.Margin = new Thickness(30, 10);
            stackLayout.Children.Add(loginButton);

            regLabel = new Label();
            regLabel.Text = "Don't have an account?";
            regLabel.Margin = new Thickness(10, 10, 10, 10);
            regLabel.HorizontalOptions = LayoutOptions.CenterAndExpand;
            stackLayout.Children.Add(regLabel);

            registerButton = new Button();
            registerButton.Text = "Create an Account";
            registerButton.Clicked += RegisterButton_Clicked;
            registerButton.Margin = new Thickness(30, 10);
            stackLayout.Children.Add(registerButton);



            Content = stackLayout;
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

        private async void LoginButton_ClickedAsync(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;

            bool userFound = false;
            int userID = 0;
            bool finishedChecking = false;
            string msg;

            if (email != "" && password != "")
            {
                while (!finishedChecking)
                {
                    HttpClient client = new HttpClient();
                    HttpResponseMessage response = await client.GetAsync(address + userID);
                    msg = await response.Content.ReadAsStringAsync();
                    if (msg.Contains("\"email\": \"" + email + "\"") && msg.Contains("\"password\": \"" + password + "\""))
                    {
                        userFound = true;
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


                emailEntry.Text = "";
                passwordEntry.Text = "";
                if (userFound)
                {
                    //await DisplayAlert("Success", "User Found In DB", "OK");
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
                else
                {
                    await DisplayAlert("ERROR", "User Not Found In DB", "OK");
                }
            }
            else {
                await DisplayAlert("ERROR", "Enter a username and password", "OK");
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "PreventLandscape");
        }
    }
}