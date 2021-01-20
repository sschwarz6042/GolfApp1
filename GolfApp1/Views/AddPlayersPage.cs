using GolfApp1.Helpers;
using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class AddPlayersPage : ContentPage
    {
        private SessionData sd;

        private Picker userPicker;
        private Button addUserButton;
        private Button backButton;

        private Grid grid = new Grid();

        public AddPlayersPage(SessionData sessionData)
        {
            sd = sessionData;
            this.BackgroundImageSource = "SharecardBase.png";

            StackLayout stackLayout = new StackLayout();

            userPicker = new Picker();

            addUserButton = new Button();
            addUserButton.Text = "Add User";
            addUserButton.Clicked += AddUserButton_Clicked;

            backButton = new Button();
            backButton.Text = "Back <-";
            backButton.Clicked += BackButton_Clicked;

            grid.Children.Add(userPicker, 0, 0);
            grid.Children.Add(addUserButton, 1, 0);
            grid.Children.Add(backButton, 1, 2);

            stackLayout.Children.Add(grid);
            Content = stackLayout;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewRoundPage(sd));
            var pages = Navigation.NavigationStack.ToList();
            foreach (var page in pages)
            {
                if (page.GetType() != typeof(NewRoundPage))
                {
                    Navigation.RemovePage(page);
                }
            }
        }

        private async void AddUserButton_Clicked(object sender, EventArgs e)
        {
            //sd.watchingUsers.Add(userPicker.ItemsSource[userPicker.SelectedIndex] as User);

            User selected = userPicker.SelectedItem as User;
            await DisplayAlert("User Added", "Added " + selected.username, "Ok");
            sd.watchingUsers.Add(selected);


            await updateUserPicker();
            userPicker.SelectedIndex = 0;

            int adjustedHandicap = calculateHandicaps();
            await updateScoreCardWithHandicaps(adjustedHandicap);
        }

        protected async override void OnAppearing()
        {
            await updateUserPicker();
        }

        private async Task<bool> updateScoreCardWithHandicaps(int h)
        {
            List<KeyValuePair<string, string>> ans = new List<KeyValuePair<string, string>>();
            if (h > 0)
            {
                for (int i = 0; i < sd.currentCourse.handicaps.Length; i++)
                {
                    await DisplayAlert("Updating Handicaps", "Hole = " + (i + 1) + " Hole Handicap = " + sd.currentCourse.handicaps[i] + " Adjusted Handicap = " + h, "Ok");
                    if (h >= sd.currentCourse.handicaps[i])
                    {
                        sd.currentScoreCard.handicapScores[i] = (int)Math.Floor((decimal)sd.currentCourse.handicaps[i] / h);
                        string holeString = "h" + i.ToString() + "hc";
                        ans.Add(new KeyValuePair<string, string>(holeString, sd.currentScoreCard.handicapScores[i].ToString()));
                    }
                }
            }

            await DBHelper.getInstance().updateScoreCardMultiple(sd.currentScoreCard.id, ans);

            return true;
        }

        private int calculateHandicaps()
        {
            int maxHandicap = sd.currentUser.handicap;
            for (int i = 0; i < sd.watchingUsers.Count; i++)
            {
                if (sd.watchingUsers.ElementAt(i).handicap > maxHandicap)
                {
                    maxHandicap = sd.watchingUsers.ElementAt(i).handicap;
                }
            }
            return maxHandicap - sd.currentUser.handicap;
        }

        private async Task<bool> updateUserPicker()
        {
            grid.Children.Remove(userPicker);

            List<User> users = await DBHelper.getInstance().getAllUsersAsync();
            List<User> addAble = new List<User>();
            for (int i = 0; i < users.Count; i++)
            {
                //await DisplayAlert("Current User", "Checking if user id " + users.ElementAt(i).id + " = current user " + sd.currentUser.id + ". Answer is" + (users.ElementAt(i).id == sd.currentUser.id), "Ok");
                //await DisplayAlert("Current Course", "Checking if course id " + users.ElementAt(i).currentCourseID + " = current course id " + sd.currentUser.currentCourseID + ". Answer is" + (users.ElementAt(i).currentCourseID == sd.currentUser.currentCourseID), "Ok");
                //await DisplayAlert("Already Watching", "Checking if user id " + users.ElementAt(i).id + " is already on the watch list. Answer is" + (alreadyWatching(users.ElementAt(i).id)), "Ok");


                //if (users.ElementAt(i).id != sd.currentUser.id && users.ElementAt(i).currentCourseID == sd.currentCourse.id && users.ElementAt(i).loggedIn == "yes" && !(sd.watchingUsers.Contains(users.ElementAt(i))))
                if (users.ElementAt(i).id != sd.currentUser.id && users.ElementAt(i).currentCourseID == sd.currentCourse.id && !(alreadyWatching(users.ElementAt(i).id)))
                {
                    addAble.Add(users.ElementAt(i));
                }
            }

            userPicker.ItemsSource = addAble;
            userPicker.ItemDisplayBinding = new Binding("username");

            grid.Children.Add(userPicker, 0, 0);
            userPicker.SelectedIndex = 0;
            return true;
        }

        private bool alreadyWatching(int checkIndex)
        {
            for (int i = 0; i < sd.watchingUsers.Count; i++)
            {
                if (sd.watchingUsers.ElementAt(i).id == checkIndex)
                {
                    return true;
                }
            }
            return false;
        }
    }
}