using GolfApp1.Helpers;
using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        SessionData sd;

        public RegisterPage(SessionData sessionData)
        {
            this.BackgroundImageSource = "SharecardBase.png";
            this.sd = sessionData;

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
            sd.currentUser = await DBHelper.getInstance().createUserAsync(emailEntry.Text, nickNameEntry.Text, Int32.Parse(handiCapEntry.Text), passwordEntry.Text);
            sd.currentScoreCard = await DBHelper.getInstance().createScoreCardAsync(sd.currentUser.id, 0);

            sd.currentUser.currentScoreCardID = sd.currentUser.id;
            await DBHelper.getInstance().updateUser(sd.currentUser.id.ToString(), "cscid", sd.currentUser.currentScoreCardID.ToString());

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
    }
}