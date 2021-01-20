using GolfApp1.Helpers;
using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private SessionData sd;

        public SplashScreenPage()
        {
            this.BackgroundImageSource = "SharecardTitle.png";
            StackLayout stackLayout = new StackLayout();

            sd = new SessionData();

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
            await Navigation.PushAsync(new RegisterPage(sd));
        }

        private async void LoginButton_ClickedAsync(object sender, EventArgs e)
        {
            //Check if the entries are filled out
            if (emailEntry.Text == null || passwordEntry.Text == null)
            {
                //Display an alert if they are not filled out
                await DisplayAlert("ERROR", "Enter a username and password", "OK");
            }
            else
            {
                //Get all users and check if any match the entries
                List<User> users = await DBHelper.getInstance().getAllUsersAsync();
                bool found = false;
                int i = 0;
                while (i < users.Count && found == false)
                {
                    //If the user is found add it to the session data and go to the next page
                    if (users.ElementAt(i).email == emailEntry.Text && users.ElementAt(i).password == passwordEntry.Text)
                    {
                        found = true;
                        sd.currentUser = users.ElementAt(i);

                        await Navigation.PushAsync(new DashboardPage(sd));
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
                        i++;
                    }
                }
                //Display error if the user is not found
                if (!found)
                {
                    emailEntry.Text = "";
                    passwordEntry.Text = "";
                    await DisplayAlert("ERROR", "User Not Found In DB", "OK");
                }
            }
        }
    }
}